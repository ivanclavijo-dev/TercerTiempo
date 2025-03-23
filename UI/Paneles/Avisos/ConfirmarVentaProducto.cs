using Entidades;
using Logica;
using Logica.BD.Altas;
using Persistencia.PersistenciaAltas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms;

namespace UI.Paneles.Avisos
{
    
    public partial class ConfirmarVentaProducto : Form
    {
        Altas altas = new Altas();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse
       );
        public ConfirmarVentaProducto()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

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
            AltaPago altaPago = new AltaPago();
            int idCliente = SesionCliente.clienteActual.idCliente; // o el seleccionado

            foreach (var producto in Carrito.Productos)
            {
                for (int i = 0; i < producto.stock; i++)
                {
                   if(altaPago.IngresarPago(idCliente, producto.idArticulo) == true){

                        MessageBox.Show("PAGO REALIZADO");
                    }
                    else
                    {
                        MessageBox.Show("PAGO NO REALIZADO");

                    }
                }
            }
            this.Dispose();
           
        }
    }
}
