using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.Empleado
{
    public class rol_empleado
    {
        private Conexion conexion = new Conexion();
        int rol;
        public int verificarRol(string usuario, string contraseña)
        {
            
            MySqlConnection conn = conexion.AbrirConexion();
            {
                string consulta = "SELECT rol FROM empleado WHERE clave = '" + contraseña + "' and user = '" + usuario + "';";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@user", usuario);
                    cmd.Parameters.AddWithValue("@clave", contraseña);

                   object valor = cmd.ExecuteScalar();
                    if (valor != null && int.TryParse(valor.ToString(), out int numero))
                    {
                        rol = numero;
                    }

                }
            }
            return rol;

        }
    }
}
