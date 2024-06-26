namespace configEmgucv33
{
    partial class frmHistogramEqualization
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
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.btnEqualization = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.imgbGray = new Emgu.CV.UI.ImageBox();
            this.ImgbOutput = new Emgu.CV.UI.ImageBox();
            this.htgBeforeE = new Emgu.CV.UI.HistogramBox();
            this.htgAfterE = new Emgu.CV.UI.HistogramBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.htgColor = new Emgu.CV.UI.HistogramBox();
            this.imgbInput = new Emgu.CV.UI.ImageBox();
            this.rbtColor = new System.Windows.Forms.RadioButton();
            this.rbtGray = new System.Windows.Forms.RadioButton();
            this.gbSelectP = new System.Windows.Forms.GroupBox();
            this.txtBoxsize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgbGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgbOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbInput)).BeginInit();
            this.gbSelectP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.Location = new System.Drawing.Point(702, 15);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(143, 44);
            this.btnLoadImg.TabIndex = 0;
            this.btnLoadImg.Text = "Load image";
            this.btnLoadImg.UseVisualStyleBackColor = true;
            this.btnLoadImg.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEqualization
            // 
            this.btnEqualization.Location = new System.Drawing.Point(702, 65);
            this.btnEqualization.Name = "btnEqualization";
            this.btnEqualization.Size = new System.Drawing.Size(143, 70);
            this.btnEqualization.TabIndex = 1;
            this.btnEqualization.Text = "Histogram equalization";
            this.btnEqualization.UseVisualStyleBackColor = true;
            this.btnEqualization.Click += new System.EventHandler(this.btnEqualization_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(702, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 44);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(702, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imgbGray
            // 
            this.imgbGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgbGray.Location = new System.Drawing.Point(12, 271);
            this.imgbGray.Name = "imgbGray";
            this.imgbGray.Size = new System.Drawing.Size(282, 255);
            this.imgbGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbGray.TabIndex = 2;
            this.imgbGray.TabStop = false;
            // 
            // ImgbOutput
            // 
            this.ImgbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgbOutput.Location = new System.Drawing.Point(12, 536);
            this.ImgbOutput.Name = "ImgbOutput";
            this.ImgbOutput.Size = new System.Drawing.Size(282, 255);
            this.ImgbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgbOutput.TabIndex = 6;
            this.ImgbOutput.TabStop = false;
            // 
            // htgBeforeE
            // 
            this.htgBeforeE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htgBeforeE.Location = new System.Drawing.Point(301, 271);
            this.htgBeforeE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htgBeforeE.Name = "htgBeforeE";
            this.htgBeforeE.Size = new System.Drawing.Size(384, 255);
            this.htgBeforeE.TabIndex = 7;
            // 
            // htgAfterE
            // 
            this.htgAfterE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htgAfterE.Location = new System.Drawing.Point(301, 536);
            this.htgAfterE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htgAfterE.Name = "htgAfterE";
            this.htgAfterE.Size = new System.Drawing.Size(384, 255);
            this.htgAfterE.TabIndex = 8;
            this.htgAfterE.Load += new System.EventHandler(this.histogramBox2_Load);
            // 
            // cmbFilter
            // 
            this.cmbFilter.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "GaussianBlur",
            "MedianBlur"});
            this.cmbFilter.Location = new System.Drawing.Point(702, 271);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(143, 28);
            this.cmbFilter.TabIndex = 9;
            this.cmbFilter.Text = "Filter";
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // htgColor
            // 
            this.htgColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htgColor.Location = new System.Drawing.Point(301, 10);
            this.htgColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htgColor.Name = "htgColor";
            this.htgColor.Size = new System.Drawing.Size(384, 255);
            this.htgColor.TabIndex = 11;
            // 
            // imgbInput
            // 
            this.imgbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgbInput.Location = new System.Drawing.Point(12, 10);
            this.imgbInput.Name = "imgbInput";
            this.imgbInput.Size = new System.Drawing.Size(282, 255);
            this.imgbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbInput.TabIndex = 10;
            this.imgbInput.TabStop = false;
            // 
            // rbtColor
            // 
            this.rbtColor.AutoSize = true;
            this.rbtColor.Location = new System.Drawing.Point(6, 21);
            this.rbtColor.Name = "rbtColor";
            this.rbtColor.Size = new System.Drawing.Size(60, 20);
            this.rbtColor.TabIndex = 12;
            this.rbtColor.TabStop = true;
            this.rbtColor.Text = "Color";
            this.rbtColor.UseVisualStyleBackColor = true;
            this.rbtColor.CheckedChanged += new System.EventHandler(this.rbtColor_CheckedChanged);
            this.rbtColor.Click += new System.EventHandler(this.rbtColor_Click);
            // 
            // rbtGray
            // 
            this.rbtGray.AutoSize = true;
            this.rbtGray.Location = new System.Drawing.Point(6, 47);
            this.rbtGray.Name = "rbtGray";
            this.rbtGray.Size = new System.Drawing.Size(57, 20);
            this.rbtGray.TabIndex = 13;
            this.rbtGray.TabStop = true;
            this.rbtGray.Text = "Gray";
            this.rbtGray.UseVisualStyleBackColor = true;
            this.rbtGray.CheckedChanged += new System.EventHandler(this.rbtGray_CheckedChanged);
            this.rbtGray.Click += new System.EventHandler(this.rbtGray_Click);
            // 
            // gbSelectP
            // 
            this.gbSelectP.Controls.Add(this.rbtGray);
            this.gbSelectP.Controls.Add(this.rbtColor);
            this.gbSelectP.Location = new System.Drawing.Point(702, 141);
            this.gbSelectP.Name = "gbSelectP";
            this.gbSelectP.Size = new System.Drawing.Size(146, 87);
            this.gbSelectP.TabIndex = 14;
            this.gbSelectP.TabStop = false;
            this.gbSelectP.Text = "Select Picture";
            this.gbSelectP.Enter += new System.EventHandler(this.gbSelectP_Enter);
            // 
            // txtBoxsize
            // 
            this.txtBoxsize.Location = new System.Drawing.Point(762, 234);
            this.txtBoxsize.Multiline = true;
            this.txtBoxsize.Name = "txtBoxsize";
            this.txtBoxsize.Size = new System.Drawing.Size(86, 31);
            this.txtBoxsize.TabIndex = 15;
            this.txtBoxsize.TextChanged += new System.EventHandler(this.txtBoxsize_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Box size";
            // 
            // frmHistogramEqualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 803);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxsize);
            this.Controls.Add(this.gbSelectP);
            this.Controls.Add(this.htgColor);
            this.Controls.Add(this.imgbInput);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.htgAfterE);
            this.Controls.Add(this.htgBeforeE);
            this.Controls.Add(this.ImgbOutput);
            this.Controls.Add(this.imgbGray);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEqualization);
            this.Controls.Add(this.btnLoadImg);
            this.Name = "frmHistogramEqualization";
            this.Text = "frmHistogramEqualization";
            this.Load += new System.EventHandler(this.frmHistogramEqualization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgbGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgbOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbInput)).EndInit();
            this.gbSelectP.ResumeLayout(false);
            this.gbSelectP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImg;
        private System.Windows.Forms.Button btnEqualization;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private Emgu.CV.UI.ImageBox imgbGray;
        private Emgu.CV.UI.ImageBox ImgbOutput;
        private Emgu.CV.UI.HistogramBox htgBeforeE;
        private Emgu.CV.UI.HistogramBox htgAfterE;
        private System.Windows.Forms.ComboBox cmbFilter;
        private Emgu.CV.UI.HistogramBox htgColor;
        private Emgu.CV.UI.ImageBox imgbInput;
        private System.Windows.Forms.RadioButton rbtColor;
        private System.Windows.Forms.RadioButton rbtGray;
        private System.Windows.Forms.GroupBox gbSelectP;
        private System.Windows.Forms.TextBox txtBoxsize;
        private System.Windows.Forms.Label label1;
    }
}