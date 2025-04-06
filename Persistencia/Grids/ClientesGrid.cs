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
        MySqlCommand cmd = new MySqlCommand();

        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();

            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = @"
                            WITH ultima_membresia AS (
                                SELECT a.*
                                FROM (
                                    SELECT *,
                                           ROW_NUMBER() OVER (PARTITION BY idCliente_adquiere ORDER BY fecha_inicio DESC) AS rn
                                    FROM adquiere
                                ) a
                                WHERE a.rn = 1
                            )

                            SELECT 
                                LPAD(c.idCliente, 3, '0') AS ID,
                                CONCAT(p.nombre, ' ', p.apellido) AS Nombre,
                                um.fecha_inicio AS 'Ultimo pago',
                                CASE 
                                    WHEN um.vencimiento IS NULL THEN 'Sin membresía'
                                    WHEN um.vencimiento >= CURDATE() + INTERVAL 7 DAY THEN 'Vigente'
                                    WHEN um.vencimiento >= CURDATE() THEN 'Por vencer'
                                    ELSE 'Vencido'
                                END AS 'Estado de cuota',
                                CASE 
                                    WHEN p.notificaciones = 1 THEN 'Activo'
                                    ELSE 'Inactivo'
                                END AS Notificaciones
                            FROM cliente c
                            JOIN persona p ON c.cedula_cliente = p.cedula
                            LEFT JOIN ultima_membresia um ON c.idCliente = um.idCliente_adquiere
                            WHERE c.estado_cliente = '1'
                            ORDER BY 
                                CASE 
                                    WHEN um.vencimiento IS NULL THEN 4
                                    WHEN um.vencimiento >= CURDATE() + INTERVAL 7 DAY THEN 1
                                    WHEN um.vencimiento >= CURDATE() THEN 2
                                    ELSE 3
                                END,
                                c.idCliente;";


            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }
    }
}
