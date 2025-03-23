using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Carrito
    {
        public static List<Articulos> Productos = new List<Articulos>();

        public static int valorTotal {  get; set; }
    }
}
