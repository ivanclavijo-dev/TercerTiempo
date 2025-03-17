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
                string consulta = "SELECT \r\n    SUM(CASE WHEN edad BETWEEN 15 AND 18 THEN 1 ELSE 0 END) AS rango_15_18,\r\n    SUM(CASE WHEN edad BETWEEN 19 AND 30 THEN 1 ELSE 0 END) AS rango_19_30,\r\n    SUM(CASE WHEN edad > 30 THEN 1 ELSE 0 END) AS rango_mayor_30\r\nFROM Cliente;\r\n";
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
