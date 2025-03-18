using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.Empleado
{
    public class RolEmpleado
    {
        private Conexion conexion = new Conexion();

        public string VerificarRol(string usuario, string contraseña)
        {
            string rol = string.Empty;

            MySqlConnection conn = conexion.AbrirConexion();
            string consulta = "SELECT rol FROM colaborador WHERE contrasenia = @clave AND usuario = @user;";
            using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
            {
                cmd.Parameters.AddWithValue("@user", usuario);
                cmd.Parameters.AddWithValue("@clave", contraseña);

                object valor = cmd.ExecuteScalar();
                if (valor != null)
                {
                    rol = valor.ToString();
                }
            }

            return rol;
        }
    }

}
