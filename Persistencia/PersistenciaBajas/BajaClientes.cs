using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.PersistenciaBajas
{
    public class BajaClientes
    {
        private Conexion cn = new Conexion();

        public bool EliminarCliente(int id)
        {
            try
            {
                cn.AbrirConexion();
                MySqlConnection conn = cn.AbrirConexion();

                string query = "UPDATE cliente SET estado_cliente = '0' WHERE idCliente = @ID;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar cliente: " + ex.Message);
                return false;
            }
            finally
            {
                cn.CerrarConexion();
            }
        }
    }
}
