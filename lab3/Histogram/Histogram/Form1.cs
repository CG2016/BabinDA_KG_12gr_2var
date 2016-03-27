using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Histogram.Properties;
using ImageMagick;
using ZedGraph;

namespace Histogram
{
    public partial class Histogram : Form
    {
        private Image _image;

        public Histogram()
        {
            InitializeComponent();
        }


        private void myPictureBox_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void LoadImage()
        {
            var file = new OpenFileDialog();
            file.Filter = Resources.Histogram_LoadImage_Image_Files;
            if (file.ShowDialog() == DialogResult.OK)
            {
                var path = Path.GetExtension(file.FileName);
                if (path != null)
                {
                    var extension = path.ToUpper();

                    if (extension == ".PCX")
                    {
                        using (MagickImage magickImage = new MagickImage(file.FileName))
                        {
                            magickImage.Format = MagickFormat.Bmp;
                            _image = magickImage.ToBitmap();
                        }
                    }
                    else
                    {
                        _image = Image.FromFile(file.FileName);
                    }
                    CalculateColors(_image);
                    myPictureBox.Image = _image;
                }
            }
        }

        private void CalculateColors(Image image)
        {
            var red = new double[256];
            var green = new double[256];
            var blue = new double[256];


            double redTotal = 0;
            double greenTotal = 0;
            double blueTotal = 0;

            var bitmap = new Bitmap(image);
            if (!isParallelCB.Checked)
            {
                for (var i = 0; i < bitmap.Width; i++)
                {
                    for (var j = 0; j < bitmap.Height; j++)
                    {
                        var pixel = bitmap.GetPixel(i, j);

                        red[pixel.R]++;
                        green[pixel.G]++;
                        blue[pixel.B]++;
                        redTotal += pixel.R;
                        greenTotal += pixel.G;
                        blueTotal += pixel.B;
                    }
                }
            }
            else
            {
                var rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                var bitmapData = bitmap.LockBits(rect, ImageLockMode.ReadWrite,
                    bitmap.PixelFormat);
                var ptr = bitmapData.Scan0;

                // Declare an array to hold the bytes of the bitmap.
                var bytes = Math.Abs(bitmapData.Stride)*bitmap.Height;
                var source = new byte[bytes];
                // Copy the RGB values into the array.
                Marshal.Copy(ptr, source, 0, bytes);
                Parallel.ForEach(SteppedIterator(0, source.Length, 4),
                    index =>
                        ExecutePixel(index, source, ref red, ref green, ref blue, ref redTotal, ref greenTotal,
                            ref blueTotal));
                Marshal.Copy(source, 0, ptr, bytes);

                // Unlock the bits.
                bitmap.UnlockBits(bitmapData);
            }

            var pixelsTotal = bitmap.Width*bitmap.Height;
            DrawGraph(red, green, blue, redTotal/pixelsTotal, greenTotal/pixelsTotal, blueTotal/pixelsTotal);
        }

        private void ExecutePixel(int index, byte[] source, ref double[] red, ref double[] green, ref double[] blue,
            ref double redTotal, ref double greenTotal, ref double blueTotal)
        {
            blue[source[index]] += 1;
            green[source[index + 1]] += 1;
            red[source[index + 2]] += 1;
            blueTotal += source[index];
            greenTotal += source[index + 1];
            redTotal += source[index + 2];
        }

        private static IEnumerable<int> SteppedIterator(int startIndex, int endIndex, int stepSize)
        {
            for (var i = startIndex; i < endIndex; i += stepSize)
            {
                yield return i;
            }
        }

        private void DrawGraph(double[] redValues, double[] greenValues, double[] blueValues, double red, double green,
            double blue)
        {
            // Получим панель для рисования
            var pane = myZedGraphControl.GraphPane;

            // Размеры шрифтов для разных элементов графика
            var labelsXfontSize = 5;
            var labelsYfontSize = 5;

            var titleXFontSize = 10;
            var titleYFontSize = 10;

            var legendFontSize = 10;

            var mainTitleFontSize = 10;

            // Установим размеры шрифтов для меток вдоль осей
            pane.XAxis.Scale.FontSpec.Size = labelsXfontSize;
            pane.YAxis.Scale.FontSpec.Size = labelsYfontSize;

            // Установим размеры шрифтов для подписей по осям
            pane.XAxis.Title.FontSpec.Size = titleXFontSize;
            pane.YAxis.Title.FontSpec.Size = titleYFontSize;

            // Установим размеры шрифта для легенды
            pane.Legend.FontSpec.Size = legendFontSize;

            // Установим размеры шрифта для общего заголовка
            pane.Title.FontSpec.Size = mainTitleFontSize;
            pane.Title.FontSpec.IsUnderline = true;
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            pane.Title.Text = "Histogram";
            pane.Title.FontSpec.FontColor = Color.Black;

            var itemscount = 256;

            // Подписи под столбиками
            var names = new double[itemscount];


            // Заполним данные
            for (var i = 0; i < itemscount; i++)
            {
                names[i] = i;
            }

            // Создадим кривую-гистограмму
            // Первый параметр - название кривой для легенды
            // Второй параметр - значения для оси X, т.к. у нас по этой оси будет идти текст, а функция ожидает тип параметра double[], то пока передаем null
            // Третий параметр - значения для оси Y
            // Четвертый параметр - цвет
            var curve = pane.AddCurve("Red: " + red, names, redValues, Color.Red, SymbolType.None);
            var curve2 = pane.AddCurve("Green: " + green, names, greenValues, Color.Green, SymbolType.None);
            var curve3 = pane.AddCurve("Blue: " + blue, names, blueValues, Color.Blue, SymbolType.None);
            /*  curve.Bar.Fill.Type = FillType.Solid;
              curve2.Bar.Fill.Type = FillType.Solid;
              curve3.Bar.Fill.Type = FillType.Solid;

              // Сделаем границы столбцов невидимыми
          //    curve.Bar.Border.IsVisible = false;
              curve2.Bar.Border.IsVisible = false;
              curve3.Bar.Border.IsVisible = false;
              */

            if (isSmooth.Checked)
            {
                curve.Line.IsSmooth = true;
                curve2.Line.IsSmooth = true;
                curve3.Line.IsSmooth = true;
            }
            pane.BarSettings.MinClusterGap = 0.0f;
            pane.XAxis.Scale.Min = -1;
            pane.XAxis.Scale.Max = 256;
            pane.YAxis.Scale.Min = 0;
            pane.YAxis.Scale.Max = redValues.Max();
            pane.XAxis.Title.Text = "Color value";
            pane.XAxis.Color = Color.Black;
            pane.YAxis.Title.Text = "Pixel count";
            pane.YAxis.Color = Color.Black;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            myZedGraphControl.AxisChange();

            // Обновляем график
            myZedGraphControl.Invalidate();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void isSmooth_CheckedChanged(object sender, EventArgs e)
        {
            if (_image != null)
            {
                CalculateColors(_image);
                myPictureBox.Image = _image;
            }
        }

        private void isParallelCB_CheckedChanged(object sender, EventArgs e)
        {
            if (_image != null)
            {
                CalculateColors(_image);
                myPictureBox.Image = _image;
            }
        }
    }
}