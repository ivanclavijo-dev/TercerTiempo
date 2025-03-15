using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;
using Entidades;
using MySql.Data.MySqlClient;
namespace Persistencia.Empleado
{
    public class ObtenerEmpleado
    {
       private Conexion conexion = new Conexion();

        public EmpleadoObjeto ObtenerEmpleadoLogin (string username, string password)
        {
            EmpleadoObjeto empleado = null;

            MySqlConnection conn = conexion.AbrirConexion();
            {
                string query = @"SELECT e.id_empleado, e.clave, e.user, e.rol, e.email, 
                                    p.nombre, p.apellido, p.telefono, p.cedula
                             FROM Empleado e 
                             JOIN Persona p ON e.cedula = p.cedula 
                             WHERE e.user = @usuario AND e.clave = @clave"
                ;

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", username);
                    cmd.Parameters.AddWithValue("@clave", password);

                    conexion.AbrirConexion();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        empleado = new EmpleadoObjeto
                        {
                            IdEmpleado = Convert.ToInt32(reader["id_empleado"]),
                            Clave = reader["clave"].ToString(), // Solo se usará para validación
                            User = reader["user"].ToString(),
                            Rol = Convert.ToInt32(reader["rol"]),
                            Email = reader["email"].ToString(),
                            DatosPersonales = new Persona
                            {
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                Telefono = Convert.ToInt32(reader["telefono"]),
                                Cedula = Convert.ToInt32(reader["cedula"])
                            }
                        };
                    }


                    reader.Close();
                }
                }

                return empleado;
        }
    }
}
