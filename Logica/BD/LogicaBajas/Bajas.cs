using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.PersistenciaBajas;


namespace Logica.BD.LogicaBajas
{
    public class Bajas
    {
        public bool eliminarCliente(int id)
        {
            BajaClientes bajas = new BajaClientes();

            if (bajas.EliminarCliente(id)) 
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool eliminarProducto(int id) { 
            BajaArticulo bajaProducto = new BajaArticulo(); 
            return bajaProducto.EliminarArticulo(id);
        }
    }
}
