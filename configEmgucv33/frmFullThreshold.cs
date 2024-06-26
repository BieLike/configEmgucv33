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
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;

namespace configEmgucv33
{
    public partial class frmFullThreshold : Form
    {
        public frmFullThreshold()
        {
            InitializeComponent();
        }
        Image<Bgr, byte> oriImg;
        Image<Gray, byte> GImg, BnyImg;
        private void frmFullThreshold_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbST_SelectedIndexChanged(object sender, EventArgs e)
        {
            int thre;

            if (txtThre.Text == "")
            {
                MessageBox.Show("Please input threshold", "Missing input data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbST.SelectedIndex == 0)
            {
                thre = int.Parse(txtThre.Text);
                BnyImg = GImg.ThresholdBinary(new Gray(thre), new Gray(255));
                imgBinary.Image = BnyImg;
                cmbAT.Text = "Select adaptive";
                txtParam.Text = "";
                txtBoxSize.Text = "";
            }
            else if (cmbST.SelectedIndex == 1)
            {
                thre = int.Parse(txtThre.Text);
                BnyImg = GImg.ThresholdBinaryInv(new Gray(thre), new Gray(255));
                imgBinary.Image = BnyImg;
                cmbAT.Text = "Select adaptive";
                txtParam.Text = "";
                txtBoxSize.Text = "";
            }
            else if (cmbST.SelectedIndex == 2)
            {
                thre = int.Parse(txtThre.Text);
                BnyImg = GImg.ThresholdToZero(new Gray(thre));
                imgBinary.Image = BnyImg;
                cmbAT.Text = "Select adaptive";
                txtParam.Text = "";
                txtBoxSize.Text = "";
            }
        }

        private void cmbST_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cmbAT_SelectedIndexChanged(object sender, EventArgs e)
        {
                int bz, param;

            if (txtBoxSize.Text == "" || txtParam.Text == "")
            {
                MessageBox.Show("Please input box size and parameter", "Missing input data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((int.Parse(txtBoxSize.Text)) % 2 == 0)
            {
                MessageBox.Show("Please input odd number in box size", "Wrong input data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (int.Parse(txtBoxSize.Text) < 3)
            {
                MessageBox.Show("Box size must greater than 2", "Wrong input data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (cmbAT.SelectedIndex == 0)
                {
                    bz = int.Parse(txtBoxSize.Text);
                    param = int.Parse(txtParam.Text);
                    BnyImg = GImg.ThresholdAdaptive(new Gray(100), AdaptiveThresholdType.GaussianC, ThresholdType.Binary, bz, new Gray(param));
                    imgBinary.Image = BnyImg;
                    cmbST.Text = "Select simple";
                    txtThre.Text = "";

                }
                else if (cmbAT.SelectedIndex == 1)
                {
                    bz = int.Parse(txtBoxSize.Text);
                    param = int.Parse(txtParam.Text);
                    BnyImg = GImg.ThresholdAdaptive(new Gray(100), AdaptiveThresholdType.MeanC, ThresholdType.Binary, bz, new Gray(param));
                    imgBinary.Image = BnyImg;
                    cmbST.Text = "Select simple";
                    txtThre.Text = "";
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgBinary.Image == null)
                {
                    MessageBox.Show("There is no threshold picture");
                }
                else {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Title = "Threshold Save";
                    sfd.DefaultExt = "*.jpg";
                    sfd.Filter = "Jpeg Files (*.jpg)|*.jpg|PNG Files(*.png)|*.jpn|Bmp Files(*.bmp)|*.bmp";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        BnyImg.Save(sfd.FileName);
                        MessageBox.Show("Save !!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not save the image","Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void imgGray_Click(object sender, EventArgs e)
        {

        }

        private void imgBinary_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                oriImg = new Image<Bgr, byte>(ofd.FileName);
                GImg = oriImg.Convert<Gray, byte>();
                imgInput.Image = oriImg;
                imgGray.Image = GImg;
                imgBinary.Image = null;
                cmbST.Text = "Select simple";
                cmbAT.Text = "Select adaptive";
                txtBoxSize.Text = "";
                txtParam.Text = "";
                txtThre.Text = "";

            }
        }
    }
}
