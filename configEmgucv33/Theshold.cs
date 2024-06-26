using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;

namespace configEmgucv33
{
    public partial class Theshold : Form
    {
        public Theshold()
        {
            InitializeComponent();
        }

        Image<Bgr, byte> oriImg;
        Image<Gray, byte> grayImg, binaryImg;

        private void cmbTheshold_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTheshold.SelectedIndex == 0)
            {
                binaryImg = grayImg.ThresholdBinary(new Gray(100), new Gray(255));
                imgBinary.Image = binaryImg;
            }
            else if (cmbTheshold.SelectedIndex == 1)
            {
                binaryImg = grayImg.ThresholdBinaryInv(new Gray(100), new Gray(255));
                imgBinary.Image = binaryImg;
            }
            else if (cmbTheshold.SelectedIndex == 2)
            {
                binaryImg = grayImg.ThresholdToZero(new Gray(100));
                imgBinary.Image = binaryImg;
            }
            else if (cmbTheshold.SelectedIndex == 3)
            {
                binaryImg = grayImg.ThresholdAdaptive(new Gray(100), AdaptiveThresholdType.GaussianC, ThresholdType.Binary, 9, new Gray(10));
                imgBinary.Image = binaryImg;
            }
            else
            {
                binaryImg = grayImg.ThresholdAdaptive(new Gray(100), AdaptiveThresholdType.MeanC, ThresholdType.Binary, 9/*Boxsize*/, new Gray(10)/*param*/);
                imgBinary.Image = binaryImg;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                oriImg = new Image<Bgr, byte>(opf.FileName);
                grayImg = oriImg.Convert<Gray, byte>();
                imgInput.Image = oriImg;
                imgGray.Image = grayImg;
                imgBinary.Image = null;
                cmbTheshold.SelectedText = "Select BlaclkWhite Image";
                    }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Threshold Save";
            sfd.DefaultExt = "*.jpg";
            sfd.Filter = "Jpeg Files (*.jpg)|*.jpg|PNG Files(*.png)|*.jpn|Bmp Files(*.bmp)|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                binaryImg.Save(sfd.FileName);
                MessageBox.Show("Save !!!");
            }

        }

        private void Theshold_Load(object sender, EventArgs e)
        {

        }
    }
}
