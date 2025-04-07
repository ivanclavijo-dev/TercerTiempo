namespace UI.Paneles.Desplegable
{
    partial class Informacion
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
            Titulo = new Label();
            Contenido = new Label();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Montserrat Medium", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(12, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(175, 20);
            Titulo.TabIndex = 0;
            Titulo.Text = "Formato de la entrada";
            // 
            // Contenido
            // 
            Contenido.AutoSize = true;
            Contenido.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Contenido.Location = new Point(10, 27);
            Contenido.Name = "Contenido";
            Contenido.Size = new Size(199, 25);
            Contenido.TabIndex = 1;
            Contenido.Text = "Formato de la entrada";
            // 
            // Informacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(216, 69);
            Controls.Add(Contenido);
            Controls.Add(Titulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Informacion";
            Text = "Informacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Label Contenido;
    }
}