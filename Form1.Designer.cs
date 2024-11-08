using System.Windows.Forms;

namespace DigitalImageProcessing
{
    partial class Form1
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
            this.dIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.webCamVidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rotationLBL = new System.Windows.Forms.Label();
            this.rotateTB = new System.Windows.Forms.TrackBar();
            this.contrastLBL = new System.Windows.Forms.Label();
            this.contrastTB = new System.Windows.Forms.TrackBar();
            this.brightnessLBL = new System.Windows.Forms.Label();
            this.brightnessTB = new System.Windows.Forms.TrackBar();
            this.greyTimer = new System.Windows.Forms.Timer(this.components);
            this.sepiaTimer = new System.Windows.Forms.Timer(this.components);
            this.invertTimer = new System.Windows.Forms.Timer(this.components);
            this.histTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dIPToolStripMenuItem,
            this.videoToolStripMenuItem,
            this.webCamVidToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // dIPToolStripMenuItem
            // 
            this.dIPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pixelCopyToolStripMenuItem,
            this.greyscaleToolStripMenuItem,
            this.inversionToolStripMenuItem,
            this.mirrorHorizontalToolStripMenuItem,
            this.mirrorVerticalToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.brightnessToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.contrastToolStripMenuItem,
            this.subtractToolStripMenuItem});
            this.dIPToolStripMenuItem.Name = "dIPToolStripMenuItem";
            this.dIPToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.dIPToolStripMenuItem.Text = "DIP";
            // 
            // pixelCopyToolStripMenuItem
            // 
            this.pixelCopyToolStripMenuItem.Name = "pixelCopyToolStripMenuItem";
            this.pixelCopyToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.pixelCopyToolStripMenuItem.Text = "Pixel Copy";
            this.pixelCopyToolStripMenuItem.Click += new System.EventHandler(this.pixelCopyToolStripMenuItem_Click);
            // 
            // greyscaleToolStripMenuItem
            // 
            this.greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            this.greyscaleToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.greyscaleToolStripMenuItem.Text = "Greyscale";
            this.greyscaleToolStripMenuItem.Click += new System.EventHandler(this.greyscaleToolStripMenuItem_Click);
            // 
            // inversionToolStripMenuItem
            // 
            this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            this.inversionToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.inversionToolStripMenuItem.Text = "Inversion";
            this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
            // 
            // mirrorHorizontalToolStripMenuItem
            // 
            this.mirrorHorizontalToolStripMenuItem.Name = "mirrorHorizontalToolStripMenuItem";
            this.mirrorHorizontalToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.mirrorHorizontalToolStripMenuItem.Text = "Mirror Horizontal";
            this.mirrorHorizontalToolStripMenuItem.Click += new System.EventHandler(this.mirrorHorizontalToolStripMenuItem_Click);
            // 
            // mirrorVerticalToolStripMenuItem
            // 
            this.mirrorVerticalToolStripMenuItem.Name = "mirrorVerticalToolStripMenuItem";
            this.mirrorVerticalToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.mirrorVerticalToolStripMenuItem.Text = "Mirror Vertical";
            this.mirrorVerticalToolStripMenuItem.Click += new System.EventHandler(this.mirrorVerticalToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.sepiaToolStripMenuItem.Text = "Sepia Color Change";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.rotateToolStripMenuItem.Text = "Rotate";
            this.rotateToolStripMenuItem.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.contrastToolStripMenuItem.Text = "Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
            // 
            // subtractToolStripMenuItem
            // 
            this.subtractToolStripMenuItem.Name = "subtractToolStripMenuItem";
            this.subtractToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.subtractToolStripMenuItem.Text = "Subtract";
            this.subtractToolStripMenuItem.Click += new System.EventHandler(this.subtractToolStripMenuItem_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greyToolStripMenuItem,
            this.inversionToolStripMenuItem1,
            this.histogramToolStripMenuItem1,
            this.sepiaToolStripMenuItem1});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.videoToolStripMenuItem.Text = "Video";
            // 
            // greyToolStripMenuItem
            // 
            this.greyToolStripMenuItem.Name = "greyToolStripMenuItem";
            this.greyToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.greyToolStripMenuItem.Text = "Grey";
            this.greyToolStripMenuItem.Click += new System.EventHandler(this.greyToolStripMenuItem_Click);
            // 
            // inversionToolStripMenuItem1
            // 
            this.inversionToolStripMenuItem1.Name = "inversionToolStripMenuItem1";
            this.inversionToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.inversionToolStripMenuItem1.Text = "Inversion";
            this.inversionToolStripMenuItem1.Click += new System.EventHandler(this.inversionToolStripMenuItem1_Click);
            // 
            // histogramToolStripMenuItem1
            // 
            this.histogramToolStripMenuItem1.Name = "histogramToolStripMenuItem1";
            this.histogramToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.histogramToolStripMenuItem1.Text = "Histogram";
            this.histogramToolStripMenuItem1.Click += new System.EventHandler(this.histogramToolStripMenuItem1_Click);
            // 
            // sepiaToolStripMenuItem1
            // 
            this.sepiaToolStripMenuItem1.Name = "sepiaToolStripMenuItem1";
            this.sepiaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.sepiaToolStripMenuItem1.Text = "Sepia";
            this.sepiaToolStripMenuItem1.Click += new System.EventHandler(this.sepiaToolStripMenuItem1_Click);
            // 
            // webCamVidToolStripMenuItem
            // 
            this.webCamVidToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNToolStripMenuItem,
            this.oFFToolStripMenuItem});
            this.webCamVidToolStripMenuItem.Name = "webCamVidToolStripMenuItem";
            this.webCamVidToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.webCamVidToolStripMenuItem.Text = "WebCam Vid";
            // 
            // oNToolStripMenuItem
            // 
            this.oNToolStripMenuItem.Name = "oNToolStripMenuItem";
            this.oNToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.oNToolStripMenuItem.Text = "ON";
            this.oNToolStripMenuItem.Click += new System.EventHandler(this.oNToolStripMenuItem_Click);
            // 
            // oFFToolStripMenuItem
            // 
            this.oFFToolStripMenuItem.Name = "oFFToolStripMenuItem";
            this.oFFToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.oFFToolStripMenuItem.Text = "OFF";
            this.oFFToolStripMenuItem.Click += new System.EventHandler(this.oFFToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(41, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(605, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 500);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uploaded Image";
            // 
            // rotationLBL
            // 
            this.rotationLBL.AutoSize = true;
            this.rotationLBL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rotationLBL.Location = new System.Drawing.Point(614, 667);
            this.rotationLBL.Name = "rotationLBL";
            this.rotationLBL.Size = new System.Drawing.Size(44, 16);
            this.rotationLBL.TabIndex = 15;
            this.rotationLBL.Text = "rotate:";
            this.rotationLBL.Visible = false;
            // 
            // rotateTB
            // 
            this.rotateTB.AccessibleName = "Brightness";
            this.rotateTB.Location = new System.Drawing.Point(605, 695);
            this.rotateTB.Maximum = 50;
            this.rotateTB.Minimum = -50;
            this.rotateTB.Name = "rotateTB";
            this.rotateTB.Size = new System.Drawing.Size(500, 56);
            this.rotateTB.TabIndex = 14;
            this.rotateTB.Visible = false;
            // 
            // contrastLBL
            // 
            this.contrastLBL.AutoSize = true;
            this.contrastLBL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.contrastLBL.Location = new System.Drawing.Point(50, 594);
            this.contrastLBL.Name = "contrastLBL";
            this.contrastLBL.Size = new System.Drawing.Size(57, 16);
            this.contrastLBL.TabIndex = 13;
            this.contrastLBL.Text = "contrast:";
            this.contrastLBL.Visible = false;
            // 
            // contrastTB
            // 
            this.contrastTB.AccessibleName = "Contrast";
            this.contrastTB.Location = new System.Drawing.Point(41, 616);
            this.contrastTB.Maximum = 100;
            this.contrastTB.Name = "contrastTB";
            this.contrastTB.Size = new System.Drawing.Size(500, 56);
            this.contrastTB.TabIndex = 12;
            this.contrastTB.Visible = false;
            // 
            // brightnessLBL
            // 
            this.brightnessLBL.AutoSize = true;
            this.brightnessLBL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.brightnessLBL.Location = new System.Drawing.Point(614, 588);
            this.brightnessLBL.Name = "brightnessLBL";
            this.brightnessLBL.Size = new System.Drawing.Size(72, 16);
            this.brightnessLBL.TabIndex = 11;
            this.brightnessLBL.Text = "brightness:";
            this.brightnessLBL.Visible = false;
            // 
            // brightnessTB
            // 
            this.brightnessTB.AccessibleName = "Brightness";
            this.brightnessTB.Location = new System.Drawing.Point(605, 616);
            this.brightnessTB.Maximum = 50;
            this.brightnessTB.Minimum = -50;
            this.brightnessTB.Name = "brightnessTB";
            this.brightnessTB.Size = new System.Drawing.Size(500, 56);
            this.brightnessTB.TabIndex = 10;
            this.brightnessTB.Visible = false;
            // 
            // greyTimer
            // 
            this.greyTimer.Interval = 1;
            this.greyTimer.Tick += new System.EventHandler(this.greyTimer_Tick);
            // 
            // sepiaTimer
            // 
            this.sepiaTimer.Interval = 1;
            this.sepiaTimer.Tick += new System.EventHandler(this.sepiaTimer_Tick);
            // 
            // invertTimer
            // 
            this.invertTimer.Interval = 1;
            this.invertTimer.Tick += new System.EventHandler(this.invertTimer_Tick);
            // 
            // histTimer
            // 
            this.histTimer.Interval = 1;
            this.histTimer.Tick += new System.EventHandler(this.histTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 749);
            this.Controls.Add(this.rotationLBL);
            this.Controls.Add(this.rotateTB);
            this.Controls.Add(this.contrastLBL);
            this.Controls.Add(this.contrastTB);
            this.Controls.Add(this.brightnessLBL);
            this.Controls.Add(this.brightnessTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ImageProcessing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webCamVidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rotationLBL;
        private System.Windows.Forms.TrackBar rotateTB;
        private System.Windows.Forms.Label contrastLBL;
        private System.Windows.Forms.TrackBar contrastTB;
        private System.Windows.Forms.Label brightnessLBL;
        private System.Windows.Forms.TrackBar brightnessTB;
        private ToolStripMenuItem inversionToolStripMenuItem1;
        private ToolStripMenuItem histogramToolStripMenuItem1;
        private ToolStripMenuItem sepiaToolStripMenuItem1;
        private Timer greyTimer;
        private Timer sepiaTimer;
        private Timer invertTimer;
        private Timer histTimer;
    }
}

