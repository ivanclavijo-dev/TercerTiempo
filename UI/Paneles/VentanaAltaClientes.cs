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
using Logica.BD.Altas;

namespace UI.Paneles
{
    public partial class VentanaAltaClientes : Form
    {
        public VentanaAltaClientes()
        {
            InitializeComponent();
        }

        private void rjButton2_Click(object sender, EventArgs e)
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

        private void rjButton1_Click(object sender, EventArgs e)
        {

            if (cedulaTextbox.Texts == "" || nombreTextbox.Texts == "" || apellidoTextbox.Texts == "" || telefonoTextbox.Texts == "" || 
                nacimientoTextbox.Texts == "" || servicioTextbox.Texts == "" || sexoTextbox.Texts == "")
            {
                MessageBox.Show("Debes completar todos los campos para enviar los datos.");
            } else
            {
                Altas altas = new Altas();

                if(altas.ingresarPersona(Convert.ToInt32(cedulaTextbox.Texts), nombreTextbox.Texts, apellidoTextbox.Texts, telefonoTextbox.Texts,
                    servicioTextbox.Texts, nacimientoTextbox.Texts, NotificacionesChkbox.Checked, sexoTextbox.Texts))
                {
                    MessageBox.Show("Se ingreso la persona");
                } else
                {
                    MessageBox.Show("Error al ingresar la persona");
                }
            }
        }
    }
}
