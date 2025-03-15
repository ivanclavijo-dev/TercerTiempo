using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmpleadoObjeto
    {
        public int IdEmpleado { get; set; }
        public string Clave { get; set; } // Debes almacenar solo el hash de la clave en la BD
        public string User { get; set; }
        public int Rol { get; set; }
        public string Email { get; set; }

        // Relación con Persona
        public Persona DatosPersonales { get; set; }
    }

}
