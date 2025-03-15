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
using Logica.BD;
using Logica.Metodos;

namespace UI.Forms
{
    public partial class RestablecerContraseña : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,     // x-coordinate of upper-left corner
    int nTopRect,      // y-coordinate of upper-left corner
    int nRightRect,    // x-coordinate of lower-right corner
    int nBottomRect,   // y-coordinate of lower-right corner
    int nWidthEllipse, // height of ellipse
    int nHeightEllipse // width of ellipse
);
        public RestablecerContraseña()
        {
            InitializeComponent();
        }

        private void RestablecerContraseña_Load(object sender, EventArgs e)
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ValidarUsuarioLogin.DatosCompartidos validarUsuarioLoginForm = new ValidarUsuarioLogin.DatosCompartidos();

            MessageBox.Show(ValidarUsuarioLogin.DatosCompartidos.ValorTextbox);

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void rjButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (rjTextBox1.Texts.Trim() == rjTextBox2.Texts.Trim())
            {
                consultasBD consultasbd = new consultasBD();
                consultasbd.CambiarContraseñaEmpleado(rjTextBox1.Texts.Trim(), ValidarUsuarioLogin.DatosCompartidos.ValorTextbox);
                Login loginform = new Login();
                loginform.Show();
                this.Hide();
            }
        }

        private void rjTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void rjTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
                if(rjTextBox1.Texts.Trim() == "")
            {
                label5.Visible = false;
                label1.Visible = true;

            }
            else
            {
                if (rjTextBox1.Texts.Trim() == rjTextBox2.Texts.Trim())
                {
                    label1.Visible = true;
                    label5.Visible = false;
                }
                else if (rjTextBox1.Texts.Trim() != rjTextBox2.Texts.Trim())
                {
                    label1.Visible = false;
                    label5.Visible = true;
                }
            }
             
            
        }
    }
}
