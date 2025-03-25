using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Articulos
    {
        public int idArticulo { get; set; }
        public string detalle { get; set; }
        public int precio_lista { get; set; }
        public int precio_oferta { get; set; }
        public string marca { get; set; }
        public int stock { get; set; }

        public static Articulos articuloactual { get; set; }

    }





}
