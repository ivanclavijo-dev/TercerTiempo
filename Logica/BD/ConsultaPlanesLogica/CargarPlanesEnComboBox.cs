using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.CargarComboBox;

namespace Logica.BD.ConsultaPlanesLogica
{
    public class CargarPlanesEnComboBox
    {
        private ConsultaPlanes consulta = new ConsultaPlanes();

        public DataTable ObtenerPlanes()
        {
            return consulta.MostrarPlanes();
        }
    }
}
