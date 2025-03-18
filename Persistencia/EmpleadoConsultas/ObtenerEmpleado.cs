using System;
using MySql.Data.MySqlClient;
using TercerTiempo.Persistencia;
using Entidades;

namespace Persistencia.Empleado
{
    public class ObtenerEmpleado
    {
        private Conexion conexion = new Conexion();

        public EmpleadoObjeto ObtenerEmpleadoLogin(string username, string password)
        {
            EmpleadoObjeto empleado = null;

            MySqlConnection conn = conexion.AbrirConexion();

            // Actualizamos la consulta para usar las tablas 'colaborador' y 'persona'
            string query = @"
                SELECT 
                    c.idColaborador, 
                    c.contrasenia, 
                    c.usuario, 
                    c.rol,
                    p.nombre, 
                    p.apellido, 
                    p.telefono, 
                    p.cedula,
                    p.servicio_medico,
                    p.fecha_nacimiento,
                    p.notificaciones,
                    p.foto_perfil,
                    p.sexo
                FROM colaborador c 
                JOIN persona p ON c.cedula_colaborador = p.cedula 
                WHERE c.usuario = @usuario AND c.contrasenia = @clave";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@usuario", username);
                cmd.Parameters.AddWithValue("@clave", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    empleado = new EmpleadoObjeto
                    {
                        idColaborador = Convert.ToInt32(reader["idColaborador"]),
                        Constrasenia = reader["contrasenia"].ToString(), // Solo se usa para validación
                        Usuario = reader["usuario"].ToString(),
                        Rol = reader["rol"].ToString(),
                        // La tabla 'colaborador' ya no tiene email, por lo que puede asignarse un valor vacío si se requiere
                        Email = string.Empty,
                        DatosPersonales = new Persona
                        {
                            Cedula = Convert.ToInt32(reader["cedula"]),
                            Nombre = reader["nombre"].ToString(),
                            Apellido = reader["apellido"].ToString(),
                            // 'telefono' se almacena como VARCHAR en la BD, por lo que se mapea a string
                            Telefono = reader["telefono"].ToString(),
                            ServicioMedico = reader["servicio_medico"].ToString(),
                            FechaNacimiento = reader["fecha_nacimiento"] == DBNull.Value
                                                ? DateTime.MinValue
                                                : Convert.ToDateTime(reader["fecha_nacimiento"]),
                            Notificaciones = reader["notificaciones"] == DBNull.Value
                                                ? false
                                                : Convert.ToBoolean(reader["notificaciones"]),
                            // 'foto_perfil' se mapea a un arreglo de bytes
                            FotoPerfil = reader["foto_perfil"] as byte[],
                            Sexo = reader["sexo"].ToString()
                        }
                    };
                }

                reader.Close();
            }

            return empleado;
        }
    }
}
