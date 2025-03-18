using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.Estadisticas
{
    public class ClientesTotales
    {
        private  Conexion conexion = new Conexion();
        public int cantidadClientesTotales()
        {
            int totalClientes = 0;

            MySqlConnection conn = conexion.AbrirConexion();
            {
                string consulta = "SELECT COUNT(*) from cliente;";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    
                    totalClientes = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            return totalClientes;

        }
    }
}
