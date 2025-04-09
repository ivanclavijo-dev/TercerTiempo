using Entidades;
using Logica.BD.Altas;
using Logica.BD.LogicaModificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Notificaciones;

namespace UI.Paneles
{
    public partial class VentanaEditarProducto : Form
    {
        public VentanaEditarProducto()
        {
            InitializeComponent();
        }

        private void VentanaEditarProducto_Load(object sender, EventArgs e)
        {
            label1.Select();

            NombreTextBox.Texts = Convert.ToString(Articulos.articuloactual.marca);
            PrecioListaTextBox.Texts = Convert.ToString(Articulos.articuloactual.precio_lista);
            PrecioOfertaTextBox.Texts = Convert.ToString(Articulos.articuloactual.precio_oferta);
            StockTextBox.Texts = Convert.ToString(Articulos.articuloactual.stock);
            DescTextBox.Texts = Convert.ToString(Articulos.articuloactual.detalle);

            labelID.Text = Convert.ToString(Articulos.articuloactual.idArticulo);
            labelNombre.Text = NombreTextBox.Texts;
            labelPrecio.Text = Convert.ToString(Articulos.articuloactual.precio_lista);
            labelDescripcion.Text = Convert.ToString(Articulos.articuloactual.detalle);
            labelStock.Text = Convert.ToString(Articulos.articuloactual.stock);

            NombreTextBox._TextChanged += (s, ev) => labelNombre.Text = NombreTextBox.Texts;
            PrecioListaTextBox._TextChanged += (s, ev) => labelPrecio.Text = PrecioListaTextBox.Texts;
            StockTextBox._TextChanged += (s, ev) => labelStock.Text = StockTextBox.Texts;
            DescTextBox._TextChanged += (s, ev) => labelDescripcion.Text = DescTextBox.Texts;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void NombreTextBox__TextChanged(object sender, EventArgs e)
        {
            labelNombre.Text = NombreTextBox.Text;
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
        private void PrecioListaTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void rjButton1_MouseClick(object sender, MouseEventArgs e)
        {
            int precioOferta = 0;
            if (!string.IsNullOrWhiteSpace(PrecioOfertaTextBox.Texts))
            {
                precioOferta = Convert.ToInt32(PrecioOfertaTextBox.Texts);
            }

            if (NombreTextBox.Texts == "" || PrecioListaTextBox.Texts == "" || StockTextBox.Texts == "" || DescTextBox.Texts == "")
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
                Modificaciones modificaciones = new Modificaciones();




                if (modificaciones.modificarProductos(DescTextBox.Texts, Convert.ToInt32(PrecioListaTextBox.Texts), precioOferta, NombreTextBox.Texts, Convert.ToInt32(StockTextBox.Texts), Convert.ToInt32(labelID.Text)))
                {


                    Form formPrincipal = ObtenerFormularioPrincipal();

                    NotificacionVentana noti = new NotificacionVentana(formPrincipal);
                    noti.TitleAlertBox = "Producto creado.";
                    noti.SubituloAlertBox = "La operacion fue exitosa.";
                    noti.ColorAlertBox = Color.Green;
                    noti.BackColorAlertBox = Color.WhiteSmoke;
                    noti.IconeAlertBox = Properties.Resources.marca_de_verificacion;

                    noti.Show();

                    // 🔥 Cierra el formulario inmediatamente
                    this.Hide();      // ocultalo primero para una transición más suave
                    this.Close();     // luego cerralo
                    return;           // salí del handler para que no siga ejecutando nada más
                }
                else
                {
                    // Podés manejar el error acá si querés
                }

            }
        }
    }
}
