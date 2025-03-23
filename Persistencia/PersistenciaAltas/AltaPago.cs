
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

        public bool IngresarPago(int idCliente, int idArticulo)
        {
            try
            {
                cn.AbrirConexion();
                MySqlConnection conn = cn.AbrirConexion();

                string query = "INSERT INTO paga (fecha_hora, idCliente_paga, idArticulo_paga) VALUES (NOW(), @idCliente_paga, @idArticulo_paga);";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idCliente_paga", idCliente);
                    cmd.Parameters.AddWithValue("@idArticulo_paga", idArticulo);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar paga: " + ex.Message);
                return false;
            }
            finally
            {
                cn.CerrarConexion();
            }
        }
    }
}
