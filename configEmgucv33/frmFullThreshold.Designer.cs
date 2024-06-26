namespace configEmgucv33
{
    partial class frmFullThreshold
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbST = new System.Windows.Forms.ComboBox();
            this.imgInput = new Emgu.CV.UI.ImageBox();
            this.imgBinary = new Emgu.CV.UI.ImageBox();
            this.imgGray = new Emgu.CV.UI.ImageBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAT = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBinary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGray)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtThre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbST);
            this.groupBox1.Location = new System.Drawing.Point(372, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 89);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simple threshold";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtThre
            // 
            this.txtThre.Location = new System.Drawing.Point(80, 21);
            this.txtThre.Multiline = true;
            this.txtThre.Name = "txtThre";
            this.txtThre.Size = new System.Drawing.Size(208, 28);
            this.txtThre.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Threshold";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbST
            // 
            this.cmbST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbST.FormattingEnabled = true;
            this.cmbST.Items.AddRange(new object[] {
            "Binary",
            "Binary Invert",
            "UT\'Su"});
            this.cmbST.Location = new System.Drawing.Point(6, 55);
            this.cmbST.Name = "cmbST";
            this.cmbST.Size = new System.Drawing.Size(282, 28);
            this.cmbST.TabIndex = 0;
            this.cmbST.SelectedIndexChanged += new System.EventHandler(this.cmbST_SelectedIndexChanged);
            this.cmbST.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbST_MouseClick);
            // 
            // imgInput
            // 
            this.imgInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgInput.Location = new System.Drawing.Point(12, 12);
            this.imgInput.Name = "imgInput";
            this.imgInput.Size = new System.Drawing.Size(313, 291);
            this.imgInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInput.TabIndex = 15;
            this.imgInput.TabStop = false;
            // 
            // imgBinary
            // 
            this.imgBinary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBinary.Location = new System.Drawing.Point(12, 318);
            this.imgBinary.Name = "imgBinary";
            this.imgBinary.Size = new System.Drawing.Size(313, 291);
            this.imgBinary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBinary.TabIndex = 18;
            this.imgBinary.TabStop = false;
            this.imgBinary.Click += new System.EventHandler(this.imgBinary_Click);
            // 
            // imgGray
            // 
            this.imgGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgGray.Location = new System.Drawing.Point(349, 12);
            this.imgGray.Name = "imgGray";
            this.imgGray.Size = new System.Drawing.Size(317, 291);
            this.imgGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGray.TabIndex = 17;
            this.imgGray.TabStop = false;
            this.imgGray.Click += new System.EventHandler(this.imgGray_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(372, 335);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(92, 45);
            this.btnOpen.TabIndex = 16;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(470, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 45);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(568, 335);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 45);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtParam);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBoxSize);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbAT);
            this.groupBox2.Location = new System.Drawing.Point(372, 481);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 115);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adaptive threshold";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtParam
            // 
            this.txtParam.Location = new System.Drawing.Point(208, 21);
            this.txtParam.Multiline = true;
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(80, 28);
            this.txtParam.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Param";
            // 
            // txtBoxSize
            // 
            this.txtBoxSize.Location = new System.Drawing.Point(69, 21);
            this.txtBoxSize.Multiline = true;
            this.txtBoxSize.Name = "txtBoxSize";
            this.txtBoxSize.Size = new System.Drawing.Size(80, 28);
            this.txtBoxSize.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Box size";
            // 
            // cmbAT
            // 
            this.cmbAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAT.FormattingEnabled = true;
            this.cmbAT.Items.AddRange(new object[] {
            "Gaussian",
            "Mean"});
            this.cmbAT.Location = new System.Drawing.Point(6, 66);
            this.cmbAT.Name = "cmbAT";
            this.cmbAT.Size = new System.Drawing.Size(282, 28);
            this.cmbAT.TabIndex = 1;
            this.cmbAT.SelectedIndexChanged += new System.EventHandler(this.cmbAT_SelectedIndexChanged);
            // 
            // frmFullThreshold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 616);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imgInput);
            this.Controls.Add(this.imgBinary);
            this.Controls.Add(this.imgGray);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "frmFullThreshold";
            this.Text = "frmFullThreshold";
            this.Load += new System.EventHandler(this.frmFullThreshold_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBinary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGray)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbST;
        private Emgu.CV.UI.ImageBox imgInput;
        private Emgu.CV.UI.ImageBox imgBinary;
        private Emgu.CV.UI.ImageBox imgGray;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAT;
        private System.Windows.Forms.TextBox txtThre;
        private System.Windows.Forms.Label label1;
    }
}