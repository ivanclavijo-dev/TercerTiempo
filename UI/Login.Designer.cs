namespace UI
{
    partial class Login
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            label5 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            rjButton1 = new CustomControls.RJControls.RJButton();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Montserrat", 32.9999962F, FontStyle.Bold);
            label1.Location = new Point(516, 173);
            label1.Name = "label1";
            label1.Size = new Size(385, 61);
            label1.TabIndex = 1;
            label1.Text = "Inicio de Sesión";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images_removebg_preview;
            pictureBox1.Location = new Point(652, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(130, 130, 130);
            label2.Location = new Point(507, 237);
            label2.Name = "label2";
            label2.Size = new Size(413, 62);
            label2.TabIndex = 2;
            label2.Text = "¡Bienvenid@ de nuevo! Por favor, ingrese\r\nsus credenciales.";
            label2.Click += label2_Click_1;
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
            rjTextBox1.Location = new Point(536, 362);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.MinimumSize = new Size(50, 30);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(364, 43);
            rjTextBox1.TabIndex = 3;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            rjTextBox1._TextChanged += rjTextBox1__TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(130, 130, 130);
            label3.Location = new Point(540, 330);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 4;
            label3.Text = "Usuario";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Quicksand", 14F);
            label4.ForeColor = Color.FromArgb(130, 130, 130);
            label4.Location = new Point(540, 414);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Component_11;
            pictureBox2.Location = new Point(-6, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(443, 700);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
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
            rjTextBox2.Location = new Point(536, 446);
            rjTextBox2.Margin = new Padding(4);
            rjTextBox2.MinimumSize = new Size(50, 30);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = true;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.Size = new Size(364, 43);
            rjTextBox2.TabIndex = 8;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(130, 130, 130);
            label5.Location = new Point(540, 498);
            label5.Name = "label5";
            label5.Size = new Size(201, 24);
            label5.TabIndex = 9;
            label5.Text = "¿Olvidaste tu contraseña?";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Quicksand", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(130, 130, 130);
            label6.Location = new Point(736, 498);
            label6.Name = "label6";
            label6.Size = new Size(135, 24);
            label6.TabIndex = 10;
            label6.Text = "Restablecer aquí";
            label6.MouseClick += label6_MouseClick;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(244, 238, 238);
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.eye;
            pictureBox3.Location = new Point(865, 460);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 19);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.MouseClick += pictureBox3_MouseClick;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(244, 238, 238);
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.eye_slash;
            pictureBox4.Location = new Point(865, 460);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 19);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            pictureBox4.MouseClick += pictureBox4_MouseClick;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(0, 65, 212);
            rjButton1.BackgroundColor = Color.FromArgb(0, 65, 212);
            rjButton1.BorderColor = Color.FromArgb(0, 65, 212);
            rjButton1.BorderRadius = 20;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Quicksand SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.WhiteSmoke;
            rjButton1.Location = new Point(540, 560);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(348, 68);
            rjButton1.TabIndex = 15;
            rjButton1.Text = "Ingresar";
            rjButton1.TextColor = Color.WhiteSmoke;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            rjButton1.MouseClick += rjButton1_MouseClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Quicksand", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(603, 538);
            label7.Name = "label7";
            label7.Size = new Size(216, 19);
            label7.TabIndex = 28;
            label7.Text = "Los valores ingresados no existen.";
            label7.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(979, 700);
            Controls.Add(label7);
            Controls.Add(rjButton1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(rjTextBox2);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rjTextBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            KeyDown += Login_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private CustomControls.RJControls.RJButton rjButton1;
        private Label label7;
    }
}