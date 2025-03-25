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
    public class ProductosGridFiltrado
    {
        public DataTable BuscarProductosFiltrados(string texto)
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                                                        SELECT 
                                                idArticulo AS 'ID',
                                                marca AS 'Nombre',
                                                precio_lista AS 'Precio',
                                                stock AS 'Stock',
                                                detalle AS 'Descripcion'
                                            FROM articulo
                                            WHERE 
                                                @texto IS NULL OR @texto = ''
                                                OR marca LIKE CONCAT(@texto, '%')
                                                OR detalle LIKE CONCAT('%', @texto, '%')
                                                OR CAST(idArticulo AS CHAR) LIKE CONCAT(@texto, '%')

                                            ORDER BY idArticulo;

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
