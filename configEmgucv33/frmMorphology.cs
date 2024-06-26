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
using System.Diagnostics;

namespace configEmgucv33
{
    public partial class frmMorphology : Form
    {
        public frmMorphology()
        {
            InitializeComponent();
        }

        Image<Bgr, byte> inputImg;
        Image<Bgr, byte> colorImg;
        Image<Gray, byte> binaryImg, morphoImg;

        private void erotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgbInput.Image != null)
            {
                colorImg = new Image<Bgr, byte>(inputImg.Width, inputImg.Height);
                colorImg = inputImg.Dilate(3);
                imgbOutput.Image = colorImg;
            }
            else
            {
                MessageBox.Show("There is no image");
            }
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }
        private void dialationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgbInput.Image != null)
            {
                colorImg = new Image<Bgr, byte>(inputImg.Width, inputImg.Height);
                colorImg = inputImg.Erode(5);

                imgbOutput.Image = colorImg;
            }
            else
            {
                MessageBox.Show("There is no image");
            }
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgbInput.Image != null)
            {
                colorImg = new Image<Bgr, byte>(inputImg.Width, inputImg.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3,3), new Point(-1,-1));
                colorImg = inputImg.MorphologyEx(MorphOp.Open, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                imgbOutput.Image = colorImg;
            }
            else
            {
                MessageBox.Show("There is no image");
            }

        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgbInput.Image != null)
            {
                colorImg = new Image<Bgr, byte>(inputImg.Width, inputImg.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3,3), new Point(-1,-1));
                colorImg = inputImg.MorphologyEx(MorphOp.Close, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                imgbOutput.Image = colorImg;
            }
            else
            {
                MessageBox.Show("There is no image");
            }
        }

        private void gradianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgbInput.Image != null)
            {
                colorImg = new Image<Bgr, byte>(inputImg.Width, inputImg.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3,3), new Point(-1,-1));
                colorImg = inputImg.MorphologyEx(MorphOp.Gradient, kernel, new Point(-1,-1), 1, BorderType.Default, new MCvScalar(1.0));
                imgbOutput.Image = colorImg;
            }
            else
            {
                MessageBox.Show("There is no image");
            }
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgbInput.Image != null)
            {
                colorImg = new Image<Bgr, byte>(inputImg.Width, inputImg.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                colorImg = inputImg.MorphologyEx(MorphOp.Tophat, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                imgbOutput.Image = colorImg;
            }
            else
            {
                MessageBox.Show("There is no image");
            }
        }

        private void blackHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgbInput.Image != null)
            {
                colorImg = new Image<Bgr, byte>(inputImg.Width, inputImg.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                colorImg = inputImg.MorphologyEx(MorphOp.Blackhat, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                imgbOutput.Image = colorImg;
            }
            else
            {
                MessageBox.Show("There is no image");
            }
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgbInput.Image != null)
            {
                binaryImg = new Image<Gray, byte>(inputImg.Width, inputImg.Height);
                binaryImg = inputImg.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(50), new Gray(255)).Dilate(1);

                imgbOutput.Image=binaryImg;
            }
            else
            {
                MessageBox.Show("There is no image");
            }
        }

        private void erotionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            binaryImg = new Image<Gray, byte>(inputImg.Width, inputImg.Height);
            binaryImg = inputImg.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(50), new Gray(255)).Erode(1);
            imgbOutput.Image=binaryImg;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try{
                if (imgbInput.Image != null)
                {

                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Title = "Save Morphology image";
                    sfd.Filter = "Jpeg Files(*.jpg)|*.jpg|Bitmap Files(*.bmp)|*.bmp|Png Files(*.png)|*.png";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        imgbOutput.Image.Save(sfd.FileName);
                        MessageBox.Show("Image Save");
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
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == DialogResult.OK)
            {
                inputImg = new Image<Bgr, byte>(opd.FileName);
                imgbInput.Image = inputImg;
                imgbOutput.Image = null;
            }
        }
    }
}
