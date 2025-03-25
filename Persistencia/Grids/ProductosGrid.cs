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
        MySqlCommand cmd = new MySqlCommand();

        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable(); // 👈 local dentro del método, se crea fresco cada vez
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = @"SELECT 
        idArticulo AS 'ID',
        marca      AS 'Nombre',
        precio_lista AS 'Precio',
        stock      AS 'Stock',
        detalle    AS 'Descripcion'
    FROM articulo;";
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

    }
}
