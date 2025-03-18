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
            cmd.CommandText = "SELECT \r\n    LPAD(c.idCliente, 3, '0') AS ID,  -- Asegura que el ID tenga al menos 3 dígitos, con ceros a la izquierda\r\n    CONCAT(p.nombre, ' ', p.apellido) AS Nombre,\r\n    ad.fecha_inicio AS 'Ultimo pago',\r\n    CASE \r\n        WHEN ad.vencimiento >= CURDATE() + INTERVAL 7 DAY THEN 'Vigente'\r\n        WHEN ad.vencimiento >= CURDATE() THEN 'Por vencer'\r\n        ELSE 'Vencido'\r\n    END AS 'Estado de cuota',\r\n    CASE \r\n        WHEN p.notificaciones = 1 THEN 'Activo'\r\n        ELSE 'Inactivo'\r\n    END AS Notificaciones\r\nFROM cliente c\r\nJOIN persona p ON c.cedula_cliente = p.cedula\r\nLEFT JOIN adquiere ad ON c.idCliente = ad.idCliente_adquiere;\r\n";
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
    }
}
