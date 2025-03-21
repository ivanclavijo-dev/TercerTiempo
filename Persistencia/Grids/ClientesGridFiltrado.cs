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
    public class ClientesGridFiltrado
    {

        public DataTable BuscarClientesFiltrados(string texto)
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            WITH ranked_adquiere AS (
                SELECT *,
                       ROW_NUMBER() OVER (PARTITION BY idCliente_adquiere ORDER BY fecha_inicio DESC) AS rn
                FROM adquiere
            )
            SELECT 
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
            LEFT JOIN ranked_adquiere ad 
                ON c.idCliente = ad.idCliente_adquiere AND ad.rn = 1
            WHERE estado_cliente = '1'
              AND (
                @texto IS NULL OR @texto = ''
                OR CONCAT(p.nombre, ' ', p.apellido) LIKE CONCAT(@texto, '%')
                OR LPAD(c.idCliente, 3, '0') LIKE CONCAT(@texto, '%')
            )
            ORDER BY c.idCliente;
        ";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@texto", texto);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
