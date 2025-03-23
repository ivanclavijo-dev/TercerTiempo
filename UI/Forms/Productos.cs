using Entidades;
using Logica.BD;
using Logica.Grids;
using Logica.ObjetosTablas;
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

namespace UI.Forms
{
    public partial class Productos : Form
    {
        int contadorCarrito = 0;
        private consultasBD consultas = new consultasBD();

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
        OB_ProductoGrid objetoP = new OB_ProductoGrid();

        public Productos()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }
        private void MostrarProductos()
        {
            dataGridView1.DataSource = objetoP.MostrarProducto();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            foreach (DataGridViewColumn col in dataGridView2.Columns)
            {
                col.ReadOnly = true;
            }

            // Solo permitir edición en la columna "Cantidad" (índice 0)
            dataGridView2.Columns[0].ReadOnly = false;

        }

        // Llamar esta función cuando cambie el DataGridView


        private void rjButton2_MouseClick(object sender, MouseEventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];

                string nombre = row.Cells[1].Value.ToString();
                int precio = int.Parse(row.Cells[2].Value.ToString());
                int stock = int.Parse(row.Cells[3].Value.ToString());
                string desc = row.Cells[4].Value.ToString();

                if (stock == 0)
                {
                    MessageBox.Show("No hay stock");
                    return;
                }

                // Buscar si el producto ya está en el carrito
                bool existe = false;
                foreach (DataGridViewRow fila in dataGridView2.Rows)
                {
                    if (fila.Cells[1].Value != null && fila.Cells[1].Value.ToString() == nombre)
                    {
                        int cantidadActual = int.Parse(fila.Cells[0].Value.ToString());
                        fila.Cells[0].Value = cantidadActual + 1;
                        existe = true;
                        break;
                    }
                }

                if (!existe)
                {
                    // Agrega el producto con cantidad 1
                    dataGridView2.Rows.Add("1", nombre, precio, desc);
                    contadorCarrito++;

                }

                labelCantCarrito.Text = contadorCarrito.ToString();
            }
        }




        private void btnCarrito_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {

                panel1.Visible = true;

            }
            else if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }

        }



        private void btnCarrito_MouseClick_1(object sender, MouseEventArgs e)
        {


        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
        }

        private void labelCantCarrito_MouseClick(object sender, MouseEventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
        }
        private void CalcularTotal()
        {
            int total = dataGridView2.Rows
    .Cast<DataGridViewRow>()
    .Where(r => !r.IsNewRow)
    .Sum(r =>
    {
        if (int.TryParse(r.Cells[0].Value?.ToString(), out int cantidad) &&
            int.TryParse(r.Cells[2].Value?.ToString(), out int precio))
        {
            return cantidad * precio;
        }
        return 0;
    });

            label3.Text = $"Total a pagar: ${total:N2}";
            Carrito.valorTotal = total;


        }


        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotal();
        }

        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularTotal();

        }

        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcularTotal();

        }

        private void rjButton3_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
                CalcularTotal(); // Actualiza el total después de eliminar
                contadorCarrito--;
                labelCantCarrito.Text = contadorCarrito.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rjButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (contadorCarrito > 0)
            {
                Paneles.SeleccionarClienteProducto seleccionarClienteProducto = new Paneles.SeleccionarClienteProducto();
                seleccionarClienteProducto.Show();
            }

        }
    }
}
