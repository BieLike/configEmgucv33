namespace configEmgucv33
{
    partial class frmEdgeDetection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetechtionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lapacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgbInput = new Emgu.CV.UI.ImageBox();
            this.imgbOutput = new Emgu.CV.UI.ImageBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.edgeDetechtionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1111, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // edgeDetechtionToolStripMenuItem
            // 
            this.edgeDetechtionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cannyToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.lapacianToolStripMenuItem});
            this.edgeDetechtionToolStripMenuItem.Name = "edgeDetechtionToolStripMenuItem";
            this.edgeDetechtionToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.edgeDetechtionToolStripMenuItem.Text = "Edge Detection";
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cannyToolStripMenuItem.Text = "Canny";
            this.cannyToolStripMenuItem.Click += new System.EventHandler(this.cannyToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // lapacianToolStripMenuItem
            // 
            this.lapacianToolStripMenuItem.Name = "lapacianToolStripMenuItem";
            this.lapacianToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lapacianToolStripMenuItem.Text = "Lapacian";
            this.lapacianToolStripMenuItem.Click += new System.EventHandler(this.lapacianToolStripMenuItem_Click);
            // 
            // imgbInput
            // 
            this.imgbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgbInput.Location = new System.Drawing.Point(12, 31);
            this.imgbInput.Name = "imgbInput";
            this.imgbInput.Size = new System.Drawing.Size(540, 474);
            this.imgbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbInput.TabIndex = 2;
            this.imgbInput.TabStop = false;
            // 
            // imgbOutput
            // 
            this.imgbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgbOutput.Location = new System.Drawing.Point(558, 31);
            this.imgbOutput.Name = "imgbOutput";
            this.imgbOutput.Size = new System.Drawing.Size(540, 474);
            this.imgbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbOutput.TabIndex = 3;
            this.imgbOutput.TabStop = false;
            // 
            // frmEdgeDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 517);
            this.Controls.Add(this.imgbOutput);
            this.Controls.Add(this.imgbInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEdgeDetection";
            this.Text = "frmEdgeDetection";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetechtionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lapacianToolStripMenuItem;
        private Emgu.CV.UI.ImageBox imgbInput;
        private Emgu.CV.UI.ImageBox imgbOutput;
    }
}