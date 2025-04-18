namespace UI.Paneles.Avisos.Clientes
{
    partial class ReactivarCliente
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
            label6 = new Label();
            rjButton1 = new CustomControls.RJControls.RJButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ReactivarCliente;
            pictureBox1.InitialImage = Properties.Resources.EliminarCliente;
            pictureBox1.Location = new Point(120, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(16, 83, 233);
            label6.Location = new Point(92, 213);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 10;
            label6.Text = "No, cancelar";
            label6.Click += label6_Click;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
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
            rjButton1.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(63, 170);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(167, 40);
            rjButton1.TabIndex = 9;
            rjButton1.Text = "Si, reactivar";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Montserrat Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(53, 90);
            label1.Name = "label1";
            label1.Size = new Size(193, 25);
            label1.TabIndex = 8;
            label1.Text = "¿Quieres reactivarlo?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Montserrat", 12F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(60, 112);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 12;
            label2.Text = "Parece que el cliente\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Montserrat", 12F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(71, 133);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 13;
            label3.Text = "está dado de baja";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReactivarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 262);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(rjButton1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReactivarCliente";
            ShowInTaskbar = false;
            Text = "ReactivarCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label6;
        private CustomControls.RJControls.RJButton rjButton1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}