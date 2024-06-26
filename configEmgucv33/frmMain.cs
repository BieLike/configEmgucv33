using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace configEmgucv33
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmguConvert cnvt = new EmguConvert();
            cnvt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHistogram hg = new frmHistogram();  
            hg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Theshold frmTs = new Theshold();   
            frmTs.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmFullThreshold ffth = new frmFullThreshold();
            ffth.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmHistogramEqualization frmhe = new frmHistogramEqualization();
            frmhe.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmMorphology fm = new frmMorphology();
            fm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmEdgeDetection ed = new frmEdgeDetection();
            ed.Show();
        }
    }
}
