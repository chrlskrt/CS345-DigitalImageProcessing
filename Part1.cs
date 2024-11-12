using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ImageProcess2;
using AForge.Video;
using AForge.Video.DirectShow;

namespace DigitalImageProcessing
{
    public enum FilterType
    {
        GreyScale,
        Sepia,
        Inverted,
        Histogram,
        Brightness,
        Contrast,
        MirrorVertical,
        MirrorHorizontal,
        Rotate
    }
    public partial class Part1 : Form
    {
        private Bitmap loadedImage, processedImage;
        private Part2 part2Form;
        private bool isVideoOn = false;
        private bool isVidFilterOn = false;
        private FilterType currentFilter;
        private FilterInfoCollection videoDevices;  // List of available video devices
        private VideoCaptureDevice videoSource;     // Video capture device
        private readonly object imageLock = new object();   // lock for thread safety
        public Part1()
        {
            InitializeComponent();
        }

        private void Part1Form_Load(object sender, EventArgs e)
        {
            part2Form = new Part2();
            LoadVideoDevices();
        }

        private void Part1Form_Closing(object sender, FormClosingEventArgs e)
        {
            StopVideo();
            part2Form.Dispose();
        }

        private void btnGoToPart2_Click(object sender, EventArgs e)
        {
            part2Form.Owner = this;
            part2Form.Show();
            this.Hide();
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

        /* Digital Image Processing - Images */
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
            ProcessImageFilter(FilterType.GreyScale);
        }
        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessImageFilter(FilterType.Inverted);
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessImageFilter(FilterType.Sepia);
        }

        private void mirrorHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessImageFilter(FilterType.MirrorHorizontal);
        }

        private void mirrorVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessImageFilter(FilterType.MirrorVertical);
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessImageFilter(FilterType.Histogram);
        }

        private void brightnessTB_Scroll(object sender, EventArgs e)
        {
            ProcessImageFilter(FilterType.Brightness);
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

        private void contrastTB_Scroll(object sender, EventArgs e)
        {
            ProcessImageFilter(FilterType.Contrast);
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

        private void rotateTB_Scroll(object sender, EventArgs e)
        {
            ProcessImageFilter(FilterType.Rotate);
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

        /* Main Image Processing */
        private void ProcessImageFilter(FilterType filterType)
        {
            if (loadedImage == null || isVideoOn)
            {
                return;
            }

            switch (filterType)
            {
                case FilterType.GreyScale:
                    BasicDIP.GreyscaleImage(ref loadedImage, ref processedImage);
                    break;
                case FilterType.Sepia:
                    BasicDIP.SepiaImage(ref loadedImage, ref processedImage);
                    break;
                case FilterType.Inverted:
                    BasicDIP.InvertImage(ref loadedImage, ref processedImage);
                    break;
                case FilterType.Histogram:
                    BasicDIP.Histogram(ref loadedImage, ref processedImage);
                    break;
                case FilterType.Brightness:
                    //BasicDIP.Brightness(ref loadedImage, ref processedImage, brightnessTB.Value);
                    processedImage = (Bitmap)loadedImage.Clone();
                    BitmapFilter.Brightness(processedImage, brightnessTB.Value);
                    break;
                case FilterType.Contrast:
                    BasicDIP.Contrast(ref loadedImage, ref processedImage, contrastTB.Value);
                    break;
                case FilterType.Rotate:
                    BasicDIP.RotateImage(ref loadedImage, ref processedImage, rotateTB.Value);
                    break;
            }

            pictureBox2.Image = processedImage;
        }

        /* Digital Image Processing - Video */
        /* Loading all video devices as options */
        private void LoadVideoDevices()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No camera detected.");
                return;
            }

            VideoOnToolStripMenuItem.DropDown.Items.Clear();

            // Creating menu item for each video device
            foreach (FilterInfo device in videoDevices)
            {
                ToolStripMenuItem deviceItem = new ToolStripMenuItem(device.Name);
                deviceItem.Tag = device.MonikerString;
                deviceItem.Click += StartVCDClick;
                VideoOnToolStripMenuItem.DropDownItems.Add(deviceItem);
            }
        }

        /* Function for turning ON the video */
        private void StartVCDClick(object sender, EventArgs e)
        {
            StopVideo();

            /* Getting the selected video device option */
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

        private void VideoOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopVideo();
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

        /* StopVidFilters() - will stop the previous video filter used (if there was any) to avoid program crash
         * StartVidFilter() - will start a new video filter for the video */
        private void VGreyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopVidFilters();
            StartVidFilter(FilterType.GreyScale);
        }

        private void VInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopVidFilters();
            StartVidFilter(FilterType.Inverted);
        }

        private void VHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopVidFilters();
            StartVidFilter(FilterType.Histogram);
        }

        private void VSepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopVidFilters();
            StartVidFilter(FilterType.Sepia);
        }

        private void vidFilterTimer_Tick(object sender, EventArgs e)
        {
            /* By enabling the timer, it will process each new frame 
             * of the video at regular intervals specified by the timer's interval setting.
             * For this project, the intervals is set to 100 */

            ProcessVideoFrameFilter();
        }

        private void StartVidFilter(FilterType filterType)
        {
            if (isVideoOn)
            {
                currentFilter = filterType;
                isVidFilterOn = true;
                vidFilterTimer.Enabled = true;
            }
        }

        private void StopVidFilters()
        {
            if (isVidFilterOn)
            {
                vidFilterTimer.Stop();
                isVidFilterOn = false;
            }
        }

        /* For processing filters onto video */
        private void ProcessVideoFrameFilter()
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

            switch (currentFilter)
            {
                case FilterType.GreyScale:
                    //BasicDIP.GreyscaleImage(ref b, ref processedImage);
                    BitmapFilter.GrayScale(b);
                    break;
                case FilterType.Sepia:
                    //BasicDIP.SepiaImage(ref b, ref processedImage);
                    BitmapFilter.Sepia(b);
                    break;
                case FilterType.Inverted:
                    //BasicDIP.InvertImage(ref b, ref processedImage);
                    BitmapFilter.Invert(b);
                    break;
                case FilterType.Histogram:
                    BasicDIP.Histogram(ref b, ref b);
                    break;
            }

            processedImage?.Dispose();
            processedImage = (Bitmap)b.Clone();

            pictureBox2.Image?.Dispose();
            pictureBox2.Image = processedImage;

            b.Dispose();
        }


        // Convolution Matrix Processes

        private void smoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null) return;

            processedImage = new Bitmap(loadedImage);
            BitmapFilter.Smooth(processedImage);
            pictureBox2.Image = processedImage;
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null) return;

            processedImage = new Bitmap(loadedImage);
            BitmapFilter.GaussianBlur(processedImage);
            pictureBox2.Image = processedImage;
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null) return;

            processedImage = new Bitmap(loadedImage);
            BitmapFilter.Sharpen(processedImage);
            pictureBox2.Image = processedImage;
        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null) return;

            processedImage = new Bitmap(loadedImage);
            BitmapFilter.MeanRemoval(processedImage);
            pictureBox2.Image = processedImage;
        }

        private void embossLaplascianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null) return;

            processedImage = new Bitmap(loadedImage);
            BitmapFilter.EmbossLaplacian(processedImage);
            pictureBox2.Image = processedImage;
        }

        private void horizontalVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null) return;

            processedImage = new Bitmap(loadedImage);
            CustomEmbossFilter.EmbossHorzVert(processedImage);
            pictureBox2.Image = processedImage;
        }

        private void allDirectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null) return;

            processedImage = new Bitmap(loadedImage);
            CustomEmbossFilter.EmbossAllDirections(processedImage);
            pictureBox2.Image = processedImage;
        }

        private void lossyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null) return;

            processedImage = new Bitmap(loadedImage);
            CustomEmbossFilter.EmbossLossy(processedImage);
            pictureBox2.Image = processedImage;
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null) return;

            processedImage = new Bitmap(loadedImage);
            CustomEmbossFilter.EmbossHorizontal(processedImage);
            pictureBox2.Image = processedImage;
        }

        private void verticalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null) return;

            processedImage = new Bitmap(loadedImage);
            CustomEmbossFilter.EmbossVertical(processedImage);
            pictureBox2.Image = processedImage;
        }
    }
}
