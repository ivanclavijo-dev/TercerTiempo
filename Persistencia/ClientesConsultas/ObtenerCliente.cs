using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.ClientesConsultas
{
    public class ObtenerCliente
    {
        private Conexion conexion = new Conexion();

        public Cliente ObtenerClienteProducto(int id)
        {
            Cliente cliente = null;

            MySqlConnection conn = conexion.AbrirConexion();

            // Actualizamos la consulta para usar las tablas 'colaborador' y 'persona'
            string query = @"
                SELECT 
                    c.idCliente, 
                    c.observacion,
                    p.nombre, 
                    p.apellido, 
                    p.telefono, 
                    p.cedula,
                    p.servicio_medico,
                    p.fecha_nacimiento,
                    p.notificaciones,
                    p.foto_perfil,
                    p.sexo
                FROM cliente c 
                JOIN persona p ON c.cedula_cliente = p.cedula 
                WHERE idCliente = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cliente = new Cliente
                    {
                        idCliente = Convert.ToInt32(reader["idCliente"]),
                        Observacion = reader["observacion"].ToString(),
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

            return cliente;
        }
    }
}
