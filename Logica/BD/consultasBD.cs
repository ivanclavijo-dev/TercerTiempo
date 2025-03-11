using Persistencia.Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.BD
{
    public class consultasBD
    {
        private existencia_empleado existenciaEmpleado = new existencia_empleado();
        private rol_empleado rolEmpleado = new rol_empleado();
        public bool ValidarUsuario(string usuario, string password)
        {
            return existenciaEmpleado.verificarUsuario(usuario, password);
        }
        public int consultarRol(string usuario, string password)
        {
            return rolEmpleado.verificarRol(usuario, password);
        }
            
    }
}
