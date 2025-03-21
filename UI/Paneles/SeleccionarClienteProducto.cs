using CustomControls.RJControls;
using Logica.BD;
using Logica;
using Logica.Grids;
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

namespace UI.Paneles
{
    public partial class SeleccionarClienteProducto : Form
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
        public SeleccionarClienteProducto()
        {
            InitializeComponent();
            MostrarClientes();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        private OB_ClienteGrid clientOb = new OB_ClienteGrid();

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            string texto = rjTextBox1.Texts.Trim();
            dataGridView1.DataSource = clientOb.ObtenerClientes(texto);
        }
        OB_ClienteGrid objetoC = new OB_ClienteGrid();
        private void MostrarClientes()
        {
            dataGridView1.DataSource = null; // Por las dudas, limpiamos antes de volver a cargar
            dataGridView1.DataSource = objetoC.MostrarClient();
        }
        int id = 0;
        string nombre = "";
        consultasBD consultas_BD = new consultasBD();
        private void rjButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];

                id = int.Parse(row.Cells[0].Value.ToString());
                nombre = row.Cells[1].Value.ToString();
                SesionCliente.clienteActual = consultas_BD.ObtenerClienteVenta(id);


                Paneles.Avisos.ConfirmarVentaProducto confirmarVentaProducto = new Avisos.ConfirmarVentaProducto();
                confirmarVentaProducto.Show();
                this.Dispose();
            }
        }

        private void ad(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
