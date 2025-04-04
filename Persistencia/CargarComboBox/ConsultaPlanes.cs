using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerTiempo.Persistencia;

namespace Persistencia.CargarComboBox
{
    public class ConsultaPlanes
    {

        private Conexion conexion = new Conexion();

        MySqlDataReader leer;
        MySqlCommand cmd = new MySqlCommand();

        public DataTable MostrarPlanes()
        {
            DataTable tabla = new DataTable();

            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "SELECT idPlan, nombre FROM plan";

            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }
    }
}
