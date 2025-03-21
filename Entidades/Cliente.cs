using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string Observacion { get; set; } // Debes almacenar solo el hash de la clave en la BD
        public int Cedula_cliente { get; set; }

        // Relación con Persona
        public Persona DatosPersonales { get; set; }
    }
}
