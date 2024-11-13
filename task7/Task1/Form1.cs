using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => a + b);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => a - b);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => a * b);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => a / b);
        }

        private void PerformOperation(Func<double, double, double> operation)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            double result = operation(num1, num2);
            txtResult.Text = result.ToString();
        }
    }
}
