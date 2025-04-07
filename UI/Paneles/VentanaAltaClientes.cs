using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Logica.BD;
using Logica.BD.Altas;
using Logica.MetodosAdicionales;
using UI.Forms;
using UI.Paneles.Desplegable;

namespace UI.Paneles
{
    public partial class VentanaAltaClientes : Form
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
        public VentanaAltaClientes()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }


        private void VentanaAltaClientes_Load(object sender, EventArgs e)
        {
            consultasBD consultas = new consultasBD();
            int idNuevo = consultas.ObtenerIdDelClienteNuevo();
            IdTextbox.PlaceholderText = "ID del Cliente: " + idNuevo;
            IdTextbox.ForeColor = Color.FromArgb(130, 130, 130);

            cedulaTextbox.MaxLength = 8;
            telefonoTextbox.MaxLength = 9;
        }

        public void limpiar()
        {
            cedulaTextbox.Texts = "";
            nombreTextbox.Texts = "";
            apellidoTextbox.Texts = "";
            telefonoTextbox.Texts = "";
            nacimientoTextbox.Texts = "";
            servicioTextbox.Texts = "";
            sexoTextbox.Text = "";
            observacionTextbox.Texts = "";
            NotificacionesChkbox.Checked = false;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            bool validarFecha = validaciones.formatoFecha(nacimientoTextbox.Texts);

            if (cedulaTextbox.Texts == "" || nombreTextbox.Texts == "" || apellidoTextbox.Texts == "" || telefonoTextbox.Texts == "" ||
                nacimientoTextbox.Texts == "" || servicioTextbox.Texts == "" || sexoTextbox.Texts == "")
            {
                MessageBox.Show("Debes completar todos los campos para enviar los datos.");
            }
            else if (!validarFecha)
            {
                MessageBox.Show("El formato de la fecha es incorrecto.");
            }
            else
            {
                Altas altas = new Altas();

                int resultadoIngresarPersona = altas.ingresarPersona(Convert.ToInt32(cedulaTextbox.Texts), nombreTextbox.Texts, apellidoTextbox.Texts, telefonoTextbox.Texts,
                    servicioTextbox.Texts, nacimientoTextbox.Texts, NotificacionesChkbox.Checked, sexoTextbox.Texts);

                int resultadoIngresarCliente = altas.ingresarCliente(observacionTextbox.Texts, Convert.ToInt32(cedulaTextbox.Texts));

                if (resultadoIngresarPersona == 1)
                {
                    MessageBox.Show("Se ingreso la persona");

                    if (resultadoIngresarCliente == 1)
                    {
                        MessageBox.Show("Se ingreso al cliente correctamente");
                        limpiar();
                    }
                    else if (resultadoIngresarCliente == 2)
                    {
                        MessageBox.Show("Error al ingresar al cliente");
                    }
                    else if (resultadoIngresarCliente == 3)
                    {
                        MessageBox.Show("El cliente ya existe. No puedes registrarlo denuevo.");
                    }
                    else
                    {
                        MessageBox.Show("Error no identificado, comunicarse con soporte.");
                    }
                }
                else if (resultadoIngresarPersona == 2)
                {
                    MessageBox.Show("Error al ingresar la persona");
                }
                else if (resultadoIngresarPersona == 3)
                {
                    MessageBox.Show("La persona ya esta ingresada en el sistema. Compruebe la cedula ingresada.");
                }
                else if (resultadoIngresarPersona == 4)
                {
                    MessageBox.Show("El formato de la fecha ingresada esta mal.");
                }
                else
                {
                    MessageBox.Show("Error no identificado, comunicarse con soporte.");
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cedulaTextbox__TextChanged(object sender, EventArgs e)
        {
            cedulalbl.Text = $"Cédula: {cedulaTextbox.Texts}";
        }

        private void nombreTextbox__TextChanged(object sender, EventArgs e)
        {
            ActualizarLabelNombreCompleto();
        }
        private void apellidoTextbox__TextChanged(object sender, EventArgs e)
        {
            ActualizarLabelNombreCompleto();
        }

        private void ActualizarLabelNombreCompleto()
        {
            string nombre = Capitalizar(nombreTextbox.Texts);
            string apellido = Capitalizar(apellidoTextbox.Texts);
            string textoCompleto = $"Nombre: {nombre} {apellido}";

            // Limitar a máximo 22 caracteres
            if (textoCompleto.Length > 21)
            {
                textoCompleto = textoCompleto.Substring(0, 18) + "...";
            }

            nombrelbl.Text = textoCompleto;
        }

        public string Capitalizar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return "";

            texto = texto.Trim().ToLower();
            return char.ToUpper(texto[0]) + texto.Substring(1);
        }

        private void telefonoTextbox__TextChanged(object sender, EventArgs e)
        {
            telefonolbl.Text = $"Teléfono: {telefonoTextbox.Texts}";
        }

        private void servicioTextbox__TextChanged(object sender, EventArgs e)
        {
            serviciolbl.Text = $"Servicio: {servicioTextbox.Texts}";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private Informacion panelInformacion = null;

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            // Si ya existe, lo eliminamos por seguridad
            if (panelInformacion != null && !panelInformacion.IsDisposed)
            {
                panelInformacion.Close();
                panelInformacion = null;
            }

            Point posicionLocal = new Point(740, 290);
            Point posicionPantalla = this.PointToScreen(posicionLocal);

            panelInformacion = new Informacion("Formato de entrada:", "YYYY-MM-DD", posicionPantalla.X, posicionPantalla.Y);
            panelInformacion.Show();
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            panelInformacion.Close();
        }

        private bool bloqueando = false;


        private void nacimientoTextbox__TextChanged(object sender, EventArgs e)
        {
            FormatoDeFecha(sender);
            nacimientolbl.Text = $"Nacimiento: {nacimientoTextbox.Texts}";
        }

        public void FormatoDeFecha(object sender)
        {

            if (bloqueando) return;

            bloqueando = true;

            TextBox txt = sender as TextBox;

            int cursorPos = txt.SelectionStart;

            // Extraer solo los dígitos
            string raw = new string(txt.Text.Where(char.IsDigit).ToArray());

            int oldLength = txt.Text.Length;

            // Insertar guiones donde corresponde
            if (raw.Length > 4)
                raw = raw.Insert(4, "-");
            if (raw.Length > 7)
                raw = raw.Insert(7, "-");

            if (raw.Length > 10)
                raw = raw.Substring(0, 10);

            // Calcular diferencia de largo
            int diff = raw.Length - txt.Text.Length;

            txt.Text = raw;

            // Restaurar posición del cursor inteligentemente
            cursorPos += diff;

            // Limitar dentro del rango del texto
            if (cursorPos < 0) cursorPos = 0;
            if (cursorPos > txt.Text.Length) cursorPos = txt.Text.Length;

            txt.SelectionStart = cursorPos;

            bloqueando = false;
        }

    }
}
