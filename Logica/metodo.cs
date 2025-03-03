using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using TercerTiempo.Persistencia;

namespace Logica
{
    public class Metodo
    {
        private Conexion db = new Conexion();

        public string Mensaje()
        {
            if (db.AbrirConexion() == true)
            {
                return "Se abrio";
            }
            else if (db.AbrirConexion() == false)
            {
                return " no Se abrio";
            }
            return "";
        }
    }
}
