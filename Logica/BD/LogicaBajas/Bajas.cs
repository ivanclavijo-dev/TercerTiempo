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
        public int eliminarCliente(int id)
        {
            BajaClientes bajas = new BajaClientes();

            try
            {
                if (bajas.EliminarCliente(id))
                {
                    return 1;
                } else
                {
                    return 2;
                }
            }
            catch (Exception ex) 
            {
                return -1;
            }
        }

        public bool eliminarProducto(int id) { 
            BajaArticulo bajaProducto = new BajaArticulo(); 
            return bajaProducto.EliminarArticulo(id);
        }
    }
}
