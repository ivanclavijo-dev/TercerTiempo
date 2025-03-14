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
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@user", usuario);
                    cmd.Parameters.AddWithValue("@clave", contraseña);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }
        public bool verificarUsuarioCambioContraseña(string numero)
        {
            MySqlConnection conn = conexion.AbrirConexion();
            {
                string consulta = "SELECT COUNT(*) FROM empleado WHERE id = '" + numero + "' OR cedula = '" + numero + "';";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@id", numero);
                    cmd.Parameters.AddWithValue("@cedula", numero);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

    }
}
