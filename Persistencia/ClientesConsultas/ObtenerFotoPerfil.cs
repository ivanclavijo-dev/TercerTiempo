using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.ClientesConsultas
{
    public class ObtenerFotoPerfil
    {
        private Conexion conexion = new Conexion();

        public byte[] ObtenerFoto(int cedula)
        {
            byte[] imagenBytes = null;

            using (MySqlConnection conn = conexion.AbrirConexion())
            {
                string consulta = "SELECT foto_perfil FROM persona WHERE cedula = @Cedula;";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@Cedula", cedula);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            imagenBytes = (byte[])reader["foto_perfil"];
                        }
                    }
                }
            }

            return imagenBytes;
        }
    }
}
