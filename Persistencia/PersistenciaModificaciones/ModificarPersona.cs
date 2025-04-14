using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.PersistenciaModificaciones
{
    public class ModificarPersona
    {
        private Conexion cn = new Conexion();

        public bool modificarPersonaFotoYNotificaciones(int cedula, bool notificaciones, byte[] fotoPerfil = null)
        {
            try
            {
                cn.AbrirConexion();
                MySqlConnection conn = cn.AbrirConexion();

                string query = "UPDATE Persona SET notificaciones = @Notificaciones, foto_perfil = @FotoPerfil WHERE cedula = @Cedula;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Notificaciones", notificaciones);
                    cmd.Parameters.AddWithValue("@FotoPerfil", fotoPerfil);
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
