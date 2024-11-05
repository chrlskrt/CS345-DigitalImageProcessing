using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleImageProcessing;

namespace DigitalImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap loadedImage, processedImage;
        private SubtractForm subForm;
        public Form1()
        {
            InitializeComponent();
            subForm = new SubtractForm();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loadedImage = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loadedImage;
        }

        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.InvertImage(ref loadedImage, ref processedImage);
            pictureBox2.Image = processedImage;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.SepiaImage(ref loadedImage, ref processedImage);
            pictureBox2.Image = processedImage;
        }

        private void mirrorHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.MirrorImageHorizantal(ref loadedImage, ref processedImage);
            pictureBox2.Image = processedImage;
        }

        private void mirrorVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.MirrorImageVertical(ref loadedImage, ref processedImage);
            pictureBox2.Image = processedImage;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.Histogram(ref loadedImage, ref processedImage);
            pictureBox2.Image = processedImage;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
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
            BasicDIP.Contrast(ref loadedImage, ref processedImage, contrastTB.Value);
            pictureBox2.Image = processedImage;
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {

        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subForm.Owner = this;
            subForm.Show();
            this.Hide();
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.GreyscaleImage(ref loadedImage, ref processedImage);
            pictureBox2.Image = processedImage;
        }
    }
}
