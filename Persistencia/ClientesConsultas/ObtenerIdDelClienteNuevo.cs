using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.ClientesConsultas
{
    public class ObtenerIdDelClienteNuevo
    {
        private Conexion conexion = new Conexion();
        public int IdNuevoCliente()
        {
            int idcliente = 0;

            MySqlConnection conn = conexion.AbrirConexion();
            {
                string consulta = "SELECT IFNULL(MAX(idCliente), 0) + 1 AS valor_maximo FROM cliente;";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {

                    idcliente = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            return idcliente;

        }
    }
}


