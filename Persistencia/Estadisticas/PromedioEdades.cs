using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.Estadisticas
{
    public class PromedioEdades
    {
        private Conexion conexion = new Conexion();

        public DataTable ObtenerRangosEdad()
        {

            MySqlConnection conn = conexion.AbrirConexion();
            {
                string consulta = "SELECT \r\n    SUM(CASE WHEN TIMESTAMPDIFF(YEAR, p.fecha_nacimiento, CURDATE()) BETWEEN 15 AND 18 THEN 1 ELSE 0 END) AS rango_15_18,\r\n    SUM(CASE WHEN TIMESTAMPDIFF(YEAR, p.fecha_nacimiento, CURDATE()) BETWEEN 19 AND 30 THEN 1 ELSE 0 END) AS rango_19_30,\r\n    SUM(CASE WHEN TIMESTAMPDIFF(YEAR, p.fecha_nacimiento, CURDATE()) > 30 THEN 1 ELSE 0 END) AS rango_mayor_30\r\nFROM cliente c\r\nJOIN persona p ON c.cedula_cliente = p.cedula;\r\n";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;

                }
            }
        }
    }
}
