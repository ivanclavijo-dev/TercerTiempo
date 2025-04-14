namespace UI.Paneles
{
    partial class VentanaAltaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAltaClientes));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            IdTextbox = new CustomControls.RJControls.RJTextBox();
            nombreTextbox = new CustomControls.RJControls.RJTextBox();
            apellidoTextbox = new CustomControls.RJControls.RJTextBox();
            telefonoTextbox = new CustomControls.RJControls.RJTextBox();
            nacimientoTextbox = new CustomControls.RJControls.RJTextBox();
            cedulaTextbox = new CustomControls.RJControls.RJTextBox();
            servicioTextbox = new CustomControls.RJControls.RJTextBox();
            observacionTextbox = new CustomControls.RJControls.RJTextBox();
            NotificacionesChkbox = new CheckBox();
            rjButton1 = new CustomControls.RJControls.RJButton();
            rjButton2 = new CustomControls.RJControls.RJButton();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            FotoPerfil = new PictureBox();
            rjButton3 = new CustomControls.RJControls.RJButton();
            rjButton4 = new CustomControls.RJControls.RJButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            sexoTextbox = new CustomControls.RJControls.RJComboBox();
            serviciolbl = new Label();
            sexolbl = new Label();
            telefonolbl = new Label();
            nacimientolbl = new Label();
            edadlbl = new Label();
            nombrelbl = new Label();
            cedulalbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FotoPerfil).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 388);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(16, 83, 233);
            label1.Location = new Point(386, 79);
            label1.Name = "label1";
            label1.Size = new Size(440, 62);
            label1.TabIndex = 1;
            label1.Text = "Registrar un Cliente";
            // 
            // IdTextbox
            // 
            IdTextbox.BackColor = SystemColors.Control;
            IdTextbox.BorderColor = Color.DarkGray;
            IdTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            IdTextbox.BorderRadius = 10;
            IdTextbox.BorderSize = 1;
            IdTextbox.Enabled = false;
            IdTextbox.Font = new Font("Quicksand", 13.75F);
            IdTextbox.ForeColor = Color.FromArgb(130, 130, 130);
            IdTextbox.Location = new Point(386, 145);
            IdTextbox.Margin = new Padding(4);
            IdTextbox.MaxLength = 32767;
            IdTextbox.MinimumSize = new Size(50, 30);
            IdTextbox.Multiline = false;
            IdTextbox.Name = "IdTextbox";
            IdTextbox.Padding = new Padding(20, 7, 10, 7);
            IdTextbox.PasswordChar = false;
            IdTextbox.PlaceholderColor = Color.DarkGray;
            IdTextbox.PlaceholderText = "";
            IdTextbox.Size = new Size(215, 43);
            IdTextbox.TabIndex = 11;
            IdTextbox.Texts = "";
            IdTextbox.UnderlinedStyle = false;
            // 
            // nombreTextbox
            // 
            nombreTextbox.BackColor = SystemColors.Control;
            nombreTextbox.BorderColor = Color.DarkGray;
            nombreTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            nombreTextbox.BorderRadius = 10;
            nombreTextbox.BorderSize = 1;
            nombreTextbox.Enabled = false;
            nombreTextbox.Font = new Font("Quicksand", 13.75F);
            nombreTextbox.ForeColor = Color.FromArgb(130, 130, 130);
            nombreTextbox.Location = new Point(386, 196);
            nombreTextbox.Margin = new Padding(4);
            nombreTextbox.MaxLength = 32767;
            nombreTextbox.MinimumSize = new Size(50, 30);
            nombreTextbox.Multiline = false;
            nombreTextbox.Name = "nombreTextbox";
            nombreTextbox.Padding = new Padding(20, 7, 10, 7);
            nombreTextbox.PasswordChar = false;
            nombreTextbox.PlaceholderColor = Color.DarkGray;
            nombreTextbox.PlaceholderText = "";
            nombreTextbox.Size = new Size(215, 43);
            nombreTextbox.TabIndex = 13;
            nombreTextbox.Texts = "";
            nombreTextbox.UnderlinedStyle = false;
            nombreTextbox._TextChanged += nombreTextbox__TextChanged;
            nombreTextbox.Enter += nombreTextbox_Enter;
            nombreTextbox.Leave += nombreTextbox_Leave;
            // 
            // apellidoTextbox
            // 
            apellidoTextbox.BackColor = SystemColors.Control;
            apellidoTextbox.BorderColor = Color.DarkGray;
            apellidoTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            apellidoTextbox.BorderRadius = 10;
            apellidoTextbox.BorderSize = 1;
            apellidoTextbox.Enabled = false;
            apellidoTextbox.Font = new Font("Quicksand", 13.75F);
            apellidoTextbox.ForeColor = Color.FromArgb(130, 130, 130);
            apellidoTextbox.Location = new Point(609, 197);
            apellidoTextbox.Margin = new Padding(4);
            apellidoTextbox.MaxLength = 32767;
            apellidoTextbox.MinimumSize = new Size(50, 30);
            apellidoTextbox.Multiline = false;
            apellidoTextbox.Name = "apellidoTextbox";
            apellidoTextbox.Padding = new Padding(20, 7, 10, 7);
            apellidoTextbox.PasswordChar = false;
            apellidoTextbox.PlaceholderColor = Color.DarkGray;
            apellidoTextbox.PlaceholderText = "";
            apellidoTextbox.Size = new Size(217, 43);
            apellidoTextbox.TabIndex = 14;
            apellidoTextbox.Texts = "";
            apellidoTextbox.UnderlinedStyle = false;
            apellidoTextbox._TextChanged += apellidoTextbox__TextChanged;
            apellidoTextbox.Enter += apellidoTextbox_Enter;
            apellidoTextbox.Leave += apellidoTextbox_Leave;
            // 
            // telefonoTextbox
            // 
            telefonoTextbox.BackColor = SystemColors.Control;
            telefonoTextbox.BorderColor = Color.DarkGray;
            telefonoTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            telefonoTextbox.BorderRadius = 10;
            telefonoTextbox.BorderSize = 1;
            telefonoTextbox.Enabled = false;
            telefonoTextbox.Font = new Font("Quicksand", 13.75F);
            telefonoTextbox.ForeColor = Color.FromArgb(130, 130, 130);
            telefonoTextbox.Location = new Point(386, 247);
            telefonoTextbox.Margin = new Padding(4);
            telefonoTextbox.MaxLength = 32767;
            telefonoTextbox.MinimumSize = new Size(50, 30);
            telefonoTextbox.Multiline = false;
            telefonoTextbox.Name = "telefonoTextbox";
            telefonoTextbox.Padding = new Padding(20, 7, 10, 7);
            telefonoTextbox.PasswordChar = false;
            telefonoTextbox.PlaceholderColor = Color.DarkGray;
            telefonoTextbox.PlaceholderText = "";
            telefonoTextbox.Size = new Size(215, 43);
            telefonoTextbox.TabIndex = 15;
            telefonoTextbox.Texts = "";
            telefonoTextbox.UnderlinedStyle = false;
            telefonoTextbox._TextChanged += telefonoTextbox__TextChanged;
            telefonoTextbox.Enter += telefonoTextbox_Enter;
            telefonoTextbox.Leave += telefonoTextbox_Leave;
            // 
            // nacimientoTextbox
            // 
            nacimientoTextbox.AccessibleDescription = "";
            nacimientoTextbox.BackColor = SystemColors.Control;
            nacimientoTextbox.BorderColor = Color.DarkGray;
            nacimientoTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            nacimientoTextbox.BorderRadius = 10;
            nacimientoTextbox.BorderSize = 1;
            nacimientoTextbox.Enabled = false;
            nacimientoTextbox.Font = new Font("Quicksand", 13.75F);
            nacimientoTextbox.ForeColor = Color.FromArgb(130, 130, 130);
            nacimientoTextbox.Location = new Point(609, 248);
            nacimientoTextbox.Margin = new Padding(4);
            nacimientoTextbox.MaxLength = 32767;
            nacimientoTextbox.MinimumSize = new Size(50, 30);
            nacimientoTextbox.Multiline = false;
            nacimientoTextbox.Name = "nacimientoTextbox";
            nacimientoTextbox.Padding = new Padding(20, 7, 10, 7);
            nacimientoTextbox.PasswordChar = false;
            nacimientoTextbox.PlaceholderColor = Color.DarkGray;
            nacimientoTextbox.PlaceholderText = "";
            nacimientoTextbox.Size = new Size(217, 43);
            nacimientoTextbox.TabIndex = 16;
            nacimientoTextbox.Texts = "";
            nacimientoTextbox.UnderlinedStyle = false;
            nacimientoTextbox._TextChanged += nacimientoTextbox__TextChanged;
            nacimientoTextbox.Enter += nacimientoTextbox_Enter;
            nacimientoTextbox.Leave += nacimientoTextbox_Leave;
            // 
            // cedulaTextbox
            // 
            cedulaTextbox.BackColor = SystemColors.Control;
            cedulaTextbox.BorderColor = Color.DarkGray;
            cedulaTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            cedulaTextbox.BorderRadius = 10;
            cedulaTextbox.BorderSize = 1;
            cedulaTextbox.Font = new Font("Quicksand", 13.75F);
            cedulaTextbox.ForeColor = Color.FromArgb(130, 130, 130);
            cedulaTextbox.Location = new Point(609, 145);
            cedulaTextbox.Margin = new Padding(4);
            cedulaTextbox.MaxLength = 32767;
            cedulaTextbox.MinimumSize = new Size(50, 30);
            cedulaTextbox.Multiline = false;
            cedulaTextbox.Name = "cedulaTextbox";
            cedulaTextbox.Padding = new Padding(20, 7, 10, 7);
            cedulaTextbox.PasswordChar = false;
            cedulaTextbox.PlaceholderColor = Color.DarkGray;
            cedulaTextbox.PlaceholderText = "";
            cedulaTextbox.Size = new Size(217, 43);
            cedulaTextbox.TabIndex = 12;
            cedulaTextbox.Texts = "";
            cedulaTextbox.UnderlinedStyle = false;
            cedulaTextbox._TextChanged += cedulaTextbox__TextChanged;
            cedulaTextbox.Enter += cedulaTextbox_Enter;
            cedulaTextbox.Leave += cedulaTextbox_Leave;
            // 
            // servicioTextbox
            // 
            servicioTextbox.AccessibleDescription = "servicioTextbox";
            servicioTextbox.BackColor = SystemColors.Control;
            servicioTextbox.BorderColor = Color.DarkGray;
            servicioTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            servicioTextbox.BorderRadius = 10;
            servicioTextbox.BorderSize = 1;
            servicioTextbox.Enabled = false;
            servicioTextbox.Font = new Font("Quicksand", 13.75F);
            servicioTextbox.ForeColor = Color.FromArgb(130, 130, 130);
            servicioTextbox.Location = new Point(387, 295);
            servicioTextbox.Margin = new Padding(4);
            servicioTextbox.MaxLength = 32767;
            servicioTextbox.MinimumSize = new Size(50, 30);
            servicioTextbox.Multiline = false;
            servicioTextbox.Name = "servicioTextbox";
            servicioTextbox.Padding = new Padding(20, 7, 10, 7);
            servicioTextbox.PasswordChar = false;
            servicioTextbox.PlaceholderColor = Color.DarkGray;
            servicioTextbox.PlaceholderText = "";
            servicioTextbox.Size = new Size(215, 43);
            servicioTextbox.TabIndex = 17;
            servicioTextbox.Texts = "";
            servicioTextbox.UnderlinedStyle = false;
            servicioTextbox._TextChanged += servicioTextbox__TextChanged;
            servicioTextbox.Enter += servicioTextbox_Enter;
            servicioTextbox.Leave += servicioTextbox_Leave;
            // 
            // observacionTextbox
            // 
            observacionTextbox.AccessibleDescription = "observacionTextbox";
            observacionTextbox.BackColor = SystemColors.Control;
            observacionTextbox.BorderColor = Color.DarkGray;
            observacionTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            observacionTextbox.BorderRadius = 10;
            observacionTextbox.BorderSize = 1;
            observacionTextbox.Font = new Font("Quicksand", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            observacionTextbox.ForeColor = Color.FromArgb(130, 130, 130);
            observacionTextbox.Location = new Point(386, 349);
            observacionTextbox.Margin = new Padding(4);
            observacionTextbox.MaxLength = 32767;
            observacionTextbox.Multiline = true;
            observacionTextbox.Name = "observacionTextbox";
            observacionTextbox.Padding = new Padding(15, 10, 10, 7);
            observacionTextbox.PasswordChar = false;
            observacionTextbox.PlaceholderColor = Color.DarkGray;
            observacionTextbox.PlaceholderText = "";
            observacionTextbox.Size = new Size(440, 83);
            observacionTextbox.TabIndex = 18;
            observacionTextbox.Texts = "";
            observacionTextbox.UnderlinedStyle = false;
            observacionTextbox.Enter += observacionTextbox_Enter;
            observacionTextbox.Leave += observacionTextbox_Leave;
            // 
            // NotificacionesChkbox
            // 
            NotificacionesChkbox.AutoSize = true;
            NotificacionesChkbox.Cursor = Cursors.Hand;
            NotificacionesChkbox.FlatStyle = FlatStyle.System;
            NotificacionesChkbox.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NotificacionesChkbox.ForeColor = Color.FromArgb(64, 64, 64);
            NotificacionesChkbox.Location = new Point(419, 438);
            NotificacionesChkbox.Name = "NotificacionesChkbox";
            NotificacionesChkbox.Size = new Size(385, 29);
            NotificacionesChkbox.TabIndex = 20;
            NotificacionesChkbox.Text = "El cliente desea recibir mensajes por Whatsapp";
            NotificacionesChkbox.UseVisualStyleBackColor = true;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(16, 83, 233);
            rjButton1.BackgroundColor = Color.FromArgb(16, 83, 233);
            rjButton1.BorderColor = Color.FromArgb(16, 83, 233);
            rjButton1.BorderRadius = 20;
            rjButton1.BorderSize = 0;
            rjButton1.Cursor = Cursors.Hand;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(437, 473);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(260, 44);
            rjButton1.TabIndex = 21;
            rjButton1.Text = "Ingresar Datos";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.Transparent;
            rjButton2.BackgroundColor = Color.Transparent;
            rjButton2.BorderColor = Color.Black;
            rjButton2.BorderRadius = 20;
            rjButton2.BorderSize = 1;
            rjButton2.Cursor = Cursors.Hand;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton2.ForeColor = Color.White;
            rjButton2.Image = Properties.Resources.BlackTrash;
            rjButton2.Location = new Point(703, 473);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(47, 44);
            rjButton2.TabIndex = 22;
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            rjButton2.MouseEnter += rjButton2_MouseEnter;
            rjButton2.MouseLeave += rjButton2_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Carret_Left;
            pictureBox2.Location = new Point(817, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.info_circle;
            pictureBox4.Location = new Point(793, 257);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 36;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            pictureBox4.MouseEnter += pictureBox4_MouseEnter;
            pictureBox4.MouseLeave += pictureBox4_MouseLeave;
            // 
            // FotoPerfil
            // 
            FotoPerfil.Image = (Image)resources.GetObject("FotoPerfil.Image");
            FotoPerfil.Location = new Point(121, 94);
            FotoPerfil.Name = "FotoPerfil";
            FotoPerfil.Size = new Size(128, 128);
            FotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            FotoPerfil.TabIndex = 38;
            FotoPerfil.TabStop = false;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.FromArgb(16, 83, 233);
            rjButton3.BackgroundColor = Color.FromArgb(16, 83, 233);
            rjButton3.BorderColor = Color.FromArgb(16, 83, 233);
            rjButton3.BorderRadius = 20;
            rjButton3.BorderSize = 0;
            rjButton3.Cursor = Cursors.Hand;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Montserrat Medium", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton3.ForeColor = Color.White;
            rjButton3.Image = Properties.Resources.Camira_Icons_UIA;
            rjButton3.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton3.Location = new Point(43, 458);
            rjButton3.Name = "rjButton3";
            rjButton3.Padding = new Padding(10, 0, 0, 0);
            rjButton3.Size = new Size(146, 59);
            rjButton3.TabIndex = 39;
            rjButton3.Text = "Foto nueva";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Visible = false;
            rjButton3.Click += rjButton3_Click;
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.FromArgb(16, 83, 233);
            rjButton4.BackgroundColor = Color.FromArgb(16, 83, 233);
            rjButton4.BorderColor = Color.FromArgb(16, 83, 233);
            rjButton4.BorderRadius = 20;
            rjButton4.BorderSize = 0;
            rjButton4.Cursor = Cursors.Hand;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.Font = new Font("Montserrat Medium", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton4.ForeColor = Color.White;
            rjButton4.Image = Properties.Resources.Search_Icons_UIA;
            rjButton4.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton4.Location = new Point(194, 458);
            rjButton4.Name = "rjButton4";
            rjButton4.Padding = new Padding(10, 0, 0, 0);
            rjButton4.Size = new Size(146, 59);
            rjButton4.TabIndex = 40;
            rjButton4.Text = "Elegir foto";
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            rjButton4.Visible = false;
            rjButton4.Click += rjButton4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(404, 137);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 41;
            label2.Text = "ID del Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(628, 137);
            label3.Name = "label3";
            label3.Size = new Size(66, 18);
            label3.TabIndex = 42;
            label3.Text = "Cedula (*)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(404, 188);
            label4.Name = "label4";
            label4.Size = new Size(75, 18);
            label4.TabIndex = 43;
            label4.Text = "Nombre (*)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(628, 188);
            label5.Name = "label5";
            label5.Size = new Size(73, 18);
            label5.TabIndex = 44;
            label5.Text = "Apellido (*)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(404, 239);
            label6.Name = "label6";
            label6.Size = new Size(75, 18);
            label6.TabIndex = 45;
            label6.Text = "Teléfono (*)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(404, 290);
            label7.Name = "label7";
            label7.Size = new Size(118, 18);
            label7.TabIndex = 46;
            label7.Text = "Servicio Médico (*)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkGray;
            label8.Location = new Point(404, 341);
            label8.Name = "label8";
            label8.Size = new Size(97, 18);
            label8.TabIndex = 47;
            label8.Text = "Observaciones";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkGray;
            label9.Location = new Point(628, 240);
            label9.Name = "label9";
            label9.Size = new Size(153, 18);
            label9.TabIndex = 49;
            label9.Text = "Fecha de Nacimiento (*)";
            // 
            // sexoTextbox
            // 
            sexoTextbox.AutoCompleteMode = AutoCompleteMode.None;
            sexoTextbox.AutoCompleteSource = AutoCompleteSource.None;
            sexoTextbox.BackColor = SystemColors.ControlLight;
            sexoTextbox.BorderColor = Color.Transparent;
            sexoTextbox.BorderRadius = 10;
            sexoTextbox.BorderSize = 0;
            sexoTextbox.DataSource = null;
            sexoTextbox.DisplayMember = "";
            sexoTextbox.DropDownStyle = ComboBoxStyle.DropDown;
            sexoTextbox.Enabled = false;
            sexoTextbox.Font = new Font("Quicksand", 13.75F);
            sexoTextbox.ForeColor = Color.FromArgb(130, 130, 130);
            sexoTextbox.IconColor = Color.FromArgb(130, 130, 130);
            sexoTextbox.ListBackColor = SystemColors.ControlLight;
            sexoTextbox.ListTextColor = Color.Black;
            sexoTextbox.Location = new Point(609, 295);
            sexoTextbox.MinimumSize = new Size(200, 30);
            sexoTextbox.Name = "sexoTextbox";
            sexoTextbox.SelectedIndex = -1;
            sexoTextbox.SelectedItem = null;
            sexoTextbox.Size = new Size(217, 43);
            sexoTextbox.TabIndex = 50;
            sexoTextbox.Texts = "";
            sexoTextbox.ValueMember = "";
            sexoTextbox.OnSelectedIndexChanged += sexoTextbox_OnSelectedIndexChanged;
            // 
            // serviciolbl
            // 
            serviciolbl.AutoSize = true;
            serviciolbl.BackColor = Color.FromArgb(16, 83, 233);
            serviciolbl.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            serviciolbl.ForeColor = Color.White;
            serviciolbl.Location = new Point(70, 407);
            serviciolbl.Name = "serviciolbl";
            serviciolbl.Size = new Size(152, 25);
            serviciolbl.TabIndex = 58;
            serviciolbl.Text = "Servicio Médico: ";
            // 
            // sexolbl
            // 
            sexolbl.AutoSize = true;
            sexolbl.BackColor = Color.FromArgb(16, 83, 233);
            sexolbl.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            sexolbl.ForeColor = Color.White;
            sexolbl.Location = new Point(70, 287);
            sexolbl.Name = "sexolbl";
            sexolbl.Size = new Size(76, 25);
            sexolbl.TabIndex = 57;
            sexolbl.Text = "Genero:";
            // 
            // telefonolbl
            // 
            telefonolbl.AutoSize = true;
            telefonolbl.BackColor = Color.FromArgb(16, 83, 233);
            telefonolbl.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            telefonolbl.ForeColor = Color.White;
            telefonolbl.Location = new Point(70, 377);
            telefonolbl.Name = "telefonolbl";
            telefonolbl.Size = new Size(87, 25);
            telefonolbl.TabIndex = 56;
            telefonolbl.Text = "Teléfono:";
            // 
            // nacimientolbl
            // 
            nacimientolbl.AutoSize = true;
            nacimientolbl.BackColor = Color.FromArgb(16, 83, 233);
            nacimientolbl.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            nacimientolbl.ForeColor = Color.White;
            nacimientolbl.Location = new Point(70, 347);
            nacimientolbl.Name = "nacimientolbl";
            nacimientolbl.Size = new Size(113, 25);
            nacimientolbl.TabIndex = 55;
            nacimientolbl.Text = "Nacimiento:";
            // 
            // edadlbl
            // 
            edadlbl.AutoSize = true;
            edadlbl.BackColor = Color.FromArgb(16, 83, 233);
            edadlbl.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            edadlbl.ForeColor = Color.White;
            edadlbl.Location = new Point(70, 317);
            edadlbl.Name = "edadlbl";
            edadlbl.Size = new Size(59, 25);
            edadlbl.TabIndex = 54;
            edadlbl.Text = "Edad:";
            // 
            // nombrelbl
            // 
            nombrelbl.AutoSize = true;
            nombrelbl.BackColor = Color.FromArgb(16, 83, 233);
            nombrelbl.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            nombrelbl.ForeColor = Color.White;
            nombrelbl.Location = new Point(70, 257);
            nombrelbl.Name = "nombrelbl";
            nombrelbl.Size = new Size(84, 25);
            nombrelbl.TabIndex = 53;
            nombrelbl.Text = "Nombre:";
            // 
            // cedulalbl
            // 
            cedulalbl.AutoSize = true;
            cedulalbl.BackColor = Color.FromArgb(16, 83, 233);
            cedulalbl.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cedulalbl.ForeColor = Color.White;
            cedulalbl.Location = new Point(70, 227);
            cedulalbl.Name = "cedulalbl";
            cedulalbl.Size = new Size(75, 25);
            cedulalbl.TabIndex = 52;
            cedulalbl.Text = "Cédula:";
            // 
            // VentanaAltaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(899, 546);
            Controls.Add(serviciolbl);
            Controls.Add(sexolbl);
            Controls.Add(telefonolbl);
            Controls.Add(nacimientolbl);
            Controls.Add(edadlbl);
            Controls.Add(nombrelbl);
            Controls.Add(cedulalbl);
            Controls.Add(sexoTextbox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rjButton4);
            Controls.Add(rjButton3);
            Controls.Add(FotoPerfil);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(NotificacionesChkbox);
            Controls.Add(observacionTextbox);
            Controls.Add(servicioTextbox);
            Controls.Add(nacimientoTextbox);
            Controls.Add(cedulaTextbox);
            Controls.Add(apellidoTextbox);
            Controls.Add(telefonoTextbox);
            Controls.Add(nombreTextbox);
            Controls.Add(IdTextbox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentanaAltaClientes";
            Text = "VentanaAltaClientes";
            Load += VentanaAltaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)FotoPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private CustomControls.RJControls.RJTextBox IdTextbox;
        private CustomControls.RJControls.RJTextBox nombreTextbox;
        private CustomControls.RJControls.RJTextBox apellidoTextbox;
        private CustomControls.RJControls.RJTextBox telefonoTextbox;
        private CustomControls.RJControls.RJTextBox nacimientoTextbox;
        private CustomControls.RJControls.RJTextBox cedulaTextbox;
        private CustomControls.RJControls.RJTextBox servicioTextbox;
        private CustomControls.RJControls.RJTextBox observacionTextbox;
        private CheckBox NotificacionesChkbox;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox FotoPerfil;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private CustomControls.RJControls.RJComboBox sexoTextbox;
        private Label serviciolbl;
        private Label sexolbl;
        private Label telefonolbl;
        private Label nacimientolbl;
        private Label edadlbl;
        private Label nombrelbl;
        private Label cedulalbl;
    }
}