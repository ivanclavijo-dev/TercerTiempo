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
                string consulta = "SELECT SUM(total_ingresos) AS total_dinero_ingresado\r\nFROM (\r\n    -- Sumar el total de ventas del mes anterior\r\n    SELECT SUM(precio_total) AS total_ingresos\r\n    FROM Ventas_Productos\r\n    WHERE MONTH(dia_hora_venta) = MONTH(CURRENT_DATE - INTERVAL 1 MONTH)\r\n      AND YEAR(dia_hora_venta) = YEAR(CURRENT_DATE - INTERVAL 1 MONTH)\r\n\r\n    UNION ALL\r\n\r\n    -- Sumar el total de pagos del mes anterior\r\n    SELECT SUM(precio) AS total_ingresos\r\n    FROM Pagos\r\n    WHERE MONTH(dia_pago) = MONTH(CURRENT_DATE - INTERVAL 1 MONTH)\r\n      AND YEAR(dia_pago) = YEAR(CURRENT_DATE - INTERVAL 1 MONTH)\r\n) AS ingresos;\r\n";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {

                    jutotalIngresos = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            return totalIngresos;

        }
    }
}
