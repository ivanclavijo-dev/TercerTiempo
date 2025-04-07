
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

                    // 2. Verificar stock actual
                    string checkStockQuery = "SELECT stock FROM articulos WHERE idArticulo = @idArticulo;";
                    using (MySqlCommand cmdCheck = new MySqlCommand(checkStockQuery, conn, trans))
                    {
                        cmdCheck.Parameters.AddWithValue("@idArticulo", idArticulo);
                        object result = cmdCheck.ExecuteScalar();

                        if (result != null)
                        {
                            int stockActual = Convert.ToInt32(result);
                            Console.WriteLine($"🧪 Stock en BD para ID {idArticulo}: {stockActual}, intentando vender: {cantidad}");

                            if (stockActual < cantidad)
                            {
                                trans.Rollback();
                                Console.WriteLine("❌ Stock insuficiente detectado");
                                return false;
                            }
                        }
                    }

                    // 3. Restar el stock
                    string updateStockQuery = @"UPDATE articulos 
                                        SET stock = stock - @cantidad 
                                        WHERE idArticulo = @idArticulo;";
                    using (MySqlCommand cmdUpdate = new MySqlCommand(updateStockQuery, conn, trans))
                    {
                        cmdUpdate.Parameters.AddWithValue("@cantidad", cantidad);
                        cmdUpdate.Parameters.AddWithValue("@idArticulo", idArticulo);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error completo: " + ex.ToString());
                return false;
            }
            finally
            {
                cn.CerrarConexion();
            }
        }


    }
}
