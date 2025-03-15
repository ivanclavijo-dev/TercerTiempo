using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.Grids
{
     public class ClientesGrid
    {
        private Conexion conexion = new Conexion();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand cmd = new MySqlCommand();

        public DataTable MostrarClientes()
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "SELECT c.id_cliente AS 'ID Cliente', c.nombre AS 'Nombre', c.apellido AS 'Apellido', c.cedula AS 'Cédula', p.dia_finalizacion AS 'Fecha de Vencimiento' FROM Cliente c JOIN Pagos p ON c.id_cliente = p.id_cliente;";
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
    }
}
