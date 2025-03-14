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

namespace UI.Forms
{
    public partial class ValidarUsuarioLogin : Form
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
        public ValidarUsuarioLogin()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ValidarUsuarioLogin_Load(object sender, EventArgs e)
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void rjButton1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
       
        private void rjButton1_MouseClick_1(object sender, MouseEventArgs e)
        {
            
             
        consultasBD consulta_bd = new consultasBD();
            if (consulta_bd.ValidarUsuarioLogin(rjTextBox1.Texts.Trim()) == true)
            {
                DatosCompartidos.ValorTextbox = rjTextBox1.Texts.Trim();
                RestablecerContraseña restablecerContraseñaform = new RestablecerContraseña();
                restablecerContraseñaform.Show();
                this.Hide();
            }
            else if (consulta_bd.ValidarUsuarioLogin(rjTextBox1.Texts.Trim()) == false)
            {
                labelError.Visible = true;

            }
            else
            {
                MessageBox.Show("No anda");

            }
        }

        public  class DatosCompartidos
        {
            public static string ValorTextbox { get; set; }
        }
    }
}
