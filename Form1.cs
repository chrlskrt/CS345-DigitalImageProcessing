using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ImageProcess2;
using AForge.Video;
using AForge.Video.DirectShow;
using WebCamLib;
using System.Drawing.Imaging;

namespace DigitalImageProcessing
{
    public enum FilterType
    {
        GreyScale,
        Sepia,
        Inverted,
        Histogram
    }
    public partial class Form1 : Form
    {
        private Bitmap loadedImage, processedImage;
        private SubtractForm subForm;
        private bool isVideoOn = false;
        private bool isVidFilterOn = false;
        private FilterType currentFilter;
        //Device[] devices;
        private FilterInfoCollection videoDevices;  // List of available video devices
        private VideoCaptureDevice videoSource;     // Video capture device
        private readonly object imageLock = new object();   // lock for thread safety
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            subForm = new SubtractForm();
            LoadVideoDevices();
            //devices = DeviceManager.GetAllDevices();
        }

        private void LoadVideoDevices()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No camera detected.");
                return;
            }

            oNToolStripMenuItem.DropDown.Items.Clear();

            // Creating menu item for each video device
            foreach (FilterInfo device in videoDevices)
            {
                ToolStripMenuItem deviceItem = new ToolStripMenuItem(device.Name);
                deviceItem.Tag = device.MonikerString;
                deviceItem.Click += StartVCDClick;
                oNToolStripMenuItem.DropDownItems.Add(deviceItem);
            }
        }

        private void StartVCDClick(object sender, EventArgs e)
        {
            StopVideo();

            ToolStripMenuItem selectedItem = sender as ToolStripMenuItem;
            string monikerString = selectedItem?.Tag.ToString();

            if (monikerString != null)
            {
                videoSource = new VideoCaptureDevice(monikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();
                isVideoOn = true;
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs e)
        {
            lock (imageLock)
            {
                loadedImage?.Dispose(); // dispose previous frame
                loadedImage = (Bitmap)e.Frame.Clone(); // clone new frame
            }

            pictureBox1.Image?.Dispose(); // Dispose previous frame
            pictureBox1.Image = (Bitmap)loadedImage.Clone();
        }

        private void StopVideo()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
                isVideoOn = false;

                StopVidFilters();
            }
        }

        private void StopVidFilters()
        {
            if (isVidFilterOn)
            {
                greyTimer.Stop();
                invertTimer.Stop();
                sepiaTimer.Stop();
                histTimer.Stop();

                isVidFilterOn = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopVideo();
            subForm.Dispose();
        }

        private void oFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopVideo();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loadedImage = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loadedImage;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processedImage == null || isVideoOn)
            {
                return;
            }

            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            processedImage.Save(saveFileDialog1.FileName);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        //Digital Image Processing
        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null || isVideoOn)
            {
                return;
            }

            processedImage = new Bitmap(loadedImage.Width, loadedImage.Height);
            Color pixel;
            for (int x = 0; x < loadedImage.Width; x++)
            {
                for (int y = 0; y < loadedImage.Height; y++)
                {
                    pixel = loadedImage.GetPixel(x, y);

                    processedImage.SetPixel(x, y, pixel);
                }
            }

            pictureBox2.Image = processedImage;
        }
        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null || isVideoOn)
            {
                return;
            }

            BasicDIP.GreyscaleImage(ref loadedImage, ref processedImage);
            pictureBox2.Image = processedImage;
        }
        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null || isVideoOn)
            {
                return;
            }

            BasicDIP.InvertImage(ref loadedImage, ref processedImage);
            pictureBox2.Image = processedImage;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null || isVideoOn)
            {
                return;
            }

            BasicDIP.SepiaImage(ref loadedImage, ref processedImage);
            pictureBox2.Image = processedImage;
        }

        private void mirrorHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null || isVideoOn)
            {
                return;
            }

            BasicDIP.MirrorImageHorizantal(ref loadedImage, ref processedImage);
            pictureBox2.Image = processedImage;
        }

        private void mirrorVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null)
            {
                return;
            }

            BasicDIP.MirrorImageVertical(ref loadedImage, ref processedImage);
            pictureBox2.Image = processedImage;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null || isVideoOn)
            {
                return;
            }

            BasicDIP.Histogram(ref loadedImage, ref processedImage);
            pictureBox2.Image = processedImage;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (loadedImage == null || isVideoOn)
            {
                return;
            }

            BasicDIP.Brightness(ref loadedImage, ref processedImage, brightnessTB.Value);
            pictureBox2.Image = processedImage;
        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (brightnessTB.Visible)
            {
                brightnessLBL.Visible = false;
                brightnessTB.Visible = false;
            } else
            {
                brightnessLBL.Visible = true;
                brightnessTB.Visible = true;
            }
        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contrastTB.Visible)
            {
                contrastLBL.Visible = false;
                contrastTB.Visible = false;
            } else
            {
                contrastLBL.Visible = true;
                contrastTB.Visible = true;
            }
        }

        private void contrastTB_Scroll(object sender, EventArgs e)
        {
            if (loadedImage == null || isVideoOn)
            {
                return;
            }

            BasicDIP.Contrast(ref loadedImage, ref processedImage, contrastTB.Value);
            pictureBox2.Image = processedImage;
        }

        private void rotateTB_Scroll(object sender, EventArgs e)
        {
            if (loadedImage == null || isVideoOn)
            {
                return;
            }

            BasicDIP.RotateImage(ref loadedImage, ref processedImage, rotateTB.Value);
            pictureBox2.Image = processedImage;
        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subForm.Owner = this;
            subForm.Show();
            this.Hide();
        }

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rotateTB.Visible)
            {
                rotationLBL.Visible = false;
                rotateTB.Visible = false;
            } else
            {
                rotationLBL.Visible = true;
                rotateTB.Visible = true;
            }
        }

        private void oNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //devices[0].ShowWindow(pictureBox1);
        }

        //For WebCam Filters
        private void ProcessFrame()
        {
            if (loadedImage == null)
            {
                return;
            }

            Bitmap b;
            lock (imageLock)
            {
                b = (Bitmap)loadedImage.Clone();
            }

            processedImage?.Dispose();
            processedImage = new Bitmap(b.Width, b.Height);

            switch (currentFilter)
            {
                case FilterType.GreyScale:
                    BasicDIP.GreyscaleImage(ref b, ref processedImage);
                    //ImageProcess2.BitmapFilter.GrayScale(b);
                    break;
                case FilterType.Sepia:
                    BasicDIP.SepiaImage(ref b, ref processedImage);
                    break;
                case FilterType.Inverted:
                    BasicDIP.InvertImage(ref b, ref processedImage);
                    break;
                case FilterType.Histogram:
                    BasicDIP.Histogram(ref b, ref processedImage);
                    break;
            }

            pictureBox2.Image?.Dispose();
            pictureBox2.Image = processedImage;
            //pictureBox2.Image = b;

            b.Dispose();
        }

        //WebCam
        private void greyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopVidFilters();

            if (!greyTimer.Enabled && isVideoOn)
            {
                currentFilter = FilterType.GreyScale;
                isVidFilterOn = true;
                greyTimer.Enabled = true;
            }
        }

        private void inversionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StopVidFilters();

            if (!invertTimer.Enabled && isVideoOn)
            {
                currentFilter = FilterType.Inverted;
                isVidFilterOn = true;
                invertTimer.Enabled = true;
            }
        }

        private void histogramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!histTimer.Enabled && isVideoOn)
            {
                currentFilter = FilterType.Histogram;
                isVidFilterOn = true;
                histTimer.Enabled = true;
            }
        }

        private void sepiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!sepiaTimer.Enabled && isVideoOn)
            {
                currentFilter = FilterType.Sepia;
                isVidFilterOn = true;
                sepiaTimer.Enabled = true;
            }
        }

        private void sepiaTimer_Tick(object sender, EventArgs e)
        {
            ProcessFrame();
        }

        private void invertTimer_Tick(object sender, EventArgs e)
        {
            ProcessFrame();
        }

        private void histTimer_Tick(object sender, EventArgs e)
        {
            ProcessFrame();
        }

        private void greyTimer_Tick(object sender, EventArgs e)
        {
            ProcessFrame();
        }
    }
}
