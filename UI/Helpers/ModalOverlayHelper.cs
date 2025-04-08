using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UI.Helpers
{
    public static class ModalOverlayHelper
    {

        public static void MostrarConOverlay(Form modalForm, Action onClose = null)
        {
            Form principal = Application.OpenForms["TercerTiempo"];

            if (principal == null)
            {
                MessageBox.Show("No se pudo encontrar la ventana principal.");
                return;
            }

            // Crear el overlay semitransparente
            Form overlay = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.Manual,
                Location = principal.Location,
                Size = principal.Size,
                ShowInTaskbar = false,
                BackColor = Color.Black,
                Opacity = 0.5,
                TopMost = false,
                Owner = principal
            };

            bool overlayCerrado = false;

            modalForm.StartPosition = FormStartPosition.CenterScreen;
            modalForm.Owner = overlay;

            modalForm.FormClosed += (s, args) =>
            {
                if (!overlayCerrado && overlay != null && overlay.IsHandleCreated && !overlay.IsDisposed)
                {
                    overlayCerrado = true;
                    overlay.Close();
                }

                principal?.Activate();

                onClose?.Invoke();
            };

            overlay.Show();
            modalForm.ShowDialog();
        }
    }
}