using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.ArticulosConsultas
{
    public class CargarArticulos
    {
        private Conexion conexion = new Conexion();
        public List<Articulos> CargarArticulosDesdeBD(int id)
        {
            List<Articulos> lista = new List<Articulos>();

            string query = "SELECT * from articulo where idArticulo = '"+id+"'";

            using (MySqlCommand cmd = new MySqlCommand(query, conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    Articulos articulos = new Articulos
                    {
                        idArticulo = reader.GetInt32("idArticulo"),
                        detalle = reader.GetString("detalle"),
                        precio_lista = reader.GetInt32("precio_lista"),
                        precio_oferta = reader.GetInt32("precio_oferta"),
                        marca = reader.GetString("marca"),
                        stock = reader.GetInt32("stock")
                    };
                    lista.Add(articulos);

                }
            }
            return lista;
        }
    }
}
