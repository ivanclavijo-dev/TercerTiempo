using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UI
{
    public partial class TercerTiempo : Form
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

        public TercerTiempo()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.contenedorVistas.Controls.Count > 0)
                this.contenedorVistas.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None; // Elimina bordes
            this.contenedorVistas.Controls.Add(fh);
            this.contenedorVistas.Tag = fh;
            fh.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Forms.Home());
        }


        private void TercerTiempo_Load(object sender, EventArgs e)
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            AbrirFormInPanel(new Forms.Home());

        }


        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormInPanel(new Forms.Home());

        }

        private void clientesLabel_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormInPanel(new Forms.Clientes());

        }

        private void productosLabel_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        public void VistaColaborador(bool visible)
        {
            empleadosLabel.Visible = visible;
            pictureBox5.Visible = visible;
            panel8.Visible = visible;
            estadisticasLabel.Visible = visible;
            pictureBox8.Visible = visible;
            panel9.Visible = visible;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            Login login = new Login();

            login.Show();

            this.Hide();
        }



        private void pictureBox13_MouseClick(object sender, MouseEventArgs e)
        {
            Login login = new Login();

            login.Show();

            this.Hide();
        }

        private void panel11_MouseClick(object sender, MouseEventArgs e)
        {
            Login login = new Login();

            login.Show();

            this.Hide();
        }
    }
}
