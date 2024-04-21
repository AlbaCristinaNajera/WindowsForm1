using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoCombustible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double distncia = double.Parse(txtDistancia.Text.ToString());
            double rendimiento = double.Parse(txtRendimiento.Text.ToString());

            double galonesConsumidos = distncia / rendimiento;

            lblResultado.Text = $"La cantidad de galones consumidos es de: {galonesConsumidos:N2}";
        }

    }
}
