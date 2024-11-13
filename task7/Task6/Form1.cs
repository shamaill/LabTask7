using System;
using System.Windows.Forms;

namespace CountdownApp
{
    public partial class Form1 : Form
    {
        private int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timeLeft = int.Parse(txtTimeSet.Text);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lblTimeLeft.Text = $"{timeLeft} Seconds";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Time Over!");
            }
        }
    }
}
