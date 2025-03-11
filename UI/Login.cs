using Logica.BD;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class Login : Form
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
        public Login()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
           this.KeyPreview = true;  

        }

        private void Login_Load(object sender, EventArgs e)
        {

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void elipseControl1_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox2__TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            rjTextBox2.PasswordChar = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            rjTextBox2.PasswordChar = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;

        }



        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.FromArgb(16, 83, 233);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.FromArgb(130, 130, 130);
        }
        private consultasBD consultas_BD = new consultasBD();


        private void rjButton1_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (consultas_BD.ValidarUsuario(rjTextBox1.Texts.Trim(), rjTextBox2.Texts.Trim()) == true)
                {
                    TercerTiempo tercerTiempo = new TercerTiempo();
                    tercerTiempo.Show();
                    this.Hide();
                }
            }
        }
    }
}

