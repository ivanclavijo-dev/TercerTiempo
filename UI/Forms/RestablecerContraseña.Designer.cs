namespace UI.Forms
{
    partial class RestablecerContraseña
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
            rjButton1 = new CustomControls.RJControls.RJButton();
            label3 = new Label();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(0, 65, 212);
            rjButton1.BackgroundColor = Color.FromArgb(0, 65, 212);
            rjButton1.BorderColor = Color.FromArgb(0, 65, 212);
            rjButton1.BorderRadius = 20;
            rjButton1.BorderSize = 0;
            rjButton1.Cursor = Cursors.Hand;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Quicksand SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.WhiteSmoke;
            rjButton1.Location = new Point(76, 475);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(364, 53);
            rjButton1.TabIndex = 23;
            rjButton1.Text = "Validar";
            rjButton1.TextColor = Color.WhiteSmoke;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.MouseClick += rjButton1_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(130, 130, 130);
            label3.Location = new Point(84, 368);
            label3.Name = "label3";
            label3.Size = new Size(136, 19);
            label3.TabIndex = 22;
            label3.Text = "Repita la contraseña";
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = Color.FromArgb(244, 238, 238);
            rjTextBox1.BorderColor = Color.Transparent;
            rjTextBox1.BorderFocusColor = Color.FromArgb(224, 224, 224);
            rjTextBox1.BorderRadius = 5;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Quicksand", 13.75F);
            rjTextBox1.ForeColor = Color.FromArgb(130, 130, 130);
            rjTextBox1.Location = new Point(76, 391);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.MinimumSize = new Size(50, 30);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(364, 43);
            rjTextBox1.TabIndex = 21;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            rjTextBox1._TextChanged += rjTextBox1__TextChanged;
            rjTextBox1.KeyDown += rjTextBox1_KeyDown;
            rjTextBox1.KeyPress += rjTextBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 193);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(359, 55);
            label2.TabIndex = 19;
            label2.Text = "Nueva Contraseña";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Carret_Left;
            pictureBox2.Location = new Point(28, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.MouseClick += pictureBox2_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.images_removebg_preview;
            pictureBox1.Location = new Point(205, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Quicksand", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(130, 130, 130);
            label4.Location = new Point(84, 276);
            label4.Name = "label4";
            label4.Size = new Size(120, 19);
            label4.TabIndex = 25;
            label4.Text = "Nueva contraseña";
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = Color.FromArgb(244, 238, 238);
            rjTextBox2.BorderColor = Color.Transparent;
            rjTextBox2.BorderFocusColor = Color.FromArgb(224, 224, 224);
            rjTextBox2.BorderRadius = 5;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Quicksand", 13.75F);
            rjTextBox2.ForeColor = Color.FromArgb(130, 130, 130);
            rjTextBox2.Location = new Point(76, 299);
            rjTextBox2.Margin = new Padding(4);
            rjTextBox2.MinimumSize = new Size(50, 30);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.Size = new Size(364, 43);
            rjTextBox2.TabIndex = 24;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(130, 130, 130);
            label1.Location = new Point(101, 534);
            label1.Name = "label1";
            label1.Size = new Size(308, 38);
            label1.TabIndex = 26;
            label1.Text = "*Esta acción será notificada al correo electronico\r\nasociado a esta cuenta\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Quicksand", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(159, 534);
            label5.Name = "label5";
            label5.Size = new Size(194, 38);
            label5.TabIndex = 27;
            label5.Text = "Las contraseñas no coinciden.\r\n Intente nuevamente";
            label5.Visible = false;
            // 
            // RestablecerContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 600);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(rjTextBox2);
            Controls.Add(rjButton1);
            Controls.Add(label3);
            Controls.Add(rjTextBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RestablecerContraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RestablecerContraseña";
            Load += RestablecerContraseña_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJButton rjButton1;
        private Label label3;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label4;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private Label label1;
        private Label label5;
    }
}