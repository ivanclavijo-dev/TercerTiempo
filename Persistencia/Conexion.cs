using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TercerTiempo.Persistencia
{
    public class Conexion
    {
        private MySqlConnection _conexion;
        private readonly string _cadenaConexion;

        // Constructor
        public Conexion(string servidor = "localhost", string baseDatos = "tercertiempo", string usuario = "root", string contraseña = "Kirayruffo2_", int puerto = 3306)
        {
            _cadenaConexion = $"Server={servidor};Database={baseDatos};Uid={usuario};Pwd={contraseña};Port={puerto};";
            _conexion = new MySqlConnection(_cadenaConexion);
        }

        public bool AbrirConexion()
        {
            try
            {
                if (_conexion.State == System.Data.ConnectionState.Closed)
                {
                    _conexion.Open();
                    Console.WriteLine("Conexión abierta correctamente.");
                }
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
                return false;
            }
        }

        // Cerrar conexión
        public bool CerrarConexion()
        {
            try
            {
                if (_conexion.State == System.Data.ConnectionState.Open)
                {
                    _conexion.Close();
                    Console.WriteLine("Conexión cerrada correctamente.");
                }
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error al cerrar la conexión: {ex.Message}");
                return false;
            }
        }

        public MySqlConnection ConexionAbierta
        {
            get { return _conexion; }
        }
    }
}
