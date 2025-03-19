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
    public partial class RegistrarProducto : Form
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
        public RegistrarProducto()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private const int CS_DropShadow = 0x0002000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = new CreateParams();
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }
    }
}
