namespace UI.Forms
{
    partial class Productos
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
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            rjButton2 = new CustomControls.RJControls.RJButton();
            pictureBox7 = new PictureBox();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            MenuClientes = new Label();
            dataGridView1 = new DataGridView();
            pictureBox4 = new PictureBox();
            labelCantCarrito = new Label();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            Cant = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnCarrito = new UI.Componentes.ElipseControl();
            label2 = new Label();
            label3 = new Label();
            rjButton1 = new CustomControls.RJControls.RJButton();
            rjButton3 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.trash;
            pictureBox3.Location = new Point(864, 111);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Edit_Pen_Icon;
            pictureBox2.Location = new Point(821, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.add_square;
            pictureBox1.Location = new Point(777, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.FromArgb(16, 83, 233);
            rjButton2.BackgroundColor = Color.FromArgb(16, 83, 233);
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 20;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Quicksand", 12F, FontStyle.Bold);
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(621, 106);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(150, 34);
            rjButton2.TabIndex = 39;
            rjButton2.Text = "Seleccionar";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.MouseClick += rjButton2_MouseClick;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Search;
            pictureBox7.Location = new Point(567, 113);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(26, 22);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 37;
            pictureBox7.TabStop = false;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = Color.White;
            rjTextBox1.BorderColor = Color.Transparent;
            rjTextBox1.BorderFocusColor = Color.FromArgb(0, 65, 212);
            rjTextBox1.BorderRadius = 20;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Quicksand", 10F);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(27, 106);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "Buscar por nombre, id...";
            rjTextBox1.Size = new Size(587, 36);
            rjTextBox1.TabIndex = 38;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            rjTextBox1._TextChanged += rjTextBox1__TextChanged;
            // 
            // MenuClientes
            // 
            MenuClientes.AutoSize = true;
            MenuClientes.Font = new Font("Montserrat SemiBold", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuClientes.ForeColor = Color.FromArgb(16, 83, 233);
            MenuClientes.Location = new Point(17, 25);
            MenuClientes.Name = "MenuClientes";
            MenuClientes.Size = new Size(517, 75);
            MenuClientes.TabIndex = 36;
            MenuClientes.Text = "Menú de Productos";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = Color.LightGray;
            dataGridViewCellStyle21.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = Color.FromArgb(16, 83, 233);
            dataGridViewCellStyle22.Font = new Font("Montserrat Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle22.ForeColor = Color.White;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = SystemColors.Window;
            dataGridViewCellStyle23.Font = new Font("Montserrat Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle23.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle23;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(26, 149);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = SystemColors.Control;
            dataGridViewCellStyle24.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle24.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle25.BackColor = Color.White;
            dataGridViewCellStyle25.Font = new Font("Montserrat Black", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle25.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle25;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(907, 431);
            dataGridView1.TabIndex = 35;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(16, 83, 233);
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.shopping_cart;
            pictureBox4.Location = new Point(821, 37);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(19, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            pictureBox4.MouseClick += pictureBox4_MouseClick;
            // 
            // labelCantCarrito
            // 
            labelCantCarrito.AutoSize = true;
            labelCantCarrito.BackColor = Color.FromArgb(16, 83, 233);
            labelCantCarrito.Cursor = Cursors.Hand;
            labelCantCarrito.Font = new Font("Quicksand", 13.25F, FontStyle.Bold);
            labelCantCarrito.ForeColor = Color.White;
            labelCantCarrito.Location = new Point(786, 32);
            labelCantCarrito.Name = "labelCantCarrito";
            labelCantCarrito.Size = new Size(23, 26);
            labelCantCarrito.TabIndex = 45;
            labelCantCarrito.Text = "0";
            labelCantCarrito.MouseClick += labelCantCarrito_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Montserrat SemiBold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(16, 83, 233);
            label1.Location = new Point(67, 12);
            label1.Name = "label1";
            label1.Size = new Size(252, 38);
            label1.TabIndex = 48;
            label1.Text = "Carrito de compras";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.BackColor = Color.LightGray;
            dataGridViewCellStyle26.ForeColor = Color.Black;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = Color.FromArgb(16, 83, 233);
            dataGridViewCellStyle27.Font = new Font("Montserrat Black", 9.25F, FontStyle.Bold);
            dataGridViewCellStyle27.ForeColor = Color.White;
            dataGridViewCellStyle27.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            dataGridView2.ColumnHeadersHeight = 60;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Cant, Nombre, Precio, Descripcion });
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = SystemColors.Window;
            dataGridViewCellStyle28.Font = new Font("Montserrat Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle28.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle28;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(29, 65);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = SystemColors.Control;
            dataGridViewCellStyle29.Font = new Font("Montserrat", 8F, FontStyle.Bold);
            dataGridViewCellStyle29.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle30.BackColor = Color.White;
            dataGridViewCellStyle30.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle30.ForeColor = Color.Black;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle30;
            dataGridView2.RowTemplate.Height = 40;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(326, 179);
            dataGridView2.TabIndex = 49;
            // 
            // Cant
            // 
            Cant.HeaderText = "Cant.";
            Cant.Name = "Cant";
            Cant.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Desc.";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(rjButton3);
            panel1.Controls.Add(rjButton1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView2);
            panel1.Location = new Point(554, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 331);
            panel1.TabIndex = 50;
            panel1.Visible = false;
            // 
            // btnCarrito
            // 
            btnCarrito.BackColor = Color.FromArgb(16, 83, 233);
            btnCarrito.CornerRadius = 20;
            btnCarrito.Cursor = Cursors.Hand;
            btnCarrito.Location = new Point(774, 20);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Size = new Size(159, 52);
            btnCarrito.TabIndex = 51;
            btnCarrito.Text = "carrito";
            btnCarrito.Click += btnCarrito_Click;
            btnCarrito.MouseClick += btnCarrito_MouseClick_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(16, 83, 233);
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Quicksand", 13.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(846, 33);
            label2.Name = "label2";
            label2.Size = new Size(72, 26);
            label2.TabIndex = 52;
            label2.Text = "Carrito";
            label2.MouseClick += label2_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 247);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 50;
            label3.Text = "Total a pagar: $2.100";
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(16, 83, 233);
            rjButton1.BackgroundColor = Color.FromArgb(16, 83, 233);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(29, 284);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(188, 26);
            rjButton1.TabIndex = 51;
            rjButton1.Text = "Pagar";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.FromArgb(244, 54, 20);
            rjButton3.BackgroundColor = Color.FromArgb(244, 54, 20);
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 10;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.ForeColor = Color.White;
            rjButton3.Location = new Point(223, 284);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(132, 26);
            rjButton3.TabIndex = 52;
            rjButton3.Text = "Vaciar";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(960, 616);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(labelCantCarrito);
            Controls.Add(btnCarrito);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(rjButton2);
            Controls.Add(pictureBox7);
            Controls.Add(rjTextBox1);
            Controls.Add(MenuClientes);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton rjButton2;
        private PictureBox pictureBox7;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private Label MenuClientes;
        private DataGridView dataGridView1;
        private PictureBox pictureBox4;
        private Label labelCantCarrito;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Cant;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Descripcion;
        private Panel panel1;
        private Componentes.ElipseControl btnCarrito;
        private Label label2;
        private Label label3;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}