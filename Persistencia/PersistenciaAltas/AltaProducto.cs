using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.PersistenciaAltas
{
    public class AltaProducto
    {
        private Conexion cn = new Conexion();

        // FALTA AGREGAR FOTO DE PERFIL

        public bool IngresarProducto(string marca, string detalle, int precioLista, int precioOferta, int stock )
        {
            try
            {
                cn.AbrirConexion();
                MySqlConnection conn = cn.AbrirConexion();

                string query = "INSERT INTO articulo (detalle, precio_lista, precio_oferta, marca, stock) VALUES (@Detalle, @PrecioLista, @PrecioOferta, @Marca, @Stock);";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Detalle", detalle);
                    cmd.Parameters.AddWithValue("@PrecioLista", precioLista);
                    cmd.Parameters.AddWithValue("@PrecioOferta", precioOferta);
                    cmd.Parameters.AddWithValue("@Marca", marca);
                    cmd.Parameters.AddWithValue("@Stock", stock);
              

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar articulo: " + ex.Message);
                return false;
            }
            finally
            {
                cn.CerrarConexion();
            }
        }
    }
}
