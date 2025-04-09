using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Logica.ObjetosTablas
{
    public class OB_RutinaGrid
    {
        private Persistencia.Grids.RutinasGrid RutinasGrid = new Persistencia.Grids.RutinasGrid();

        public DataTable MostrarRutinas()
        {
            DataTable tabla = new DataTable();
            tabla = RutinasGrid.MostrarRutina();
            return tabla;
        }
    }
}
