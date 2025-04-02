using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.ArticulosConsultas
{
    public class ObtenerIdArticuloNuevo
    {
        private Conexion conexion = new Conexion();
        public int IdNuevoArticulo()
        {
            int idarticulo = 0;

            MySqlConnection conn = conexion.AbrirConexion();
            {
                string consulta = "SELECT MAX(idArticulo) +1 AS valor_maximo\r\nFROM articulo;\r\n";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {

                    idarticulo = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            return idarticulo;

        }
    }
}
