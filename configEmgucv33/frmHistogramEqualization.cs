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
using Emgu.CV.CvEnum;
using Emgu.Util;

namespace configEmgucv33
{
    public partial class frmHistogramEqualization : Form
    {
        public frmHistogramEqualization()
        {
            InitializeComponent();
        }
        Image<Bgr, byte> imgOri, imgOF;
        Image<Gray, byte> imgBfe, imgAfe;
        Image<Gray, byte> imgFilter = null;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgOri = new Image<Bgr, byte>(ofd.FileName);
                imgbInput.Image = imgOri;
                imgBfe = imgOri.Convert<Gray, byte>();
                imgbGray.Image = imgBfe;
                ImgbOutput.Image = null;

                htgColor.ClearHistogram();
                htgColor.GenerateHistograms(imgOri,255);
                htgColor.Refresh();
                htgBeforeE.ClearHistogram();
                htgBeforeE.GenerateHistograms(imgBfe, 255);
                htgBeforeE.Refresh();
                htgAfterE.ClearHistogram();
                cmbFilter.Text = "Filter";
                htgAfterE.ClearHistogram();
                htgAfterE.Refresh();
                txtBoxsize.Text = "";
                rbtColor.Checked = false;
                rbtGray.Checked = false;
                btnEqualization.Enabled = true;
                gbSelectP.Enabled = false;
                txtBoxsize.Enabled  = false;
                cmbFilter.Enabled = false;
                btnSave.Enabled = false;

            }

        }

        private void btnEqualization_Click(object sender, EventArgs e)
        {
            if (imgbInput.Image == null)
            {
                MessageBox.Show("Please input image first");
            }
            else
            {
                    imgAfe = new Image<Gray, byte>(imgBfe.Width, imgBfe.Height);
                    CvInvoke.EqualizeHist(imgBfe, imgAfe);
                    ImgbOutput.Image = imgAfe;

                    htgAfterE.ClearHistogram();
                    htgAfterE.GenerateHistograms(imgAfe, 255);
                    htgAfterE.Refresh();
                    cmbFilter.Text = "Filter";
                    txtBoxsize.Text = "";
                    rbtColor.Checked = false;
                    rbtGray.Checked = false;
                
                /*else if (rbtColor.Checked == true)
                {
                    imgOF = new Image<Bgr, byte>(imgOri.Width, imgOri.Height);
                    CvInvoke.EqualizeHist(imgOri, imgOF);
                    ImgbOutput.Image = imgOF;

                    htgAfterE.ClearHistogram();
                    htgAfterE.GenerateHistograms(imgOF, 255);
                    htgAfterE.Refresh();
                    cmbFilter.Text = "Filter";
                    txtBoxsize.Text = "";
                    rbtColor.Checked = false;
                    rbtGray.Checked = false;
                }*/

                gbSelectP.Enabled = true;
                btnSave.Enabled = true;

            }

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rbtColor.Checked == false && rbtGray.Checked == false)
            {
                MessageBox.Show("Please select picture");

            }
            else if (txtBoxsize.Text == "")
            {
                MessageBox.Show("Please input box size");
            }
            else if (int.Parse(txtBoxsize.Text) < 3 )
            {
                MessageBox.Show("Box size must greater than 2");
            }
            else if ((int.Parse(txtBoxsize.Text)) % 2 == 0)
            {
                MessageBox.Show("Box size must be odd number");
            }
            else
            {
                int s = int.Parse(txtBoxsize.Text);
                if (cmbFilter.SelectedIndex == 0)
                {
                    if (rbtColor.Checked == true)
                    {
                        imgOF = new Image<Bgr, byte>(imgAfe.Width, imgAfe.Height);
                        CvInvoke.GaussianBlur(imgOri, imgOF, new Size(s, s), 0, 0, BorderType.Default);
                        ImgbOutput.Image = imgOF;

                        htgAfterE.ClearHistogram();
                        htgAfterE.GenerateHistograms(imgOF, 255);
                        htgAfterE.Refresh();
                    }
                    else if (rbtGray.Checked == true) { 
                        imgFilter = new Image<Gray, byte>(imgAfe.Width, imgAfe.Height);
                        CvInvoke.GaussianBlur(imgAfe, imgFilter, new Size(s,s),0,0, BorderType.Default);
                        ImgbOutput.Image = imgFilter;

                        htgAfterE.ClearHistogram();
                        htgAfterE.GenerateHistograms(imgFilter, 255);
                        htgAfterE.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Please select picture");
                    }
                    ImgbOutput.Refresh();

                }
                else
                {
                    if (rbtColor.Checked == true)
                    {
                        imgOF = new Image<Bgr, byte>(imgAfe.Width, imgAfe.Height);
                        CvInvoke.MedianBlur(imgOri, imgOF, s);
                        ImgbOutput.Image = imgOF;
                        ImgbOutput.Refresh();

                        htgAfterE.ClearHistogram();
                        htgAfterE.GenerateHistograms(imgOF, 255);
                        htgAfterE.Refresh();
                    }else if (rbtGray.Checked == true)
                    {
                        imgFilter = new Image<Gray, byte>(imgAfe.Width, imgAfe.Height);
                        CvInvoke.MedianBlur(imgAfe, imgFilter, s);
                        ImgbOutput.Image = imgFilter;
                        ImgbOutput.Refresh();

                        htgAfterE.ClearHistogram();
                        htgAfterE.GenerateHistograms(imgFilter, 255);
                        htgAfterE.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Please select picture");
                    }
                    ImgbOutput.Refresh();

                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ImgbOutput.Image == null ) {
                    MessageBox.Show("There is no filtered picture");

                }
                else {
                    btnSave.Enabled = true;
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Title = "Save image Equalization and Filtering";
                    sfd.Filter = "Jpeg Files(*.jpg)|*.jpg|Bitmap Files(*.bmp)|*.bmp|Png Files(*.png)|*.png";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        ImgbOutput.Image.Save(sfd.FileName);
                        MessageBox.Show("Save Complete !!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to save picture");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtColor_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbtGray_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtColor_Click(object sender, EventArgs e)
        {
            if (ImgbOutput.Image == null)
            {
                MessageBox.Show("Please make equalization");
                rbtColor.Checked = false;
            }
        }

        private void frmHistogramEqualization_Load(object sender, EventArgs e)
        {
            btnEqualization.Enabled = false;
            gbSelectP.Enabled = false;
            txtBoxsize.Enabled = false; 
            cmbFilter.Enabled = false;
            btnSave.Enabled = false;

        }

        private void txtBoxsize_TextChanged(object sender, EventArgs e)
        {
            cmbFilter.Enabled = true;   
        }

        private void gbSelectP_Enter(object sender, EventArgs e)
        {
            txtBoxsize.Enabled = true;
        }

        private void rbtGray_Click(object sender, EventArgs e)
        {
            if (ImgbOutput.Image == null)
            {
                MessageBox.Show("Please make equalization");
                rbtGray.Checked = false;
            }
        }

        private void histogramBox2_Load(object sender, EventArgs e)
        {

        }
    }
}
