using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms;

namespace UI.Paneles.Avisos
{
    public partial class ConfirmarVentaProducto : Form
    {
        public ConfirmarVentaProducto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmarVentaProducto_Load(object sender, EventArgs e)
        {
            idCliente.Text = SesionCliente.clienteActual.idCliente.ToString();
            nombreCliente.Text = SesionCliente.clienteActual.DatosPersonales.Nombre + " " + SesionCliente.clienteActual.DatosPersonales.Apellido;
            label5.Text = "Total a pagar: $"+Carrito.valorTotal;
        }

        private void rjButton1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
            Productos productos = new Productos();
            productos.Show();
        }
    }
}
