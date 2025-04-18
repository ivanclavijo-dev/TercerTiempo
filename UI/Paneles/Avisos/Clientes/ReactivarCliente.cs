using Logica.BD.LogicaModificaciones;
using System.Runtime.InteropServices;
using UI.Notificaciones;

namespace UI.Paneles.Avisos.Clientes
{
    public partial class ReactivarCliente : Form
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

        private string cedula_cliente;

        public ReactivarCliente(string cedula)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            cedula_cliente = cedula;
        }

        public enum TipoNotificacion
        {
            Exito,
            Alerta,
            Error
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

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Modificaciones modificaciones = new Modificaciones();
            int resultado = modificaciones.reactivarCliente(Convert.ToInt32(cedula_cliente));
            switch (resultado)
            {
                case 1:
                    MostrarNotificacion(TipoNotificacion.Exito, "Cliente reactivado", "El registro se reactivó correctamente");
                    this.Close();
                    break;
                case 2:
                    MostrarNotificacion(TipoNotificacion.Error, "Error al reactivar", "No se pudo reactivar el cliente");
                    break;
                case -1:
                    MostrarNotificacion(TipoNotificacion.Error, "Error inesperado", "Contacte con soporte");
                    break;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
