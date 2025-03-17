using Entidades;
using Persistencia.Empleado;
using Persistencia.Estadisticas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.BD
{
    public class consultasBD
    {
        private existencia_empleado existenciaEmpleado = new existencia_empleado();
        private rol_empleado rolEmpleado = new rol_empleado();
        private cambiar_contraseña cambiarContraseña = new cambiar_contraseña();
        private extraer_email extraerEmail = new extraer_email();
        private ObtenerEmpleado empleadoDAO = new ObtenerEmpleado();
        private ClientesTotales clientesTotales = new ClientesTotales();
        private ClientesTotales clientes = new ClientesTotales();
        private VentasUltimoMes ventasMes = new VentasUltimoMes();
        private IngresosUltimoMes ingresosUltimoMes = new IngresosUltimoMes();
       private PromedioEdades promedioEdades = new PromedioEdades();

        public DataTable ObtenerRangosEdad()
        {
            return promedioEdades.ObtenerRangosEdad();
        }
        public bool ValidarExistenciaUsuario(string usuario, string password)
        {
            return existenciaEmpleado.verificarUsuario(usuario, password);
        }
        public int ObtenerIngresosMesAnterior()
        {
            return ingresosUltimoMes.ingresosUltimoMes();
        }

        public int ObtenerNumeroVentasMes()
        {
            return ventasMes.ventasUltimoMes();
        }
        public int ObtenerNumeroClientesTotales()
        {
            return clientes.cantidadClientesTotales();

        }

        public EmpleadoObjeto ObtenerEmpleadoLogin(string usuario, string password)
        {
            return empleadoDAO.ObtenerEmpleadoLogin(usuario, password);
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

        public string ConseguirGmail(string numeroClave)
        {
            return extraerEmail.extrarMail(numeroClave);
        }
           
    }
}
