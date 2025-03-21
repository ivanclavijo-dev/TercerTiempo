namespace UI.Paneles.Avisos
{
    partial class ConfirmarBajaProducto
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
            estadoCuotaCliente = new Label();
            nombreCliente = new Label();
            idCliente = new Label();
            label6 = new Label();
            rjButton1 = new CustomControls.RJControls.RJButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // estadoCuotaCliente
            // 
            estadoCuotaCliente.AutoSize = true;
            estadoCuotaCliente.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            estadoCuotaCliente.ForeColor = Color.Silver;
            estadoCuotaCliente.Location = new Point(339, 269);
            estadoCuotaCliente.Name = "estadoCuotaCliente";
            estadoCuotaCliente.Size = new Size(28, 40);
            estadoCuotaCliente.TabIndex = 19;
            estadoCuotaCliente.Text = "-";
            // 
            // nombreCliente
            // 
            nombreCliente.AutoSize = true;
            nombreCliente.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombreCliente.Location = new Point(339, 227);
            nombreCliente.Name = "nombreCliente";
            nombreCliente.Size = new Size(28, 40);
            nombreCliente.TabIndex = 18;
            nombreCliente.Text = "-";
            // 
            // idCliente
            // 
            idCliente.AutoSize = true;
            idCliente.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idCliente.Location = new Point(339, 187);
            idCliente.Name = "idCliente";
            idCliente.Size = new Size(28, 40);
            idCliente.TabIndex = 17;
            idCliente.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(233, 387);
            label6.Name = "label6";
            label6.Size = new Size(112, 22);
            label6.TabIndex = 16;
            label6.Text = "No, cancelar";
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
            rjButton1.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(69, 338);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(434, 40);
            rjButton1.TabIndex = 15;
            rjButton1.Text = "Si, eliminar";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(69, 269);
            label5.Name = "label5";
            label5.Size = new Size(97, 40);
            label5.TabIndex = 14;
            label5.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(69, 227);
            label4.Name = "label4";
            label4.Size = new Size(138, 40);
            label4.TabIndex = 13;
            label4.Text = "Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 185);
            label3.Name = "label3";
            label3.Size = new Size(234, 40);
            label3.TabIndex = 12;
            label3.Text = "ID del producto: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Montserrat", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(1, 16, 83, 233);
            label1.Location = new Point(69, 45);
            label1.Name = "label1";
            label1.Size = new Size(430, 66);
            label1.TabIndex = 10;
            label1.Text = "¿Desea eliminar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Montserrat", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(1, 16, 83, 233);
            label2.Location = new Point(124, 100);
            label2.Name = "label2";
            label2.Size = new Size(342, 66);
            label2.TabIndex = 11;
            label2.Text = "el producto?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConfirmarBajaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 461);
            Controls.Add(estadoCuotaCliente);
            Controls.Add(nombreCliente);
            Controls.Add(idCliente);
            Controls.Add(label6);
            Controls.Add(rjButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmarBajaProducto";
            Text = "ConfirmarVentaProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label estadoCuotaCliente;
        private Label nombreCliente;
        private Label idCliente;
        private Label label6;
        private CustomControls.RJControls.RJButton rjButton1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}