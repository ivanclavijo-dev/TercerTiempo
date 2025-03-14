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
        private CambiarContraseña cambiarContraseña = new CambiarContraseña();
        public bool ValidarExistenciaUsuario(string usuario, string password)
        {
            return existenciaEmpleado.verificarUsuario(usuario, password);
        }
        public bool ValidarUsuarioLogin(string numero)
        {
            return existenciaEmpleado.verificarUsuarioCambioContraseña(numero);
        }

        public int consultarRol(string usuario, string password)
        {
            return rolEmpleado.verificarRol(usuario, password);
        }

        public bool CambiarContraseñaEmpleado(string clave, string numeroClave)
        {
            return cambiarContraseña.cambiarPassword(clave, numeroClave);
        }
            
    }
}
