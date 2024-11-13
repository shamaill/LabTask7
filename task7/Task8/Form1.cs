using System;
using System.IO;
using System.Windows.Forms;

namespace PhotoViewerApp
{
    public partial class Form1 : Form
    {
        private string[] files;
        private int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            files = Directory.GetFiles(txtLocation.Text, "*.jpg");
            DisplayPhoto();
        }

        private void DisplayPhoto()
        {
            if (files.Length > 0)
            {
                pictureBox1.ImageLocation = files[currentIndex];
                lblTotalPhotos.Text = $"Total Photos: {files.Length}";
            }
        }
    }
}
