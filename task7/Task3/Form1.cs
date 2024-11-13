using System;
using System.Windows.Forms;

namespace SquareApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                int square = i * i;
                listBox1.Items.Add($"{i} \t {square}");
            }
        }
    }
}
