using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.Estadisticas
{
    public class IngresosUltimoMes
    {
        private Conexion conexion = new Conexion();
        public int ingresosUltimoMes()
        {
            int totalIngresos = 0;

            MySqlConnection conn = conexion.AbrirConexion();
            {
                string consulta = "SELECT SUM(total_ingresos) AS TotalIngresos\r\nFROM (\r\n    -- Ingresos por artículos vendidos en el mes anterior\r\n    SELECT SUM(a.precio_oferta) AS total_ingresos\r\n    FROM paga p\r\n    JOIN articulo a ON p.idArticulo_paga = a.idArticulo\r\n    WHERE p.fecha_hora >= DATE_FORMAT(DATE_SUB(CURDATE(), INTERVAL 1 MONTH), '%Y-%m-01')\r\n      AND p.fecha_hora < DATE_FORMAT(CURDATE(), '%Y-%m-01')\r\n    \r\n    UNION ALL\r\n    \r\n    -- Ingresos por membresías pagadas en el mes anterior\r\n    SELECT SUM(pl.precio_oferta) AS total_ingresos\r\n    FROM adquiere ad\r\n    JOIN plan pl ON ad.idPlan = pl.idPlan\r\n    WHERE ad.fecha_inicio >= DATE_FORMAT(DATE_SUB(CURDATE(), INTERVAL 1 MONTH), '%Y-%m-01')\r\n      AND ad.fecha_inicio < DATE_FORMAT(CURDATE(), '%Y-%m-01')\r\n) AS t;\r\n";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {

                    totalIngresos = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            return totalIngresos;

        }
    }
}
