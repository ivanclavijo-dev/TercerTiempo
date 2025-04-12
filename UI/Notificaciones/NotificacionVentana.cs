using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using UI.Properties;

namespace UI.Notificaciones
{
    public partial class NotificacionVentana : Form
    {
        private Form _formPadre;

        public NotificacionVentana(Form formPadre)
        {
            InitializeComponent();
            _formPadre = formPadre;
            timerAnimacion.Interval = 8; // velocidad de la animación en milisegundos
            labelTituloAlertBox.BackColor = Color.Transparent;
            subtitleAlert.BackColor = Color.Transparent;
        }

        public void NotiAlerta(string Titulo, string Cuerpo)
        {
            TitleAlertBox = Titulo;
            SubituloAlertBox = Cuerpo;
            this.BackgroundImage = Resources.orange_Solid_Toast;
            fotoAlertBox.Image = Resources.orange_Icon_2;
            linAlertBox.BackColor = Color.White;
        }
        public void NotiError(string Titulo, string Cuerpo)
        {
            TitleAlertBox = Titulo;
            SubituloAlertBox = Cuerpo;
            this.BackgroundImage = Resources.red_Solid_Toast;
            fotoAlertBox.Image = Resources.red_Icon_2;
            linAlertBox.BackColor = Color.White;
        }
        public void NotiExito(string Titulo, string Cuerpo)
        {
            TitleAlertBox = Titulo;
            SubituloAlertBox = Cuerpo;
            this.BackgroundImage = Resources.green_Solid_Toast;
            fotoAlertBox.Image = Resources.green_Icon_2;
            linAlertBox.BackColor = Color.White;
        }

        public Color BackColorAlertBox
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public Color ColorAlertBox
        {
            get { return linAlertBox.BackColor; }
            set { linAlertBox.BackColor = labelTituloAlertBox.ForeColor = subtitleAlert.ForeColor = value; }
        }

        public Image IconeAlertBox
        {
            get { return fotoAlertBox.Image; }
            set { fotoAlertBox.Image = value; }
        }

        public string TitleAlertBox
        {
            get { return labelTituloAlertBox.Text; }
            set { labelTituloAlertBox.Text = value; }
        }

        public string SubituloAlertBox
        {
            get { return subtitleAlert.Text; }
            set { subtitleAlert.Text = value; }
        }

        private void PositionAlertBox()
        {


            if (_formPadre != null)
            {
                int x = _formPadre.Bounds.Right - this.Width - 20;
                int y = _formPadre.Bounds.Bottom - this.Height - 40;
                this.Location = new Point(x, y);
            }
            else
            {
                int x = Screen.GetWorkingArea(this).Width - this.Width;
                int y = Screen.GetWorkingArea(this).Height - this.Height;
                this.Location = new Point(x, y);
            }


        }

        private void subtitleAlert_Click(object sender, EventArgs e)
        {
            // Dejar vacío si no se usa
        }

        private void NotificacionVentana_Load(object sender, EventArgs e)
        {
            PositionAlertBox();
            linAlertBox.Width = 0;
            timerAnimacion.Start();
        }

        private void timerAnimacion_Tick(object sender, EventArgs e)
        {
            linAlertBox.Width += 2;

            if (linAlertBox.Width >= 344)
            {
                timerAnimacion.Stop();

                // Cerrar formulario llamador si está disponible
                if (_formPadre != null && !_formPadre.IsDisposed)
                {
                    this.Close();
                }

                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timerAnimacion.Stop();
            this.Close();
        }
    }
}
