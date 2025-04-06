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
    public class PagosGrid
    {
        private Conexion conexion = new Conexion();

        MySqlDataReader leer;
        MySqlCommand cmd = new MySqlCommand();

        public DataTable MostrarPagos(string id)
        {
            DataTable tabla = new DataTable();
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = @"SELECT idAdquiere AS Factura, vencimiento AS Vencimiento, p.nombre AS Plan, metodo_pago AS Metodo FROM adquiere
                                INNER JOIN plan p ON adquiere.idPlan = p.idPlan
                                WHERE idCliente_adquiere = "+id+";";
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
