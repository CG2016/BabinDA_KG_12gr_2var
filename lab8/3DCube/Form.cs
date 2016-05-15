using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int _d;
        private Point _drawOrigin;
        private Point _drawOrigin2;
        private Point _drawOrigin3;
        private int _h;

        private Math3D.Cube _mainCube1;
        private Math3D.Cube _mainCube12;
        private Math3D.Cube _mainCube13;
        private Math3D.Cube _mainCube2;
        private Math3D.Cube _mainCube22;
        private Math3D.Cube _mainCube23;
        private Math3D.Cube _mainCube3;
        private Math3D.Cube _mainCube32;
        private Math3D.Cube _mainCube33;
        private int _w;

        public Form()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tX.Value = 0;
            tY.Value = 0;
            tZ.Value = 0;

            chWires.Checked = true;
            chFront.Checked = false;
            chBack.Checked = false;
            chLeft.Checked = false;
            chRight.Checked = false;
            chTop.Checked = false;
            chBottom.Checked = false;
            xRotL.Text = string.Format("X: {0}", tX.Value);
            yRotL.Text = string.Format("Y: {0}", tX.Value);
            zRotL.Text = string.Format("Z: {0}", tX.Value);
            GenerateCharB(_w, _h, _d);
            Refresh();
        }

        private void chBack_CheckedChanged(object sender, EventArgs e)
        {
            _mainCube13.FillBack = chBack.Checked;
            _mainCube12.FillBack = chBack.Checked;
            _mainCube1.FillBack = chBack.Checked;
            _mainCube23.FillBack = chBack.Checked;
            _mainCube22.FillBack = chBack.Checked;
            _mainCube2.FillBack = chBack.Checked;
            _mainCube33.FillBack = chBack.Checked;
            _mainCube32.FillBack = chBack.Checked;
            _mainCube3.FillBack = chBack.Checked;
            Refresh();
        }

        private void chBottom_CheckedChanged(object sender, EventArgs e)
        {
            _mainCube13.FillBottom = chBottom.Checked;
            _mainCube12.FillBottom = chBottom.Checked;
            _mainCube1.FillBottom = chBottom.Checked;
            _mainCube23.FillBottom = chBottom.Checked;
            _mainCube22.FillBottom = chBottom.Checked;
            _mainCube2.FillBottom = chBottom.Checked;
            _mainCube33.FillBottom = chBottom.Checked;
            _mainCube32.FillBottom = chBottom.Checked;
            _mainCube3.FillBottom = chBottom.Checked;
            Refresh();
        }

        private void chFront_CheckedChanged(object sender, EventArgs e)
        {
            _mainCube13.FillFront = chFront.Checked;
            _mainCube12.FillFront = chFront.Checked;
            _mainCube1.FillFront = chFront.Checked;
            _mainCube23.FillFront = chFront.Checked;
            _mainCube22.FillFront = chFront.Checked;
            _mainCube2.FillFront = chFront.Checked;
            _mainCube33.FillFront = chFront.Checked;
            _mainCube32.FillFront = chFront.Checked;
            _mainCube3.FillFront = chFront.Checked;
            Refresh();
        }

        private void chLeft_CheckedChanged(object sender, EventArgs e)
        {
            _mainCube13.FillLeft = chLeft.Checked;
            _mainCube12.FillLeft = chLeft.Checked;
            _mainCube1.FillLeft = chLeft.Checked;
            _mainCube23.FillLeft = chLeft.Checked;
            _mainCube22.FillLeft = chLeft.Checked;
            _mainCube2.FillLeft = chLeft.Checked;
            _mainCube33.FillLeft = chLeft.Checked;
            _mainCube32.FillLeft = chLeft.Checked;
            _mainCube3.FillLeft = chLeft.Checked;
            Refresh();
        }

        private void chRight_CheckedChanged(object sender, EventArgs e)
        {
            _mainCube13.FillRight = chRight.Checked;
            _mainCube12.FillRight = chRight.Checked;
            _mainCube1.FillRight = chRight.Checked;
            _mainCube23.FillRight = chRight.Checked;
            _mainCube22.FillRight = chRight.Checked;
            _mainCube2.FillRight = chRight.Checked;
            _mainCube33.FillRight = chRight.Checked;
            _mainCube32.FillRight = chRight.Checked;
            _mainCube3.FillRight = chRight.Checked;
            Refresh();
        }

        private void chTop_CheckedChanged(object sender, EventArgs e)
        {
            _mainCube13.FillTop = chTop.Checked;
            _mainCube12.FillTop = chTop.Checked;
            _mainCube1.FillTop = chTop.Checked;
            _mainCube23.FillTop = chTop.Checked;
            _mainCube22.FillTop = chTop.Checked;
            _mainCube2.FillTop = chTop.Checked;
            _mainCube33.FillTop = chTop.Checked;
            _mainCube32.FillTop = chTop.Checked;
            _mainCube3.FillTop = chTop.Checked;
            Refresh();
        }


        private void chWires_CheckedChanged(object sender, EventArgs e)
        {
            _mainCube13.DrawWires = chWires.Checked;
            _mainCube12.DrawWires = chWires.Checked;
            _mainCube1.DrawWires = chWires.Checked;
            _mainCube23.DrawWires = chWires.Checked;
            _mainCube22.DrawWires = chWires.Checked;
            _mainCube2.DrawWires = chWires.Checked;
            _mainCube33.DrawWires = chWires.Checked;
            _mainCube32.DrawWires = chWires.Checked;
            _mainCube3.DrawWires = chWires.Checked;
            Refresh();
        }

        private void ConfigureFirstWindow()
        {
            _mainCube1.RotateX = tX.Value - 90;
            _mainCube1.RotateY = tZ.Value;
            _mainCube1.RotateZ = -tY.Value;
            _mainCube12.RotateX = tX.Value - 90;
            _mainCube12.RotateY = tZ.Value;
            _mainCube12.RotateZ = -tY.Value;
            _mainCube13.RotateX = tX.Value - 90;
            _mainCube13.RotateY = tZ.Value;
            _mainCube13.RotateZ = -tY.Value;
        }

        private void ConfigureSecondWindow()
        {
            _mainCube2.RotateX = tX.Value;
            _mainCube2.RotateY = tY.Value;
            _mainCube2.RotateZ = tZ.Value;
            _mainCube22.RotateX = tX.Value;
            _mainCube22.RotateY = tY.Value;
            _mainCube22.RotateZ = tZ.Value;
            _mainCube23.RotateX = tX.Value;
            _mainCube23.RotateY = tY.Value;
            _mainCube23.RotateZ = tZ.Value;
        }

        private void ConfigureThirdWindow()
        {
            _mainCube3.RotateX = tZ.Value;
            _mainCube3.RotateY = (float) tY.Value + 90;
            _mainCube3.RotateZ = -(float) tX.Value;
            _mainCube32.RotateX = tZ.Value;
            _mainCube32.RotateY = (float) tY.Value + 90;
            _mainCube32.RotateZ = -(float) tX.Value;
            _mainCube33.RotateX = tZ.Value;
            _mainCube33.RotateY = (float) tY.Value + 90;
            _mainCube33.RotateZ = -(float) tX.Value;
        }

        private void DrawFirstWindow()
        {
            pictureBox1.Image = _mainCube13.DrawCube(_drawOrigin3,
                _mainCube12.DrawCube(_drawOrigin2, _mainCube1.DrawCube(_drawOrigin)));
        }

        private void DrawSecondWindow()
        {
            pictureBox2.Image = _mainCube23.DrawCube(_drawOrigin3,
                _mainCube22.DrawCube(_drawOrigin2, _mainCube2.DrawCube(_drawOrigin)));
        }

        private void DrawThirdWindow()
        {
            pictureBox3.Image = _mainCube33.DrawCube(_drawOrigin3,
                _mainCube32.DrawCube(_drawOrigin2, _mainCube3.DrawCube(_drawOrigin)));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Render();
        }


        private void GenerateCharB(int w, int h, int d)
        {
            _drawOrigin3 = _drawOrigin2 = _drawOrigin = new Point(pictureBox1.Width/2, pictureBox1.Height/2);

            _mainCube1 = new Math3D.Cube(w, h/2, d, new Math3D.Vector3D(w/2, 0, d/2));
            _mainCube12 = new Math3D.Cube(w/5, h/2, d, new Math3D.Vector3D(w/2, h/2, d/2));
            _mainCube13 = new Math3D.Cube(w, h/10, d, new Math3D.Vector3D(w/2, h/2, d/2));

            _mainCube2 = new Math3D.Cube(w, h/2, d, new Math3D.Vector3D(w/2, 0, d/2));
            _mainCube22 = new Math3D.Cube(w/5, h/2, d, new Math3D.Vector3D(w/2, h/2, d/2));
            _mainCube23 = new Math3D.Cube(w, h/10, d, new Math3D.Vector3D(w/2, h/2, d/2));

            _mainCube3 = new Math3D.Cube(w, h/2, d, new Math3D.Vector3D(w/2, 0, d/2));
            _mainCube32 = new Math3D.Cube(w/5, h/2, d, new Math3D.Vector3D(w/2, h/2, d/2));
            _mainCube33 = new Math3D.Cube(w, h/10, d, new Math3D.Vector3D(w/2, h/2, d/2));
        }

        private void Render()
        {
            RenderFirstWindow();
            RenderSecondWindow();
            RenderThirdWindow();
        }

        private void RenderFirstWindow()
        {
            ConfigureFirstWindow();
            DrawFirstWindow();
        }

        private void RenderSecondWindow()
        {
            ConfigureSecondWindow();
            DrawSecondWindow();
        }

        private void RenderThirdWindow()
        {
            ConfigureThirdWindow();
            DrawThirdWindow();
        }

        private void SetCharSize(int size)
        {
            _h = size;
            _w = _h/2;
            _d = _h/8;
        }

        private void tX_Scroll(object sender, EventArgs e)
        {
            xRotL.Text = string.Format("X: {0}", tX.Value);
            Refresh();
        }

        private void tY_Scroll(object sender, EventArgs e)
        {
            yRotL.Text = string.Format("Y: {0}", tY.Value);
            Refresh();
        }

        private void tZ_Scroll(object sender, EventArgs e)
        {
            zRotL.Text = string.Format("Z: {0}", tZ.Value);
            Refresh();
        }

        private void FormRender_Load(object sender, EventArgs e)
        {
            var size = 160;
            SetCharSize(size);
            GenerateCharB(_w, _h, _d);
        }
    }
}