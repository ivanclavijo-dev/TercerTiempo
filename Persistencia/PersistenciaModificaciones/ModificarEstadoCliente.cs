using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.PersistenciaModificaciones
{
    public class ModificarEstadoCliente
    {
        private Conexion cn = new Conexion();

        public bool modificarEstadoCliente(int cedula)
        {
            try
            {
                cn.AbrirConexion();
                MySqlConnection conn = cn.AbrirConexion();

                string query = "UPDATE cliente\r\nSET estado_cliente = '1'\r\nWHERE cedula_cliente = @Cedula;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cedula", cedula);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                cn.CerrarConexion();
            }
        }
    }
}
