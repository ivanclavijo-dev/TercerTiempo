using Entidades;
using Persistencia.Grids;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.BD.CargarDGV
{
    public class CargarUltimosPagos
    {
        private PagosGrid pagos = new PagosGrid();

        public DataTable MostrarUltimosPagos(string id)
        {
            DataTable tabla = new DataTable();
            tabla = pagos.MostrarPagos(id);
            return tabla;
        }
    }
}
