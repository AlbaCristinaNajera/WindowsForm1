using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeViajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double velocidad= int.Parse(txtVelocidad.Text.ToString());
            double distancia = 100;
            double tiempoEstimado = distancia / velocidad;

            MessageBox.Show($"El tiempo estimado de viaje de {txtOrigen.Text} a {txtDestino.Text} es de aproximadamente {tiempoEstimado:N2} horas.", "Tiempo Estimado de Viaje");
        }
    }
}
