using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalImageProcessing
{
    static class BasicDIP
    {
        public static void GreyscaleImage(ref Bitmap loadedImage, ref Bitmap processedImage)
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
        }
        public static void MirrorImageVertical(ref Bitmap loadedImage, ref Bitmap processedImage)
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
        }
        public static void MirrorImageHorizantal(ref Bitmap loadedImage,  ref Bitmap processedImage)
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
        }
        public static void SepiaImage(ref Bitmap loadedImage, ref Bitmap processedImage)
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
        }
        public static void InvertImage(ref Bitmap loadedImage, ref Bitmap processedImage)
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
        }
        public static void Histogram(ref Bitmap loadedImage, ref Bitmap processedImage)
        {
            Bitmap histImage = new Bitmap(loadedImage.Width, loadedImage.Height);
            GreyscaleImage(ref loadedImage, ref histImage);
            Color sample;
            int[] histData = new int[256];
            for (int x = 0; x < histImage.Width; x++)
            {
                for (int y = 0; y < histImage.Height; y++)
                {
                    sample = histImage.GetPixel(x, y);
                    histData[sample.R]++;
                }
            }

            processedImage = new Bitmap(256, 800); // histogram

            // making the bg of histogram white
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    processedImage.SetPixel(x, y, Color.White);
                }
            }

            // plotting histogram data
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histData[x] / 5, processedImage.Height - 1); y++)
                {
                    processedImage.SetPixel(x, (processedImage.Height - 1) - y, Color.Black);
                }
            }

        }
        public static void Brightness(ref Bitmap loadedImage, ref Bitmap processedImage, int value)
        {
            processedImage = new Bitmap(loadedImage.Width, loadedImage.Height);

            for (int x = 0; x < loadedImage.Width; x++)
            {
                for (int y = 0; y < loadedImage.Height; y++)
                {
                    Color temp = loadedImage.GetPixel(x, y);
                    Color changed;

                    if (value > 0)
                    {
                        changed = Color.FromArgb(Math.Min((temp.R + value), 255), Math.Min((temp.G + value), 255), Math.Min((temp.B + value), 255));
                    }
                    else
                    {
                        changed = Color.FromArgb(Math.Max((temp.R + value), 0), Math.Max((temp.G + value), 0), Math.Max((temp.B + value), 0));

                    }

                    processedImage.SetPixel(x, y, changed);
                }
            }
        }

        public static void Contrast(ref Bitmap loadedImage, ref Bitmap processedImage, int degree)
        {
            int height = loadedImage.Height;
            int width = loadedImage.Width;
            int numSamples, histSum;
            int[] hist = new int[256];
            int[] YMap = new int[256];
            int percent = degree;

            // get histogram array
            // greyscale the image
            Bitmap histImage = new Bitmap(width, height);
            GreyscaleImage(ref loadedImage, ref histImage);

            // getting histogram data
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color grey = histImage.GetPixel(x, y);
                    hist[grey.R]++;
                }
            }

            // remap the Ys, use maximum contrast
            numSamples = width * height;
            histSum = 0;
            for (int x = 0; x < 256; x++) {
                histSum += hist[x];
                YMap[x] = histSum * 255 / numSamples;
            }

            // if desired contrast is not maximum (percent < 100), adjust mapping
            if (percent < 100)
            {
                for (int x = 0; x < 256; x++)
                {
                    histSum += hist[x];
                    YMap[x] = x + ((int) YMap[x] - x) * percent / 100;
                }
            }

            processedImage = new Bitmap(width, height);
            // enhance region by remapping the intensities
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // set new value of the gray value
                    Color temp = Color.FromArgb(YMap[histImage.GetPixel(x, y).R], YMap[histImage.GetPixel(x, y).G], YMap[histImage.GetPixel(x, y).B]);
                    processedImage.SetPixel(x, y, temp);
                }
            }
        }

        public static void RotateImage(ref Bitmap loadedImage, ref Bitmap processedImage, int degree)
        {
            float angle = degree * (float)Math.PI / 180;
            int xCenter = (int)(loadedImage.Width / 2);
            int yCenter = (int)(loadedImage.Height / 2);

            float cosA = (float)Math.Cos(angle);
            float sinA = (float)Math.Sin(angle);

            processedImage = new Bitmap(loadedImage.Width, loadedImage.Height);

            for (int xp = 0; xp < loadedImage.Width; xp++)
            {
                for (int yp = 0; yp < loadedImage.Height; yp++)
                {
                    int x0 = xp - xCenter; 
                    int y0 = yp - yCenter;

                    int xs = (int)(x0 * cosA + y0 * sinA);
                    int ys = (int)(-x0 * sinA + y0 * cosA);

                    xs = (int)(xs + xCenter);
                    ys = (int)(ys + yCenter);

                    xs = Math.Max(0, Math.Min(loadedImage.Width - 1, xs));
                    ys = Math.Max(0, Math.Min(loadedImage.Height - 1, ys));

                    processedImage.SetPixel(xp, yp, loadedImage.GetPixel(xs, ys));
                } 
            }
        } 
    }
}
