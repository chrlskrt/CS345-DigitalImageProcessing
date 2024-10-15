using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap loadedImage, processedImage;
        public Form1()
        {
            InitializeComponent();
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
            processedImage = new Bitmap(loadedImage.Width, loadedImage.Height);
            Color pixel;
  
            for (int x = 0; x < loadedImage.Width; x++)
            {
                for (int y = 0; y < loadedImage.Height; y++)
                {
                    pixel = loadedImage.GetPixel(x, y);

                    Color inverted = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    processedImage.SetPixel(x, y, inverted);
                }
            }

            pictureBox2.Image = processedImage;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(loadedImage.Width, loadedImage.Height);
            Color pixel;
            for (int x = 0; x < loadedImage.Width; x++)
            {
                for (int y = 0; y < loadedImage.Height; y++)
                {
                    pixel = loadedImage.GetPixel(x, y);
                    
                    int new_red = (int)((pixel.R * .393) + (pixel.G * .769) + (pixel.B * .189));
                    int new_green = (int)((pixel.R * .349) + (pixel.G * .686) + (pixel.B * .168));
                    int new_blue = (int)((pixel.R * .272) + (pixel.G * .534) + (pixel.B * .131));

                    new_red = (new_red > 255) ? 255 : new_red;
                    new_green = (new_green > 255) ? 255 : new_green;
                    new_blue = (new_blue > 255) ? 255 : new_blue;

                    Color sepia_pixel = Color.FromArgb(new_red, new_green, new_blue);
                    processedImage.SetPixel(x, y, sepia_pixel);
                }
            }

            pictureBox2.Image = processedImage;
        }

        private void mirrorHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(loadedImage.Width, loadedImage.Height);
            Color pixel;
            int width = loadedImage.Width;
            int height = loadedImage.Height;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    pixel = loadedImage.GetPixel(x, y);

                    processedImage.SetPixel(width - x - 1, y, pixel);
                }
            }

            pictureBox2.Image = processedImage;
        }

        private void mirrorVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(loadedImage.Width, loadedImage.Height);
            Color pixel;
            int width = loadedImage.Width;
            int height = loadedImage.Height;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    pixel = loadedImage.GetPixel(x, y);

                    processedImage.SetPixel(x, height - y - 1, pixel);
                }
            }

            pictureBox2.Image = processedImage;
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processedImage = new Bitmap(loadedImage.Width, loadedImage.Height);
            Color pixel;
            int grey;
            for (int x = 0; x < loadedImage.Width; x++)
            {
                for (int y = 0; y < loadedImage.Height; y++)
                {
                    pixel = loadedImage.GetPixel(x, y);
                    grey = (int)(pixel.R + pixel.G + pixel.B) / 3;

                    Color grey_pixel = Color.FromArgb(grey, grey, grey);
                    processedImage.SetPixel(x, y, grey_pixel);
                }
            }

            pictureBox2.Image = processedImage;
        }
    }
}
