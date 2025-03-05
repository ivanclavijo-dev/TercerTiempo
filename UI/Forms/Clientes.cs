using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Logica.Grids;

namespace UI.Forms
{
    public partial class Clientes : Form
    {
        OB_ClienteGrid objetoC = new OB_ClienteGrid();
        public Clientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }
        private void MostrarClientes()
        {
            dataGridView1.DataSource = objetoC.MostrarClient();
        }
    }
}
