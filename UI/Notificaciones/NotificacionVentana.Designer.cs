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
            labelTituloAlertBox = new Label();
            subtitleAlert = new Label();
            timerAnimacion = new System.Windows.Forms.Timer(components);
            elipseComponentNotificacion = new View.Components.ElipseComponent();
            linAlertBox = new Panel();
            fotoAlertBox = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)fotoAlertBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTituloAlertBox
            // 
            labelTituloAlertBox.AutoSize = true;
            labelTituloAlertBox.Font = new Font("Quicksand", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloAlertBox.ForeColor = Color.White;
            labelTituloAlertBox.Location = new Point(67, 12);
            labelTituloAlertBox.Name = "labelTituloAlertBox";
            labelTituloAlertBox.Size = new Size(72, 31);
            labelTituloAlertBox.TabIndex = 1;
            labelTituloAlertBox.Text = "label1";
            // 
            // subtitleAlert
            // 
            subtitleAlert.AutoSize = true;
            subtitleAlert.Font = new Font("Quicksand", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subtitleAlert.ForeColor = Color.White;
            subtitleAlert.Location = new Point(67, 40);
            subtitleAlert.Name = "subtitleAlert";
            subtitleAlert.Size = new Size(46, 19);
            subtitleAlert.TabIndex = 2;
            subtitleAlert.Text = "label1";
            subtitleAlert.Click += subtitleAlert_Click;
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
            // linAlertBox
            // 
            linAlertBox.BackColor = Color.Black;
            linAlertBox.Location = new Point(0, 74);
            linAlertBox.Name = "linAlertBox";
            linAlertBox.Size = new Size(5, 6);
            linAlertBox.TabIndex = 3;
            // 
            // fotoAlertBox
            // 
            fotoAlertBox.BackColor = Color.Transparent;
            fotoAlertBox.Image = Properties.Resources.red_Icon_2;
            fotoAlertBox.Location = new Point(29, 27);
            fotoAlertBox.Name = "fotoAlertBox";
            fotoAlertBox.Size = new Size(24, 24);
            fotoAlertBox.TabIndex = 0;
            fotoAlertBox.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.cross;
            pictureBox1.Location = new Point(297, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // NotificacionVentana
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gainsboro;
            BackgroundImage = Properties.Resources.red_Solid_Toast;
            ClientSize = new Size(343, 81);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTituloAlertBox;
        private Label subtitleAlert;
        private System.Windows.Forms.Timer timerAnimacion;
        private View.Components.ElipseComponent elipseComponentNotificacion;
        private Panel linAlertBox;
        private PictureBox fotoAlertBox;
        private PictureBox pictureBox1;
    }
}