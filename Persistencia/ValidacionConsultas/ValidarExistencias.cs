using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.ValidacionConsultas
{
    public class ValidarExistencias
    {
        private Conexion conexion = new Conexion();

        public bool validarCliente(int cedula)
        {
            MySqlConnection conn = conexion.AbrirConexion();
            {
                string consulta = "SELECT COUNT(*) FROM cliente WHERE cedula_cliente = '" + cedula + "';";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@Cedula", cedula);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool validarPersona(int cedula)
        {
            MySqlConnection conn = conexion.AbrirConexion();
            {
                string consulta = "SELECT COUNT(*) FROM persona WHERE cedula = '" + cedula + "';";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@Cedula", cedula);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }
    }
}
