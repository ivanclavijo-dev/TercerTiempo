namespace UI.Paneles
{
    partial class VentanaEditarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaEditarProducto));
            label1 = new Label();
            PrecioOfertaTextBox = new CustomControls.RJControls.RJTextBox();
            pictureBox2 = new PictureBox();
            rjButton2 = new CustomControls.RJControls.RJButton();
            rjButton1 = new CustomControls.RJControls.RJButton();
            DescTextBox = new CustomControls.RJControls.RJTextBox();
            StockTextBox = new CustomControls.RJControls.RJTextBox();
            PrecioListaTextBox = new CustomControls.RJControls.RJTextBox();
            NombreTextBox = new CustomControls.RJControls.RJTextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            labelNombre = new Label();
            labelDescripcion = new Label();
            labelStock = new Label();
            labelPrecio = new Label();
            labelID = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand", 10F);
            label1.Location = new Point(402, 350);
            label1.Name = "label1";
            label1.Size = new Size(218, 21);
            label1.TabIndex = 45;
            label1.Text = "*El precio oferta puede ser vacio.";
            // 
            // PrecioOfertaTextBox
            // 
            PrecioOfertaTextBox.BackColor = Color.FromArgb(232, 232, 232);
            PrecioOfertaTextBox.BorderColor = Color.Transparent;
            PrecioOfertaTextBox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            PrecioOfertaTextBox.BorderRadius = 20;
            PrecioOfertaTextBox.BorderSize = 2;
            PrecioOfertaTextBox.Font = new Font("Quicksand", 13.75F);
            PrecioOfertaTextBox.ForeColor = Color.FromArgb(130, 130, 130);
            PrecioOfertaTextBox.Location = new Point(620, 201);
            PrecioOfertaTextBox.Margin = new Padding(4);
            PrecioOfertaTextBox.MinimumSize = new Size(50, 30);
            PrecioOfertaTextBox.Multiline = false;
            PrecioOfertaTextBox.Name = "PrecioOfertaTextBox";
            PrecioOfertaTextBox.Padding = new Padding(20, 7, 10, 7);
            PrecioOfertaTextBox.PasswordChar = false;
            PrecioOfertaTextBox.PlaceholderColor = Color.DarkGray;
            PrecioOfertaTextBox.PlaceholderText = "";
            PrecioOfertaTextBox.Size = new Size(218, 43);
            PrecioOfertaTextBox.TabIndex = 44;
            PrecioOfertaTextBox.Texts = "";
            PrecioOfertaTextBox.UnderlinedStyle = false;
            PrecioOfertaTextBox.KeyPress += PrecioOfertaTextBox_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Carret_Left;
            pictureBox2.Location = new Point(771, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
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
            rjButton2.Location = new Point(794, 398);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(44, 39);
            rjButton2.TabIndex = 42;
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
            rjButton1.Location = new Point(402, 403);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(386, 34);
            rjButton1.TabIndex = 41;
            rjButton1.Text = "Ingresar Datos";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.MouseClick += rjButton1_MouseClick;
            // 
            // DescTextBox
            // 
            DescTextBox.BackColor = Color.FromArgb(232, 232, 232);
            DescTextBox.BorderColor = Color.Transparent;
            DescTextBox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            DescTextBox.BorderRadius = 20;
            DescTextBox.BorderSize = 2;
            DescTextBox.Font = new Font("Quicksand", 13.75F);
            DescTextBox.ForeColor = Color.FromArgb(130, 130, 130);
            DescTextBox.Location = new Point(402, 303);
            DescTextBox.Margin = new Padding(4);
            DescTextBox.MinimumSize = new Size(50, 30);
            DescTextBox.Multiline = false;
            DescTextBox.Name = "DescTextBox";
            DescTextBox.Padding = new Padding(20, 7, 10, 7);
            DescTextBox.PasswordChar = false;
            DescTextBox.PlaceholderColor = Color.DarkGray;
            DescTextBox.PlaceholderText = "";
            DescTextBox.Size = new Size(436, 43);
            DescTextBox.TabIndex = 40;
            DescTextBox.Texts = "";
            DescTextBox.UnderlinedStyle = false;
            // 
            // StockTextBox
            // 
            StockTextBox.BackColor = Color.FromArgb(232, 232, 232);
            StockTextBox.BorderColor = Color.Transparent;
            StockTextBox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            StockTextBox.BorderRadius = 20;
            StockTextBox.BorderSize = 2;
            StockTextBox.Font = new Font("Quicksand", 13.75F);
            StockTextBox.ForeColor = Color.FromArgb(130, 130, 130);
            StockTextBox.Location = new Point(402, 252);
            StockTextBox.Margin = new Padding(4);
            StockTextBox.MinimumSize = new Size(50, 30);
            StockTextBox.Multiline = false;
            StockTextBox.Name = "StockTextBox";
            StockTextBox.Padding = new Padding(20, 7, 10, 7);
            StockTextBox.PasswordChar = false;
            StockTextBox.PlaceholderColor = Color.DarkGray;
            StockTextBox.PlaceholderText = "";
            StockTextBox.Size = new Size(436, 43);
            StockTextBox.TabIndex = 39;
            StockTextBox.Texts = "";
            StockTextBox.UnderlinedStyle = false;
            StockTextBox.KeyPress += StockTextBox_KeyPress;
            // 
            // PrecioListaTextBox
            // 
            PrecioListaTextBox.BackColor = Color.FromArgb(232, 232, 232);
            PrecioListaTextBox.BorderColor = Color.Transparent;
            PrecioListaTextBox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            PrecioListaTextBox.BorderRadius = 20;
            PrecioListaTextBox.BorderSize = 2;
            PrecioListaTextBox.Font = new Font("Quicksand", 13.75F);
            PrecioListaTextBox.ForeColor = Color.FromArgb(130, 130, 130);
            PrecioListaTextBox.Location = new Point(402, 201);
            PrecioListaTextBox.Margin = new Padding(4);
            PrecioListaTextBox.MinimumSize = new Size(50, 30);
            PrecioListaTextBox.Multiline = false;
            PrecioListaTextBox.Name = "PrecioListaTextBox";
            PrecioListaTextBox.Padding = new Padding(20, 7, 10, 7);
            PrecioListaTextBox.PasswordChar = false;
            PrecioListaTextBox.PlaceholderColor = Color.DarkGray;
            PrecioListaTextBox.PlaceholderText = "";
            PrecioListaTextBox.Size = new Size(218, 43);
            PrecioListaTextBox.TabIndex = 38;
            PrecioListaTextBox.Texts = "";
            PrecioListaTextBox.UnderlinedStyle = false;
            PrecioListaTextBox.KeyPress += PrecioListaTextBox_KeyPress;
            // 
            // NombreTextBox
            // 
            NombreTextBox.BackColor = Color.FromArgb(232, 232, 232);
            NombreTextBox.BorderColor = Color.Transparent;
            NombreTextBox.BorderFocusColor = Color.FromArgb(16, 83, 233);
            NombreTextBox.BorderRadius = 20;
            NombreTextBox.BorderSize = 2;
            NombreTextBox.Font = new Font("Quicksand", 13.75F);
            NombreTextBox.ForeColor = Color.FromArgb(130, 130, 130);
            NombreTextBox.Location = new Point(402, 150);
            NombreTextBox.Margin = new Padding(4);
            NombreTextBox.MinimumSize = new Size(50, 30);
            NombreTextBox.Multiline = false;
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Padding = new Padding(20, 7, 10, 7);
            NombreTextBox.PasswordChar = false;
            NombreTextBox.PlaceholderColor = Color.DarkGray;
            NombreTextBox.PlaceholderText = "";
            NombreTextBox.Size = new Size(436, 43);
            NombreTextBox.TabIndex = 37;
            NombreTextBox.Texts = "";
            NombreTextBox.UnderlinedStyle = false;
            NombreTextBox._TextChanged += NombreTextBox__TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(16, 83, 233);
            label2.Location = new Point(402, 78);
            label2.Name = "label2";
            label2.Size = new Size(420, 55);
            label2.TabIndex = 36;
            label2.Text = "Editar un Producto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Group_74;
            pictureBox1.Location = new Point(43, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 291);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.FromArgb(22, 83, 233);
            labelNombre.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(170, 226);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(53, 23);
            labelNombre.TabIndex = 47;
            labelNombre.Text = "dsada";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.BackColor = Color.FromArgb(22, 83, 233);
            labelDescripcion.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescripcion.ForeColor = Color.White;
            labelDescripcion.Location = new Point(202, 338);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(87, 23);
            labelDescripcion.TabIndex = 50;
            labelDescripcion.Text = "Agua Salus";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.BackColor = Color.FromArgb(22, 83, 233);
            labelStock.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStock.ForeColor = Color.White;
            labelStock.Location = new Point(138, 303);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(87, 23);
            labelStock.TabIndex = 49;
            labelStock.Text = "Agua Salus";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.BackColor = Color.FromArgb(22, 83, 233);
            labelPrecio.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrecio.ForeColor = Color.White;
            labelPrecio.Location = new Point(146, 265);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(87, 23);
            labelPrecio.TabIndex = 48;
            labelPrecio.Text = "Agua Salus";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.BackColor = Color.FromArgb(22, 83, 233);
            labelID.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelID.ForeColor = Color.White;
            labelID.Location = new Point(103, 191);
            labelID.Name = "labelID";
            labelID.Size = new Size(35, 23);
            labelID.TabIndex = 46;
            labelID.Text = "dsd";
            // 
            // VentanaEditarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(899, 546);
            Controls.Add(labelNombre);
            Controls.Add(labelDescripcion);
            Controls.Add(labelStock);
            Controls.Add(labelPrecio);
            Controls.Add(labelID);
            Controls.Add(label1);
            Controls.Add(PrecioOfertaTextBox);
            Controls.Add(pictureBox2);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(DescTextBox);
            Controls.Add(StockTextBox);
            Controls.Add(PrecioListaTextBox);
            Controls.Add(NombreTextBox);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentanaEditarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaEditarProducto";
            Load += VentanaEditarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CustomControls.RJControls.RJTextBox PrecioOfertaTextBox;
        private PictureBox pictureBox2;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJTextBox DescTextBox;
        private CustomControls.RJControls.RJTextBox StockTextBox;
        private CustomControls.RJControls.RJTextBox PrecioListaTextBox;
        private CustomControls.RJControls.RJTextBox NombreTextBox;
        private Label label2;
        private PictureBox pictureBox1;
        private Label labelNombre;
        private Label labelDescripcion;
        private Label labelStock;
        private Label labelPrecio;
        private Label labelID;
    }
}