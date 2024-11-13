using System;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double fahrenheit = Convert.ToDouble(txtFahrenheit.Text);
            double celsius = (fahrenheit - 32) * 5 / 9;
            txtCelsius.Text = celsius.ToString("F2");
        }
    }
}
