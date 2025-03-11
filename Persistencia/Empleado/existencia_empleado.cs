using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.Empleado
{
    public class existencia_empleado
    {
        private Conexion conexion = new Conexion();

        public bool verificarUsuario(string usuario, string contraseña)
        {
            MySqlConnection conn = conexion.AbrirConexion();
            {
                string consulta = "SELECT COUNT(*) FROM empleado WHERE clave = '" + contraseña + "' and user = '" + usuario + "';";
                using(MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@user", usuario);
                    cmd.Parameters.AddWithValue("@clave", contraseña);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

    }
}
