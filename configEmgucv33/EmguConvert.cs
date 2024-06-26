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

namespace configEmgucv33
{
    public partial class EmguConvert : Form
    {
        Image<Bgr, Byte> MyImage;
        Image<Gray, Byte> GrayImage;

        public EmguConvert()
        {
            InitializeComponent();
        }

        private void EmguConvert_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                MyImage = new Image<Bgr, Byte>(openFile.FileName);
                ptbOrigin.Image = MyImage.ToBitmap();
            }
        }

        private void ptbOrigin_MouseMove(object sender, MouseEventArgs e)
        {
            if (ptbOrigin.Image != null)
            {
                lbX.Text = "X: " + e.X.ToString();
                lbY.Text = "Y: " + e.Y.ToString();

                lbValue.Text = "Value: " + MyImage[e.Y, e.X].ToString();
            }
        }

        private void btnConvertToGray_Click(object sender, EventArgs e)
        {
            if (MyImage != null)
            {
                GrayImage = MyImage.Convert<Gray, Byte>();
                ptbGray.Image = GrayImage.ToBitmap() ;
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.Title = "Save Gray Image";
            saveImage.DefaultExt = "*.jpg";
            saveImage.Filter = "Jpeg Files (*.jpg)|*.jpg|PNG files(*.png)|*.png|BMP files(*.bmp)|*.bmp";
            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                GrayImage.Save(saveImage.FileName);
                MessageBox.Show("Saving complete");
            }

        }
    }
}
