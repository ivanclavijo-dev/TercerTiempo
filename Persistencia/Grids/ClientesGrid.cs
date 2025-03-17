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
            cmd.CommandText = "SELECT \r\n    LPAD(c.id_cliente, 3, '0') AS ID,  -- Asegura que el ID tenga al menos 3 dígitos, con ceros a la izquierda si es necesario\r\n    CONCAT(p.nombre, ' ', p.apellido) AS Nombre,\r\n    pa.dia_pago AS 'Último pago',\r\n    CASE \r\n        WHEN pa.dia_finalizacion >= CURDATE() + INTERVAL 7 DAY THEN 'Vigente'\r\n        WHEN pa.dia_finalizacion >= CURDATE() THEN 'Por vencer'\r\n        ELSE 'Vencido'\r\n    END AS 'Estado de cuota',\r\n    CASE \r\n        WHEN c.notis = 1 THEN 'Activo'\r\n        ELSE 'Inactivo'\r\n    END AS Notificaciones\r\nFROM Cliente c\r\nJOIN Persona p ON c.cedula = p.cedula\r\nLEFT JOIN Pagos pa ON c.id_cliente = pa.id_cliente;\r\n";
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
    }
}
