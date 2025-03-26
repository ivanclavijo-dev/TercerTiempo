using CustomControls.RJControls;
using Logica.Grids;
using Logica.ObjetosTablas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Paneles;

namespace UI.Forms
{
    public partial class Colaboradores : Form
    {
        public Colaboradores()
        {
            InitializeComponent();
            MostrarEmplaedos();

        }
        OB_ColaboradorGrid objetoE = new OB_ColaboradorGrid();

        private void MostrarEmplaedos()
        {

            var productos = objetoE.MostrarEmplead();
            dataGridView1.DataSource = productos;
            dataGridView1.ClearSelection();
        }

        private void Colaboradores_Load(object sender, EventArgs e)
        {
            MostrarEmplaedos();
            


        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Paneles.VentanaAltaColaborador ventanaAlta = new Paneles.VentanaAltaColaborador();
            ventanaAlta.Show();

        }



    }
}

