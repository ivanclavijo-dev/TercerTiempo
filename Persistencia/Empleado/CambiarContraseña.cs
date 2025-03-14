using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TercerTiempo.Persistencia;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Persistencia.Empleado
{
    public class CambiarContraseña
    {

        private Conexion conexion = new Conexion();

        public bool cambiarPassword(string clave, string numeroClave)
        {
            bool actualizado=false;
            MySqlConnection conn = conexion.AbrirConexion();
            {
                string consulta = "UPDATE `tercertiempo`.`empleado` SET clave = '"+clave+ "' WHERE id = '" + numeroClave + "' OR cedula = '" + numeroClave + "';";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@clave", clave);
                    cmd.Parameters.AddWithValue("@id", numeroClave);
                    cmd.Parameters.AddWithValue("@cedula", numeroClave);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    actualizado = filasAfectadas>0;

                    return actualizado;
                }
            }
        }
    }
}
