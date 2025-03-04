using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Logica.Metodo me = new Logica.Metodo();

            MessageBox.Show(me.Mensaje());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panelProfile.Visible == true)
            {
                panelProfile.Visible = false;

            }
            else
            {
                panelProfile.Visible = true;

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
