using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Persistencia;
using Persistencia.Grids;
namespace Logica.Grids
{
     public class OB_ClienteGrid
    {
        private ClientesGrid objetoCliente =  new ClientesGrid();

        public DataTable MostrarClient()
        {
            DataTable tabla = new DataTable();  
            tabla=objetoCliente.MostrarClientes();
            return tabla;
        }
    }
}
