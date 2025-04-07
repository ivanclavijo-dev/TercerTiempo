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

namespace UI.Paneles.Desplegable
{
    public partial class Informacion : Form
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

        public Informacion(string titulo, string contenido, int x, int y)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual; // MUY importante
            this.Location = new Point(x, y);               // Aquí usas los valores pasados

            this.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            Titulo.Text = titulo;
            Contenido.Text = contenido;
        }
    }
}
