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
            cedulalbl = new Label();
            nombrelbl = new Label();
            telefonolbl = new Label();
            nacimientolbl = new Label();
            serviciolbl = new Label();
            pictureBox4 = new PictureBox();
            sexoTextbox = new CustomControls.RJControls.RJTextBox();
            FotoPerfil = new PictureBox();
            rjButton3 = new CustomControls.RJControls.RJButton();
            rjButton4 = new CustomControls.RJControls.RJButton();
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
            IdTextbox.BackColor = Color.FromArgb(232, 232, 232);
            IdTextbox.BorderColor = Color.Transparent;
            IdTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            IdTextbox.BorderRadius = 20;
            IdTextbox.BorderSize = 2;
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
            IdTextbox.PlaceholderText = "ID del Cliente: 123";
            IdTextbox.Size = new Size(215, 43);
            IdTextbox.TabIndex = 11;
            IdTextbox.Texts = "";
            IdTextbox.UnderlinedStyle = false;
            // 
            // nombreTextbox
            // 
            nombreTextbox.BackColor = Color.FromArgb(232, 232, 232);
            nombreTextbox.BorderColor = Color.Transparent;
            nombreTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            nombreTextbox.BorderRadius = 20;
            nombreTextbox.BorderSize = 2;
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
            nombreTextbox.PlaceholderText = "Nombre";
            nombreTextbox.Size = new Size(215, 43);
            nombreTextbox.TabIndex = 12;
            nombreTextbox.Texts = "";
            nombreTextbox.UnderlinedStyle = false;
            nombreTextbox._TextChanged += nombreTextbox__TextChanged;
            // 
            // apellidoTextbox
            // 
            apellidoTextbox.BackColor = Color.FromArgb(232, 232, 232);
            apellidoTextbox.BorderColor = Color.Transparent;
            apellidoTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            apellidoTextbox.BorderRadius = 20;
            apellidoTextbox.BorderSize = 2;
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
            apellidoTextbox.PlaceholderText = "Apellido";
            apellidoTextbox.Size = new Size(217, 43);
            apellidoTextbox.TabIndex = 14;
            apellidoTextbox.Texts = "";
            apellidoTextbox.UnderlinedStyle = false;
            apellidoTextbox._TextChanged += apellidoTextbox__TextChanged;
            // 
            // telefonoTextbox
            // 
            telefonoTextbox.BackColor = Color.FromArgb(232, 232, 232);
            telefonoTextbox.BorderColor = Color.Transparent;
            telefonoTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            telefonoTextbox.BorderRadius = 20;
            telefonoTextbox.BorderSize = 2;
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
            telefonoTextbox.PlaceholderText = "Telefono";
            telefonoTextbox.Size = new Size(215, 43);
            telefonoTextbox.TabIndex = 13;
            telefonoTextbox.Texts = "";
            telefonoTextbox.UnderlinedStyle = false;
            telefonoTextbox._TextChanged += telefonoTextbox__TextChanged;
            // 
            // nacimientoTextbox
            // 
            nacimientoTextbox.AccessibleDescription = "";
            nacimientoTextbox.BackColor = Color.FromArgb(232, 232, 232);
            nacimientoTextbox.BorderColor = Color.Transparent;
            nacimientoTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            nacimientoTextbox.BorderRadius = 20;
            nacimientoTextbox.BorderSize = 2;
            nacimientoTextbox.Font = new Font("Quicksand", 13.75F);
            nacimientoTextbox.ForeColor = Color.FromArgb(130, 130, 130);
            nacimientoTextbox.Location = new Point(609, 249);
            nacimientoTextbox.Margin = new Padding(4);
            nacimientoTextbox.MaxLength = 32767;
            nacimientoTextbox.MinimumSize = new Size(50, 30);
            nacimientoTextbox.Multiline = false;
            nacimientoTextbox.Name = "nacimientoTextbox";
            nacimientoTextbox.Padding = new Padding(20, 7, 10, 7);
            nacimientoTextbox.PasswordChar = false;
            nacimientoTextbox.PlaceholderColor = Color.DarkGray;
            nacimientoTextbox.PlaceholderText = "Fecha de Nacimiento";
            nacimientoTextbox.Size = new Size(217, 43);
            nacimientoTextbox.TabIndex = 16;
            nacimientoTextbox.Texts = "";
            nacimientoTextbox.UnderlinedStyle = false;
            nacimientoTextbox._TextChanged += nacimientoTextbox__TextChanged;
            // 
            // cedulaTextbox
            // 
            cedulaTextbox.BackColor = Color.FromArgb(232, 232, 232);
            cedulaTextbox.BorderColor = Color.Transparent;
            cedulaTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            cedulaTextbox.BorderRadius = 20;
            cedulaTextbox.BorderSize = 2;
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
            cedulaTextbox.PlaceholderText = "Cedula";
            cedulaTextbox.Size = new Size(217, 43);
            cedulaTextbox.TabIndex = 15;
            cedulaTextbox.Texts = "";
            cedulaTextbox.UnderlinedStyle = false;
            cedulaTextbox._TextChanged += cedulaTextbox__TextChanged;
            // 
            // servicioTextbox
            // 
            servicioTextbox.AccessibleDescription = "servicioTextbox";
            servicioTextbox.BackColor = Color.FromArgb(232, 232, 232);
            servicioTextbox.BorderColor = Color.Transparent;
            servicioTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            servicioTextbox.BorderRadius = 20;
            servicioTextbox.BorderSize = 2;
            servicioTextbox.Font = new Font("Quicksand", 13.75F);
            servicioTextbox.ForeColor = Color.FromArgb(130, 130, 130);
            servicioTextbox.Location = new Point(386, 301);
            servicioTextbox.Margin = new Padding(4);
            servicioTextbox.MaxLength = 32767;
            servicioTextbox.MinimumSize = new Size(50, 30);
            servicioTextbox.Multiline = false;
            servicioTextbox.Name = "servicioTextbox";
            servicioTextbox.Padding = new Padding(20, 7, 10, 7);
            servicioTextbox.PasswordChar = false;
            servicioTextbox.PlaceholderColor = Color.DarkGray;
            servicioTextbox.PlaceholderText = "Servicio Medico";
            servicioTextbox.Size = new Size(215, 43);
            servicioTextbox.TabIndex = 17;
            servicioTextbox.Texts = "";
            servicioTextbox.UnderlinedStyle = false;
            servicioTextbox._TextChanged += servicioTextbox__TextChanged;
            // 
            // observacionTextbox
            // 
            observacionTextbox.AccessibleDescription = "observacionTextbox";
            observacionTextbox.BackColor = Color.FromArgb(232, 232, 232);
            observacionTextbox.BorderColor = Color.Transparent;
            observacionTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            observacionTextbox.BorderRadius = 20;
            observacionTextbox.BorderSize = 2;
            observacionTextbox.Font = new Font("Quicksand", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            observacionTextbox.ForeColor = Color.FromArgb(64, 64, 64);
            observacionTextbox.Location = new Point(386, 352);
            observacionTextbox.Margin = new Padding(4);
            observacionTextbox.MaxLength = 32767;
            observacionTextbox.Multiline = true;
            observacionTextbox.Name = "observacionTextbox";
            observacionTextbox.Padding = new Padding(15, 10, 10, 7);
            observacionTextbox.PasswordChar = false;
            observacionTextbox.PlaceholderColor = Color.DarkGray;
            observacionTextbox.PlaceholderText = "Observaciones";
            observacionTextbox.Size = new Size(440, 83);
            observacionTextbox.TabIndex = 19;
            observacionTextbox.Texts = "";
            observacionTextbox.UnderlinedStyle = false;
            // 
            // NotificacionesChkbox
            // 
            NotificacionesChkbox.AutoSize = true;
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
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(419, 473);
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
            rjButton2.BackColor = Color.FromArgb(244, 54, 20);
            rjButton2.BackgroundColor = Color.FromArgb(244, 54, 20);
            rjButton2.BorderColor = Color.FromArgb(244, 54, 20);
            rjButton2.BorderRadius = 20;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton2.ForeColor = Color.White;
            rjButton2.Image = (Image)resources.GetObject("rjButton2.Image");
            rjButton2.Location = new Point(697, 473);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(44, 44);
            rjButton2.TabIndex = 22;
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
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
            // cedulalbl
            // 
            cedulalbl.AutoSize = true;
            cedulalbl.BackColor = Color.FromArgb(16, 83, 233);
            cedulalbl.Font = new Font("Montserrat Medium", 14.25F, FontStyle.Bold);
            cedulalbl.ForeColor = Color.White;
            cedulalbl.Location = new Point(61, 232);
            cedulalbl.Name = "cedulalbl";
            cedulalbl.Size = new Size(92, 30);
            cedulalbl.TabIndex = 24;
            cedulalbl.Text = "Cedula:";
            // 
            // nombrelbl
            // 
            nombrelbl.AutoSize = true;
            nombrelbl.BackColor = Color.FromArgb(16, 83, 233);
            nombrelbl.Font = new Font("Montserrat Medium", 14.25F, FontStyle.Bold);
            nombrelbl.ForeColor = Color.White;
            nombrelbl.Location = new Point(61, 270);
            nombrelbl.Name = "nombrelbl";
            nombrelbl.Size = new Size(104, 30);
            nombrelbl.TabIndex = 25;
            nombrelbl.Text = "Nombre:";
            // 
            // telefonolbl
            // 
            telefonolbl.AutoSize = true;
            telefonolbl.BackColor = Color.FromArgb(16, 83, 233);
            telefonolbl.Font = new Font("Montserrat Medium", 14.25F, FontStyle.Bold);
            telefonolbl.ForeColor = Color.White;
            telefonolbl.Location = new Point(61, 308);
            telefonolbl.Name = "telefonolbl";
            telefonolbl.Size = new Size(109, 30);
            telefonolbl.TabIndex = 26;
            telefonolbl.Text = "Teléfono:";
            // 
            // nacimientolbl
            // 
            nacimientolbl.AutoSize = true;
            nacimientolbl.BackColor = Color.FromArgb(16, 83, 233);
            nacimientolbl.Font = new Font("Montserrat Medium", 14.25F, FontStyle.Bold);
            nacimientolbl.ForeColor = Color.White;
            nacimientolbl.Location = new Point(61, 346);
            nacimientolbl.Name = "nacimientolbl";
            nacimientolbl.Size = new Size(140, 30);
            nacimientolbl.TabIndex = 27;
            nacimientolbl.Text = "Nacimiento:";
            // 
            // serviciolbl
            // 
            serviciolbl.AutoSize = true;
            serviciolbl.BackColor = Color.FromArgb(16, 83, 233);
            serviciolbl.Font = new Font("Montserrat Medium", 14.25F, FontStyle.Bold);
            serviciolbl.ForeColor = Color.White;
            serviciolbl.Location = new Point(61, 384);
            serviciolbl.Name = "serviciolbl";
            serviciolbl.Size = new Size(102, 30);
            serviciolbl.TabIndex = 28;
            serviciolbl.Text = "Servicio:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.info_circle;
            pictureBox4.Location = new Point(829, 257);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 36;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            pictureBox4.MouseEnter += pictureBox4_MouseEnter;
            pictureBox4.MouseLeave += pictureBox4_MouseLeave;
            // 
            // sexoTextbox
            // 
            sexoTextbox.AccessibleDescription = "servicioTextbox";
            sexoTextbox.BackColor = Color.FromArgb(232, 232, 232);
            sexoTextbox.BorderColor = Color.Transparent;
            sexoTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            sexoTextbox.BorderRadius = 20;
            sexoTextbox.BorderSize = 2;
            sexoTextbox.Font = new Font("Quicksand", 13.75F);
            sexoTextbox.ForeColor = Color.FromArgb(130, 130, 130);
            sexoTextbox.Location = new Point(609, 301);
            sexoTextbox.Margin = new Padding(4);
            sexoTextbox.MaxLength = 32767;
            sexoTextbox.MinimumSize = new Size(50, 30);
            sexoTextbox.Multiline = false;
            sexoTextbox.Name = "sexoTextbox";
            sexoTextbox.Padding = new Padding(20, 7, 10, 7);
            sexoTextbox.PasswordChar = false;
            sexoTextbox.PlaceholderColor = Color.DarkGray;
            sexoTextbox.PlaceholderText = "Genero";
            sexoTextbox.Size = new Size(217, 43);
            sexoTextbox.TabIndex = 37;
            sexoTextbox.Texts = "";
            sexoTextbox.UnderlinedStyle = false;
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
            rjButton3.BorderRadius = 10;
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
            rjButton3.Padding = new Padding(5, 0, 0, 0);
            rjButton3.Size = new Size(146, 27);
            rjButton3.TabIndex = 39;
            rjButton3.Text = "Foto nueva";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click;
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.FromArgb(16, 83, 233);
            rjButton4.BackgroundColor = Color.FromArgb(16, 83, 233);
            rjButton4.BorderColor = Color.FromArgb(16, 83, 233);
            rjButton4.BorderRadius = 10;
            rjButton4.BorderSize = 0;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.Font = new Font("Montserrat Medium", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton4.ForeColor = Color.White;
            rjButton4.Image = Properties.Resources.Search_Icons_UIA;
            rjButton4.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton4.Location = new Point(194, 458);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(146, 27);
            rjButton4.TabIndex = 40;
            rjButton4.Text = "Elegir foto";
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            rjButton4.Click += rjButton4_Click;
            // 
            // VentanaAltaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(899, 546);
            Controls.Add(rjButton4);
            Controls.Add(rjButton3);
            Controls.Add(FotoPerfil);
            Controls.Add(sexoTextbox);
            Controls.Add(pictureBox4);
            Controls.Add(serviciolbl);
            Controls.Add(nacimientolbl);
            Controls.Add(telefonolbl);
            Controls.Add(nombrelbl);
            Controls.Add(cedulalbl);
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
        private Label cedulalbl;
        private Label nombrelbl;
        private Label telefonolbl;
        private Label nacimientolbl;
        private Label serviciolbl;
        private PictureBox pictureBox4;
        private CustomControls.RJControls.RJTextBox sexoTextbox;
        private PictureBox FotoPerfil;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton4;
    }
}