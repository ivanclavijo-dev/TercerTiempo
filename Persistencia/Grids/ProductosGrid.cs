using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.Grids
{
    public class ProductosGrid
    {

        private Conexion conexion = new Conexion();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand cmd = new MySqlCommand();

        public DataTable MostrarProductos()
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "SELECT \r\n    idArticulo AS 'ID',\r\n    marca      AS 'Nombre',\r\n    precio_lista AS 'Precio',\r\n    stock      AS 'Stock',\r\n    detalle    AS 'Descripcion'\r\nFROM articulo;\r\n";
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
    }
}
