namespace UI.Paneles
{
    partial class Detalle_planes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            MenuClientes = new Label();
            estadoCuotaCliente = new Label();
            nombreCliente = new Label();
            idCliente = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            rjButton1 = new CustomControls.RJControls.RJButton();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // MenuClientes
            // 
            MenuClientes.AutoSize = true;
            MenuClientes.Font = new Font("Montserrat SemiBold", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuClientes.ForeColor = Color.FromArgb(16, 83, 233);
            MenuClientes.Location = new Point(50, 41);
            MenuClientes.Name = "MenuClientes";
            MenuClientes.Size = new Size(388, 75);
            MenuClientes.TabIndex = 2;
            MenuClientes.Text = "Pago de cuota";
            // 
            // estadoCuotaCliente
            // 
            estadoCuotaCliente.AutoSize = true;
            estadoCuotaCliente.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            estadoCuotaCliente.ForeColor = Color.Silver;
            estadoCuotaCliente.Location = new Point(320, 211);
            estadoCuotaCliente.Name = "estadoCuotaCliente";
            estadoCuotaCliente.Size = new Size(28, 40);
            estadoCuotaCliente.TabIndex = 15;
            estadoCuotaCliente.Text = "-";
            // 
            // nombreCliente
            // 
            nombreCliente.AutoSize = true;
            nombreCliente.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombreCliente.Location = new Point(320, 169);
            nombreCliente.Name = "nombreCliente";
            nombreCliente.Size = new Size(28, 40);
            nombreCliente.TabIndex = 14;
            nombreCliente.Text = "-";
            // 
            // idCliente
            // 
            idCliente.AutoSize = true;
            idCliente.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idCliente.Location = new Point(320, 129);
            idCliente.Name = "idCliente";
            idCliente.Size = new Size(28, 40);
            idCliente.TabIndex = 13;
            idCliente.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 211);
            label5.Name = "label5";
            label5.Size = new Size(278, 40);
            label5.TabIndex = 12;
            label5.Text = "Estado de la cuota: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 169);
            label4.Name = "label4";
            label4.Size = new Size(270, 40);
            label4.TabIndex = 11;
            label4.Text = "Nombre completo: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 127);
            label3.Name = "label3";
            label3.Size = new Size(200, 40);
            label3.TabIndex = 10;
            label3.Text = "ID del cliente: ";
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
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(231, 238, 253);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
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
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 70;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(50, 317);
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
            dataGridView1.Size = new Size(789, 151);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(16, 83, 233);
            label1.Location = new Point(50, 276);
            label1.Name = "label1";
            label1.Size = new Size(245, 38);
            label1.TabIndex = 17;
            label1.Text = "Últimos pagos de";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(607, 125);
            label2.Name = "label2";
            label2.Size = new Size(157, 23);
            label2.TabIndex = 19;
            label2.Text = "Seleccione el plan";
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(607, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 33);
            comboBox1.TabIndex = 20;
            // 
            // comboBox2
            // 
            comboBox2.Cursor = Cursors.Hand;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.ForeColor = SystemColors.WindowText;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
            comboBox2.Location = new Point(607, 217);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(221, 33);
            comboBox2.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Quicksand Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(607, 193);
            label6.Name = "label6";
            label6.Size = new Size(139, 23);
            label6.TabIndex = 22;
            label6.Text = "Método de pago";
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(16, 83, 233);
            rjButton1.BackgroundColor = Color.FromArgb(16, 83, 233);
            rjButton1.BorderColor = Color.FromArgb(244, 54, 20);
            rjButton1.BorderRadius = 20;
            rjButton1.BorderSize = 0;
            rjButton1.Cursor = Cursors.Hand;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(607, 262);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(221, 40);
            rjButton1.TabIndex = 26;
            rjButton1.Text = "Continuar";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Carret_Left;
            pictureBox2.Location = new Point(784, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Detalle_planes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 507);
            Controls.Add(pictureBox2);
            Controls.Add(rjButton1);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(estadoCuotaCliente);
            Controls.Add(nombreCliente);
            Controls.Add(idCliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(MenuClientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Detalle_planes";
            Text = "Detalle_planes";
            Load += Detalle_planes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MenuClientes;
        private Label estadoCuotaCliente;
        private Label nombreCliente;
        private Label idCliente;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label6;
        private CustomControls.RJControls.RJButton rjButton1;
        private PictureBox pictureBox2;
    }
}