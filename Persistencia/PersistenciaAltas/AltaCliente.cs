using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.PersistenciaAltas
{
    public class AltaCliente
    {
        private Conexion cn = new Conexion();

        public bool IngresarCliente(string observacion, int cedula)
        {
            try
            {
                cn.AbrirConexion();
                MySqlConnection conn = cn.AbrirConexion();

                string query = "INSERT INTO cliente (observacion, cedula_cliente) VALUES (@Observacion, @Cedula);";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Observacion", observacion);
                    cmd.Parameters.AddWithValue("@Cedula", cedula);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar cliente: " + ex.Message);
                return false;
            }
            finally
            {
                cn.CerrarConexion();
            }
        }
    }
}

