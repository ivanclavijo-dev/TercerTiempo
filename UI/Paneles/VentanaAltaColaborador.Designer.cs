namespace UI.Paneles
{
    partial class VentanaAltaColaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAltaColaborador));
            pictureBox2 = new PictureBox();
            rjButton2 = new CustomControls.RJControls.RJButton();
            rjButton1 = new CustomControls.RJControls.RJButton();
            nacimientoTextbox = new CustomControls.RJControls.RJTextBox();
            cedulaTextbox = new CustomControls.RJControls.RJTextBox();
            telefonoTextbox = new CustomControls.RJControls.RJTextBox();
            nombreTextbox = new CustomControls.RJControls.RJTextBox();
            IdTextbox = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            NotificacionesChkbox = new CheckBox();
            labelNombre = new Label();
            labelDescripcion = new Label();
            labelStock = new Label();
            labelPrecio = new Label();
            labelID = new Label();
            rjComboBox1 = new CustomControls.RJControls.RJComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Carret_Left;
            pictureBox2.Location = new Point(771, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            pictureBox2.MouseClick += pictureBox2_MouseClick;
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
            rjButton2.Location = new Point(711, 423);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(44, 44);
            rjButton2.TabIndex = 33;
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
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
            rjButton1.Location = new Point(433, 423);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(260, 44);
            rjButton1.TabIndex = 32;
            rjButton1.Text = "Ingresar Datos";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // nacimientoTextbox
            // 
            nacimientoTextbox.AccessibleDescription = "nacimientoTextbox";
            nacimientoTextbox.BackColor = Color.FromArgb(232, 232, 232);
            nacimientoTextbox.BorderColor = Color.Transparent;
            nacimientoTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            nacimientoTextbox.BorderRadius = 20;
            nacimientoTextbox.BorderSize = 2;
            nacimientoTextbox.Font = new Font("Quicksand", 13.75F);
            nacimientoTextbox.ForeColor = Color.FromArgb(130, 130, 130);
            nacimientoTextbox.Location = new Point(609, 292);
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
            nacimientoTextbox.TabIndex = 31;
            nacimientoTextbox.Texts = "";
            nacimientoTextbox.UnderlinedStyle = false;
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
            cedulaTextbox.Location = new Point(609, 158);
            cedulaTextbox.Margin = new Padding(4);
            cedulaTextbox.MaxLength = 32767;
            cedulaTextbox.MinimumSize = new Size(50, 30);
            cedulaTextbox.Multiline = false;
            cedulaTextbox.Name = "cedulaTextbox";
            cedulaTextbox.Padding = new Padding(20, 7, 10, 7);
            cedulaTextbox.PasswordChar = false;
            cedulaTextbox.PlaceholderColor = Color.DarkGray;
            cedulaTextbox.PlaceholderText = "Apellido";
            cedulaTextbox.Size = new Size(217, 43);
            cedulaTextbox.TabIndex = 30;
            cedulaTextbox.Texts = "";
            cedulaTextbox.UnderlinedStyle = false;
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
            telefonoTextbox.Location = new Point(386, 292);
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
            telefonoTextbox.TabIndex = 28;
            telefonoTextbox.Texts = "";
            telefonoTextbox.UnderlinedStyle = false;
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
            nombreTextbox.Location = new Point(386, 212);
            nombreTextbox.Margin = new Padding(4);
            nombreTextbox.MaxLength = 32767;
            nombreTextbox.MinimumSize = new Size(50, 30);
            nombreTextbox.Multiline = false;
            nombreTextbox.Name = "nombreTextbox";
            nombreTextbox.Padding = new Padding(20, 7, 10, 7);
            nombreTextbox.PasswordChar = false;
            nombreTextbox.PlaceholderColor = Color.DarkGray;
            nombreTextbox.PlaceholderText = "Número de Teléfono";
            nombreTextbox.Size = new Size(215, 43);
            nombreTextbox.TabIndex = 27;
            nombreTextbox.Texts = "";
            nombreTextbox.UnderlinedStyle = false;
            // 
            // IdTextbox
            // 
            IdTextbox.BackColor = Color.FromArgb(232, 232, 232);
            IdTextbox.BorderColor = Color.Transparent;
            IdTextbox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            IdTextbox.BorderRadius = 20;
            IdTextbox.BorderSize = 2;
            IdTextbox.Font = new Font("Quicksand", 13.75F);
            IdTextbox.ForeColor = Color.FromArgb(130, 130, 130);
            IdTextbox.Location = new Point(386, 158);
            IdTextbox.Margin = new Padding(4);
            IdTextbox.MaxLength = 32767;
            IdTextbox.MinimumSize = new Size(50, 30);
            IdTextbox.Multiline = false;
            IdTextbox.Name = "IdTextbox";
            IdTextbox.Padding = new Padding(20, 7, 10, 7);
            IdTextbox.PasswordChar = false;
            IdTextbox.PlaceholderColor = Color.DarkGray;
            IdTextbox.PlaceholderText = "Nombre";
            IdTextbox.Size = new Size(215, 43);
            IdTextbox.TabIndex = 26;
            IdTextbox.Texts = "";
            IdTextbox.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(16, 83, 233);
            label1.Location = new Point(386, 79);
            label1.Name = "label1";
            label1.Size = new Size(435, 62);
            label1.TabIndex = 25;
            label1.Text = "Añadir Colaborador";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Component_92;
            pictureBox1.Location = new Point(43, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 388);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Line_2;
            pictureBox3.Location = new Point(433, 275);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(346, 1);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 35;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // NotificacionesChkbox
            // 
            NotificacionesChkbox.AutoSize = true;
            NotificacionesChkbox.FlatStyle = FlatStyle.System;
            NotificacionesChkbox.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NotificacionesChkbox.ForeColor = Color.FromArgb(64, 64, 64);
            NotificacionesChkbox.Location = new Point(412, 388);
            NotificacionesChkbox.Name = "NotificacionesChkbox";
            NotificacionesChkbox.Size = new Size(385, 29);
            NotificacionesChkbox.TabIndex = 36;
            NotificacionesChkbox.Text = "El cliente desea recibir mensajes por Whatsapp";
            NotificacionesChkbox.UseVisualStyleBackColor = true;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.FromArgb(22, 83, 233);
            labelNombre.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(159, 285);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(53, 23);
            labelNombre.TabIndex = 38;
            labelNombre.Text = "dsada";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.BackColor = Color.FromArgb(22, 83, 233);
            labelDescripcion.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescripcion.ForeColor = Color.White;
            labelDescripcion.Location = new Point(196, 397);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(87, 23);
            labelDescripcion.TabIndex = 41;
            labelDescripcion.Text = "Agua Salus";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.BackColor = Color.FromArgb(22, 83, 233);
            labelStock.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStock.ForeColor = Color.White;
            labelStock.Location = new Point(155, 363);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(87, 23);
            labelStock.TabIndex = 40;
            labelStock.Text = "Agua Salus";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.BackColor = Color.FromArgb(22, 83, 233);
            labelPrecio.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrecio.ForeColor = Color.White;
            labelPrecio.Location = new Point(165, 324);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(87, 23);
            labelPrecio.TabIndex = 39;
            labelPrecio.Text = "Agua Salus";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.BackColor = Color.FromArgb(22, 83, 233);
            labelID.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelID.ForeColor = Color.White;
            labelID.Location = new Point(158, 248);
            labelID.Name = "labelID";
            labelID.Size = new Size(35, 23);
            labelID.TabIndex = 37;
            labelID.Text = "dsd";
            // 
            // rjComboBox1
            // 
            rjComboBox1.AutoCompleteMode = AutoCompleteMode.None;
            rjComboBox1.AutoCompleteSource = AutoCompleteSource.None;
            rjComboBox1.BackColor = Color.FromArgb(232, 232, 232);
            rjComboBox1.BorderColor = Color.MediumSlateBlue;
            rjComboBox1.BorderRadius = 20;
            rjComboBox1.BorderSize = 0;
            rjComboBox1.DataSource = null;
            rjComboBox1.DisplayMember = "";
            rjComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            rjComboBox1.Font = new Font("Segoe UI", 10F);
            rjComboBox1.ForeColor = Color.FromArgb(130, 130, 130);
            rjComboBox1.IconColor = Color.FromArgb(130, 130, 130);
            rjComboBox1.ListBackColor = Color.FromArgb(230, 228, 245);
            rjComboBox1.ListTextColor = Color.FromArgb(130, 130, 130);
            rjComboBox1.Location = new Point(609, 212);
            rjComboBox1.MinimumSize = new Size(200, 30);
            rjComboBox1.Name = "rjComboBox1";
            rjComboBox1.SelectedIndex = -1;
            rjComboBox1.SelectedItem = null;
            rjComboBox1.Size = new Size(217, 43);
            rjComboBox1.TabIndex = 42;
            rjComboBox1.Texts = "";
            rjComboBox1.ValueMember = "";
            // 
            // VentanaAltaColaborador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(899, 546);
            Controls.Add(rjComboBox1);
            Controls.Add(labelNombre);
            Controls.Add(labelDescripcion);
            Controls.Add(labelStock);
            Controls.Add(labelPrecio);
            Controls.Add(labelID);
            Controls.Add(NotificacionesChkbox);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(nacimientoTextbox);
            Controls.Add(cedulaTextbox);
            Controls.Add(telefonoTextbox);
            Controls.Add(nombreTextbox);
            Controls.Add(IdTextbox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentanaAltaColaborador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaAltaColaborador";
            TopMost = true;
            Load += VentanaAltaColaborador_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJTextBox nacimientoTextbox;
        private CustomControls.RJControls.RJTextBox cedulaTextbox;
        private CustomControls.RJControls.RJTextBox telefonoTextbox;
        private CustomControls.RJControls.RJTextBox nombreTextbox;
        private CustomControls.RJControls.RJTextBox IdTextbox;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private CheckBox NotificacionesChkbox;
        private Label labelNombre;
        private Label labelDescripcion;
        private Label labelStock;
        private Label labelPrecio;
        private Label labelID;
        private CustomControls.RJControls.RJComboBox rjComboBox1;
    }
}