using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace Histogram
{
    public partial class Histogram : Form
    {
        public Histogram()
        {
            InitializeComponent();
         

        }

        private Image image;
        private bool imageReady = false;
        
        
    private void myPictureBox_Click(object sender, EventArgs e)
        {
            string path = null;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (file.ShowDialog() == DialogResult.OK)
            {
                imageReady = true;
                path = file.FileName;
                image = Image.FromFile(path);
                CalculateColors(image);
                myPictureBox.Image = image;
            }
        }
        private void CalculateColors(Image image)
        {
            Bitmap bitmap = new Bitmap(image);
            double[] red = new double[256];
            double[] green = new double[256];
            double[] blue = new double[256];
           

            double redTotal = 0;
            double greenTotal = 0;
            double blueTotal = 0;
            BigInteger iterator = 0;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixel = bitmap.GetPixel(i, j);
     
                    red[pixel.R]++;
                    green[pixel.G]++;
                    blue[pixel.B]++;
                    redTotal += pixel.R;
                    greenTotal += pixel.G;
                    blueTotal += pixel.B;
                }
            }

            int pixelsTotal = bitmap.Width * bitmap.Height;
            DrawGraph(red, green, blue, redTotal / pixelsTotal, greenTotal / pixelsTotal, blueTotal / pixelsTotal);
        }
        private void DrawGraph(double[] redValues, double[] greenValues, double[] blueValues,double red,double green, double blue)
        {
            // Получим панель для рисования
            GraphPane pane = myZedGraphControl.GraphPane;

            // Размеры шрифтов для разных элементов графика
            int labelsXfontSize = 5;
            int labelsYfontSize = 5;

            int titleXFontSize = 10;
            int titleYFontSize = 10;

            int legendFontSize = 10;

            int mainTitleFontSize = 10;

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

            int itemscount = 256;

            Random rnd = new Random();

            // Подписи под столбиками
            double[] names = new double[itemscount];


            // Заполним данные
            for (int i = 0; i < itemscount; i++)
            {
                names[i] = i;
            }

            // Создадим кривую-гистограмму
            // Первый параметр - название кривой для легенды
            // Второй параметр - значения для оси X, т.к. у нас по этой оси будет идти текст, а функция ожидает тип параметра double[], то пока передаем null
            // Третий параметр - значения для оси Y
            // Четвертый параметр - цвет
            BarItem curve = pane.AddBar("Red: "+red, names, redValues, Color.Red);
            BarItem curve2 = pane.AddBar("Green: "+green, names, greenValues, Color.Green);
            BarItem curve3 = pane.AddBar("Blue: "+blue, names, blueValues, Color.Blue);
            curve.Bar.Fill.Type = FillType.Solid;
            curve2.Bar.Fill.Type = FillType.Solid;
            curve3.Bar.Fill.Type = FillType.Solid;

            // Сделаем границы столбцов невидимыми
            curve.Bar.Border.IsVisible = false;
            curve2.Bar.Border.IsVisible = false;
            curve3.Bar.Border.IsVisible = false;

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
            string path = null;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (file.ShowDialog() == DialogResult.OK)
            {
                imageReady = true;
                path = file.FileName;
                image = Image.FromFile(path);
                CalculateColors(image);
                myPictureBox.Image = image;
            }
            
        }
    }
}
