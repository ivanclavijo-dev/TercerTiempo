using Entidades;
using Logica.BD.LogicaBajas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Paneles.Avisos
{
    public partial class ConfirmarBajaProducto : Form
    {
        public ConfirmarBajaProducto()
        {
            InitializeComponent();
            idProducto.Text = Articulos.articuloactual.idArticulo.ToString();
            nombreProducto.Text = Articulos.articuloactual.marca.ToString() + Articulos.articuloactual.detalle.ToString();
            Stock.Text = Articulos.articuloactual.stock.ToString();
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void rjButton1_MouseClick(object sender, MouseEventArgs e)
        {
            Bajas bajas = new Bajas();
            Articulos articulos = new Articulos();
            bajas.eliminarProducto(Articulos.articuloactual.idArticulo);
            this.Close();
        }
    }
}
