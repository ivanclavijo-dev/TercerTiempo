using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TercerTiempo.Persistencia;

namespace Persistencia.Grids
{
    public class RutinasGrid
    {

                private Conexion conexion = new Conexion();

                MySqlDataReader leer;
                MySqlCommand cmd = new MySqlCommand();

                public DataTable MostrarRutina() 
                {
                    DataTable tabla = new DataTable();

                    cmd.Connection = conexion.AbrirConexion();
                    cmd.CommandText = @"SELECT idRutina as ID, nombre AS Nombre, dificultad AS Dificultad, duracion as Duracion FROM rutina;";


                    leer = cmd.ExecuteReader();
                    tabla.Load(leer);
                    conexion.CerrarConexion();

                    return tabla;
                }
    }
}
