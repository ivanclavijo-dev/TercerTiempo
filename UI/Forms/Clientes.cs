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
using Logica.BD;
using Logica.Grids;
using Persistencia.Grids;
using UI.Paneles;
using UI.Paneles.Avisos;

namespace UI.Forms
{
    public partial class Clientes : Form
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
        OB_ClienteGrid objetoC = new OB_ClienteGrid();

        private Form ventanaAltaCliente;
        private Form ventanaPagarCliente;

        public Clientes()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            MostrarClientes();

        }
        private void MostrarClientes()
        {
            dataGridView1.DataSource = null; // Por las dudas, limpiamos antes de volver a cargar
            dataGridView1.DataSource = objetoC.MostrarClient();
        }

        private void MostrarPanel(Form form)
        {
            UI.Helpers.ModalOverlayHelper.MostrarConOverlay(form, MostrarClientes);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ventanaAltaCliente = new VentanaAltaClientes();
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            string texto = rjTextBox1.Texts.Trim();
            dataGridView1.DataSource = objetoC.ObtenerClientes(texto);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Estado de cuota" && e.Value != null)
            {
                string estado = e.Value.ToString();

                if (estado == "Vigente")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(56, 224, 56);
                }
                else if (estado == "Por vencer")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(240, 165, 45);
                }
                else if (estado == "Vencido")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(244, 54, 20);
                }
                else if (estado == "Pendiente")
                {
                    e.CellStyle.ForeColor = Color.Silver;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ventanaAltaCliente == null || ventanaAltaCliente.IsDisposed)
            {
                ventanaAltaCliente = new VentanaAltaClientes();
            }

            MostrarPanel(ventanaAltaCliente);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Verifica que haya una fila seleccionada
            {
                // Obtiene los datos de la fila seleccionada
                string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                string nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string estadoCuota = dataGridView1.SelectedRows[0].Cells["Estado de cuota"].Value.ToString();

                // Abre el segundo formulario y le pasa los datos
                if (id != null && nombre != null && estadoCuota != null)
                {
                    ConfirmaBajaCliente confirmaBajaCliente = new ConfirmaBajaCliente(id, nombre, estadoCuota);
                    MostrarPanel(confirmaBajaCliente);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar obtener el cliente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                string nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string estadoCuota = dataGridView1.SelectedRows[0].Cells["Estado de cuota"].Value.ToString();

                if (id != null && nombre != null && estadoCuota != null)
                {
                    Detalle_planes ventana_planes = new Detalle_planes(id, nombre, estadoCuota);
                    MostrarPanel(ventana_planes);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al intentar obtener el cliente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
