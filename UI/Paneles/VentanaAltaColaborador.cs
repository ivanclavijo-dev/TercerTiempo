using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Paneles
{
    public partial class VentanaAltaColaborador : Form
    {
        public VentanaAltaColaborador()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void VentanaAltaColaborador_Load(object sender, EventArgs e)
        {
            rjComboBox1.Items.Add("Administrador");
            rjComboBox1.Items.Add("Colaborador");
            
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }
    }
}
