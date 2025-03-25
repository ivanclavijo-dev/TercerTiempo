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
    public class EmpleadosGrids
    {

        private Conexion conexion = new Conexion();

        MySqlDataReader leer;
        MySqlCommand cmd = new MySqlCommand();

        public DataTable MostrarEmpleados()
        {
            DataTable tabla = new DataTable();

            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = @"
                           SELECT 
    c.idColaborador AS ID,
    CONCAT(p.nombre, ' ', p.apellido) AS Nombre,
    CASE 
        WHEN c.rol = 'Admin' THEN 'Administrador'
        ELSE 'Profe'
    END AS Rol
FROM colaborador c
JOIN persona p ON c.cedula_colaborador = p.cedula
ORDER BY c.idColaborador;
";


            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }
    }
}
