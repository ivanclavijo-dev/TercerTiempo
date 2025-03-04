namespace UI.Forms
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            elipseControl1 = new View.Components.ElipseControl();
            elipseControl2 = new View.Components.ElipseControl();
            elipseControl3 = new View.Components.ElipseControl();
            label1 = new Label();
            labelFecha = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            elipseComponent1 = new View.Components.ElipseComponent();
            button1 = new Button();
            label2 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            hora = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // elipseControl1
            // 
            elipseControl1.BackColor = Color.FromArgb(72, 128, 255);
            elipseControl1.CornerRadius = 30;
            elipseControl1.Location = new Point(77, 67);
            elipseControl1.Name = "elipseControl1";
            elipseControl1.Size = new Size(858, 236);
            elipseControl1.TabIndex = 0;
            elipseControl1.Text = "elipseControl1";
            // 
            // elipseControl2
            // 
            elipseControl2.BackColor = Color.White;
            elipseControl2.CornerRadius = 30;
            elipseControl2.Location = new Point(77, 309);
            elipseControl2.Name = "elipseControl2";
            elipseControl2.Size = new Size(180, 236);
            elipseControl2.TabIndex = 2;
            elipseControl2.Text = "elipseControl2";
            // 
            // elipseControl3
            // 
            elipseControl3.BackColor = Color.White;
            elipseControl3.CornerRadius = 30;
            elipseControl3.Location = new Point(263, 309);
            elipseControl3.Name = "elipseControl3";
            elipseControl3.Size = new Size(672, 236);
            elipseControl3.TabIndex = 3;
            elipseControl3.Text = "elipseControl3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(72, 128, 255);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Montserrat", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(148, 104);
            label1.Name = "label1";
            label1.Size = new Size(454, 51);
            label1.TabIndex = 4;
            label1.Text = "Hola de nuevo, Nacho!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.BackColor = Color.FromArgb(72, 128, 255);
            labelFecha.Font = new Font("Quicksand Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFecha.ForeColor = Color.White;
            labelFecha.Location = new Point(155, 85);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(102, 24);
            labelFecha.TabIndex = 5;
            labelFecha.Text = "labelFecha";
            labelFecha.Click += labelFecha_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(72, 128, 255);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Quicksand", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(154, 144);
            label3.Name = "label3";
            label3.Size = new Size(379, 31);
            label3.TabIndex = 8;
            label3.Text = "La persistencia es el camino al éxito";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(72, 128, 255);
            pictureBox1.Image = Properties.Resources.undraw_athletes_training_koqa__1__Photoroom;
            pictureBox1.Location = new Point(618, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // elipseComponent1
            // 
            elipseComponent1.CornerRadius = 20;
            elipseComponent1.TargetControl = button1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Quicksand Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(154, 198);
            button1.Name = "button1";
            button1.Size = new Size(447, 67);
            button1.TabIndex = 10;
            button1.Text = "Añadir un cliente nuevo.";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(130, 454);
            label2.Name = "label2";
            label2.Size = new Size(78, 40);
            label2.TabIndex = 12;
            label2.Text = "1500";
            label2.Click += label2_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(86, 397);
            label4.Name = "label4";
            label4.Size = new Size(166, 26);
            label4.TabIndex = 13;
            label4.Text = "Clientes totales";
            label4.Click += label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.customer__1_;
            pictureBox2.Location = new Point(136, 333);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 61);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // hora
            // 
            hora.Enabled = true;
            hora.Tick += hora_Tick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1020, 645);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(labelFecha);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(elipseControl3);
            Controls.Add(elipseControl2);
            Controls.Add(elipseControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private View.Components.ElipseControl elipseControl1;
        private View.Components.ElipseControl elipseControl2;
        private View.Components.ElipseControl elipseControl3;
        private Label label1;
        private Label labelFecha;
        private Label label3;
        private PictureBox pictureBox1;
        private View.Components.ElipseComponent elipseComponent1;
        private Button button1;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer hora;
    }
}