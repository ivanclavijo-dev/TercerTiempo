using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.PersistenciaAltas
{
    public class AltaPersona
    {
        private Conexion cn = new Conexion();

        public bool IngresarPersona(int cedula, string nombre, string apellido, string telefono, string servicio_medico, string fecha_nacimiento, bool notificaciones, string sexo, byte[] foto_perfil = null)
        {
            try
            {
                MySqlConnection conn = cn.AbrirConexion();

                string query = @"INSERT INTO persona 
                    (cedula, nombre, apellido, telefono, servicio_medico, fecha_nacimiento, notificaciones, sexo, foto_perfil) 
                    VALUES 
                    (@Cedula, @Nombre, @Apellido, @Telefono, @Servicio_medico, @Fecha_nacimiento, @Notificaciones, @Sexo, @FotoPerfil);";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cedula", cedula);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@Servicio_medico", servicio_medico);
                    cmd.Parameters.AddWithValue("@Fecha_nacimiento", fecha_nacimiento);
                    cmd.Parameters.AddWithValue("@Notificaciones", notificaciones);
                    cmd.Parameters.AddWithValue("@Sexo", sexo);

                    // Manejo seguro del parámetro de imagen
                    if (foto_perfil != null)
                        cmd.Parameters.Add("@FotoPerfil", MySqlDbType.MediumBlob).Value = foto_perfil;
                    else
                        cmd.Parameters.Add("@FotoPerfil", MySqlDbType.MediumBlob).Value = DBNull.Value;

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar persona: " + ex.Message);
                return false;
            }
            finally
            {
                cn.CerrarConexion();
            }
        }
    }
}
