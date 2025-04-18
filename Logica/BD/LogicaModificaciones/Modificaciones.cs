
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


        // devuelve 1 = modificado correctamente, 2 = error al modificar, -1 = error inesperado
        public int modificarPersona(int cedula, bool notificaciones, byte[] fotoPerfil)
        {
            ModificarPersona modificarPersona = new ModificarPersona();
            try
            {
                if (modificarPersona.modificarPersonaFotoYNotificaciones(cedula, notificaciones, fotoPerfil))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            catch (Exception ex) 
            {
                return -1;
            }
        }

        public int reactivarCliente(int cedula)
        {
            ModificarEstadoCliente modificarEstadoCliente = new ModificarEstadoCliente();
            try
            {
                if (modificarEstadoCliente.modificarEstadoCliente(cedula))
                {
                    return 1;
                } else
                {
                    return 2;
                }
            } catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
