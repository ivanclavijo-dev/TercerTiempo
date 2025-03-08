using UI.Componentes;

namespace UI
{
    partial class TercerTiempo
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
            contenedorVistas = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel9 = new Panel();
            estadisticasLabel = new Label();
            pictureBox6 = new PictureBox();
            panel8 = new Panel();
            empleadosLabel = new Label();
            pictureBox5 = new PictureBox();
            panel7 = new Panel();
            productosLabel = new Label();
            pictureBox4 = new PictureBox();
            panel6 = new Panel();
            clientesLabel = new Label();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            bindingSource1 = new BindingSource(components);
            pictureBox7 = new PictureBox();
            elipseControl1 = new ElipseControl();
            pictureBox8 = new PictureBox();
            elipseControl2 = new ElipseControl();
            elipseControl3 = new ElipseControl();
            elipseControl4 = new ElipseControl();
            label2 = new Label();
            pictureBox9 = new PictureBox();
            label3 = new Label();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // contenedorVistas
            // 
            contenedorVistas.Location = new Point(184, 84);
            contenedorVistas.Name = "contenedorVistas";
            contenedorVistas.Size = new Size(960, 616);
            contenedorVistas.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images_removebg_preview;
            pictureBox1.Location = new Point(21, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 700);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 558);
            panel4.Name = "panel4";
            panel4.Size = new Size(186, 142);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(0, 224);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 284);
            panel3.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(estadisticasLabel);
            panel9.Controls.Add(pictureBox6);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 212);
            panel9.Name = "panel9";
            panel9.Size = new Size(185, 53);
            panel9.TabIndex = 6;
            // 
            // estadisticasLabel
            // 
            estadisticasLabel.AutoSize = true;
            estadisticasLabel.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            estadisticasLabel.Location = new Point(66, 14);
            estadisticasLabel.Name = "estadisticasLabel";
            estadisticasLabel.Size = new Size(97, 24);
            estadisticasLabel.TabIndex = 0;
            estadisticasLabel.Text = "Estadisticas";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.bar_chart_13;
            pictureBox6.Location = new Point(36, 14);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 25);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(empleadosLabel);
            panel8.Controls.Add(pictureBox5);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 159);
            panel8.Name = "panel8";
            panel8.Size = new Size(185, 53);
            panel8.TabIndex = 5;
            // 
            // empleadosLabel
            // 
            empleadosLabel.AutoSize = true;
            empleadosLabel.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empleadosLabel.Location = new Point(66, 14);
            empleadosLabel.Name = "empleadosLabel";
            empleadosLabel.Size = new Size(95, 24);
            empleadosLabel.TabIndex = 0;
            empleadosLabel.Text = "Empleados";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.users;
            pictureBox5.Location = new Point(36, 14);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(productosLabel);
            panel7.Controls.Add(pictureBox4);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 106);
            panel7.Name = "panel7";
            panel7.Size = new Size(185, 53);
            panel7.TabIndex = 4;
            // 
            // productosLabel
            // 
            productosLabel.AutoSize = true;
            productosLabel.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productosLabel.Location = new Point(66, 14);
            productosLabel.Name = "productosLabel";
            productosLabel.Size = new Size(86, 24);
            productosLabel.TabIndex = 0;
            productosLabel.Text = "Productos";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.list;
            pictureBox4.Location = new Point(36, 14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(clientesLabel);
            panel6.Controls.Add(pictureBox3);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 53);
            panel6.Name = "panel6";
            panel6.Size = new Size(185, 53);
            panel6.TabIndex = 3;
            // 
            // clientesLabel
            // 
            clientesLabel.AutoSize = true;
            clientesLabel.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientesLabel.Location = new Point(66, 14);
            clientesLabel.Name = "clientesLabel";
            clientesLabel.Size = new Size(67, 24);
            clientesLabel.TabIndex = 0;
            clientesLabel.Text = "Clientes";
            clientesLabel.Click += label2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user_03;
            pictureBox3.Location = new Point(36, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(pictureBox2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(185, 53);
            panel5.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 14);
            label1.Name = "label1";
            label1.Size = new Size(56, 24);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.home_01;
            pictureBox2.Location = new Point(36, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 146);
            panel2.TabIndex = 0;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = Color.FromArgb(246, 246, 246);
            rjTextBox1.BorderColor = Color.Transparent;
            rjTextBox1.BorderFocusColor = Color.Black;
            rjTextBox1.BorderRadius = 20;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox1.ForeColor = Color.FromArgb(130, 130, 130);
            rjTextBox1.Location = new Point(184, 25);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(549, 39);
            rjTextBox1.TabIndex = 3;
            rjTextBox1.Texts = "             Ingrese el nombre del producto o cliente que busca...";
            rjTextBox1.UnderlinedStyle = false;
            rjTextBox1._TextChanged += rjTextBox1__TextChanged;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(246, 246, 246);
            pictureBox7.Image = Properties.Resources.Search;
            pictureBox7.Location = new Point(206, 34);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(26, 22);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 4;
            pictureBox7.TabStop = false;
            // 
            // elipseControl1
            // 
            elipseControl1.BackColor = Color.FromArgb(246, 246, 246);
            elipseControl1.CornerRadius = 40;
            elipseControl1.Location = new Point(744, 25);
            elipseControl1.Name = "elipseControl1";
            elipseControl1.Size = new Size(73, 39);
            elipseControl1.TabIndex = 5;
            elipseControl1.Text = "elipseControl1";
            elipseControl1.Click += elipseControl1_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(246, 246, 246);
            pictureBox8.Image = Properties.Resources.notification;
            pictureBox8.Location = new Point(783, 32);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(24, 24);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 6;
            pictureBox8.TabStop = false;
            // 
            // elipseControl2
            // 
            elipseControl2.BackColor = Color.FromArgb(246, 246, 246);
            elipseControl2.CornerRadius = 40;
            elipseControl2.Location = new Point(826, 25);
            elipseControl2.Name = "elipseControl2";
            elipseControl2.Size = new Size(195, 39);
            elipseControl2.TabIndex = 7;
            elipseControl2.Text = "elipseControl2";
            // 
            // elipseControl3
            // 
            elipseControl3.BackColor = Color.FromArgb(246, 246, 246);
            elipseControl3.CornerRadius = 40;
            elipseControl3.Location = new Point(1028, 25);
            elipseControl3.Name = "elipseControl3";
            elipseControl3.Size = new Size(113, 39);
            elipseControl3.TabIndex = 8;
            elipseControl3.Text = "elipseControl3";
            elipseControl3.Click += elipseControl3_Click;
            // 
            // elipseControl4
            // 
            elipseControl4.BackColor = Color.FromArgb(37, 161, 240);
            elipseControl4.CornerRadius = 40;
            elipseControl4.Location = new Point(753, 31);
            elipseControl4.Name = "elipseControl4";
            elipseControl4.Size = new Size(28, 28);
            elipseControl4.TabIndex = 9;
            elipseControl4.Text = "elipseControl4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(37, 161, 240);
            label2.Font = new Font("Montserrat ExtraBold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(758, 34);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 10;
            label2.Text = "3";
            label2.Click += label2_Click_1;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(246, 246, 246);
            pictureBox9.Image = Properties.Resources.Avatar_3;
            pictureBox9.Location = new Point(855, 33);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(22, 22);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 11;
            pictureBox9.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(246, 246, 246);
            label3.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(883, 31);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 12;
            label3.Text = "Nacho Simois";
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(246, 246, 246);
            pictureBox10.Image = Properties.Resources.Vector_33;
            pictureBox10.Location = new Point(1056, 44);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(17, 2);
            pictureBox10.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox10.TabIndex = 13;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.FromArgb(246, 246, 246);
            pictureBox11.Image = Properties.Resources.Close_Icons_UIA;
            pictureBox11.Location = new Point(1090, 28);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(26, 34);
            pictureBox11.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox11.TabIndex = 14;
            pictureBox11.TabStop = false;
            // 
            // TercerTiempo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(label3);
            Controls.Add(pictureBox9);
            Controls.Add(label2);
            Controls.Add(elipseControl4);
            Controls.Add(elipseControl3);
            Controls.Add(elipseControl2);
            Controls.Add(pictureBox8);
            Controls.Add(elipseControl1);
            Controls.Add(pictureBox7);
            Controls.Add(rjTextBox1);
            Controls.Add(panel1);
            Controls.Add(contenedorVistas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TercerTiempo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += TercerTiempo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel contenedorVistas;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private ElipseControl elipseControl2;
        private Panel panel9;
        private Label estadisticasLabel;
        private PictureBox pictureBox6;
        private Panel panel8;
        private Label empleadosLabel;
        private PictureBox pictureBox5;
        private Panel panel7;
        private Label productosLabel;
        private PictureBox pictureBox4;
        private Panel panel6;
        private Label clientesLabel;
        private PictureBox pictureBox3;
        private Panel panel5;
        private Label label1;
        private PictureBox pictureBox2;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private BindingSource bindingSource1;
        private PictureBox pictureBox7;
        private ElipseControl elipseControl1;
        private PictureBox pictureBox8;
        private ElipseControl elipseControl3;
        private ElipseControl elipseControl4;
        private Label label2;
        private PictureBox pictureBox9;
        private Label label3;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
    }
}