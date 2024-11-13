using System;
using System.Windows.Forms;

namespace TextLimitApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtInput.MaxLength = 160;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblCharCount.Text = $"Characters Left: {160 - txtInput.Text.Length}";
        }
    }
}
