using System;
using System.Windows.Forms;

namespace FactorialCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumber.Text);
            int factorial = CalculateFactorial(number);
            txtFactorial.Text = factorial.ToString();
        }

        private int CalculateFactorial(int n)
        {
            if (n <= 1) return 1;
            return n * CalculateFactorial(n - 1);
        }
    }
}
