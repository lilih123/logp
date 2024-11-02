using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pag16_ex11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double tempC, tempK, tempF;

            tempC = double.Parse(txtCelsius.Text);

            tempF = 9 / 5 * tempC + 32;
            tempK = tempC + 273; 

            txtFahrenheit.Text = tempF.ToString();
            txtKelvin.Text = tempK.ToString();


            txtCelsius.Text = tempC + "°";
            txtFahrenheit.Text = tempF + "°";
            txtKelvin.Text = tempK + "K";

        }
    }
}
