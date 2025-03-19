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
        }

        private void rjButton2_MouseClick(object sender, MouseEventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                int id = int.Parse(row.Cells[0].Value.ToString());
                string nombre = row.Cells[1].Value.ToString();
                int precio = int.Parse(row.Cells[2].Value.ToString());
                int stock = int.Parse(row.Cells[3].Value.ToString());
                string desc = row.Cells[4].Value.ToString();
                if (stock == 0) {
                    MessageBox.Show("No hay stock");
                }else{
                    dataGridView2.Rows.Add("1" , nombre, precio, desc);
                }

                contadorCarrito++;
                labelCantCarrito.Text = Convert.ToString(contadorCarrito);
                MessageBox.Show(id.ToString()+ nombre+ precio.ToString()+ stock.ToString()+ desc);
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
    }
}
