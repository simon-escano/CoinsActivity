using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace CoinsActivity
{
    public class Circles
    {
        public class Circle
        {
            public Point CenterPoint { get; set; }
            public float Radius { get; set; }
            public Circle(Point centerPoint, float radius)
            {
                CenterPoint = centerPoint;
                Radius = radius;
            }
        }

        public static List<Circle> Detect(PictureBox pictureBox, double minDist = 30, double param1 = 150, double param2 = 50, int minRadius = 10, int maxRadius = 100)
        {
            Bitmap image = new Bitmap(pictureBox.Image);
            List<Circle> detectedCircles = new List<Circle>();
            
            using (Mat grayImage = new Mat())
            using (Mat sourceImage = BitmapToMat(image))
            {
                CvInvoke.CvtColor(sourceImage, grayImage, ColorConversion.Bgr2Gray);
                CvInvoke.GaussianBlur(grayImage, grayImage, new Size(5, 5), 1.5);
                CircleF[] circles = CvInvoke.HoughCircles(grayImage, HoughModes.Gradient, 1, minDist, param1, param2, minRadius, maxRadius);

                foreach (CircleF circle in circles)
                {
                    detectedCircles.Add(new Circle(
                        new Point((int)circle.Center.X, (int)circle.Center.Y),
                        circle.Radius
                    ));

                    CvInvoke.Circle(sourceImage, new Point((int)circle.Center.X, (int)circle.Center.Y), (int)circle.Radius, new MCvScalar(0, 255, 0), 2);

                    string radiusText = circle.Radius.ToString("F2");
                    int[] baseline = new int[1];
                    Size textSize = CvInvoke.GetTextSize(radiusText, FontFace.HersheySimplex, 0.7, 2, ref baseline[0]);
                    Point textPosition = new Point((int)(circle.Center.X - textSize.Width / 2), (int)(circle.Center.Y + textSize.Height / 2));
                    CvInvoke.PutText(sourceImage, radiusText, textPosition, FontFace.HersheySimplex, 0.7, new MCvScalar(255, 240, 0), 2);
                }

                pictureBox.Image = MatToBitmap(sourceImage);
            }

            return detectedCircles;
        }


        private static Mat BitmapToMat(Bitmap bitmap)
        {
            Mat mat = new Mat();
            using (Bitmap tempBitmap = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format24bppRgb))
            {
                string tempFilePath = Path.GetTempFileName();
                tempBitmap.Save(tempFilePath, ImageFormat.Bmp);
                mat = CvInvoke.Imread(tempFilePath, ImreadModes.Color);
                File.Delete(tempFilePath);
            }
            return mat;
        }

        private static Bitmap MatToBitmap(Mat mat)
        {
            return mat.ToBitmap();
        }
    }
}
