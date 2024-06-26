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
using Emgu.CV.UI;

namespace configEmgucv33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panAndZoomPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ReadImage_Click(object sender, EventArgs e)
        {
            /*Image<Bgr, byte> imgInput = new Image<Bgr, byte>("C:\\Users\\ACER\\OneDrive\\Pictures\\Meme\\Im fine.jpg");
            imageBox1.Image = imgInput;*/

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> img = new Image<Bgr, byte>(ofd.FileName);
                imageBox1.Image = img;
            }

        }
    }
}
