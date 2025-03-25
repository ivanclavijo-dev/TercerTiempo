
using Persistencia.PersistenciaBajas;
using Persistencia.PersistenciaModificaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.BD.LogicaModificaciones
{
    public class Modificaciones
    {
        public bool modificarProductos(string detalle, int precioLista, int precioOferta, string marca, int stock, int id)
        {
            ModificarProducto modificarProducto = new ModificarProducto();
            return modificarProducto.modificarProducto(detalle, precioLista, precioOferta, marca, stock, id);   
           
        }

    }
}
