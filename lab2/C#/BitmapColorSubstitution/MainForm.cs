/*
 * ColorReplacer dimababin
*/

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ColorReplacer
{
    public partial class MainForm : Form
    {
        private readonly ColorSubstitutionFilter filterData = new ColorSubstitutionFilter();

        private double gmul;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ApplyFilter()
        {
            if (picSource.Image != null)
            {
                filterData.SourceColor = pnlSourceColor.BackColor;
                filterData.ThresholdValue = (byte)(255.0f / 100.0f * trcThreshHold.Value);
                filterData.NewColor = pnlResultColor.BackColor;

                picResult.Image = ((Bitmap)picSource.Image).ColorSubstitution(filterData);

                pnlFilter.Enabled = true;
                btnSave.Enabled = true;
                btnResultAsSource.Enabled = true;
            }
        }

        private void PictureBoxMouseUpEventHandler(object sender, MouseEventArgs e)
        {
        }

        private void trcThreshHold_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnResultAsSource_Click(object sender, EventArgs e)
        {
            picSource.Image = ((Bitmap)picResult.Image).Format32bppArgbCopy();
        }

        private void ShowColorDialogButtonClickEventHandler(object sender, EventArgs e)
        {
            using (var colorDlg = new ColorDialog())
            {
                colorDlg.AllowFullOpen = true;
                colorDlg.AnyColor = true;
                colorDlg.FullOpen = true;

                if (sender == btnSelectColorToReplace)
                {
                    colorDlg.Color = pnlSourceColor.BackColor;
                }
                else if (sender == btnSelectReplacementColor)
                {
                    colorDlg.Color = pnlResultColor.BackColor;
                }

                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    if (sender == btnSelectColorToReplace)
                    {
                        pnlSourceColor.BackColor = colorDlg.Color;
                    }
                    else if (sender == btnSelectReplacementColor)
                    {
                        pnlResultColor.BackColor = colorDlg.Color;
                    }
                    double hue;
                    double saturation;
                    double value;
                    HSV.ColorToHSV(pnlResultColor.BackColor, out hue, out saturation, out value);
                    hueTB.Value = (int)hue;

                    ApplyFilter();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Title = "Specify a Source file name and file path";
            ofd.Filter = "Jpeg Images(*.jpg)|*.jpg|Png Images(*.png)|*.png|Bitmap Images(*.bmp)|*.bmp";
            var maximal = 1000;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var streamReader = new StreamReader(ofd.FileName);
                var sourceBitmap = new Bitmap(streamReader.BaseStream);
                streamReader.Close();

                picSource.Image = sourceBitmap.Format32bppArgbCopy();
                if (picSource.Image.Width > maximal || picSource.Image.Height > maximal)
                {
                    var mul = (double)picSource.Image.Width / picSource.Image.Height;
                    gmul = mul;
                    if (mul.CompareTo(1.0) >= 0)
                    {
                        picSource.Image = resizeImage(picSource.Image,
                            new Size(maximal, (int)(maximal / mul)));
                    }
                    else
                    {
                        picSource.Image = resizeImage(picSource.Image,
                            new Size((int)(maximal * mul), maximal));
                    }
                }
                ApplyFilter();
            }
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return new Bitmap(imgToResize, size);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (picResult.Image != null)
            {
                var sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg|Bitmap Images(*.bmp)|*.bmp";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    var imgFormat = ImageFormat.Png;

                    if (fileExtension == "BMP")
                    {
                        imgFormat = ImageFormat.Bmp;
                    }
                    else if (fileExtension == "JPG")
                    {
                        imgFormat = ImageFormat.Jpeg;
                    }


                    var streamWriter = new StreamWriter(sfd.FileName, false);
                    picResult.Image.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
        }

        private void trcThreshHold_Scroll(object sender, EventArgs e)
        {
            lblThreshold.Text = "Threshold \r\n" + trcThreshHold.Value + "%";

            ApplyFilter();
        }

        private void hueTB_Scroll(object sender, EventArgs e)
        {
            var original = pnlResultColor.BackColor;

            double hue;
            double saturation;
            double value;
            HSV.ColorToHSV(original, out hue, out saturation, out value);

            var copy = HSV.ColorFromHSV(hueTB.Value, saturation, value);

            pnlResultColor.BackColor = copy;

            ApplyFilter();
        }

        private void picResult_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox)
            {
                var eventSource = (PictureBox)sender;
                using (var bmpSource = new Bitmap(eventSource.Width, eventSource.Height))
                {
                    picResult.DrawToBitmap(bmpSource, new Rectangle(0, 0, eventSource.Width, eventSource.Height));

                    var color = bmpSource.GetPixel(e.X, e.Y);
                    picker2.BackColor = color;
                    picker.Text = string.Format("R:{0:D3} G:{1:D3} B:{2:D3}", color.R, color.G, color.B);
                }
            }
        }

        private void PictureBox2MouseUpEventHandler(object sender, MouseEventArgs e)
        {
        }

        private void PictureBox1MouseUpEventHandler(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox)
            {
                var eventSource = (PictureBox)sender;
                using (var bmpSource = new Bitmap(eventSource.Width, eventSource.Height))
                {
                    picSource.DrawToBitmap(bmpSource, new Rectangle(0, 0, eventSource.Width, eventSource.Height));
                    pnlSourceColor.BackColor = bmpSource.GetPixel(e.X, e.Y);
                }

                ApplyFilter();
            }
        }
    }
}