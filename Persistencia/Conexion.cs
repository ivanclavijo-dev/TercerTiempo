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
        public Conexion(string servidor = "localhost", string baseDatos = "tercertiempo", string usuario = "root")
        {
            _cadenaConexion = $"Server={servidor};Port=3309;Database={baseDatos};Uid={usuario};";
            _conexion = new MySqlConnection(_cadenaConexion);
        }


        public MySqlConnection AbrirConexion()
        {
            try
            {
                if (_conexion.State == System.Data.ConnectionState.Closed)
                {
                    _conexion.Open();
                    Console.WriteLine("Conexión abierta correctamente.");
                }
                return _conexion;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
                return _conexion;
            }
        }

        // Cerrar conexión
        public MySqlConnection CerrarConexion()
        {
            try
            {
                if (_conexion.State == System.Data.ConnectionState.Open)
                {
                    _conexion.Close();
                    Console.WriteLine("Conexión cerrada correctamente.");
                }
                return _conexion;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error al cerrar la conexión: {ex.Message}");
                return _conexion;
            }
        }

        public MySqlConnection ConexionAbierta
        {
            get { return _conexion; }
        }
    }
}
