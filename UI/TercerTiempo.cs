using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class TercerTiempo : Form
    {

        public TercerTiempo()
        {

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
            this.contenedorVistas.Controls.Add(fh);
            this.contenedorVistas.Tag = fh;
            fh.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Forms.Home());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void TercerTiempo_Load(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Forms.Home());
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Forms.Clientes());
        }

        private void contenedorVistas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BotonHome_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void elipseControl1_MouseHover(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void elipseControl1_Click(object sender, EventArgs e)
        {

        }

        private void elipseControl3_Click(object sender, EventArgs e)
        {

        }
    }
}
