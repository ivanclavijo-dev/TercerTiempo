using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logica;
using Entidades;
using Persistencia.Empleado;
using Logica.BD;
using System.Windows.Forms.DataVisualization.Charting;
namespace UI.Forms
{
    public partial class Home : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse
           );

        public Home()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelFecha_Click(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            pictureBox2.Parent = elipseControl1;
            pictureBox2.BackColor
                = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        consultasBD consultas = new consultasBD();
        private void Home_Load(object sender, EventArgs e)
        {
            label1.Text = $"Hola de nuevo, " + SesionUsuario.EmpleadoActual.DatosPersonales.Nombre + "!";
            labelNumClientesTotales.Text = consultas.ObtenerNumeroClientesTotales().ToString();
            labelProductosVendidos.Text = consultas.ObtenerNumeroVentasMes().ToString();
            labelIngresosUltimoMes.Text = consultas.ObtenerIngresosMesAnterior().ToString();

            DataTable tabla = consultas.ObtenerRangosEdad();
            if (tabla.Rows.Count > 0)
            {
                int rango1 = Convert.ToInt32(tabla.Rows[0]["rango_15_18"]);
                int rango2 = Convert.ToInt32(tabla.Rows[0]["rango_19_30"]);
                int rango3 = Convert.ToInt32(tabla.Rows[0]["rango_mayor_30"]);

                // Limpiar el chart
                chart1.Series.Clear();
                chart1.Legends.Clear(); // Limpiar leyendas previas

                // Crear serie para el gráfico
                Series series = new Series("Edades");
                series.ChartType = SeriesChartType.Pie;
                series.Font = new Font("Quicksand", 12, FontStyle.Bold);
                series.LabelForeColor = Color.White;

                // Agregar los puntos al gráfico
                series.Points.AddXY("15 a 18", rango1);
                series.Points.AddXY("19 a 30", rango2);
                series.Points.AddXY(">30", rango3);

                // Asignar colores personalizados a las porciones
                series.Points[0].Color = ColorTranslator.FromHtml("#1079F0");
                series.Points[1].Color = ColorTranslator.FromHtml("#5F5F5F");
                series.Points[2].Color = ColorTranslator.FromHtml("#93A6BD");

                // Personalizar las etiquetas para que solo muestren la cantidad dentro del gráfico
                foreach (DataPoint point in series.Points)
                {
                    point.Label = "#VALY";  // Mostrar solo el valor dentro del gráfico
                }

                // Agregar la serie al gráfico
                chart1.Series.Add(series);

                // Desactivar efecto 3D para una mejor presentación
                chart1.ChartAreas[0].Area3DStyle.Enable3D = false;

                // Ajustar la posición del gráfico
                chart1.ChartAreas[0].Position.X = 0;   // Ajustar la posición horizontal
                chart1.ChartAreas[0].Position.Y = 10;  // Ajustar la posición vertical
                chart1.ChartAreas[0].Position.Width = 50; // Reducir el tamaño del gráfico para dar espacio a la leyenda
                chart1.ChartAreas[0].Position.Height = 80;

                // Configurar la leyenda para que aparezca al lado del gráfico, alineada al centro
                Legend legend = new Legend("Leyenda");
                legend.Docking = Docking.Right; // Ubicar la leyenda a la derecha del gráfico
                legend.Alignment = StringAlignment.Center; // Centrar la leyenda verticalmente
                legend.Font = new Font("Quicksand", 10, FontStyle.Bold); // Personalizar la fuente
                legend.ForeColor = ColorTranslator.FromHtml("#BAB8B8");
                chart1.Legends.Add(legend);

                // Asignar la leyenda a la serie y mantener los nombres de los grupos de edad
                series.Legend = "Leyenda";
                series.Points[0].LegendText = "15 a 18";
                series.Points[1].LegendText = "19 a 30";
                series.Points[2].LegendText = ">30";
            }







        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void hora_Tick(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void elipseControl2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
