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
        private void GenerateBLine(int x, int y)
        {
            Bitmap bitmap = new Bitmap(x + 1, y + 1);
            Bresenham4Line(bitmap, x, y);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(new Bitmap(x + 1, y + 1), 0, 0, x, y);
            }

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
                g.DrawImage(new Bitmap(radius * 2+10, radius * 2+10), 0, 0, radius * 2+10, radius * 2+10);
            }

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
                if (!isFromNullCB.Checked)
                {
                    trackBar2.Enabled = true;
                    trackBar1.Enabled = true;
                }
                trackBar3.Enabled = true;
                trackBar4.Enabled = true;
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
