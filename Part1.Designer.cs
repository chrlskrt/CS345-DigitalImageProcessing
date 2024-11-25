using System.Windows.Forms;

namespace DigitalImageProcessing
{
    partial class Part1
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
            this.webCamVidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VideoOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VGreyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VInversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VSepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGoToPart2 = new System.Windows.Forms.ToolStripMenuItem();
            this.part3ConvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanRemovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossLaplascianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDirectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lossyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.vidFilterTimer = new System.Windows.Forms.Timer(this.components);
            this.coinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.webCamVidToolStripMenuItem,
            this.videoToolStripMenuItem,
            this.btnGoToPart2,
            this.part3ConvToolStripMenuItem,
            this.coinsToolStripMenuItem});
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
            this.contrastToolStripMenuItem});
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
            // webCamVidToolStripMenuItem
            // 
            this.webCamVidToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VideoOnToolStripMenuItem,
            this.oFFToolStripMenuItem});
            this.webCamVidToolStripMenuItem.Name = "webCamVidToolStripMenuItem";
            this.webCamVidToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.webCamVidToolStripMenuItem.Text = "WebCam Options";
            // 
            // VideoOnToolStripMenuItem
            // 
            this.VideoOnToolStripMenuItem.Name = "VideoOnToolStripMenuItem";
            this.VideoOnToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.VideoOnToolStripMenuItem.Text = "ON";
            // 
            // oFFToolStripMenuItem
            // 
            this.oFFToolStripMenuItem.Name = "oFFToolStripMenuItem";
            this.oFFToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.oFFToolStripMenuItem.Text = "OFF";
            this.oFFToolStripMenuItem.Click += new System.EventHandler(this.VideoOFFToolStripMenuItem_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VGreyToolStripMenuItem,
            this.VInversionToolStripMenuItem,
            this.VHistogramToolStripMenuItem,
            this.VSepiaToolStripMenuItem});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.videoToolStripMenuItem.Text = "Video Filters";
            // 
            // VGreyToolStripMenuItem
            // 
            this.VGreyToolStripMenuItem.Name = "VGreyToolStripMenuItem";
            this.VGreyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.VGreyToolStripMenuItem.Text = "Grey";
            this.VGreyToolStripMenuItem.Click += new System.EventHandler(this.VGreyToolStripMenuItem_Click);
            // 
            // VInversionToolStripMenuItem
            // 
            this.VInversionToolStripMenuItem.Name = "VInversionToolStripMenuItem";
            this.VInversionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.VInversionToolStripMenuItem.Text = "Inversion";
            this.VInversionToolStripMenuItem.Click += new System.EventHandler(this.VInversionToolStripMenuItem_Click);
            // 
            // VHistogramToolStripMenuItem
            // 
            this.VHistogramToolStripMenuItem.Name = "VHistogramToolStripMenuItem";
            this.VHistogramToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.VHistogramToolStripMenuItem.Text = "Histogram";
            this.VHistogramToolStripMenuItem.Click += new System.EventHandler(this.VHistogramToolStripMenuItem_Click);
            // 
            // VSepiaToolStripMenuItem
            // 
            this.VSepiaToolStripMenuItem.Name = "VSepiaToolStripMenuItem";
            this.VSepiaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.VSepiaToolStripMenuItem.Text = "Sepia";
            this.VSepiaToolStripMenuItem.Click += new System.EventHandler(this.VSepiaToolStripMenuItem_Click);
            // 
            // btnGoToPart2
            // 
            this.btnGoToPart2.Name = "btnGoToPart2";
            this.btnGoToPart2.Size = new System.Drawing.Size(118, 24);
            this.btnGoToPart2.Text = "Part2: Subtract";
            this.btnGoToPart2.Click += new System.EventHandler(this.btnGoToPart2_Click);
            // 
            // part3ConvToolStripMenuItem
            // 
            this.part3ConvToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smoothingToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.meanRemovalToolStripMenuItem,
            this.embossingToolStripMenuItem});
            this.part3ConvToolStripMenuItem.Name = "part3ConvToolStripMenuItem";
            this.part3ConvToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.part3ConvToolStripMenuItem.Text = "Part3: ConvMatrix";
            // 
            // smoothingToolStripMenuItem
            // 
            this.smoothingToolStripMenuItem.Name = "smoothingToolStripMenuItem";
            this.smoothingToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.smoothingToolStripMenuItem.Text = "Smoothing";
            this.smoothingToolStripMenuItem.Click += new System.EventHandler(this.smoothingToolStripMenuItem_Click);
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            this.gaussianBlurToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlurToolStripMenuItem_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenToolStripMenuItem_Click);
            // 
            // meanRemovalToolStripMenuItem
            // 
            this.meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            this.meanRemovalToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.meanRemovalToolStripMenuItem.Text = "Mean Removal";
            this.meanRemovalToolStripMenuItem.Click += new System.EventHandler(this.meanRemovalToolStripMenuItem_Click);
            // 
            // embossingToolStripMenuItem
            // 
            this.embossingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.embossLaplascianToolStripMenuItem,
            this.horizontalVerticalToolStripMenuItem,
            this.allDirectionsToolStripMenuItem,
            this.lossyToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalOnlyToolStripMenuItem});
            this.embossingToolStripMenuItem.Name = "embossingToolStripMenuItem";
            this.embossingToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.embossingToolStripMenuItem.Text = "Embossing";
            // 
            // embossLaplascianToolStripMenuItem
            // 
            this.embossLaplascianToolStripMenuItem.Name = "embossLaplascianToolStripMenuItem";
            this.embossLaplascianToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.embossLaplascianToolStripMenuItem.Text = "Emboss Laplascian";
            this.embossLaplascianToolStripMenuItem.Click += new System.EventHandler(this.embossLaplascianToolStripMenuItem_Click);
            // 
            // horizontalVerticalToolStripMenuItem
            // 
            this.horizontalVerticalToolStripMenuItem.Name = "horizontalVerticalToolStripMenuItem";
            this.horizontalVerticalToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.horizontalVerticalToolStripMenuItem.Text = "Horizontal / Vertical";
            this.horizontalVerticalToolStripMenuItem.Click += new System.EventHandler(this.horizontalVerticalToolStripMenuItem_Click);
            // 
            // allDirectionsToolStripMenuItem
            // 
            this.allDirectionsToolStripMenuItem.Name = "allDirectionsToolStripMenuItem";
            this.allDirectionsToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.allDirectionsToolStripMenuItem.Text = "All Directions";
            this.allDirectionsToolStripMenuItem.Click += new System.EventHandler(this.allDirectionsToolStripMenuItem_Click);
            // 
            // lossyToolStripMenuItem
            // 
            this.lossyToolStripMenuItem.Name = "lossyToolStripMenuItem";
            this.lossyToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.lossyToolStripMenuItem.Text = "Lossy";
            this.lossyToolStripMenuItem.Click += new System.EventHandler(this.lossyToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.horizontalToolStripMenuItem.Text = "Horizontal Only";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalOnlyToolStripMenuItem
            // 
            this.verticalOnlyToolStripMenuItem.Name = "verticalOnlyToolStripMenuItem";
            this.verticalOnlyToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.verticalOnlyToolStripMenuItem.Text = "Vertical Only";
            this.verticalOnlyToolStripMenuItem.Click += new System.EventHandler(this.verticalOnlyToolStripMenuItem_Click);
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
            this.rotateTB.Scroll += new System.EventHandler(this.rotateTB_Scroll);
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
            this.contrastTB.Scroll += new System.EventHandler(this.contrastTB_Scroll);
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
            this.brightnessTB.Scroll += new System.EventHandler(this.brightnessTB_Scroll);
            // 
            // vidFilterTimer
            // 
            this.vidFilterTimer.Tick += new System.EventHandler(this.vidFilterTimer_Tick);
            // 
            // coinsToolStripMenuItem
            // 
            this.coinsToolStripMenuItem.Name = "coinsToolStripMenuItem";
            this.coinsToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.coinsToolStripMenuItem.Text = "Coins ";
            this.coinsToolStripMenuItem.Click += new System.EventHandler(this.coinsToolStripMenuItem_Click);
            // 
            // Part1
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
            this.Name = "Part1";
            this.Text = "Part 1: Basic Image Processing w Conv Matrix Processes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Part1Form_Closing);
            this.Load += new System.EventHandler(this.Part1Form_Load);
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
        private System.Windows.Forms.ToolStripMenuItem VGreyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webCamVidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VideoOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rotationLBL;
        private System.Windows.Forms.TrackBar rotateTB;
        private System.Windows.Forms.Label contrastLBL;
        private System.Windows.Forms.TrackBar contrastTB;
        private System.Windows.Forms.Label brightnessLBL;
        private System.Windows.Forms.TrackBar brightnessTB;
        private ToolStripMenuItem VInversionToolStripMenuItem;
        private ToolStripMenuItem VHistogramToolStripMenuItem;
        private ToolStripMenuItem VSepiaToolStripMenuItem;
        private ToolStripMenuItem btnGoToPart2;
        private ToolStripMenuItem part3ConvToolStripMenuItem;
        private ToolStripMenuItem smoothingToolStripMenuItem;
        private ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private ToolStripMenuItem sharpenToolStripMenuItem;
        private ToolStripMenuItem meanRemovalToolStripMenuItem;
        private ToolStripMenuItem embossingToolStripMenuItem;
        private ToolStripMenuItem embossLaplascianToolStripMenuItem;
        private ToolStripMenuItem horizontalVerticalToolStripMenuItem;
        private ToolStripMenuItem allDirectionsToolStripMenuItem;
        private ToolStripMenuItem lossyToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalOnlyToolStripMenuItem;
        private Timer vidFilterTimer;
        private ToolStripMenuItem coinsToolStripMenuItem;
    }
}

