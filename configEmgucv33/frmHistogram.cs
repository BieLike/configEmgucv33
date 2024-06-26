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
using Emgu.Util;
using Emgu.CV.Structure;

namespace configEmgucv33
{
    public partial class frmHistogram : Form
    {
        public frmHistogram()
        {
            InitializeComponent();
        }

        Image<Bgr, byte> oriImage;
        Image<Gray, byte> R;
        Image<Gray, byte> G;
        Image<Gray, byte> B;

        private void histogramBox2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            FileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                oriImage = new Image<Bgr, byte>(openFile.FileName);
                B = oriImage[0];
                G = oriImage[1];
                R = oriImage[2];
                imgbR.Image = R;
                imgbG.Image = G;
                imgbB.Image = B;
            }

            htgbR.ClearHistogram();
            htgbG.ClearHistogram();
            htgbB.ClearHistogram();
            htgbR.Refresh();
            htgbG.Refresh();
            htgbB.Refresh();
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            if (oriImage == null)
            {
                MessageBox.Show("Please select an Image", "Problem found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            htgbR.ClearHistogram();
            htgbG.ClearHistogram();
            htgbB.ClearHistogram();
            htgbR.GenerateHistograms(R, 256);
            htgbG.GenerateHistograms(G, 256);
            htgbB.GenerateHistograms(B, 256);
            htgbR.Refresh();
            htgbG.Refresh();
            htgbB.Refresh();

        }

        private void htgbR_Load(object sender, EventArgs e)
        {
            
        }

        private void htgbB_Load(object sender, EventArgs e)
        {
            
        }

        private void imgbR_Click(object sender, EventArgs e)
        {
        }

        private void imgbG_Click(object sender, EventArgs e)
        {
        }

        private void imgbB_Click(object sender, EventArgs e)
        {
        }
    }
}
