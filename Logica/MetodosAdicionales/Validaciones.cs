using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Logica.MetodosAdicionales
{
    public class Validaciones
    {
        public bool formatoFecha(string fecha_nacimiento)
        {
            return DateTime.TryParse(fecha_nacimiento, out _);
        }
    }
}
