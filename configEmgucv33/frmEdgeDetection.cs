using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;

namespace configEmgucv33
{
    public partial class frmEdgeDetection : Form
    {
        Image<Bgr, byte> inputImg;
        Image<Gray, byte> cannyImg;
        Image<Gray, float> sobelImg, lapacianImg;
        public frmEdgeDetection()
        {
            InitializeComponent();
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgbInput.Image != null)
            {
                cannyImg = inputImg.Convert<Gray, byte>().Canny(150, 10);
                imgbOutput.Image = cannyImg;
            }
            else
            {
                MessageBox.Show("There is no image");
            }
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgbInput.Image != null)
            {
                sobelImg = inputImg.Convert<Gray, float>().Sobel(1, 1, 5);
                imgbOutput.Image= sobelImg;
            }
            else
            {
                MessageBox.Show("There is no image");
            }
        }

        private void lapacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgbInput.Image != null)
            {
                lapacianImg = inputImg.Convert<Gray, float>().Laplace(5);
                imgbOutput.Image = lapacianImg;
            }
            else
            {
                MessageBox.Show("There is no image");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgbInput.Image != null)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Title = "Save Edge Detection";
                    sfd.Filter = ".Jpeg Files(*.jpg)|*jpg|Bitmap Files(*.bmp)|*.bmp|Png File(*.png)|*.png";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        imgbOutput.Image.Save(sfd.FileName);
                        MessageBox.Show("Save Complete !!");

                    }
                }
                else
                {
                    MessageBox.Show("There is no image");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                inputImg = new Image<Bgr, byte>(ofd.FileName);
                imgbInput.Image = inputImg;
            }

        }

    }
}
