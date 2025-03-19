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

        // FALTA AGREGAR FOTO DE PERFIL

        public bool IngresarPersona(int cedula, string nombre, string apellido, string telefono, string servicio_medico, string fecha_nacimiento, bool notificaciones, string sexo)
        {
            try
            {
                cn.AbrirConexion();
                MySqlConnection conn = cn.AbrirConexion();

                string query = "INSERT INTO persona (cedula, nombre, apellido, telefono, servicio_medico, fecha_nacimiento, notificaciones, sexo) VALUES (@Cedula, @Nombre, @Apellido, @Telefono, @Servicio_medico, @Fecha_nacimiento, @Notificaciones, @Sexo);";
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
