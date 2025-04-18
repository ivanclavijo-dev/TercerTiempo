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
using UI.Notificaciones;

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

        private string id_cliente;

        public ConfirmaBajaCliente(string id)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            id_cliente = id;    
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
            int resultadoBaja = bajas.eliminarCliente(Convert.ToInt32(id_cliente));

            switch(resultadoBaja)
            {
                case 1:
                    MostrarNotificacion(TipoNotificacion.Exito, "Cliente eliminado", "El registro se eliminó correctamente");
                    this.Close();
                    break;
                case 2:
                    MostrarNotificacion(TipoNotificacion.Error, "Error al eliminar", "No se pudo eliminar el registro");
                    break;
                case -1:
                    MostrarNotificacion(TipoNotificacion.Error, "Error inesperado", "Contacte con soporte");
                    break;
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
