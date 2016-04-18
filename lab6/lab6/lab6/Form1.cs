using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using ImageMagick;

namespace lab6
{
    public partial class Lab6 : Form
    {
        private Image _image;

        public Lab6()
        {
            InitializeComponent();

        }
       
        


        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            LoadImage();
        }
        private void LoadImage()
        {
            var file = new OpenFileDialog();
            file.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|"
                          + "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|"+"All|*.*";
            file.FilterIndex = 6;
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
                            magickImage.Format = MagickFormat.Gray;
                            _image = magickImage.ToBitmap();
                            byte[] gray = GrayBMP_File.CreateGrayBitmapArray(_image);
                            _image = ImageConverter.byteArrayToImage(gray);
                        }
                    }
                    else
                    {
                        _image = Image.FromFile(file.FileName);
                        byte[] gray = GrayBMP_File.CreateGrayBitmapArray(_image);
                       _image = ImageConverter.byteArrayToImage(gray);
                    }
                    
                    pictureBox1.Image = _image;
                }
            }
        }

        private void invertCB_CheckedChanged(object sender, EventArgs e)
        {
            if (invertCB.Checked)
                if (_image != null)
                {
                    Bitmap fImage = (Bitmap)pictureBox1.Image;
                    Invert filter = new Invert();
                    Bitmap result = filter.Apply(fImage);
                    pictureBox2.Image = new Bitmap(result);


                }

        }
        private void contrastCorrectionCB_CheckedChanged(object sender, EventArgs e)
        {
            if (contrastCorrectionCB.Checked)
                if (_image != null)
            {
                Bitmap fImage = (Bitmap)pictureBox1.Image;
                    ContrastCorrection filter = new ContrastCorrection();
                    Bitmap result = filter.Apply(fImage);
                pictureBox2.Image = result;
                
            }
        }

        private void adaptiveSmoothingCB_CheckedChanged(object sender, EventArgs e)
        {
            if (adaptiveSmoothingCB.Checked)
                if (_image != null)
            {
                Bitmap fImage = (Bitmap)pictureBox1.Image;
                    AdaptiveSmoothing filter = new AdaptiveSmoothing();
                    Bitmap result = filter.Apply(fImage);
                pictureBox2.Image = new Bitmap(result);
                }
        }

        private void gammaCorrectionCB_CheckedChanged(object sender, EventArgs e)
        {
            if (gammaCorrectionCB.Checked)
                if (_image != null)
            {
                Bitmap fImage = (Bitmap)pictureBox1.Image;
                    GammaCorrection filter = new GammaCorrection();
                   
                Bitmap resilt = filter.Apply(fImage);
                    pictureBox2.Image = new Bitmap(resilt);
                }
        }

        private void levelCorrectionCB_CheckedChanged(object sender, EventArgs e)
        {
            if(levelCorrectionCB.Checked)
            if (_image != null)
            {
                Bitmap fImage = (Bitmap)pictureBox1.Image;
                    LevelsLinear filter = new LevelsLinear();
                    Bitmap result = filter.Apply(fImage);
                pictureBox2.Image = new Bitmap(result);
                }
        }

        private void binarizationTresholdCB_CheckedChanged(object sender, EventArgs e)
        {
            BinarizationThreshold();
        }

        private void BinarizationThreshold()
        {
            if (binarizationTresholdCB.Checked)
            {
                Image image = pictureBox1.Image;
                Threshold filter = new Threshold(thresholdTB.Value);
                // apply the filter
               Bitmap result = filter.Apply((Bitmap) image);
                pictureBox2.Image = result;
            }
           
        }

        private void binarizationJarvisCB_CheckedChanged(object sender, EventArgs e)
        {
            BinarizationJarvis();
        }

        private void BinarizationJarvis()
        {

            if (binarizationJarvisCB.Checked)
            {
                Image image = pictureBox1.Image;
                JarvisJudiceNinkeDithering filter = new JarvisJudiceNinkeDithering();
                // apply the filter
                Bitmap result = filter.Apply((Bitmap)image);
                pictureBox2.Image = result;
            }
        }







        private
            void thresholdTB_Scroll(object sender, EventArgs e)
        {
            thresholdTextBox.Text = thresholdTB.Value.ToString();
            if (binarizationTresholdCB.Checked)
                BinarizationThreshold();
         

        }

        private void binarizationBayerCB_CheckedChanged(object sender, EventArgs e)
        {
            if (binarizationBayerCB.Checked)
            {
                Image image = pictureBox1.Image;
                BayerDithering filter = new BayerDithering();
                // apply the filter
                Bitmap result = filter.Apply((Bitmap)image);
                pictureBox2.Image = result;
            }
        }

        private void binarizationSierraCB_CheckedChanged(object sender, EventArgs e)
        {
            if (binarizationSierraCB.Checked)
            {
                Image image = pictureBox1.Image;
                SierraDithering filter = new SierraDithering();
                // apply the filter
                Bitmap result = filter.Apply((Bitmap)image);
                pictureBox2.Image = result;
            }
        }

        private void otsuCB_CheckedChanged(object sender, EventArgs e)
        {
            if (otsuCB.Checked)
            {
                Image image = pictureBox1.Image;
                OtsuThreshold filter = new OtsuThreshold();
                // apply the filter
                Bitmap result = filter.Apply((Bitmap)image);
                pictureBox2.Image = result;
            }
        }

    }
}
