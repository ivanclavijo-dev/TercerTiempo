using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.PersonaConsultas
{
    public class ConsultarDatos
    {
        private Conexion conexion = new Conexion();

        public Persona ObtenerPorCedula(string cedula)
        {
            Persona persona = null;
            MySqlConnection conn = conexion.AbrirConexion();

            string query = @"
            SELECT cedula, nombre, apellido, telefono, servicio_medico, 
                   fecha_nacimiento, notificaciones, foto_perfil, sexo
            FROM persona
            WHERE cedula = @cedula";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@cedula", cedula);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        persona = new Persona
                        {
                            Cedula = Convert.ToInt32(reader["cedula"]),
                            Nombre = reader["nombre"].ToString(),
                            Apellido = reader["apellido"].ToString(),
                            Telefono = reader["telefono"].ToString(),
                            ServicioMedico = reader["servicio_medico"].ToString(),
                            FechaNacimiento = reader["fecha_nacimiento"] == DBNull.Value
                                                ? DateTime.MinValue
                                                : Convert.ToDateTime(reader["fecha_nacimiento"]),
                            Notificaciones = reader["notificaciones"] == DBNull.Value
                                                ? false
                                                : Convert.ToBoolean(reader["notificaciones"]),
                            FotoPerfil = reader["foto_perfil"] as byte[],
                            Sexo = reader["sexo"].ToString()
                        };
                    }
                }
            }

            return persona;
        }
    }
}
