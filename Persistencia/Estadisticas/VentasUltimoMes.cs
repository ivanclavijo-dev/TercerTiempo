using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.Estadisticas
{
    public class VentasUltimoMes
    {
        private Conexion conexion = new Conexion();
        public int ventasUltimoMes()
        {
            int totalVentas = 0;

            MySqlConnection conn = conexion.AbrirConexion();
            {
                string consulta = "SELECT COUNT(*) FROM paga WHERE fecha_hora >= DATE_SUB(CURDATE(), INTERVAL 1 MONTH);";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {

                    totalVentas = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            return totalVentas;

        }
    }
}
