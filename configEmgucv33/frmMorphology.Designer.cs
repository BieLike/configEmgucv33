namespace configEmgucv33
{
    partial class frmMorphology
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
            this.morphologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morphologicalBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erotionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.morphologyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 28);
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
            // morphologyToolStripMenuItem
            // 
            this.morphologyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dialationToolStripMenuItem,
            this.erotionToolStripMenuItem,
            this.toolStripSeparator1,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.gradianToolStripMenuItem,
            this.topHatToolStripMenuItem,
            this.blackHatToolStripMenuItem,
            this.morphologicalBinaryToolStripMenuItem});
            this.morphologyToolStripMenuItem.Name = "morphologyToolStripMenuItem";
            this.morphologyToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.morphologyToolStripMenuItem.Text = "Morphology";
            // 
            // dialationToolStripMenuItem
            // 
            this.dialationToolStripMenuItem.Name = "dialationToolStripMenuItem";
            this.dialationToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.dialationToolStripMenuItem.Text = "Dilation";
            this.dialationToolStripMenuItem.Click += new System.EventHandler(this.dialationToolStripMenuItem_Click);
            // 
            // erotionToolStripMenuItem
            // 
            this.erotionToolStripMenuItem.Name = "erotionToolStripMenuItem";
            this.erotionToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.erotionToolStripMenuItem.Text = "Erosion";
            this.erotionToolStripMenuItem.Click += new System.EventHandler(this.erotionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.openingToolStripMenuItem.Text = "Opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.closingToolStripMenuItem.Text = "Closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // gradianToolStripMenuItem
            // 
            this.gradianToolStripMenuItem.Name = "gradianToolStripMenuItem";
            this.gradianToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.gradianToolStripMenuItem.Text = "Gradian";
            this.gradianToolStripMenuItem.Click += new System.EventHandler(this.gradianToolStripMenuItem_Click);
            // 
            // topHatToolStripMenuItem
            // 
            this.topHatToolStripMenuItem.Name = "topHatToolStripMenuItem";
            this.topHatToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.topHatToolStripMenuItem.Text = "Top hat";
            this.topHatToolStripMenuItem.Click += new System.EventHandler(this.topHatToolStripMenuItem_Click);
            // 
            // blackHatToolStripMenuItem
            // 
            this.blackHatToolStripMenuItem.Name = "blackHatToolStripMenuItem";
            this.blackHatToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.blackHatToolStripMenuItem.Text = "Black hat";
            this.blackHatToolStripMenuItem.Click += new System.EventHandler(this.blackHatToolStripMenuItem_Click);
            // 
            // morphologicalBinaryToolStripMenuItem
            // 
            this.morphologicalBinaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationToolStripMenuItem,
            this.erotionToolStripMenuItem1});
            this.morphologicalBinaryToolStripMenuItem.Name = "morphologicalBinaryToolStripMenuItem";
            this.morphologicalBinaryToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.morphologicalBinaryToolStripMenuItem.Text = "Morphological Binary";
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.dilationToolStripMenuItem.Text = "Dilation";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
            // 
            // erotionToolStripMenuItem1
            // 
            this.erotionToolStripMenuItem1.Name = "erotionToolStripMenuItem1";
            this.erotionToolStripMenuItem1.Size = new System.Drawing.Size(145, 26);
            this.erotionToolStripMenuItem1.Text = "Erotion";
            this.erotionToolStripMenuItem1.Click += new System.EventHandler(this.erotionToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // imgbInput
            // 
            this.imgbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgbInput.Location = new System.Drawing.Point(12, 31);
            this.imgbInput.Name = "imgbInput";
            this.imgbInput.Size = new System.Drawing.Size(524, 434);
            this.imgbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbInput.TabIndex = 2;
            this.imgbInput.TabStop = false;
            // 
            // imgbOutput
            // 
            this.imgbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgbOutput.Location = new System.Drawing.Point(542, 31);
            this.imgbOutput.Name = "imgbOutput";
            this.imgbOutput.Size = new System.Drawing.Size(524, 434);
            this.imgbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbOutput.TabIndex = 3;
            this.imgbOutput.TabStop = false;
            // 
            // frmMorphology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 477);
            this.Controls.Add(this.imgbOutput);
            this.Controls.Add(this.imgbInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMorphology";
            this.Text = "frmMorphology";
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
        private System.Windows.Forms.ToolStripMenuItem morphologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erotionToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topHatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackHatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morphologicalBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erotionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Emgu.CV.UI.ImageBox imgbInput;
        private Emgu.CV.UI.ImageBox imgbOutput;
    }
}