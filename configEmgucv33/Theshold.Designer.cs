namespace configEmgucv33
{
    partial class Theshold
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.imgInput = new Emgu.CV.UI.ImageBox();
            this.imgGray = new Emgu.CV.UI.ImageBox();
            this.imgBinary = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTheshold = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBinary)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(480, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 45);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(382, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 45);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(284, 248);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(92, 45);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // imgInput
            // 
            this.imgInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgInput.Location = new System.Drawing.Point(12, 12);
            this.imgInput.Name = "imgInput";
            this.imgInput.Size = new System.Drawing.Size(266, 230);
            this.imgInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInput.TabIndex = 2;
            this.imgInput.TabStop = false;
            // 
            // imgGray
            // 
            this.imgGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgGray.Location = new System.Drawing.Point(308, 12);
            this.imgGray.Name = "imgGray";
            this.imgGray.Size = new System.Drawing.Size(270, 230);
            this.imgGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGray.TabIndex = 3;
            this.imgGray.TabStop = false;
            // 
            // imgBinary
            // 
            this.imgBinary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBinary.Location = new System.Drawing.Point(12, 258);
            this.imgBinary.Name = "imgBinary";
            this.imgBinary.Size = new System.Drawing.Size(266, 230);
            this.imgBinary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBinary.TabIndex = 4;
            this.imgBinary.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTheshold);
            this.groupBox1.Location = new System.Drawing.Point(284, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 189);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thesolding";
            // 
            // cmbTheshold
            // 
            this.cmbTheshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTheshold.FormattingEnabled = true;
            this.cmbTheshold.Items.AddRange(new object[] {
            "Binary",
            "Binary Invert",
            "UT\'Su",
            "Gaussian",
            "Mean"});
            this.cmbTheshold.Location = new System.Drawing.Point(6, 32);
            this.cmbTheshold.Name = "cmbTheshold";
            this.cmbTheshold.Size = new System.Drawing.Size(282, 28);
            this.cmbTheshold.TabIndex = 0;
            this.cmbTheshold.SelectedIndexChanged += new System.EventHandler(this.cmbTheshold_SelectedIndexChanged);
            // 
            // Theshold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imgInput);
            this.Controls.Add(this.imgBinary);
            this.Controls.Add(this.imgGray);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "Theshold";
            this.Text = "Theshold";
            this.Load += new System.EventHandler(this.Theshold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBinary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private Emgu.CV.UI.ImageBox imgInput;
        private Emgu.CV.UI.ImageBox imgGray;
        private Emgu.CV.UI.ImageBox imgBinary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTheshold;
    }
}