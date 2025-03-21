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
            DataTable tabla = new DataTable();

            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = @"SELECT 
                                LPAD(c.idCliente, 3, '0') AS ID,
                                CONCAT(p.nombre, ' ', p.apellido) AS Nombre,
                                ad.fecha_inicio AS 'Ultimo pago',
                                CASE 
                                    WHEN ad.vencimiento >= CURDATE() + INTERVAL 7 DAY THEN 'Vigente'
                                    WHEN ad.vencimiento >= CURDATE() THEN 'Por vencer'
                                    ELSE 'Vencido'
                                END AS 'Estado de cuota',
                                CASE 
                                    WHEN p.notificaciones = 1 THEN 'Activo'
                                    ELSE 'Inactivo'
                                END AS Notificaciones
                            FROM cliente c
                            JOIN persona p ON c.cedula_cliente = p.cedula
                            LEFT JOIN adquiere ad ON c.idCliente = ad.idCliente_adquiere
                            WHERE estado_cliente = '1'
                            ORDER BY c.idCliente;";

            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }
    }
}
