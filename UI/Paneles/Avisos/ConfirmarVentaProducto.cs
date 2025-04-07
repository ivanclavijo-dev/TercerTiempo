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
using UI.Notificaciones;

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
            label5.Text = "Total a pagar: $" + Carrito.valorTotal;
        }

        private Form ObtenerFormularioPrincipal()
        {
            // Buscar en los formularios abiertos un formulario de tipo TercerTiempo (tu form principal)
            foreach (Form form in Application.OpenForms)
            {
                if (form is TercerTiempo) // Cambiá esto si tu form principal tiene otro nombre
                {
                    return form;
                }
            }

            return null;
        }



        private void rjButton1_MouseClick(object sender, MouseEventArgs e)
        {
            AltaPago altaPago = new AltaPago();
            int idCliente = SesionCliente.clienteActual.idCliente;

            bool huboError = true;

            foreach (var producto in Carrito.Productos)
            {
                bool insertado = altaPago.IngresarPago(idCliente, producto.idArticulo, producto.stock);


                if (!insertado)
                {
                    huboError = true;
                    Console.WriteLine($"Error al registrar el producto con ID {producto.idArticulo}");
                }
            }

            // Si todo salió bien, recién ahí mostramos notificación y cerramos
            if (!huboError)
            {
                Form formPrincipal = ObtenerFormularioPrincipal();

                NotificacionVentana noti = new NotificacionVentana(formPrincipal);
                noti.TitleAlertBox = "Venta confirmada";
                noti.SubituloAlertBox = "La venta fue exitosa";
                noti.ColorAlertBox = Color.Green;
                noti.BackColorAlertBox = Color.WhiteSmoke;
                noti.IconeAlertBox = Properties.Resources.marca_de_verificacion;
                noti.Show();

                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Algunos productos no pudieron registrarse.");
            }


        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
