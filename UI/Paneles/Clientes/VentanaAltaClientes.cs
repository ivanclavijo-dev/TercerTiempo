using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CustomControls.RJControls;
using Entidades;
using Logica;
using Logica.BD;
using Logica.BD.Altas;
using Logica.BD.LogicaConsultas;
using Logica.BD.LogicaModificaciones;
using Logica.MetodosAdicionales;
using UI.Forms;
using UI.Notificaciones;
using UI.Paneles.Desplegable;
using UI.Properties;
using static Logica.BD.consultasBD;

namespace UI.Paneles
{
    public partial class VentanaAltaClientes : Form
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

        readonly Color ColorSeleccionado = Color.FromArgb(16, 83, 233);
        readonly Color ColorNoSeleccionado = Color.DarkGray;

        public enum TipoNotificacion
        {
            Exito,
            Alerta,
            Error
        }

        public void MostrarNotificacion(TipoNotificacion tipo, string titulo, string mensaje)
        {
            Form formPrincipal = ObtenerFormularioPrincipal();
            NotificacionVentana noti = new NotificacionVentana(formPrincipal);

            switch (tipo)
            {
                case TipoNotificacion.Exito:
                    noti.NotiExito(titulo, mensaje);
                    break;
                case TipoNotificacion.Alerta:
                    noti.NotiAlerta(titulo, mensaje);
                    break;
                case TipoNotificacion.Error:
                    noti.NotiError(titulo, mensaje);
                    break;
            }

            noti.Show();
        }

        private Form ObtenerFormularioPrincipal()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is TercerTiempo)
                {
                    return form;
                }
            }

            return null;
        }

        private void ColorearLabel(Label label, Color color)
        {
            label.ForeColor = color;
        }

        public void RedondearPictureBox(PictureBox pb)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width - 3, pb.Height - 3);
            pb.Region = new Region(gp);
        }

        public VentanaAltaClientes()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void VentanaAltaClientes_Load(object sender, EventArgs e)
        {
            consultasBD consultas = new consultasBD();
            int idNuevo = consultas.ObtenerIdDelClienteNuevo();
            IdTextbox.Texts = idNuevo.ToString();
            IdTextbox.ForeColor = Color.Red;

            cedulaTextbox.MaxLength = 8;
            telefonoTextbox.MaxLength = 9;
            RedondearPictureBox(FotoPerfil);

            sexoTextbox.Items.Add("");
            sexoTextbox.Items.Add("MASCULINO");
            sexoTextbox.Items.Add("FEMENINO");
            sexoTextbox.Items.Add("OTRO");

        }

        private void SetImagenPredeterminada()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "UI.Resources.default_user.png";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    FotoPerfil.Image = Image.FromStream(stream);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        FotoPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        fotoPerfilBytes = ms.ToArray();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el recurso incrustado: " + resourceName, "Error");
                }
            }
        }

        public void limpiar()
        {
            cedulaTextbox.Texts = "";
            nombreTextbox.Texts = "";
            apellidoTextbox.Texts = "";
            telefonoTextbox.Texts = "";
            nacimientoTextbox.Texts = "";
            servicioTextbox.Texts = "";
            observacionTextbox.Texts = "";
            sexoTextbox.SelectedIndex = 0;
            NotificacionesChkbox.Checked = false;
            SetImagenPredeterminada();
        }

        public void limpiarMenosCedula()
        {
            nombreTextbox.Texts = "";
            apellidoTextbox.Texts = "";
            telefonoTextbox.Texts = "";
            nacimientoTextbox.Texts = "";
            servicioTextbox.Texts = "";
            observacionTextbox.Texts = "";
            sexoTextbox.SelectedIndex = 0;
            NotificacionesChkbox.Checked = false;
            SetImagenPredeterminada();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            bool validarFecha = validaciones.formatoFecha(nacimientoTextbox.Texts);

            if (cedulaTextbox.Texts == "" || nombreTextbox.Texts == "" || apellidoTextbox.Texts == "" || telefonoTextbox.Texts == "" ||
                nacimientoTextbox.Texts == "" || servicioTextbox.Texts == "" || sexoTextbox.Texts == "")
            {
                // CAMPOS VACIOS    
                MostrarNotificacion(TipoNotificacion.Alerta, "Aviso", "Debes completar los campos con (*).");
            }
            else if (!validarFecha)
            {
                // FECHA MAL INGRESADA
                MostrarNotificacion(TipoNotificacion.Error, "Error", "El formato de la fecha es incorrecto.");
            }
            else
            {
                if (clienteNuevo)
                {
                    IngresarNuevoClienteYPersona();
                } else if (personaYaRegistrada)
                {
                    IngresarCliente();
                }
            }

        }

        private Altas altas = new Altas();
        private Modificaciones modificaciones = new Modificaciones();
        private ConsultarExistencia ConsultarExistencia = new ConsultarExistencia();

        // Es el ingreso cuando no existe como cliente ni persona
        public void IngresarNuevoClienteYPersona()
        {
            int resultadoIngresarPersona = altas.ingresarPersona(
                Convert.ToInt32(cedulaTextbox.Texts),
                nombreTextbox.Texts,
                apellidoTextbox.Texts,
                telefonoTextbox.Texts,
                servicioTextbox.Texts.ToUpper(),
                nacimientoTextbox.Texts,
                NotificacionesChkbox.Checked,
                sexoTextbox.Texts.ToUpper(),
                fotoPerfilBytes);

            switch (resultadoIngresarPersona) 
            {
                case 1:
                    // Tengo que ingresar a la persona como cliente
                    IngresarCliente();
                    break;
                case 2:
                    // Error al ingresar los datos en Persona
                    MostrarNotificacion(TipoNotificacion.Error, "Error", "No se pudieron registrar los datos personales.");
                    break;
                case 3:

                    break;
                default:
                    MostrarNotificacion(TipoNotificacion.Error, "Error técnico : Persona", "Comuniquese con soporte.");
                    break;
            }
        }

        // Es el ingreso cuando existe como persona 
        public void IngresarCliente()
        {

            int resultadoIngresarCliente = altas.ingresarCliente(
                observacionTextbox.Texts,
                Convert.ToInt32(cedulaTextbox.Texts)
            );

            switch (resultadoIngresarCliente)
            {
                case 1:
                    int resultadoActualizarPersona = modificaciones.modificarPersona(Convert.ToInt32(cedulaTextbox.Texts), NotificacionesChkbox.Checked, fotoPerfilBytes);

                    switch (resultadoActualizarPersona)
                    {
                        case 1:

                            break;
                        case 2:
                            MostrarNotificacion(TipoNotificacion.Error, "Error : Persona", "No se pudieron actualizar los datos personales.");
                            break;
                        case -1:
                            MostrarNotificacion(TipoNotificacion.Error, "Error técnico : Persona", "Comunicarse con soporte.");
                            break;
                        default:
                            break;
                    }

                    MostrarNotificacion(TipoNotificacion.Exito, "Cliente ingresado", "El registro se guardó correctamente.");
                    this.Close();
                    break;

                case 2:
                    MostrarNotificacion(TipoNotificacion.Error, "Error", "La persona no existe. No se puede registrar el cliente.");
                    break;

                case 3:
                    MostrarNotificacion(TipoNotificacion.Alerta, "¡CUIDADO!", "El cliente ya existe en la base de datos.");
                    break;

                case 4:
                    MostrarNotificacion(TipoNotificacion.Error, "Error técnico", "Ocurrió un problema al registrar el cliente.");
                    break;

                default:
                    MostrarNotificacion(TipoNotificacion.Error, "Error técnico : Cliente", "Comuniquese con soporte.");
                    break;
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void MostrarDatosPersonales(int cedula)
        {
            PersonaLogica personaLogica = new PersonaLogica();
            Persona persona = personaLogica.obtenerPersonaPorCedula(cedula);

            if (persona != null)
            {
                nombreTextbox.Texts = persona.Nombre;
                apellidoTextbox.Texts = persona.Apellido;
                telefonoTextbox.Texts = persona.Telefono;
                nacimientoTextbox.Texts = persona.FechaNacimiento.ToString("yyyy-MM-dd");
                servicioTextbox.Texts = persona.ServicioMedico;
                NotificacionesChkbox.Checked = persona.Notificaciones;

                // Asignar sexo según índice del ComboBox
                switch (persona.Sexo.Trim().ToUpper())
                {
                    case "MASCULINO":
                        sexoTextbox.SelectedIndex = 1;
                        break;
                    case "FEMENINO":
                        sexoTextbox.SelectedIndex = 2;
                        break;
                    case "OTRO":
                        sexoTextbox.SelectedIndex = 3;
                        break;
                    default:
                        sexoTextbox.SelectedIndex = 0;
                        break;
                }

                // Cargar imagen si existe
                if (persona.FotoPerfil != null)
                {
                    using (MemoryStream ms = new MemoryStream(persona.FotoPerfil))
                    {
                        FotoPerfil.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        private bool personaYaRegistrada = false;
        private bool clienteNuevo = false;

        private void cedulaTextbox__TextChanged(object sender, EventArgs e)
        {
            cedulalbl.Text = $"Cédula: {cedulaTextbox.Texts}";

            if (cedulaTextbox.Texts.Length == 8)
            {
                int resultado = ConsultarExistencia.VerificarPersonaYCliente(Convert.ToInt32(cedulaTextbox.Texts));

                switch (resultado)
                {
                    case 1:
                        MostrarNotificacion(TipoNotificacion.Alerta, "¡CUIDADO!", "El cliente ya está registrado.");
                        rjButton1.BackColor = Color.Silver;
                        rjButton1.Enabled = false;
                        break;
                    case 2:
                        MostrarDatosPersonales(Convert.ToInt32(cedulaTextbox.Texts));
                        personaYaRegistrada = true;
                        rjButton3.Visible = true;
                        rjButton4.Visible = true;
                        break;
                    case 3:
                        clienteNuevo = true;

                        rjButton3.Visible = true;
                        rjButton4.Visible = true;

                        nombreTextbox.Enabled = true;
                        apellidoTextbox.Enabled = true;
                        telefonoTextbox.Enabled = true;
                        nacimientoTextbox.Enabled = true;
                        servicioTextbox.Enabled = true;
                        sexoTextbox.Enabled = true;
                        break;
                    case -1:
                        MessageBox.Show("");
                        MostrarNotificacion(TipoNotificacion.Error, "Error técnico", "Ocurrió un error al verificar los datos.");
                        break;
                }
            } else
            {
                limpiarMenosCedula();
                rjButton1.BackColor = Color.FromArgb(16, 83, 233);
                rjButton1.Enabled = true;

                rjButton3.Visible = false;
                rjButton4.Visible = false;

                nombreTextbox.Enabled = false;
                apellidoTextbox.Enabled = false;
                telefonoTextbox.Enabled = false;
                nacimientoTextbox.Enabled = false;
                servicioTextbox.Enabled = false;
                sexoTextbox.Enabled = false;
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void nombreTextbox__TextChanged(object sender, EventArgs e)
        {
            CapitalizarControl(sender);
            ActualizarLabelNombreCompleto();
        }
        private void apellidoTextbox__TextChanged(object sender, EventArgs e)
        {
            CapitalizarControl(sender);
            ActualizarLabelNombreCompleto();
        }

        private void ActualizarLabelNombreCompleto()
        {
            string nombre = nombreTextbox.Texts;
            string apellido = apellidoTextbox.Texts;
            string textoCompleto = $"Nombre: {nombre} {apellido}";

            // Limitar a máximo 22 caracteres
            if (textoCompleto.Length > 21)
            {
                textoCompleto = textoCompleto.Substring(0, 18) + "...";
            }

            nombrelbl.Text = textoCompleto;
        }

        private string Capitalizar(string texto)
        {
            var sb = new StringBuilder();
            bool nuevaPalabra = true;

            foreach (char c in texto)
            {
                if (char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                    nuevaPalabra = true;
                }
                else
                {
                    sb.Append(nuevaPalabra ? char.ToUpper(c) : char.ToLower(c));
                    nuevaPalabra = false;
                }
            }

            return sb.ToString();
        }

        public void CapitalizarControl(object sender)
        {
            if (sender is TextBox textBox && !string.IsNullOrWhiteSpace(textBox.Text))
            {
                int selectionStart = textBox.SelectionStart;
                string originalText = textBox.Text;

                string capitalizado = Capitalizar(originalText);

                if (capitalizado != originalText)
                {
                    textBox.Text = capitalizado;
                    textBox.SelectionStart = selectionStart;
                }
            }
        }

        private void telefonoTextbox__TextChanged(object sender, EventArgs e)
        {
            telefonolbl.Text = $"Teléfono: {telefonoTextbox.Texts}";
        }

        private void servicioTextbox__TextChanged(object sender, EventArgs e)
        {
            servicioTextbox.Text.ToUpper();

            serviciolbl.Text = $"Servicio: {servicioTextbox.Texts}";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private Informacion panelInformacion = null;

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            // Si ya existe, lo eliminamos por seguridad
            if (panelInformacion != null && !panelInformacion.IsDisposed)
            {
                panelInformacion.Close();
                panelInformacion = null;
            }

            Point posicionLocal = new Point(740, 290);
            Point posicionPantalla = this.PointToScreen(posicionLocal);

            panelInformacion = new Informacion("Formato de entrada:", "YYYY-MM-DD", posicionPantalla.X, posicionPantalla.Y);
            panelInformacion.Show();
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            panelInformacion.Close();
        }

        private bool bloqueando = false;


        private void nacimientoTextbox__TextChanged(object sender, EventArgs e)
        {
            FormatoDeFecha(sender);
            nacimientolbl.Text = $"Nacimiento: {nacimientoTextbox.Texts}";
        }

        public void FormatoDeFecha(object sender)
        {

            if (bloqueando) return;

            bloqueando = true;

            TextBox txt = sender as TextBox;

            int cursorPos = txt.SelectionStart;

            // Extraer solo los dígitos
            string raw = new string(txt.Text.Where(char.IsDigit).ToArray());

            int oldLength = txt.Text.Length;

            // Insertar guiones donde corresponde
            if (raw.Length > 4)
                raw = raw.Insert(4, "-");
            if (raw.Length > 7)
                raw = raw.Insert(7, "-");

            if (raw.Length > 10)
                raw = raw.Substring(0, 10);

            // Calcular diferencia de largo
            int diff = raw.Length - txt.Text.Length;

            txt.Text = raw;

            // Restaurar posición del cursor inteligentemente
            cursorPos += diff;

            // Limitar dentro del rango del texto
            if (cursorPos < 0) cursorPos = 0;
            if (cursorPos > txt.Text.Length) cursorPos = txt.Text.Length;

            txt.SelectionStart = cursorPos;

            bloqueando = false;
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            BuscarImagen();
        }

        private byte[] fotoPerfilBytes = null;

        public void BuscarImagen()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Imágenes|*.jpg; *.png",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                    Title = "Seleccione una foto de perfil"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FotoPerfil.Image = Image.FromFile(openFileDialog.FileName);

                    // Convertir imagen a byte[]
                    using (MemoryStream ms = new MemoryStream())
                    {
                        FotoPerfil.Image.Save(ms, FotoPerfil.Image.RawFormat);
                        fotoPerfilBytes = ms.ToArray();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error al cargar la imagen: " + error.Message, "Error");
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
        }

        private void cedulaTextbox_Enter(object sender, EventArgs e)
        {
            ColorearLabel(label3, ColorSeleccionado);
        }

        private void cedulaTextbox_Leave(object sender, EventArgs e)
        {
            ColorearLabel(label3, ColorNoSeleccionado);
        }

        private void nombreTextbox_Enter(object sender, EventArgs e)
        {
            ColorearLabel(label4, ColorSeleccionado);
        }

        private void nombreTextbox_Leave(object sender, EventArgs e)
        {
            ColorearLabel(label4, ColorNoSeleccionado);
        }

        private void apellidoTextbox_Enter(object sender, EventArgs e)
        {
            ColorearLabel(label5, ColorSeleccionado);
        }

        private void apellidoTextbox_Leave(object sender, EventArgs e)
        {
            ColorearLabel(label5, ColorNoSeleccionado);

        }

        private void telefonoTextbox_Enter(object sender, EventArgs e)
        {
            ColorearLabel(label6, ColorSeleccionado);
        }

        private void telefonoTextbox_Leave(object sender, EventArgs e)
        {
            ColorearLabel(label6, ColorNoSeleccionado);

        }

        private void nacimientoTextbox_Enter(object sender, EventArgs e)
        {
            ColorearLabel(label9, ColorSeleccionado);

        }

        private void nacimientoTextbox_Leave(object sender, EventArgs e)

        {
            ColorearLabel(label9, ColorNoSeleccionado);

        }

        private void servicioTextbox_Enter(object sender, EventArgs e)
        {
            ColorearLabel(label7, ColorSeleccionado);

        }

        private void servicioTextbox_Leave(object sender, EventArgs e)
        {
            ColorearLabel(label7, ColorNoSeleccionado);

        }

        private void observacionTextbox_Enter(object sender, EventArgs e)
        {
            ColorearLabel(label8, ColorSeleccionado);

        }

        private void observacionTextbox_Leave(object sender, EventArgs e)
        {
            ColorearLabel(label8, ColorNoSeleccionado);

        }

        private void sexoTextbox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string genero = sexoTextbox.SelectedItem.ToString();
            sexolbl.Text = $"Sexo: {genero}";
        }

        private void rjButton2_MouseEnter(object sender, EventArgs e)
        {
            rjButton2.Image = Resources.RedTrash;
        }

        private void rjButton2_MouseLeave(object sender, EventArgs e)
        {
            rjButton2.Image = Resources.BlackTrash;

        }

    }
}
