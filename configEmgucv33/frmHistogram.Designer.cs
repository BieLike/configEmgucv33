namespace configEmgucv33
{
    partial class frmHistogram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imgbR = new Emgu.CV.UI.ImageBox();
            this.imgbG = new Emgu.CV.UI.ImageBox();
            this.imgbB = new Emgu.CV.UI.ImageBox();
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.btnHistogram = new System.Windows.Forms.Button();
            this.htgbR = new Emgu.CV.UI.HistogramBox();
            this.htgbG = new Emgu.CV.UI.HistogramBox();
            this.htgbB = new Emgu.CV.UI.HistogramBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbB)).BeginInit();
            this.SuspendLayout();
            // 
            // imgbR
            // 
            this.imgbR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgbR.Location = new System.Drawing.Point(12, 62);
            this.imgbR.Name = "imgbR";
            this.imgbR.Size = new System.Drawing.Size(337, 325);
            this.imgbR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbR.TabIndex = 2;
            this.imgbR.TabStop = false;
            this.imgbR.Click += new System.EventHandler(this.imgbR_Click);
            // 
            // imgbG
            // 
            this.imgbG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgbG.Location = new System.Drawing.Point(375, 62);
            this.imgbG.Name = "imgbG";
            this.imgbG.Size = new System.Drawing.Size(337, 325);
            this.imgbG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbG.TabIndex = 3;
            this.imgbG.TabStop = false;
            this.imgbG.Click += new System.EventHandler(this.imgbG_Click);
            // 
            // imgbB
            // 
            this.imgbB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgbB.Location = new System.Drawing.Point(728, 62);
            this.imgbB.Name = "imgbB";
            this.imgbB.Size = new System.Drawing.Size(337, 325);
            this.imgbB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbB.TabIndex = 4;
            this.imgbB.TabStop = false;
            this.imgbB.Click += new System.EventHandler(this.imgbB_Click);
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.Location = new System.Drawing.Point(12, 12);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(114, 44);
            this.btnLoadImg.TabIndex = 5;
            this.btnLoadImg.Text = "Read Image";
            this.btnLoadImg.UseVisualStyleBackColor = true;
            this.btnLoadImg.Click += new System.EventHandler(this.btnLoadImg_Click);
            // 
            // btnHistogram
            // 
            this.btnHistogram.Location = new System.Drawing.Point(147, 12);
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(114, 44);
            this.btnHistogram.TabIndex = 6;
            this.btnHistogram.Text = "Histogram";
            this.btnHistogram.UseVisualStyleBackColor = true;
            this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click);
            // 
            // htgbR
            // 
            this.htgbR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htgbR.Location = new System.Drawing.Point(12, 427);
            this.htgbR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htgbR.Name = "htgbR";
            this.htgbR.Size = new System.Drawing.Size(337, 337);
            this.htgbR.TabIndex = 7;
            this.htgbR.Load += new System.EventHandler(this.htgbR_Load);
            // 
            // htgbG
            // 
            this.htgbG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htgbG.Location = new System.Drawing.Point(375, 427);
            this.htgbG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htgbG.Name = "htgbG";
            this.htgbG.Size = new System.Drawing.Size(337, 337);
            this.htgbG.TabIndex = 8;
            this.htgbG.Load += new System.EventHandler(this.histogramBox2_Load);
            // 
            // htgbB
            // 
            this.htgbB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htgbB.Location = new System.Drawing.Point(728, 427);
            this.htgbB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htgbB.Name = "htgbB";
            this.htgbB.Size = new System.Drawing.Size(337, 337);
            this.htgbB.TabIndex = 9;
            this.htgbB.Load += new System.EventHandler(this.htgbB_Load);
            // 
            // frmHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 786);
            this.Controls.Add(this.htgbB);
            this.Controls.Add(this.htgbG);
            this.Controls.Add(this.htgbR);
            this.Controls.Add(this.btnHistogram);
            this.Controls.Add(this.btnLoadImg);
            this.Controls.Add(this.imgbB);
            this.Controls.Add(this.imgbG);
            this.Controls.Add(this.imgbR);
            this.Name = "frmHistogram";
            this.Text = "frmHistogram";
            ((System.ComponentModel.ISupportInitialize)(this.imgbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgbR;
        private Emgu.CV.UI.ImageBox imgbG;
        private Emgu.CV.UI.ImageBox imgbB;
        private System.Windows.Forms.Button btnLoadImg;
        private System.Windows.Forms.Button btnHistogram;
        private Emgu.CV.UI.HistogramBox htgbR;
        private Emgu.CV.UI.HistogramBox htgbG;
        private Emgu.CV.UI.HistogramBox htgbB;
    }
}