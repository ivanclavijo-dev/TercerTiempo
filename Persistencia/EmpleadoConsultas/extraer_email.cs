
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Persistencia.Empleado
{
    public class extraer_email
    {
        private Conexion conexion = new Conexion();

        public string extrarMail(string numeroClave)
        {
            string mail = "";
            MySqlConnection conn = conexion.AbrirConexion();
            {
                string consulta = "SELECT email FROM Empleado e JOIN Persona p ON e.cedula = p.cedula WHERE e.id_empleado = '" + numeroClave + "' OR p.cedula = '" + numeroClave + "';";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@id_empleado", numeroClave);
                    cmd.Parameters.AddWithValue("@cedula", numeroClave);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                                mail = reader.GetString("email");
                        }
                    }
                }
            }
            return mail;

        }
    }
}
