using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace aoci04
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> srcImage; //глобальная переменная

        public static int count=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                srcImage = new Image<Bgr, byte>(fileName);

                imageBox1.Image = srcImage.Resize(640, 480, Inter.Linear);
            }
        }


        public Image<Gray, byte> roi(Image<Bgr, byte> image, int b, int g)
        {
            //var grayImage = srcImage.Convert<Gray, byte>();
            var grayImage = image.Convert<Gray, byte>();
            //int kernelSize = 5; // радиус размытия
            var bluredImage = grayImage.SmoothGaussian(b);

            //var threshold = new Gray(80); // пороговое значение
            var color = new Gray(255); // этим цветом будут закрашены пиксели, имеющие значение > threshold
            var binarizedImage = bluredImage.ThresholdBinary(new Gray(g), color);

            //return binarizedImage.Resize(640, 480, Inter.Linear);
            return binarizedImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //for (int i = 0; i < contours.Size; i++)
            //{
            //    var points = approxContour[i].ToArray();
            //    contoursImage.Draw(points, new Bgr(Color.GreenYellow), 1); // отрисовка точек
            //}

            //imageBox2.Image = contoursImage.Resize(640, 480, Inter.Linear);
            imageBox2.Image = roi(srcImage, trackBar9.Value, trackBar5.Value);
        }


        public Image<Bgr, byte> fCircles(Image<Bgr, byte> image, int mnd, int p, int mnr, int mxr)
        {
            var grayImage = image.Convert<Gray, byte>();
            var bluredImage = grayImage.SmoothGaussian(9);

            List<CircleF> circles = new List<CircleF>(CvInvoke.HoughCircles(bluredImage,
                         HoughModes.Gradient,
                         1.0,
                         mnd,//min dist
                         100,
                         p,//porog
                         mnr,//min rad
                         mxr));//max rad

            var resultImage = srcImage.Copy();

            foreach (CircleF circle in circles)
                resultImage.Draw(circle, new Bgr(Color.Blue), 2);
            textBox1.Text = circles.Count.ToString();
            return resultImage.Resize(640, 480, Inter.Linear);
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            imageBox2.Image = fCircles(srcImage, trackBar1.Value * 10, trackBar2.Value, trackBar3.Value, trackBar4.Value * 10);
        }



        public Image<Bgr, byte> fTriangles(Image<Bgr, byte> image, int b, int g, int minmax)
        {
            Image<Gray, byte> binarizedImage = roi(image, b, g);

            var contours = new VectorOfVectorOfPoint(); // контейнер для хранения контуров

            CvInvoke.FindContours(
                binarizedImage, // исходное чёрно-белое изображение
                contours, // найденные контуры
                null, // объект для хранения иерархии контуров (в данном случае не используется)
                RetrType.List, // структура возвращаемых данных (в данном случае список)
                ChainApproxMethod.ChainApproxSimple); // метод аппроксимации (сжимает горизонтальные,
                                                      //вертикальные и диагональные сегменты
                                                      //и оставляет только их конечные точки)



            var contoursImage = srcImage.Copy(); //создание "пустой" копии исходного изображения

            var approxContour = new VectorOfPoint();

            for (int i = 0; i < contours.Size; i++)
            {
                CvInvoke.ApproxPolyDP(
                contours[i], // исходный контур
                approxContour, // контур после аппроксимации
                CvInvoke.ArcLength(contours[i], true) * 0.05, // точность аппроксимации, прямо
                                                              //пропорциональная площади контура
                true); // контур становится закрытым (первая и последняя точки соединяются)

                // var points = approxContour.ToArray();
                // contoursImage.Draw(points, new Bgr(Color.GreenYellow), 1); // отрисовка точек
                if (CvInvoke.ContourArea(approxContour, false) > minmax)
                {
                    //int count = 0;
                    if (approxContour.Size == 3) // если контур содержит 3 точки, то рисуется треугольник
                    {
                        var points = approxContour.ToArray();
                        contoursImage.Draw(new Triangle2DF(points[0], points[1], points[2]),
                        new Bgr(Color.GreenYellow), 2);

                        count++;
                    }
                }
                textBox1.Text = count.ToString();
            }

            return contoursImage.Resize(640, 480, Inter.Linear);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            count = 0;
            imageBox2.Image = fTriangles(srcImage, trackBar9.Value, trackBar5.Value, trackBar6.Value);
        }




        public Image<Bgr, byte> fRect(Image<Bgr, byte> image, int b, int g, int delta, int minmax)
        {
            
            Image<Gray, byte> binarizedImage = roi(image, b, g);

            var contours = new VectorOfVectorOfPoint(); // контейнер для хранения контуров

            CvInvoke.FindContours(
                binarizedImage, // исходное чёрно-белое изображение
                contours, // найденные контуры
                null, // объект для хранения иерархии контуров (в данном случае не используется)
                RetrType.List, // структура возвращаемых данных (в данном случае список)
                ChainApproxMethod.ChainApproxSimple); // метод аппроксимации (сжимает горизонтальные,
                                                      //вертикальные и диагональные сегменты
                                                      //и оставляет только их конечные точки)



            var contoursImage = srcImage.Copy(); //создание "пустой" копии исходного изображения

            var approxContour = new VectorOfPoint();

            for (int i = 0; i < contours.Size; i++)
            {
                CvInvoke.ApproxPolyDP(
                contours[i], // исходный контур
                approxContour, // контур после аппроксимации
                CvInvoke.ArcLength(contours[i], true) * 0.05, // точность аппроксимации, прямо
                                                              //пропорциональная площади контура
                true); // контур становится закрытым (первая и последняя точки соединяются)

                // var points = approxContour.ToArray();
                // contoursImage.Draw(points, new Bgr(Color.GreenYellow), 1); // отрисовка точек
                if (CvInvoke.ContourArea(approxContour, false) > minmax)
                {
                    //int count = 0;
                    //if (approxContour.Size == 4) // если контур содержит 3 точки, то рисуется треугольник
                  //  {
                        var points = approxContour.ToArray();
                        if (rectangleCheck(points, delta) == true)
                        {
                            contoursImage.Draw(CvInvoke.MinAreaRect(approxContour), new Bgr(Color.GreenYellow), 2);

                           count++;
                        }
                    //contoursImage.Draw(new Triangle2DF(points[0], points[1], points[2]),
                    //new Bgr(Color.GreenYellow), 2);

                    //var gnida = new Rectangle(points[0].X, points[3].x, 10, 10);
                    // contoursImage.Draw(new Rectangle(new Point(points[0].X, points[3].Y)), new Bgr(Color.GreenYellow), 2);
                    //contoursImage.Draw(gnida, new Bgr(Color.GreenYellow), 2);
                    // }
                    
                }

                textBox1.Text = count.ToString();

            }

            return contoursImage.Resize(640, 480, Inter.Linear);
        }

        private bool rectangleCheck(Point[] points, int delta)
        {
            LineSegment2D[] edges = PointCollection.PolyLine(points, true);
            for (int i = 0; i < edges.Length; i++)
            {
                double angle = Math.Abs(edges[(i + 1) %
                edges.Length].GetExteriorAngleDegree(edges[i]));
                if (angle < 90 - delta || angle > 90 + delta)
                {
                    return false;
                }
            }
            return true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            count = 0;
            imageBox2.Image = fRect(srcImage, trackBar9.Value, trackBar5.Value, trackBar7.Value, trackBar8.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            imageBox2.Image = srcImage.Canny(trackBar9.Value, trackBar5.Value);
        }

    }
}
