namespace UI.Paneles.Avisos
{
    partial class ConfirmaBajaCliente
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
            rjButton1 = new CustomControls.RJControls.RJButton();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Montserrat Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(63, 101);
            label1.Name = "label1";
            label1.Size = new Size(169, 50);
            label1.TabIndex = 0;
            label1.Text = "¿Desea elminar el \r\ncliente?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(244, 54, 20);
            rjButton1.BackgroundColor = Color.FromArgb(244, 54, 20);
            rjButton1.BorderColor = Color.FromArgb(244, 54, 20);
            rjButton1.BorderRadius = 20;
            rjButton1.BorderSize = 0;
            rjButton1.Cursor = Cursors.Hand;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(63, 169);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(167, 40);
            rjButton1.TabIndex = 5;
            rjButton1.Text = "Si, eliminar";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(244, 54, 20);
            label6.Location = new Point(92, 212);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 6;
            label6.Text = "No, cancelar";
            label6.Click += label6_Click;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.EliminarCliente;
            pictureBox1.InitialImage = Properties.Resources.EliminarCliente;
            pictureBox1.Location = new Point(120, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // ConfirmaBajaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(301, 262);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(rjButton1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmaBajaCliente";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmaBajaCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CustomControls.RJControls.RJButton rjButton1;
        private Label label6;
        private PictureBox pictureBox1;
    }
}