using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Security;
using Persistencia.PersistenciaAltas;
using Persistencia.ValidacionConsultas;
using TercerTiempo.Persistencia;

namespace Logica.BD.Altas
{
    public class Altas
    {
        private AltaPersona altaPersona;
        private AltaCliente altacliente;
        private AltaPago altaPago;
        private ValidarExistencias validarExistencias;

        public Altas()
        {
            altaPersona = new AltaPersona();
            altacliente = new AltaCliente();
            validarExistencias = new ValidarExistencias();
        }


        public bool ingresarPago(int idCliente, int idArticulo)
        {
            return altaPago.IngresarPago(idCliente, idArticulo);
        }

        // El metodo de ingresar persona devuelve 1 = Creado correctamente, 2 = Error al crear, 3 = La persona ya existe en la tabla, 4 = Error en el formato de la fecha

        public int ingresarPersona(int cedula, string nombre, string apellido, string telefono, string servicio_medico, string fecha_nacimiento, bool notis, string sexo)
        {
            try
            {

                    bool existencia = validarExistencias.validarPersona(cedula);

                    if (existencia)
                    {
                        return 3;
                    }

                    bool resultado = altaPersona.IngresarPersona(cedula, nombre, apellido, telefono, servicio_medico, fecha_nacimiento, notis, sexo);

                    if (resultado)
                    {
                        Console.WriteLine("Se ingresó a la persona");
                        return 1;
                    } else
                    {
                        Console.WriteLine("Error al ingresar a la persona");
                        return 2;
                    }

            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
                return 2;
            }
        }

        // El metodo de ingresar cliente devuelve 1 = Creado correctamente, 2 = Error al crear, 3 = El cliente ya existe en la tabla

        public int ingresarCliente(string observacion, int cedula)
        {
            try
            {
                bool existencia = validarExistencias.validarCliente(cedula);

                if (existencia)
                {
                    return 3; 
                }

                bool resultado = altacliente.IngresarCliente(observacion, cedula);

                if (resultado)
                {
                    Console.WriteLine("Se ingresó el cliente");
                    return 1; 
                }
                else
                {
                    Console.WriteLine("Error al ingresar al cliente");
                    return 2;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return 2; 
            }
        }
    }
}
