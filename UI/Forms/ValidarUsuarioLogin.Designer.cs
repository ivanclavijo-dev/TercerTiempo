namespace UI.Forms
{
    partial class ValidarUsuarioLogin
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            rjButton1 = new CustomControls.RJControls.RJButton();
            labelError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.images_removebg_preview;
            pictureBox1.Location = new Point(201, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Carret_Left;
            pictureBox2.Location = new Point(24, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.MouseClick += pictureBox2_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 166);
            label2.Name = "label2";
            label2.Size = new Size(455, 75);
            label2.TabIndex = 4;
            label2.Text = "Valida tu usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(88, 237);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(317, 50);
            label1.TabIndex = 5;
            label1.Text = "Para poder reestablecer tu contraseña,\r\n primero necesitaremos identificarte";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
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
            rjTextBox1.Location = new Point(72, 378);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.MinimumSize = new Size(50, 30);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(364, 43);
            rjTextBox1.TabIndex = 6;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(130, 130, 130);
            label3.Location = new Point(80, 355);
            label3.Name = "label3";
            label3.Size = new Size(225, 19);
            label3.TabIndex = 7;
            label3.Text = "ID de usuario o Cedula de Identidad";
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
            rjButton1.Location = new Point(72, 471);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(364, 53);
            rjButton1.TabIndex = 16;
            rjButton1.Text = "Validar";
            rjButton1.TextColor = Color.WhiteSmoke;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.MouseClick += rjButton1_MouseClick_1;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Quicksand", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(153, 425);
            labelError.Name = "labelError";
            labelError.Size = new Size(190, 19);
            labelError.TabIndex = 17;
            labelError.Text = "No existe el usuario ingresado";
            labelError.Visible = false;
            // 
            // ValidarUsuarioLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 600);
            Controls.Add(labelError);
            Controls.Add(rjButton1);
            Controls.Add(label3);
            Controls.Add(rjTextBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ValidarUsuarioLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ValidarUsuarioLogin";
            Load += ValidarUsuarioLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private Label label3;
        private CustomControls.RJControls.RJButton rjButton1;
        private Label labelError;
    }
}