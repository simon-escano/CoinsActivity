using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace CoinsActivity
{
    public class Coins
    {
        public static (int, int, int, int, int, int) Count(Bitmap image, PictureBox pbImage)
        {
            BitmapFilter.GrayScale(image);
            BitmapFilter.GaussianBlur(image, 5);
            BitmapFilter.EdgeDetectQuick(image);
            BitmapFilter.EdgeDetectConvolution(image, 1, 255);
            pbImage.Image = image;
            int c5 = 0, c10 = 0, c25 = 0, p1 = 0, p5 = 0, p10 = 0;
            return (c5, c10, c25, p1, p5, p10);
        }
    }
}