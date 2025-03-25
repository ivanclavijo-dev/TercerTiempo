
using Persistencia.Grids;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.ObjetosTablas
{
    public class OB_ColaboradorGrid
    {
        private EmpleadosGrids empleadoObjeto = new EmpleadosGrids();


        public DataTable MostrarEmplead()
        {
            DataTable tabla = new DataTable();
            tabla = empleadoObjeto.MostrarEmpleados();
            return tabla;
        }

    }
}
