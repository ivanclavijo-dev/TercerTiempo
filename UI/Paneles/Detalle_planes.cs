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
using Logica;
using Logica.BD.ConsultaPlanesLogica;
using Persistencia.Grids;


namespace UI.Paneles
{
    public partial class Detalle_planes : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
        );

        public Detalle_planes(string id, string nombre, string estado_cuota)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            idCliente.Text = id;
            nombreCliente.Text = nombre;
            estadoCuotaCliente.Text = estado_cuota;

            if (estado_cuota == "Vigente")
            {
                estadoCuotaCliente.ForeColor = Color.FromArgb(56, 224, 56);
            }
            else if (estado_cuota == "Por vencer")
            {
                estadoCuotaCliente.ForeColor = Color.FromArgb(240, 165, 45);
            }
            else if (estado_cuota == "Vencido")
            {
                estadoCuotaCliente.ForeColor = Color.FromArgb(244, 54, 20);
            }
            else if (estado_cuota == "Pendiente")
            {
                estadoCuotaCliente.ForeColor = Color.Silver;
            }

            CargarPlanesEnComboBox logica = new CargarPlanesEnComboBox();
            comboBox1.DataSource = logica.ObtenerPlanes();
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idPlan";

            comboBox2.SelectedIndex = 0;

            string soloNombre = nombre.Split(' ')[0];
            label1.Text = $"Últimos pagos de {soloNombre}";

        }

        PagosGrid pagosGrid = new PagosGrid();

        private void Detalle_planes_Load(object sender, EventArgs e)
        {
            pagosGrid.MostrarPagos(idCliente.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
