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
using Logica.BD.LogicaBajas;
using UI.Forms;

namespace UI.Paneles.Avisos
{
    public partial class ConfirmaBajaCliente : Form
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

        public ConfirmaBajaCliente(string id, string nombre, string estadoCuota)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            idCliente.Text = id;
            nombreCliente.Text = nombre;
            estadoCuotaCliente.Text = estadoCuota;

            if (estadoCuota == "Vigente")
            {
                estadoCuotaCliente.ForeColor = Color.FromArgb(56, 224, 56);
            }
            else if (estadoCuota == "Por vencer")
            {
                estadoCuotaCliente.ForeColor = Color.FromArgb(240, 165, 45);
            }
            else if (estadoCuota == "Vencido")
            {
                estadoCuotaCliente.ForeColor = Color.FromArgb(244, 54, 20);
            }
            else if (estadoCuota == "Pendiente")
            {
                estadoCuotaCliente.ForeColor = Color.Silver;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Bajas bajas = new Bajas();
            bool resultadoBaja = bajas.eliminarCliente(Convert.ToInt32(idCliente.Text));

            if (resultadoBaja)
            {
                MessageBox.Show("Se elimino el cliente correctamente");
                this.Close();

            }
            else
            {
                MessageBox.Show("Error al eliminar el cliente.");
            }
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl != null)
            {
                lbl.Font = new Font(lbl.Font, FontStyle.Underline);
            }
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl != null)
            {
                lbl.Font = new Font(lbl.Font, FontStyle.Regular);
            }
        }
    }
}
