using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmpleadoObjeto
    {
        public int idColaborador { get; set; }
        public string Usuario { get; set; } // Debes almacenar solo el hash de la clave en la BD
        public string Constrasenia { get; set; }
        public string Rol { get; set; }
        public string Email { get; set; }
        public string Cedula_Colaborador { get; set; }

        // Relación con Persona
        public Persona DatosPersonales { get; set; }
    }

}
