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
using Logica;

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

        private Form homeForm;
        private Form clientesForm;
        private Form productosForm;
        private Form colaboradoresForm;
        private Form rutinasForm;

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(homeForm);
        }


        private void TercerTiempo_Load(object sender, EventArgs e)
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            homeForm = new Forms.Home();
            clientesForm = new Forms.Clientes();
            productosForm = new Forms.Productos();
            colaboradoresForm = new Forms.Colaboradores();
            rutinasForm = new Forms.Rutinas();

            AbrirFormInPanel(homeForm);
            label3.Text = SesionUsuario.EmpleadoActual.DatosPersonales.Nombre + " " + SesionUsuario.EmpleadoActual.DatosPersonales.Apellido;

        }

        private void AbrirFormInPanel(Form formHijo)
        {
            if (this.contenedorVistas.Controls.Count > 0)
                this.contenedorVistas.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            this.contenedorVistas.Controls.Add(formHijo);
            this.contenedorVistas.Tag = formHijo;
            formHijo.Show();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormInPanel(homeForm);

        }

        private void clientesLabel_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormInPanel(clientesForm);

        }

        private void productosLabel_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormInPanel(productosForm);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormInPanel(clientesForm);

        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormInPanel(productosForm);

        }

        private void empleadosLabel_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormInPanel(colaboradoresForm);
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(productosForm);

        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormInPanel(rutinasForm);
        }

        private void pictureBox14_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormInPanel(rutinasForm);

        }
    }
}
