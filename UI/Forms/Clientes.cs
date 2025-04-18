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
using Entidades;
using Logica;
using Logica.BD;
using Logica.Grids;
using Persistencia.Grids;
using UI.Paneles;
using UI.Paneles.Avisos;
using UI.Paneles.Clientes;
using UI.Properties;

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

        private ClienteSeleccionado ObtenerClienteSeleccionado(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                try
                {
                    string id = dgv.SelectedRows[0].Cells["ID"].Value?.ToString();
                    string nombre = dgv.SelectedRows[0].Cells["Nombre"].Value?.ToString();
                    string estadoCuota = dgv.SelectedRows[0].Cells["Estado de cuota"].Value?.ToString();

                    if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(estadoCuota))
                    {
                        return new ClienteSeleccionado
                        {
                            Id = id,
                            Nombre = nombre,
                            EstadoCuota = estadoCuota
                        };
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ha ocurrido un error \nCodigo: " + e);
                }
            }

            return null;
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var cliente = ObtenerClienteSeleccionado(dataGridView1);

            if (cliente != null)
            {
                ConfirmaBajaCliente ventana = new ConfirmaBajaCliente(cliente.Id);
                MostrarPanel(ventana);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            var cliente = ObtenerClienteSeleccionado(dataGridView1);

            if (cliente != null)
            {
                Detalle_planes ventana = new Detalle_planes(cliente.Id, cliente.Nombre, cliente.EstadoCuota);
                MostrarPanel(ventana);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var cliente = ObtenerClienteSeleccionado(dataGridView1);

            if (cliente != null)
            {
                VentanaInformacionCliente ventana = new VentanaInformacionCliente(cliente.Id, cliente.Nombre);
                MostrarPanel(ventana);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.Redtrash27x27;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.Blacktrash22x22;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.blue_add_square;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.add_square;

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.blue_Edit_Pen_Icon;

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.Edit_Pen_Icon;

        }
    }
}
