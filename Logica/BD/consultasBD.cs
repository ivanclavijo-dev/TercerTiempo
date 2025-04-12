using Entidades;
using Persistencia.ArticulosConsultas;
using Persistencia.ClientesConsultas;
using Persistencia.Empleado;
using Persistencia.Estadisticas;
using Persistencia.PersonaConsultas;
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
        private RolEmpleado rolEmpleado = new RolEmpleado();
        private cambiar_contraseña cambiarContraseña = new cambiar_contraseña();
        private extraer_email extraerEmail = new extraer_email();
        private ObtenerEmpleado empleadoDAO = new ObtenerEmpleado();
        private ClientesTotales clientesTotales = new ClientesTotales();
        private ClientesTotales clientes = new ClientesTotales();
        private VentasUltimoMes ventasMes = new VentasUltimoMes();
        private IngresosUltimoMes ingresosUltimoMes = new IngresosUltimoMes();
       private PromedioEdades promedioEdades = new PromedioEdades();
        private ObtenerCliente obtenerCliente = new ObtenerCliente();
        private ObtenerIdDelClienteNuevo obtenerIdDelClienteNuevo = new ObtenerIdDelClienteNuevo();
        private ObtenerIdArticuloNuevo ObtenerIdArticuloNuevo = new ObtenerIdArticuloNuevo();


        public int ObtenerIdDelArticuloNuevo()
        {
            return ObtenerIdArticuloNuevo.IdNuevoArticulo();
        }
        public int ObtenerIdDelClienteNuevo()
        {
            return obtenerIdDelClienteNuevo.IdNuevoCliente();
        }
        public Cliente ObtenerClienteVenta(int id)
        {
            return obtenerCliente.ObtenerClienteProducto(id);
        }
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

        public string consultarRol(string usuario, string password)
        {
            return rolEmpleado.VerificarRol(usuario, password);
        }

        public bool CambiarContraseñaEmpleado(string clave, string numeroClave)
        {
            return cambiarContraseña.cambiarPassword(clave, numeroClave);
        }

        public string ConseguirGmail(string numeroClave)
        {
            return extraerEmail.extrarMail(numeroClave);
        }

        // Carrito

        private CargarArticulos cargarArticulos = new CargarArticulos();

        public List<Articulos> carrito(int id)
        {
            return cargarArticulos.CargarArticulosDesdeBD(id);
        }

        private ObtenerFotoPerfil obtenerFotoPerfil = new ObtenerFotoPerfil();

        public byte[] ObtenerFotoDePerfil(int cedula)
        {
            return obtenerFotoPerfil.ObtenerFoto(cedula);
        }

        public class ClienteLogica
        {
            private ObtenerCliente obtenerCliente = new ObtenerCliente();

            public Cliente ObtenerClientePorId(int id)
            {
                return obtenerCliente.ObtenerClienteProducto(id);
            }
        }

        public class PersonaDatos
        {
            private ConsultarDatos obtenerPersona = new ConsultarDatos();

            public Persona ObtenerPersonaPorCedula(string cedula)
            {
                return obtenerPersona.ObtenerPorCedula(cedula);
            }
        }
    }
}
