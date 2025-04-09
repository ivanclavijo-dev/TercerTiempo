namespace UI.Paneles.Clientes
{
    partial class VentanaInformacionCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaInformacionCliente));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            FotoPerfil = new PictureBox();
            telefonolbl = new Label();
            nacimientolbl = new Label();
            edadlbl = new Label();
            nombrelbl = new Label();
            cedulalbl = new Label();
            pictureBox1 = new PictureBox();
            sexolbl = new Label();
            serviciolbl = new Label();
            label3 = new Label();
            actividadtxt = new Label();
            dataGridView1 = new DataGridView();
            observacionestxt = new Label();
            observacioneslbl = new RichTextBox();
            bntExpandir = new CustomControls.RJControls.RJButton();
            btnVerCompras = new CustomControls.RJControls.RJButton();
            btnVerPagos = new CustomControls.RJControls.RJButton();
            btnVerAsistencias = new CustomControls.RJControls.RJButton();
            btnVerRutinas = new CustomControls.RJControls.RJButton();
            pictureBox2 = new PictureBox();
            btnGuardarCambios = new CustomControls.RJControls.RJButton();
            btnMinimizar = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)FotoPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // FotoPerfil
            // 
            FotoPerfil.Image = (Image)resources.GetObject("FotoPerfil.Image");
            FotoPerfil.Location = new Point(143, 110);
            FotoPerfil.Name = "FotoPerfil";
            FotoPerfil.Size = new Size(128, 128);
            FotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            FotoPerfil.TabIndex = 45;
            FotoPerfil.TabStop = false;
            // 
            // telefonolbl
            // 
            telefonolbl.AutoSize = true;
            telefonolbl.BackColor = Color.FromArgb(16, 83, 233);
            telefonolbl.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            telefonolbl.ForeColor = Color.White;
            telefonolbl.Location = new Point(83, 398);
            telefonolbl.Name = "telefonolbl";
            telefonolbl.Size = new Size(87, 25);
            telefonolbl.TabIndex = 44;
            telefonolbl.Text = "Teléfono:";
            telefonolbl.Click += serviciolbl_Click;
            // 
            // nacimientolbl
            // 
            nacimientolbl.AutoSize = true;
            nacimientolbl.BackColor = Color.FromArgb(16, 83, 233);
            nacimientolbl.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            nacimientolbl.ForeColor = Color.White;
            nacimientolbl.Location = new Point(83, 368);
            nacimientolbl.Name = "nacimientolbl";
            nacimientolbl.Size = new Size(113, 25);
            nacimientolbl.TabIndex = 43;
            nacimientolbl.Text = "Nacimiento:";
            // 
            // edadlbl
            // 
            edadlbl.AutoSize = true;
            edadlbl.BackColor = Color.FromArgb(16, 83, 233);
            edadlbl.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            edadlbl.ForeColor = Color.White;
            edadlbl.Location = new Point(83, 338);
            edadlbl.Name = "edadlbl";
            edadlbl.Size = new Size(59, 25);
            edadlbl.TabIndex = 42;
            edadlbl.Text = "Edad:";
            // 
            // nombrelbl
            // 
            nombrelbl.AutoSize = true;
            nombrelbl.BackColor = Color.FromArgb(16, 83, 233);
            nombrelbl.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            nombrelbl.ForeColor = Color.White;
            nombrelbl.Location = new Point(83, 278);
            nombrelbl.Name = "nombrelbl";
            nombrelbl.Size = new Size(84, 25);
            nombrelbl.TabIndex = 41;
            nombrelbl.Text = "Nombre:";
            // 
            // cedulalbl
            // 
            cedulalbl.AutoSize = true;
            cedulalbl.BackColor = Color.FromArgb(16, 83, 233);
            cedulalbl.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cedulalbl.ForeColor = Color.White;
            cedulalbl.Location = new Point(83, 248);
            cedulalbl.Name = "cedulalbl";
            cedulalbl.Size = new Size(75, 25);
            cedulalbl.TabIndex = 40;
            cedulalbl.Text = "Cédula:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 388);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // sexolbl
            // 
            sexolbl.AutoSize = true;
            sexolbl.BackColor = Color.FromArgb(16, 83, 233);
            sexolbl.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            sexolbl.ForeColor = Color.White;
            sexolbl.Location = new Point(83, 308);
            sexolbl.Name = "sexolbl";
            sexolbl.Size = new Size(76, 25);
            sexolbl.TabIndex = 46;
            sexolbl.Text = "Genero:";
            // 
            // serviciolbl
            // 
            serviciolbl.AutoSize = true;
            serviciolbl.BackColor = Color.FromArgb(16, 83, 233);
            serviciolbl.Font = new Font("Montserrat", 12F, FontStyle.Bold);
            serviciolbl.ForeColor = Color.White;
            serviciolbl.Location = new Point(83, 428);
            serviciolbl.Name = "serviciolbl";
            serviciolbl.Size = new Size(152, 25);
            serviciolbl.TabIndex = 47;
            serviciolbl.Text = "Servicio Médico: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(16, 83, 233);
            label3.Location = new Point(445, 78);
            label3.Name = "label3";
            label3.Size = new Size(558, 67);
            label3.TabIndex = 48;
            label3.Text = "Información del Cliente";
            // 
            // actividadtxt
            // 
            actividadtxt.AutoSize = true;
            actividadtxt.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            actividadtxt.ForeColor = Color.FromArgb(16, 83, 233);
            actividadtxt.Location = new Point(397, 162);
            actividadtxt.Name = "actividadtxt";
            actividadtxt.Size = new Size(222, 30);
            actividadtxt.TabIndex = 49;
            actividadtxt.Text = "Actividad que realiza";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(231, 238, 253);
            dataGridViewCellStyle1.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(16, 83, 233);
            dataGridViewCellStyle2.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 70;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(397, 195);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(633, 78);
            dataGridView1.TabIndex = 50;
            // 
            // observacionestxt
            // 
            observacionestxt.AutoSize = true;
            observacionestxt.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            observacionestxt.ForeColor = Color.FromArgb(16, 83, 233);
            observacionestxt.Location = new Point(397, 299);
            observacionestxt.Name = "observacionestxt";
            observacionestxt.Size = new Size(177, 33);
            observacionestxt.TabIndex = 51;
            observacionestxt.Text = "Observaciones";
            observacionestxt.Click += label5_Click;
            // 
            // observacioneslbl
            // 
            observacioneslbl.BorderStyle = BorderStyle.None;
            observacioneslbl.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            observacioneslbl.Location = new Point(397, 327);
            observacioneslbl.Name = "observacioneslbl";
            observacioneslbl.Size = new Size(276, 139);
            observacioneslbl.TabIndex = 52;
            observacioneslbl.Text = "";
            observacioneslbl.TextChanged += observacioneslbl_TextChanged;
            // 
            // bntExpandir
            // 
            bntExpandir.BackColor = Color.WhiteSmoke;
            bntExpandir.BackgroundColor = Color.WhiteSmoke;
            bntExpandir.BorderColor = Color.PaleVioletRed;
            bntExpandir.BorderRadius = 5;
            bntExpandir.BorderSize = 0;
            bntExpandir.Cursor = Cursors.Hand;
            bntExpandir.FlatAppearance.BorderSize = 0;
            bntExpandir.FlatStyle = FlatStyle.Flat;
            bntExpandir.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntExpandir.ForeColor = Color.White;
            bntExpandir.Image = Properties.Resources.fi_rr_expand1;
            bntExpandir.Location = new Point(639, 331);
            bntExpandir.Name = "bntExpandir";
            bntExpandir.Padding = new Padding(10);
            bntExpandir.Size = new Size(30, 30);
            bntExpandir.TabIndex = 53;
            bntExpandir.TextColor = Color.White;
            bntExpandir.UseVisualStyleBackColor = false;
            bntExpandir.Click += bntExpandir_Click;
            // 
            // btnVerCompras
            // 
            btnVerCompras.BackColor = Color.FromArgb(16, 83, 233);
            btnVerCompras.BackgroundColor = Color.FromArgb(16, 83, 233);
            btnVerCompras.BorderColor = Color.FromArgb(16, 83, 233);
            btnVerCompras.BorderRadius = 10;
            btnVerCompras.BorderSize = 0;
            btnVerCompras.Cursor = Cursors.Hand;
            btnVerCompras.FlatAppearance.BorderSize = 0;
            btnVerCompras.FlatStyle = FlatStyle.Flat;
            btnVerCompras.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            btnVerCompras.ForeColor = Color.White;
            btnVerCompras.Image = Properties.Resources.fi_rr_shopping_cart;
            btnVerCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerCompras.Location = new Point(770, 303);
            btnVerCompras.Name = "btnVerCompras";
            btnVerCompras.Padding = new Padding(14, 0, 0, 0);
            btnVerCompras.Size = new Size(260, 43);
            btnVerCompras.TabIndex = 54;
            btnVerCompras.Text = "Ver historial de compras";
            btnVerCompras.TextColor = Color.White;
            btnVerCompras.UseVisualStyleBackColor = false;
            // 
            // btnVerPagos
            // 
            btnVerPagos.BackColor = Color.FromArgb(16, 83, 233);
            btnVerPagos.BackgroundColor = Color.FromArgb(16, 83, 233);
            btnVerPagos.BorderColor = Color.FromArgb(16, 83, 233);
            btnVerPagos.BorderRadius = 10;
            btnVerPagos.BorderSize = 0;
            btnVerPagos.Cursor = Cursors.Hand;
            btnVerPagos.FlatAppearance.BorderSize = 0;
            btnVerPagos.FlatStyle = FlatStyle.Flat;
            btnVerPagos.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            btnVerPagos.ForeColor = Color.White;
            btnVerPagos.Image = Properties.Resources.Bag_Icon_UIA;
            btnVerPagos.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerPagos.Location = new Point(770, 352);
            btnVerPagos.Name = "btnVerPagos";
            btnVerPagos.Padding = new Padding(14, 0, 0, 0);
            btnVerPagos.Size = new Size(260, 43);
            btnVerPagos.TabIndex = 55;
            btnVerPagos.Text = "Ver todos los pagos";
            btnVerPagos.TextColor = Color.White;
            btnVerPagos.UseVisualStyleBackColor = false;
            // 
            // btnVerAsistencias
            // 
            btnVerAsistencias.BackColor = Color.FromArgb(16, 83, 233);
            btnVerAsistencias.BackgroundColor = Color.FromArgb(16, 83, 233);
            btnVerAsistencias.BorderColor = Color.FromArgb(16, 83, 233);
            btnVerAsistencias.BorderRadius = 10;
            btnVerAsistencias.BorderSize = 0;
            btnVerAsistencias.Cursor = Cursors.Hand;
            btnVerAsistencias.FlatAppearance.BorderSize = 0;
            btnVerAsistencias.FlatStyle = FlatStyle.Flat;
            btnVerAsistencias.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            btnVerAsistencias.ForeColor = Color.White;
            btnVerAsistencias.Image = Properties.Resources.menu_board;
            btnVerAsistencias.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerAsistencias.Location = new Point(770, 401);
            btnVerAsistencias.Name = "btnVerAsistencias";
            btnVerAsistencias.Padding = new Padding(14, 0, 0, 0);
            btnVerAsistencias.Size = new Size(260, 43);
            btnVerAsistencias.TabIndex = 56;
            btnVerAsistencias.Text = "Ver las asistencias";
            btnVerAsistencias.TextColor = Color.White;
            btnVerAsistencias.UseVisualStyleBackColor = false;
            // 
            // btnVerRutinas
            // 
            btnVerRutinas.BackColor = Color.FromArgb(16, 83, 233);
            btnVerRutinas.BackgroundColor = Color.FromArgb(16, 83, 233);
            btnVerRutinas.BorderColor = Color.FromArgb(16, 83, 233);
            btnVerRutinas.BorderRadius = 10;
            btnVerRutinas.BorderSize = 0;
            btnVerRutinas.Cursor = Cursors.Hand;
            btnVerRutinas.FlatAppearance.BorderSize = 0;
            btnVerRutinas.FlatStyle = FlatStyle.Flat;
            btnVerRutinas.Font = new Font("Montserrat", 11.25F, FontStyle.Bold);
            btnVerRutinas.ForeColor = Color.White;
            btnVerRutinas.Image = Properties.Resources.share;
            btnVerRutinas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerRutinas.Location = new Point(770, 450);
            btnVerRutinas.Name = "btnVerRutinas";
            btnVerRutinas.Padding = new Padding(14, 0, 0, 0);
            btnVerRutinas.Size = new Size(260, 43);
            btnVerRutinas.TabIndex = 57;
            btnVerRutinas.Text = "Ver rutinas asignadas";
            btnVerRutinas.TextColor = Color.White;
            btnVerRutinas.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Carret_Left;
            pictureBox2.Location = new Point(990, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.FromArgb(16, 83, 233);
            btnGuardarCambios.BackgroundColor = Color.FromArgb(16, 83, 233);
            btnGuardarCambios.BorderColor = Color.FromArgb(16, 83, 233);
            btnGuardarCambios.BorderRadius = 10;
            btnGuardarCambios.BorderSize = 0;
            btnGuardarCambios.Cursor = Cursors.Hand;
            btnGuardarCambios.FlatAppearance.BorderSize = 0;
            btnGuardarCambios.FlatStyle = FlatStyle.Flat;
            btnGuardarCambios.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCambios.ForeColor = Color.White;
            btnGuardarCambios.Image = Properties.Resources.export2;
            btnGuardarCambios.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarCambios.Location = new Point(397, 472);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Padding = new Padding(14, 0, 0, 0);
            btnGuardarCambios.Size = new Size(206, 32);
            btnGuardarCambios.TabIndex = 59;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.TextColor = Color.White;
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Visible = false;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.WhiteSmoke;
            btnMinimizar.BackgroundColor = Color.WhiteSmoke;
            btnMinimizar.BorderColor = Color.PaleVioletRed;
            btnMinimizar.BorderRadius = 5;
            btnMinimizar.BorderSize = 0;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Image = Properties.Resources.fi_rr_compress;
            btnMinimizar.Location = new Point(609, 472);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Padding = new Padding(10);
            btnMinimizar.Size = new Size(30, 30);
            btnMinimizar.TabIndex = 60;
            btnMinimizar.TextColor = Color.White;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Visible = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // VentanaInformacionCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 546);
            Controls.Add(btnMinimizar);
            Controls.Add(btnGuardarCambios);
            Controls.Add(pictureBox2);
            Controls.Add(btnVerRutinas);
            Controls.Add(btnVerAsistencias);
            Controls.Add(btnVerPagos);
            Controls.Add(btnVerCompras);
            Controls.Add(bntExpandir);
            Controls.Add(observacioneslbl);
            Controls.Add(observacionestxt);
            Controls.Add(dataGridView1);
            Controls.Add(actividadtxt);
            Controls.Add(label3);
            Controls.Add(serviciolbl);
            Controls.Add(sexolbl);
            Controls.Add(FotoPerfil);
            Controls.Add(telefonolbl);
            Controls.Add(nacimientolbl);
            Controls.Add(edadlbl);
            Controls.Add(nombrelbl);
            Controls.Add(cedulalbl);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentanaInformacionCliente";
            Text = "VentanaInformacionCliente";
            Load += VentanaInformacionCliente_Load;
            ((System.ComponentModel.ISupportInitialize)FotoPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox FotoPerfil;
        private Label telefonolbl;
        private Label nacimientolbl;
        private Label edadlbl;
        private Label nombrelbl;
        private Label cedulalbl;
        private PictureBox pictureBox1;
        private Label sexolbl;
        private Label serviciolbl;
        private Label label3;
        private Label actividadtxt;
        private DataGridView dataGridView1;
        private Label observacionestxt;
        private RichTextBox observacioneslbl;
        private CustomControls.RJControls.RJButton bntExpandir;
        private CustomControls.RJControls.RJButton btnVerCompras;
        private CustomControls.RJControls.RJButton btnVerPagos;
        private CustomControls.RJControls.RJButton btnVerAsistencias;
        private CustomControls.RJControls.RJButton btnVerRutinas;
        private PictureBox pictureBox2;
        private CustomControls.RJControls.RJButton btnGuardarCambios;
        private CustomControls.RJControls.RJButton btnMinimizar;
    }
}