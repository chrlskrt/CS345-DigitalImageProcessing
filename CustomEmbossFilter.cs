using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcess2
{
    static class CustomEmbossFilter
    {
        public static bool EmbossHorzVert(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(-1);
            m.TopLeft = m.TopRight = m.BottomLeft = m.BottomRight = 0;
            m.Pixel = 4;
            m.Offset = 127;

            return BitmapFilter.Conv3x3(b, m);
        }

        public static bool EmbossAllDirections(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(-1);
            m.Pixel = 8;
            m.Offset = 127;

            return BitmapFilter.Conv3x3(b, m);
        }

        public static bool EmbossLossy(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(-2);
            m.TopLeft = m.TopRight = m.BottomMid = 1;
            m.Pixel = 4;
            m.Offset = 127;

            return BitmapFilter.Conv3x3(b, m);
        }

        public static bool EmbossHorizontal(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(0);
            m.MidLeft = m.MidRight = -1;
            m.Pixel = 2;
            m.Offset = 127;

            return BitmapFilter.Conv3x3(b, m);
        }

        public static bool EmbossVertical(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(0);
            m.TopMid = -1;
            m.BottomMid = 1;
            m.Pixel = 0;
            m.Offset = 127;

            return BitmapFilter.Conv3x3(b, m);
        }
    }
}
