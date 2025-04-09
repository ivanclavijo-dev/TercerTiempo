using Entidades;
using Logica.BD;
using Persistencia.ClientesConsultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Logica.BD.consultasBD;

namespace UI.Paneles.Clientes
{
    public partial class VentanaInformacionCliente : Form
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

        public VentanaInformacionCliente(string id, string nombre)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            CargarDatosCliente(Convert.ToInt32(id), nombre);
        }

        public void RedondearPictureBox(PictureBox pb)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width - 3, pb.Height - 3);
            pb.Region = new Region(gp);
        }
        private void VentanaInformacionCliente_Load(object sender, EventArgs e)
        {
            RedondearPictureBox(FotoPerfil);
        }

        private ClienteLogica clienteLogica = new ClienteLogica();
        private ObtenerFotoPerfil obtenerFotoPerfil = new ObtenerFotoPerfil();

        public byte[] ObtenerFotoDePerfil(int cedula)
        {
            return obtenerFotoPerfil.ObtenerFoto(cedula);
        }

        private void CargarDatosCliente(int id, string nombre)
        {
            Cliente cliente = clienteLogica.ObtenerClientePorId(id);

            if (cliente != null)
            {
                cedulalbl.Text = $"Cédula: {cliente.DatosPersonales.Cedula.ToString()}";
                nombrelbl.Text = $"Nombre: {nombre}";
                sexolbl.Text = $"Genero: {cliente.DatosPersonales.Sexo}";

                int edad = CalcularEdad(cliente.DatosPersonales.FechaNacimiento);
                edadlbl.Text = $"Edad: {edad} años";

                nacimientolbl.Text = $"Nacimiento: {cliente.DatosPersonales.FechaNacimiento.ToShortDateString()} ";
                telefonolbl.Text = $"Teléfono: {cliente.DatosPersonales.Telefono}";
                serviciolbl.Text = $"Servicio Médico: {cliente.DatosPersonales.ServicioMedico}";

                observacioneslbl.Text = cliente.Observacion;

                consultasBD consultas = new consultasBD();
                byte[] imagen = consultas.ObtenerFotoDePerfil(cliente.DatosPersonales.Cedula);

                if (imagen != null)
                {
                    using (MemoryStream ms = new MemoryStream(imagen))
                    {
                        FotoPerfil.Image = Image.FromStream(ms);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontró el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > hoy.AddYears(-edad)) edad--;

            return edad;
        }

        private void serviciolbl_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void observacioneslbl_TextChanged(object sender, EventArgs e)
        {
            btnGuardarCambios.Visible = true;
        }

        private void bntExpandir_Click(object sender, EventArgs e)
        {
            //cambiar tamaño al textbox
            observacioneslbl.Size = new Size(633, 271);
            //cambiar locacion al textbox
            observacioneslbl.Location = new Point(397, 195);
            //escondo el label de "Actividades que realiza"
            actividadtxt.Visible = false;
            //cambio la locacion del label "Observaciones"
            observacionestxt.Location = actividadtxt.Location;
            //escondo los botones
            btnVerAsistencias.Visible = false;
            btnVerCompras.Visible = false;
            btnVerPagos.Visible = false;
            btnVerRutinas.Visible = false;
            //posiciono el nuevo boton de minimizar
            btnMinimizar.Location = new Point(993, 202);
            btnMinimizar.Visible = true;
            //oculto el boton de expandir
            bntExpandir.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //cambiar tamaño al textbox
            observacioneslbl.Size = new Size(276, 139);
            //cambiar locacion al textbox
            observacioneslbl.Location = new Point(397, 327);
            //escondo el label de "Actividades que realiza"
            actividadtxt.Visible = true;
            //cambio la locacion del label "Observaciones"
            observacionestxt.Location = new Point(397, 299);
            //escondo los botones
            btnVerAsistencias.Visible = true;
            btnVerCompras.Visible = true;
            btnVerPagos.Visible = true;
            btnVerRutinas.Visible = true;
            //posiciono el nuevo boton de minimizar
            btnMinimizar.Location = new Point(609, 472);
            btnMinimizar.Visible = false;
            //oculto el boton de expandir
            bntExpandir.Visible = true;
        }
    }
}
