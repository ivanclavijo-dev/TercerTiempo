using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Logica.BD;
using Logica.BD.Altas;
using Logica.MetodosAdicionales;
using UI.Forms;

namespace UI.Paneles
{
    public partial class VentanaAltaClientes : Form
    {
        public VentanaAltaClientes()
        {
            InitializeComponent();
            
        }

        public void limpiar()
        {
            cedulaTextbox.Texts = "";
            nombreTextbox.Texts = "";
            apellidoTextbox.Texts = "";
            telefonoTextbox.Texts = "";
            nacimientoTextbox.Texts = "";
            servicioTextbox.Texts = "";
            sexoTextbox.Texts = "";
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

        private void VentanaAltaClientes_Load(object sender, EventArgs e)
        {
            consultasBD consultas = new consultasBD();
            int idNuevo = consultas.ObtenerIdDelClienteNuevo();
            IdTextbox.PlaceholderText = "ID del Cliente: " + idNuevo;
            IdTextbox.ForeColor = Color.FromArgb(130, 130, 130);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cedulaTextbox__TextChanged(object sender, EventArgs e)
        {
            string cedula = cedulaTextbox.Texts;
            cedulalbl.Text = $"Cedula: {cedula}";
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
    }
}
