using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Security;
using Persistencia.PersistenciaAltas;
using TercerTiempo.Persistencia;

namespace Logica.BD.Altas
{
    public class Altas
    {
        private AltaPersona altaPersona; 

        public Altas()
        {
            altaPersona = new AltaPersona();
        }

        public bool ingresarPersona(int cedula, string nombre, string apellido, string telefono, string servicio_medico, string fecha_nacimiento, bool notis, string sexo)
        {

            DateTime fecha_de_nacimiento;

            if (!DateTime.TryParse(fecha_nacimiento, out fecha_de_nacimiento))
            {
                Console.WriteLine("Formato de fecha incorrecto.");
                return false;
            }

            try
            {
                bool resultado = altaPersona.IngresarPersona(cedula, nombre, apellido, telefono, servicio_medico, fecha_nacimiento, notis, sexo);

                if (resultado)
                {
                    Console.WriteLine("Se ingresó a la persona");
                } else
                {
                    Console.WriteLine("Error al ingresar a la persona");
                }
                return resultado;
            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
