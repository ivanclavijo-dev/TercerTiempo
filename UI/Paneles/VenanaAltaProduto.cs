using Entidades;
using Logica.BD;
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

namespace UI.Paneles
{
    public partial class VenanaAltaProduto : Form
    {
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
        public VenanaAltaProduto()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }



        private Form ObtenerFormularioPrincipal()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is TercerTiempo) 
                {
                    return form;
                }
            }

            return null;
        }





        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea el caracter
                Form formPrincipal = ObtenerFormularioPrincipal();

                NotificacionVentana noti = new NotificacionVentana(formPrincipal);
                noti.TitleAlertBox = "Alerta.";
                noti.SubituloAlertBox = "Ingrese numeros.";
                noti.ColorAlertBox = Color.Orange;
                noti.BackColorAlertBox = Color.WhiteSmoke;
                noti.IconeAlertBox = Properties.Resources.exclamacion;

                noti.Show();

            }
        }
        consultasBD consultasBD = new consultasBD();

        private void VenanaAltaProduto_Load(object sender, EventArgs e)
        {
            NombreTextBox._TextChanged += (s, ev) => labelNombre.Text = NombreTextBox.Texts;
            PrecioListaTextBox._TextChanged += (s, ev) => labelPrecio.Text = PrecioListaTextBox.Texts;
            StockTextBox._TextChanged += (s, ev) => labelStock.Text = StockTextBox.Texts;
            DescTextBox._TextChanged += (s, ev) => labelDescripcion.Text = DescTextBox.Texts;

            int id = consultasBD.ObtenerIdDelArticuloNuevo();
            labelID.Text = Convert.ToString(id);
            
        }

        private void StockTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea el caracter
                Form formPrincipal = ObtenerFormularioPrincipal();

                NotificacionVentana noti = new NotificacionVentana(formPrincipal);
                noti.TitleAlertBox = "Alerta.";
                noti.SubituloAlertBox = "Ingrese numeros.";
                noti.ColorAlertBox = Color.Orange;
                noti.BackColorAlertBox = Color.WhiteSmoke;
                noti.IconeAlertBox = Properties.Resources.exclamacion;

                noti.Show();

            }
        }

        private void NombreTextBox__TextChanged(object sender, EventArgs e)
        {
            labelPrecio.Text = NombreTextBox.Text;
            labelPrecio.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_MouseClick(object sender, MouseEventArgs e)
        {
            int precioOferta = 0;
            if (!string.IsNullOrWhiteSpace(PrecioOfertaTextBox.Texts))
            {
                precioOferta = Convert.ToInt32(PrecioOfertaTextBox.Texts);
            }

            if (NombreTextBox.Texts == "" || PrecioListaTextBox.Texts == "" || StockTextBox.Texts == "" ||  DescTextBox.Texts == "")
            {
               
                Form formPrincipal = ObtenerFormularioPrincipal();

                NotificacionVentana noti = new NotificacionVentana(formPrincipal);
                noti.TitleAlertBox = "Alerta.";
                noti.SubituloAlertBox = "Hay ingresos vacios.";
                noti.ColorAlertBox = Color.Orange;
                noti.BackColorAlertBox = Color.WhiteSmoke;
                noti.IconeAlertBox = Properties.Resources.exclamacion;

                noti.Show();
            }
            else
            {
                Altas altaProducto = new Altas();

             


                if (altaProducto.ingresarProducto(DescTextBox.Texts, Convert.ToInt32(PrecioListaTextBox.Texts), precioOferta, NombreTextBox.Texts, Convert.ToInt32(StockTextBox.Texts)))
                {


                    Form formPrincipal = ObtenerFormularioPrincipal();

                    NotificacionVentana noti = new NotificacionVentana(formPrincipal);
                    noti.TitleAlertBox = "Producto creado.";
                    noti.SubituloAlertBox = "La operacion fue exitosa.";
                    noti.ColorAlertBox = Color.Green;
                    noti.BackColorAlertBox = Color.WhiteSmoke;
                    noti.IconeAlertBox = Properties.Resources.marca_de_verificacion;

                    noti.Show();

                    this.Hide();      
                    this.Close();    
                    return;         
                }
                else
                {
                    // Podés manejar el error acá si querés
                }

            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void PrecioOfertaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea el caracter
                Form formPrincipal = ObtenerFormularioPrincipal();

                NotificacionVentana noti = new NotificacionVentana(formPrincipal);
                noti.TitleAlertBox = "Alerta.";
                noti.SubituloAlertBox = "Ingrese numeros.";
                noti.ColorAlertBox = Color.Orange;
                noti.BackColorAlertBox = Color.WhiteSmoke;
                noti.IconeAlertBox = Properties.Resources.exclamacion;

                noti.Show();

            }
        }
    }
}
