namespace UI.Notificaciones
{
    partial class NotificacionVentana
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            fotoAlertBox = new PictureBox();
            labelTituloAlertBox = new Label();
            subtitleAlert = new Label();
            linAlertBox = new Panel();
            timerAnimacion = new System.Windows.Forms.Timer(components);
            elipseComponentNotificacion = new View.Components.ElipseComponent();
            ((System.ComponentModel.ISupportInitialize)fotoAlertBox).BeginInit();
            SuspendLayout();
            // 
            // fotoAlertBox
            // 
            fotoAlertBox.Image = Properties.Resources.marca_de_verificacion;
            fotoAlertBox.Location = new Point(27, 18);
            fotoAlertBox.Name = "fotoAlertBox";
            fotoAlertBox.Size = new Size(50, 50);
            fotoAlertBox.SizeMode = PictureBoxSizeMode.Zoom;
            fotoAlertBox.TabIndex = 0;
            fotoAlertBox.TabStop = false;
            // 
            // labelTituloAlertBox
            // 
            labelTituloAlertBox.AutoSize = true;
            labelTituloAlertBox.Font = new Font("Quicksand SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloAlertBox.Location = new Point(83, 25);
            labelTituloAlertBox.Name = "labelTituloAlertBox";
            labelTituloAlertBox.Size = new Size(64, 28);
            labelTituloAlertBox.TabIndex = 1;
            labelTituloAlertBox.Text = "label1";
            // 
            // subtitleAlert
            // 
            subtitleAlert.AutoSize = true;
            subtitleAlert.Font = new Font("Quicksand", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subtitleAlert.Location = new Point(83, 53);
            subtitleAlert.Name = "subtitleAlert";
            subtitleAlert.Size = new Size(43, 19);
            subtitleAlert.TabIndex = 2;
            subtitleAlert.Text = "label1";
            subtitleAlert.Click += subtitleAlert_Click;
            // 
            // linAlertBox
            // 
            linAlertBox.BackColor = Color.Black;
            linAlertBox.Location = new Point(0, 74);
            linAlertBox.Name = "linAlertBox";
            linAlertBox.Size = new Size(5, 6);
            linAlertBox.TabIndex = 3;
            // 
            // timerAnimacion
            // 
            timerAnimacion.Interval = 10;
            timerAnimacion.Tick += timerAnimacion_Tick;
            // 
            // elipseComponentNotificacion
            // 
            elipseComponentNotificacion.CornerRadius = 25;
            elipseComponentNotificacion.TargetControl = this;
            // 
            // NotificacionVentana
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(300, 80);
            Controls.Add(linAlertBox);
            Controls.Add(subtitleAlert);
            Controls.Add(labelTituloAlertBox);
            Controls.Add(fotoAlertBox);
            Font = new Font("Quicksand", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotificacionVentana";
            Text = "NotificacionVentana";
            TopMost = true;
            Load += NotificacionVentana_Load;
            ((System.ComponentModel.ISupportInitialize)fotoAlertBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox fotoAlertBox;
        private Label labelTituloAlertBox;
        private Label subtitleAlert;
        private Panel linAlertBox;
        private System.Windows.Forms.Timer timerAnimacion;
        private View.Components.ElipseComponent elipseComponentNotificacion;
    }
}