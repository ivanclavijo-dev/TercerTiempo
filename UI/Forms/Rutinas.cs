using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.ObjetosTablas;

namespace UI.Forms
{
    public partial class Rutinas : Form
    {
        public Rutinas()
        {
            InitializeComponent();
        }

        private void MostrarRutinas()
        {
            OB_RutinaGrid oB_RutinaGrid = new OB_RutinaGrid();
            var productos = oB_RutinaGrid.MostrarRutinas();
            dataGridView1.DataSource = productos;
            dataGridView1.ClearSelection();

        }

        private void Rutinas_Load(object sender, EventArgs e)
        {
            MostrarRutinas();
        }
    }
}
