
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.PersistenciaAltas
{
    public class AltaPago
    {
        private Conexion cn = new Conexion();

        public bool IngresarPago(int idCliente, int idArticulo, int cantidad)
        {
            try
            {
                MySqlConnection conn = cn.AbrirConexion();

                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Insertar en la tabla paga
                        string insertQuery = @"INSERT INTO paga 
                    (fecha_hora, idCliente_paga, idArticulo_paga, cantidad)
                    VALUES (NOW(), @idCliente, @idArticulo, @cantidad);";

                        using (MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn, trans))
                        {
                            cmdInsert.Parameters.AddWithValue("@idCliente", idCliente);
                            cmdInsert.Parameters.AddWithValue("@idArticulo", idArticulo);
                            cmdInsert.Parameters.AddWithValue("@cantidad", cantidad);
                            cmdInsert.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("💥 Error al insertar en la tabla `paga`:\n" + ex.Message);
                        trans.Rollback();
                        return false;
                    }

                    try
                    {
                        // 2. Verificar stock actual
                        string checkStockQuery = "SELECT stock FROM articulo WHERE idArticulo = @idArticulo;";
                        using (MySqlCommand cmdCheck = new MySqlCommand(checkStockQuery, conn, trans))
                        {
                            cmdCheck.Parameters.AddWithValue("@idArticulo", idArticulo);
                            object result = cmdCheck.ExecuteScalar();

                            if (result != null)
                            {
                                int stockActual = Convert.ToInt32(result);
                                if (stockActual < cantidad)
                                {
                                    Console.WriteLine($"❌ Stock insuficiente para el producto ID {idArticulo}. Stock actual: {stockActual}, cantidad pedida: {cantidad}");
                                    trans.Rollback();
                                    return false;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"⚠️ No se encontró el producto con ID {idArticulo} en la tabla `articulo`.");
                                trans.Rollback();
                                return false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("💥 Error al consultar el stock:\n" + ex.Message);
                        trans.Rollback();
                        return false;
                    }

                    try
                    {
                        // 3. Restar el stock
                        string updateStockQuery = @"UPDATE articulo 
                    SET stock = stock - @cantidad 
                    WHERE idArticulo = @idArticulo;";

                        using (MySqlCommand cmdUpdate = new MySqlCommand(updateStockQuery, conn, trans))
                        {
                            cmdUpdate.Parameters.AddWithValue("@cantidad", cantidad);
                            cmdUpdate.Parameters.AddWithValue("@idArticulo", idArticulo);
                            cmdUpdate.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("💥 Error al actualizar el stock:\n" + ex.Message);
                        trans.Rollback();
                        return false;
                    }

                    // Si todo salió bien
                    trans.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Error general en la transacción:\n" + ex.Message);
                return false;
            }
            finally
            {
                cn.CerrarConexion();
            }
        }



    }
}
