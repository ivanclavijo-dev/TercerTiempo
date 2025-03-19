using Persistencia.Grids;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.ObjetosTablas
{
    public class OB_ProductoGrid
    {
        private ProductosGrid objetoProducto = new ProductosGrid();

        public DataTable MostrarProducto()
        {
            DataTable tabla = new DataTable();
            tabla = objetoProducto.MostrarProductos();
            return tabla;
        }
    }
}
