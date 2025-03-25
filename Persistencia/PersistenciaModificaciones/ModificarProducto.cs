using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.PersistenciaModificaciones
{
    public class ModificarProducto
    {
        private Conexion cn = new Conexion();

        public bool modificarProducto(string detalle, int precioLista, int precioOferta, string marca, int stock, int id)
        {
            try
            {
                cn.AbrirConexion();
                MySqlConnection conn = cn.AbrirConexion();

                string query = "UPDATE `tercertiempo`.`articulo` SET `detalle` = @Detalle, `precio_lista` = @PrecioLista, `precio_oferta` = @PrecioOferta, `marca` = @Marca, `stock` = @Stock WHERE `idArticulo` = @IdArticulo;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Detalle", detalle);
                    cmd.Parameters.AddWithValue("@PrecioLista", precioLista);
                    cmd.Parameters.AddWithValue("@PrecioOferta", precioOferta);
                    cmd.Parameters.AddWithValue("@Marca", marca);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.Parameters.AddWithValue("@IdArticulo", id);


                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar producto: " + ex.Message);
                return false;
            }
            finally
            {
                cn.CerrarConexion();
            }
        }
    }
}
