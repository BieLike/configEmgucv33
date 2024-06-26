namespace configEmgucv33
{
    partial class EmguConvert
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
            this.ptbOrigin = new System.Windows.Forms.PictureBox();
            this.ptbGray = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnConvertToGray = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.lbValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGray)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbOrigin
            // 
            this.ptbOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbOrigin.Location = new System.Drawing.Point(12, 12);
            this.ptbOrigin.Name = "ptbOrigin";
            this.ptbOrigin.Size = new System.Drawing.Size(359, 326);
            this.ptbOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbOrigin.TabIndex = 0;
            this.ptbOrigin.TabStop = false;
            this.ptbOrigin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbOrigin_MouseMove);
            // 
            // ptbGray
            // 
            this.ptbGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbGray.Location = new System.Drawing.Point(428, 12);
            this.ptbGray.Name = "ptbGray";
            this.ptbGray.Size = new System.Drawing.Size(360, 326);
            this.ptbGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbGray.TabIndex = 1;
            this.ptbGray.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(334, 375);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(91, 40);
            this.btnLoadImage.TabIndex = 2;
            this.btnLoadImage.Text = "Load";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnConvertToGray
            // 
            this.btnConvertToGray.Location = new System.Drawing.Point(431, 375);
            this.btnConvertToGray.Name = "btnConvertToGray";
            this.btnConvertToGray.Size = new System.Drawing.Size(260, 40);
            this.btnConvertToGray.TabIndex = 3;
            this.btnConvertToGray.Text = "Convert to grayscale";
            this.btnConvertToGray.UseVisualStyleBackColor = true;
            this.btnConvertToGray.Click += new System.EventHandler(this.btnConvertToGray_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(697, 375);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(91, 40);
            this.btnSaveImage.TabIndex = 4;
            this.btnSaveImage.Text = "Save";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(9, 387);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(18, 16);
            this.lbX.TabIndex = 5;
            this.lbX.Text = "X:";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(78, 387);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(19, 16);
            this.lbY.TabIndex = 6;
            this.lbY.Text = "Y:";
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(165, 387);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(52, 16);
            this.lbValue.TabIndex = 7;
            this.lbValue.Text = "Values:";
            // 
            // EmguConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnConvertToGray);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.ptbGray);
            this.Controls.Add(this.ptbOrigin);
            this.Name = "EmguConvert";
            this.Text = "EmguConvert";
            this.Load += new System.EventHandler(this.EmguConvert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbOrigin;
        private System.Windows.Forms.PictureBox ptbGray;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnConvertToGray;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbValue;
    }
}