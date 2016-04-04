using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitTrackbars();
        }

        private void InitTrackbars()
        {
            if (x1TB.Text.Length == 0)
            {
                x1TB.Text = "0";
            }
            if (y1TB.Text.Length == 0)
            {
                y1TB.Text = "0";
            }
            trackBar1.Maximum = trackBar3.Maximum = Convert.ToInt32(x1TB.Text);
            trackBar1.TickFrequency = trackBar3.TickFrequency = trackBar3.Maximum/10;
            trackBar2.Maximum = trackBar4.Maximum = Convert.ToInt32(y1TB.Text);
            trackBar2.TickFrequency = trackBar4.TickFrequency = trackBar3.Maximum / 10;
        }

        private static void Swap<T>(ref T lhs, ref T rhs) { T temp; temp = lhs; lhs = rhs; rhs = temp; }

        public static void Line(Bitmap image,int x0, int y0, int x1, int y1)
            {
                bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
                if (steep) { Swap<int>(ref x0, ref y0); Swap<int>(ref x1, ref y1); }
                if (x0 > x1) { Swap<int>(ref x0, ref x1); Swap<int>(ref y0, ref y1); }
                int dX = (x1 - x0), dY = Math.Abs(y1 - y0), err = (dX / 2), ystep = (y0 < y1 ? 1 : -1), y = y0;

                for (int x = x0; x <= x1; ++x)
                {
                    if (!(steep ? PutPixel(image,y, x) : PutPixel(image,x, y))) return;
                    err = err - dY;
                    if (err < 0) { y += ystep; err += dX; }
                }
            }

        public static void Simple(Bitmap image, int x0, int y0, int x1, int y1)
        {
            int dx = x1 - x0;
            int dy = y1 - y0;
            for (int x = x0; x < x1; x++)
            {
                int y = y0 + dy*(x - x0)/dx;
                PutPixel(image, x, y);
            }
               

        }
        private static bool PutPixel(Bitmap image, int x0, int y0)
        {
            if((x0>=0 && y0>=0) || (x0 <image.Width && y0 < image.Height))
            image.SetPixel(x0,y0,Color.Black);
            return true;
        }

        static public void Bresenham4Line(Bitmap image, int x, int y)
        {
            Line(image, 0, 0, x, y);
        }
        private static int IPart(float x)
        {
            return (int)x;
        }
        private static float FPart(float x)
        {
            while (x >= 0)
                x--;
            x++;
            return x;
        }
        public static void DrawWuLine(Bitmap image, int x0, int y0, int x1, int y1)
        {
            //Вычисление изменения координат
            int dx = (x1 > x0) ? (x1 - x0) : (x0 - x1);
            int dy = (y1 > y0) ? (y1 - y0) : (y0 - y1);
            //Если линия параллельна одной из осей, рисуем обычную линию - заполняем все пикселы в ряд
            if (dx == 0 || dy == 0)
            {
                Line(image, x0, y0, x1, y1);
                return;
            }

            //Для Х-линии (коэффициент наклона < 1)
            if (dy < dx)
            {
                //Первая точка должна иметь меньшую координату Х
                if (x1 < x0)
                {
                    x1 += x0; x0 = x1 - x0; x1 -= x0;
                    y1 += y0; y0 = y1 - y0; y1 -= y0;
                }
                //Относительное изменение координаты Y
                float grad = (float)dy / dx;
                //Промежуточная переменная для Y
                float intery = y0 + grad;
                //Первая точка
                //PutPixel(image, x0, y0);

                for (int x = x0 + 1; x < x1; x++)
                {
                    //Верхняя точка
                    PutPixel(image, x, IPart(intery), (int)(255 - FPart(intery) * 255));
                    //Нижняя точка
                    PutPixel(image, x, IPart(intery) + 1, (int)(FPart(intery) * 255));
                    //Изменение координаты Y
                    intery += grad;
                }
                //Последняя точка
              //  PutPixel(image, x1, y1);
            }
            //Для Y-линии (коэффициент наклона > 1)
            else
            {
                //Первая точка должна иметь меньшую координату Y
                if (y1 < y0)
                {
                    x1 += x0; x0 = x1 - x0; x1 -= x0;
                    y1 += y0; y0 = y1 - y0; y1 -= y0;
                }
                //Относительное изменение координаты X
                float grad = (float)dx / dy;
                //Промежуточная переменная для X
                float interx = x0 + grad;
                //Первая точка
               // PutPixel(image, x0, y0);

                for (int y = y0 + 1; y < y1; y++)
                {
                    //Верхняя точка
                    PutPixel(image, IPart(interx), y, 255 - (int)(FPart(interx) * 255));
                    //Нижняя точка
                    PutPixel(image, IPart(interx) + 1, y, (int)(FPart(interx) * 255));
                    //Изменение координаты X
                    interx += grad;
                }
                //Последняя точка
               // PutPixel(image, x1, y1);
            }
        }
       
        public static void DrawWuCircle(Bitmap image, int radius)
        {
            int _x = radius+5, _y = radius+5;
            //Установка пикселов, лежащих на осях системы координат с началом в центре
            PutPixel(image, _x + radius, _y);
            PutPixel(image, _x, _y + radius);
            PutPixel(image, _x - radius + 1, _y);
            PutPixel(image, _x, _y - radius + 1);

            float iy = 0;
            for (int x = 0; x <= radius * Math.Cos(Math.PI / 4); x++)
            {
                //Вычисление точного значения координаты Y 
                iy = (float)Math.Sqrt(radius * radius - x * x);

                //IV квадрант, Y
                PutPixel(image, _x - x, _y + IPart(iy), 255 - (int)(FPart(iy) * 255));
                PutPixel(image, _x - x, _y + IPart(iy) + 1, (int)(FPart(iy) * 255));
                //I квадрант, Y
                PutPixel(image, _x + x, _y + IPart(iy), 255 - (int)(FPart(iy) * 255));
                PutPixel(image, _x + x, _y + IPart(iy) + 1, (int)(FPart(iy) * 255));
                //I квадрант, X
                PutPixel(image, _x + IPart(iy), _y + x, 255 - (int)(FPart(iy) * 255));
                PutPixel(image, _x + IPart(iy) + 1, _y + x, (int)(FPart(iy) * 255));
                //II квадрант, X
                PutPixel(image, _x + IPart(iy), _y - x, 255 - (int)(FPart(iy) * 255));
                PutPixel(image, _x + IPart(iy) + 1, _y - x, (int)(FPart(iy) * 255));

                //С помощью инкремента устраняется ошибка смещения на 1 пиксел
                x++;
                //II квадрант, Y
                PutPixel(image, _x + x, _y - IPart(iy), (int)(FPart(iy) * 255));
                PutPixel(image, _x + x, _y - IPart(iy) + 1, 255 - (int)(FPart(iy) * 255));
                //III квадрант, Y
                PutPixel(image, _x - x, _y - IPart(iy), (int)(FPart(iy) * 255));
                PutPixel(image, _x - x, _y - IPart(iy) + 1, 255 - (int)(FPart(iy) * 255));
                //III квадрант, X
                PutPixel(image, _x - IPart(iy), _y - x, (int)(FPart(iy) * 255));
                PutPixel(image, _x - IPart(iy) + 1, _y - x, 255 - (int)(FPart(iy) * 255));
                //IV квадрант, X
                PutPixel(image, _x - IPart(iy), _y + x, (int)(FPart(iy) * 255));
                PutPixel(image, _x - IPart(iy) + 1, _y + x, 255 - (int)(FPart(iy) * 255));
                //Возврат значения
                x--;
            }
        }

        private static bool PutPixel(Bitmap image, int x0, int y0, int a)
        {
            if ((x0 >= 0 && y0 >= 0) || (x0 < image.Width && y0 < image.Height))
                image.SetPixel(x0, y0, Color.FromArgb(a,Color.Black));
            return true;
        }

        private void GenerateBLine(int x, int y)
        {
            Bitmap bitmap = new Bitmap(x + 1, y + 1);
            Bresenham4Line(bitmap, x, y);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(new Bitmap(x + 1, y + 1), 0, 0, x, y);
            }
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = resizeImage(bitmap, pictureBox1.Size);
        }
        private void GenerateBLine(int x0, int y0,int x,int y)
        {

            Bitmap bitmap = new Bitmap(MaxRadius(x0,x)+2,MaxRadius(y0,y)+2);
            Line(bitmap,x0,y0, x, y);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(new Bitmap(MaxRadius(x0, x)+2, MaxRadius(y0, y)+2), 0, 0, MaxRadius(x0, x)+2, MaxRadius(y0, y)+2);
            }
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = resizeImage(bitmap, pictureBox1.Size);
        }
        private void GenerateBCircle(int radius)
        {
            Bitmap bitmap = new Bitmap(radius * 2 + 10, radius * 2 + 10);
            BresenhamCircle(bitmap, radius);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.SmoothingMode = SmoothingMode.None;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.DrawImage(new Bitmap(radius * 2 + 10, radius * 2 + 10), 0, 0, radius * 2 + 10, radius * 2 + 10);
            }
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = resizeImage(bitmap, pictureBox1.Size);
        }
        private void GenerateWuCircle(int radius)
        {
            Bitmap bitmap = new Bitmap(radius * 2 + 10, radius * 2 + 10);
            DrawWuCircle(bitmap, radius);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.SmoothingMode = SmoothingMode.None;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.DrawImage(new Bitmap(radius * 2 + 10, radius * 2 + 10), 0, 0, radius * 2 + 10, radius * 2 + 10);
            }
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = resizeImage(bitmap, pictureBox1.Size);
        }
        public static void BresenhamCircle(Bitmap image, int radius)
        {
            int _x = radius+5 , _y = radius+5;
            int x = 0, y = radius, gap = 0, delta = (2 - 2 * radius);
            while (y >= 0)
            {
                PutPixel(image, _x + x, _y + y);
                PutPixel(image, _x + x, _y - y);
                PutPixel(image, _x - x, _y - y);
                PutPixel(image, _x - x, _y + y);
                gap = 2 * (delta + y) - 1;
                if (delta < 0 && gap <= 0)
                {
                    x++;
                    delta += 2 * x + 1;
                    continue;
                }
                if (delta > 0 && gap > 0)
                {
                    y--;
                    delta -= 2 * y + 1;
                    continue;
                }
                x++;
                delta += 2 * (x - y);
                y--;
            }
        }
        private static Image resizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }
        public int MaxRadius(int x, int y)
        {
            if (x <= y)
            {
                if ((x >= 0 && y >= 0) || (x <= 0 && y <= 0))
                    return Math.Abs(x + y);
                if (x <= 0 && y >= 0)
                    return -x + y;
            }
            else
            {
                if ((x >= 0 && y >= 0) || (x <= 0 && y <= 0))
                    return Math.Abs(x + y);
                if (x >= 0 && y <= 0)
                    return x - y;
            }
            return 0;
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (checkedListBox1.GetSelected(0))
            {
                label1.Text = "max x";
                label2.Text = "max y";
                y1TB.Enabled = true;
                x1TB.Enabled = true;
                if (!isFromNullCB.Checked)
                {
                    trackBar2.Enabled = true;
                    trackBar1.Enabled = true;
                }
                trackBar3.Enabled = true;
                trackBar4.Enabled = true;

            }
            else if (checkedListBox1.GetSelected(1))
            {
                label1.Text = "radius";
                label2.Text = "";
                y1TB.Enabled = false;
                trackBar2.Enabled = false;
                trackBar1.Enabled = false;
                trackBar4.Enabled = false;

            }
            else if (checkedListBox1.GetSelected(2))
            {
                label1.Text = "max x";
                label2.Text = "max y";
                y1TB.Enabled = true;
                x1TB.Enabled = true;

                trackBar2.Enabled = true;
                    trackBar1.Enabled = true;
                
                trackBar3.Enabled = true;
                trackBar4.Enabled = true;
            }
            else if (checkedListBox1.GetSelected(3))
            {
                // isFromNullCB.Checked = true;
                label1.Text = "max x";
                label2.Text = "max y";
                y1TB.Enabled = true;
                x1TB.Enabled = true;
                if (!isFromNullCB.Checked)
                {
                    trackBar2.Enabled = true;
                    trackBar1.Enabled = true;
                }
                trackBar3.Enabled = true;
                trackBar4.Enabled = true;
            }
            else if (checkedListBox1.GetSelected(4))
            {
                // isFromNullCB.Checked = true;
                label1.Text = "max x";
                label2.Text = "max y";
                y1TB.Text = "10";
                x1TB.Text = "10";
                y1TB.Enabled = false;
                x1TB.Enabled = false;
                if (!isFromNullCB.Checked)
                {
                    trackBar2.Enabled = true;
                    trackBar1.Enabled = true;
                }
                trackBar3.Enabled = true;
                trackBar4.Enabled = true;
            }
            else if (checkedListBox1.GetSelected(5))
            {

                label1.Text = "radius";
                label2.Text = "";
                y1TB.Enabled = false;
                x1TB.Enabled = true;
                trackBar2.Enabled = false;
                trackBar1.Enabled = false;
                trackBar4.Enabled = false;

            }


        }
        private void y1TB_TextChanged(object sender, EventArgs e)
        {
           InitTrackbars();
        }

        private void x1TB_TextChanged(object sender, EventArgs e)
        {
            InitTrackbars();
        }

        private void isFromNullCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isFromNullCB.Checked)
            {
                trackBar1.Enabled = false;
            
            trackBar2.Enabled = false;
            }
            else
            {
                trackBar1.Enabled = true;

                trackBar2.Enabled = true;
            }
    }
        private void ShowLine()
        {
            label6.Text = "x0: " + trackBar1.Value;
            label5.Text = "y0: " + trackBar2.Value;
            label8.Text = "x1: " + trackBar3.Value;
            label7.Text = "y1: " + trackBar4.Value;
            if (checkedListBox1.GetSelected(0))
            {
                if (isFromNullCB.Checked)
                {
                    GenerateBLine(trackBar3.Value, trackBar4.Value);
                }
                else
                {
                    GenerateBLine(trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value);
                }
            }
            else if (checkedListBox1.GetSelected(1))
            {
                GenerateBCircle(trackBar3.Value);
            }
            else if (checkedListBox1.GetSelected(2))
            {
                GenerateDDA(trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value);
            }
            else if (checkedListBox1.GetSelected(3))
            {
               // isFromNullCB.Checked = true;
                GenerateSimple(trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value);
            }
            else if (checkedListBox1.GetSelected(4))
            {
                GenerateWu(trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value);
            }
            else if (checkedListBox1.GetSelected(5))
            {
                GenerateWuCircle(trackBar3.Value);
            }
        }

        private void GenerateWu(int x0, int y0, int x, int y)
        {
            Bitmap bitmap = new Bitmap(MaxRadius(x0, x) + 20, MaxRadius(y0, y) + 20);
            
            DrawWuLine(bitmap, x0, y0, x, y);

            using (Graphics g = Graphics.FromImage(bitmap))
            {

                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(new Bitmap(MaxRadius(x0, x) + 20, MaxRadius(y0, y) + 20), 0, 0, MaxRadius(x0, x) + 20, MaxRadius(y0, y) + 20);
            }
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = resizeImage(bitmap, pictureBox1.Size);
        }

        private void GenerateDDA(int x0, int y0, int x1, int y1)
        {
            Bitmap bitmap = new Bitmap(MaxRadius(x0, x1) + 2, MaxRadius(y0, y1) + 2);
            DDA(bitmap, x0, y0, x1, y1);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(new Bitmap(MaxRadius(x0, x1) + 2, MaxRadius(y0, y1) + 2), 0, 0, MaxRadius(x0, x1) + 2, MaxRadius(y0, y1) + 2);
            }
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = resizeImage(bitmap, pictureBox1.Size);
        }

        private void DDA(Bitmap bitmap, int x0, int y0, int x1, int y1)
        {
            int dx = x1 - x0;
            int dy = y1 - y0;
            int step, k;
            float xInc, yInc, x = x0, y = y0;
            if (Math.Abs(dx) > Math.Abs(dy))
                step = Math.Abs(dx);
            else
                step = Math.Abs(dy);
            xInc =(float) dx/step;
            yInc = (float)dy /step;
            PutPixel(bitmap, (int) x, (int) y);
            for (k = 0; k < step; k++)
            {
                x += xInc;
                y += yInc;
                PutPixel(bitmap, (int) x, (int) y);
            }
        }

        private void GenerateSimple(int x0, int y0, int x1, int y1)
        {
            Bitmap bitmap = new Bitmap(MaxRadius(x0, x1) + 2, MaxRadius(y0, y1) + 2);
            Simple(bitmap, x0, y0, x1, y1);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(new Bitmap(MaxRadius(x0, x1) + 2, MaxRadius(y0, y1) + 2), 0, 0, MaxRadius(x0, x1) + 2, MaxRadius(y0, y1) + 2);
            }
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = resizeImage(bitmap, pictureBox1.Size);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ShowLine();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            ShowLine();
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            ShowLine();
        }
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            ShowLine();
        }
    }

}
