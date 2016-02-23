namespace lab1
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BOX = new System.Windows.Forms.PictureBox();
            this.redS = new System.Windows.Forms.TrackBar();
            this.greenS = new System.Windows.Forms.TrackBar();
            this.blueS = new System.Windows.Forms.TrackBar();
            this.alphaS = new System.Windows.Forms.TrackBar();
            this.rl = new System.Windows.Forms.Label();
            this.gl = new System.Windows.Forms.Label();
            this.bl = new System.Windows.Forms.Label();
            this.al = new System.Windows.Forms.Label();
            this.VS = new System.Windows.Forms.TrackBar();
            this.SS = new System.Windows.Forms.TrackBar();
            this.HS = new System.Windows.Forms.TrackBar();
            this.vl = new System.Windows.Forms.Label();
            this.sl = new System.Windows.Forms.Label();
            this.hl = new System.Windows.Forms.Label();
            this.v2l = new System.Windows.Forms.Label();
            this.ul = new System.Windows.Forms.Label();
            this.ll = new System.Windows.Forms.Label();
            this.V2S = new System.Windows.Forms.TrackBar();
            this.US = new System.Windows.Forms.TrackBar();
            this.LS = new System.Windows.Forms.TrackBar();
            this.yl = new System.Windows.Forms.Label();
            this.ml = new System.Windows.Forms.Label();
            this.cl = new System.Windows.Forms.Label();
            this.YS = new System.Windows.Forms.TrackBar();
            this.MS = new System.Windows.Forms.TrackBar();
            this.CS = new System.Windows.Forms.TrackBar();
            this.zl = new System.Windows.Forms.Label();
            this.y2l = new System.Windows.Forms.Label();
            this.xl = new System.Windows.Forms.Label();
            this.ZC = new System.Windows.Forms.TrackBar();
            this.Y2C = new System.Windows.Forms.TrackBar();
            this.XC = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V2S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.US)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y2C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XC)).BeginInit();
            this.SuspendLayout();
            // 
            // BOX
            // 
            this.BOX.Location = new System.Drawing.Point(12, 12);
            this.BOX.Name = "BOX";
            this.BOX.Size = new System.Drawing.Size(143, 140);
            this.BOX.TabIndex = 0;
            this.BOX.TabStop = false;
            this.BOX.VisibleChanged += new System.EventHandler(this.BOX_VisibleChanged);
            // 
            // redS
            // 
            this.redS.Location = new System.Drawing.Point(219, 107);
            this.redS.Maximum = 255;
            this.redS.Name = "redS";
            this.redS.Size = new System.Drawing.Size(684, 45);
            this.redS.TabIndex = 1;
            this.redS.TickFrequency = 3;
            this.redS.Value = 200;
            this.redS.Scroll += new System.EventHandler(this.redS_Scroll);
            // 
            // greenS
            // 
            this.greenS.Location = new System.Drawing.Point(219, 134);
            this.greenS.Maximum = 255;
            this.greenS.Name = "greenS";
            this.greenS.Size = new System.Drawing.Size(684, 45);
            this.greenS.TabIndex = 2;
            this.greenS.TickFrequency = 3;
            this.greenS.Value = 150;
            this.greenS.Scroll += new System.EventHandler(this.greenS_Scroll);
            // 
            // blueS
            // 
            this.blueS.Location = new System.Drawing.Point(219, 161);
            this.blueS.Maximum = 255;
            this.blueS.Name = "blueS";
            this.blueS.Size = new System.Drawing.Size(684, 45);
            this.blueS.TabIndex = 3;
            this.blueS.TickFrequency = 3;
            this.blueS.Value = 100;
            this.blueS.Scroll += new System.EventHandler(this.blueS_Scroll);
            // 
            // alphaS
            // 
            this.alphaS.Location = new System.Drawing.Point(219, 188);
            this.alphaS.Maximum = 255;
            this.alphaS.Name = "alphaS";
            this.alphaS.Size = new System.Drawing.Size(684, 45);
            this.alphaS.TabIndex = 4;
            this.alphaS.TickFrequency = 3;
            this.alphaS.Value = 255;
            this.alphaS.Scroll += new System.EventHandler(this.alphaS_Scroll);
            // 
            // rl
            // 
            this.rl.AutoSize = true;
            this.rl.Location = new System.Drawing.Point(161, 107);
            this.rl.Name = "rl";
            this.rl.Size = new System.Drawing.Size(15, 13);
            this.rl.TabIndex = 5;
            this.rl.Text = "R";
            // 
            // gl
            // 
            this.gl.AutoSize = true;
            this.gl.Location = new System.Drawing.Point(161, 134);
            this.gl.Name = "gl";
            this.gl.Size = new System.Drawing.Size(15, 13);
            this.gl.TabIndex = 6;
            this.gl.Text = "G";
            // 
            // bl
            // 
            this.bl.AutoSize = true;
            this.bl.Location = new System.Drawing.Point(161, 161);
            this.bl.Name = "bl";
            this.bl.Size = new System.Drawing.Size(14, 13);
            this.bl.TabIndex = 7;
            this.bl.Text = "B";
            // 
            // al
            // 
            this.al.AutoSize = true;
            this.al.Location = new System.Drawing.Point(161, 188);
            this.al.Name = "al";
            this.al.Size = new System.Drawing.Size(14, 13);
            this.al.TabIndex = 8;
            this.al.Text = "A";
            // 
            // VS
            // 
            this.VS.Location = new System.Drawing.Point(219, 66);
            this.VS.Maximum = 100;
            this.VS.Name = "VS";
            this.VS.Size = new System.Drawing.Size(684, 45);
            this.VS.TabIndex = 11;
            this.VS.Value = 50;
            this.VS.Scroll += new System.EventHandler(this.VS_Scroll);
            // 
            // SS
            // 
            this.SS.Location = new System.Drawing.Point(219, 39);
            this.SS.Maximum = 100;
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(684, 45);
            this.SS.TabIndex = 10;
            this.SS.Value = 50;
            this.SS.Scroll += new System.EventHandler(this.SS_Scroll);
            // 
            // HS
            // 
            this.HS.Location = new System.Drawing.Point(219, 12);
            this.HS.Maximum = 360;
            this.HS.Name = "HS";
            this.HS.Size = new System.Drawing.Size(684, 45);
            this.HS.TabIndex = 9;
            this.HS.TickFrequency = 4;
            this.HS.Value = 200;
            this.HS.Scroll += new System.EventHandler(this.HS_Scroll);
            // 
            // vl
            // 
            this.vl.AutoSize = true;
            this.vl.Location = new System.Drawing.Point(161, 66);
            this.vl.Name = "vl";
            this.vl.Size = new System.Drawing.Size(14, 13);
            this.vl.TabIndex = 14;
            this.vl.Text = "V";
            // 
            // sl
            // 
            this.sl.AutoSize = true;
            this.sl.Location = new System.Drawing.Point(161, 39);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(14, 13);
            this.sl.TabIndex = 13;
            this.sl.Text = "S";
            // 
            // hl
            // 
            this.hl.AutoSize = true;
            this.hl.Location = new System.Drawing.Point(161, 12);
            this.hl.Name = "hl";
            this.hl.Size = new System.Drawing.Size(15, 13);
            this.hl.TabIndex = 12;
            this.hl.Text = "H";
            // 
            // v2l
            // 
            this.v2l.AutoSize = true;
            this.v2l.Location = new System.Drawing.Point(161, 303);
            this.v2l.Name = "v2l";
            this.v2l.Size = new System.Drawing.Size(14, 13);
            this.v2l.TabIndex = 20;
            this.v2l.Text = "V";
            // 
            // ul
            // 
            this.ul.AutoSize = true;
            this.ul.Location = new System.Drawing.Point(161, 276);
            this.ul.Name = "ul";
            this.ul.Size = new System.Drawing.Size(15, 13);
            this.ul.TabIndex = 19;
            this.ul.Text = "U";
            // 
            // ll
            // 
            this.ll.AutoSize = true;
            this.ll.Location = new System.Drawing.Point(161, 249);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(13, 13);
            this.ll.TabIndex = 18;
            this.ll.Text = "L";
            // 
            // V2S
            // 
            this.V2S.Location = new System.Drawing.Point(219, 303);
            this.V2S.Maximum = 122;
            this.V2S.Minimum = -140;
            this.V2S.Name = "V2S";
            this.V2S.Size = new System.Drawing.Size(684, 45);
            this.V2S.TabIndex = 17;
            this.V2S.TickFrequency = 3;
            this.V2S.Scroll += new System.EventHandler(this.V2S_Scroll);
            // 
            // US
            // 
            this.US.Location = new System.Drawing.Point(219, 276);
            this.US.Maximum = 224;
            this.US.Minimum = -134;
            this.US.Name = "US";
            this.US.Size = new System.Drawing.Size(684, 45);
            this.US.TabIndex = 16;
            this.US.TickFrequency = 4;
            this.US.Value = 50;
            this.US.Scroll += new System.EventHandler(this.US_Scroll);
            // 
            // LS
            // 
            this.LS.Location = new System.Drawing.Point(219, 249);
            this.LS.Maximum = 100;
            this.LS.Name = "LS";
            this.LS.Size = new System.Drawing.Size(684, 45);
            this.LS.TabIndex = 15;
            this.LS.Value = 50;
            this.LS.Scroll += new System.EventHandler(this.LS_Scroll);
            // 
            // yl
            // 
            this.yl.AutoSize = true;
            this.yl.Location = new System.Drawing.Point(161, 408);
            this.yl.Name = "yl";
            this.yl.Size = new System.Drawing.Size(14, 13);
            this.yl.TabIndex = 26;
            this.yl.Text = "Y";
            // 
            // ml
            // 
            this.ml.AutoSize = true;
            this.ml.Location = new System.Drawing.Point(161, 381);
            this.ml.Name = "ml";
            this.ml.Size = new System.Drawing.Size(16, 13);
            this.ml.TabIndex = 25;
            this.ml.Text = "M";
            // 
            // cl
            // 
            this.cl.AutoSize = true;
            this.cl.Location = new System.Drawing.Point(161, 354);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(14, 13);
            this.cl.TabIndex = 24;
            this.cl.Text = "C";
            // 
            // YS
            // 
            this.YS.Location = new System.Drawing.Point(219, 408);
            this.YS.Maximum = 100;
            this.YS.Name = "YS";
            this.YS.Size = new System.Drawing.Size(684, 45);
            this.YS.TabIndex = 23;
            this.YS.Value = 50;
            this.YS.Scroll += new System.EventHandler(this.YS_Scroll);
            // 
            // MS
            // 
            this.MS.Location = new System.Drawing.Point(219, 381);
            this.MS.Maximum = 100;
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(684, 45);
            this.MS.TabIndex = 22;
            this.MS.Value = 50;
            this.MS.Scroll += new System.EventHandler(this.MS_Scroll);
            // 
            // CS
            // 
            this.CS.Location = new System.Drawing.Point(219, 354);
            this.CS.Maximum = 100;
            this.CS.Name = "CS";
            this.CS.Size = new System.Drawing.Size(684, 45);
            this.CS.TabIndex = 21;
            this.CS.Value = 50;
            this.CS.Scroll += new System.EventHandler(this.CS_Scroll);
            // 
            // zl
            // 
            this.zl.AutoSize = true;
            this.zl.Location = new System.Drawing.Point(161, 513);
            this.zl.Name = "zl";
            this.zl.Size = new System.Drawing.Size(14, 13);
            this.zl.TabIndex = 32;
            this.zl.Text = "Z";
            // 
            // y2l
            // 
            this.y2l.AutoSize = true;
            this.y2l.Location = new System.Drawing.Point(161, 486);
            this.y2l.Name = "y2l";
            this.y2l.Size = new System.Drawing.Size(14, 13);
            this.y2l.TabIndex = 31;
            this.y2l.Text = "Y";
            // 
            // xl
            // 
            this.xl.AutoSize = true;
            this.xl.Location = new System.Drawing.Point(161, 459);
            this.xl.Name = "xl";
            this.xl.Size = new System.Drawing.Size(14, 13);
            this.xl.TabIndex = 30;
            this.xl.Text = "X";
            // 
            // ZC
            // 
            this.ZC.Location = new System.Drawing.Point(219, 513);
            this.ZC.Maximum = 109;
            this.ZC.Name = "ZC";
            this.ZC.Size = new System.Drawing.Size(684, 45);
            this.ZC.TabIndex = 29;
            this.ZC.Value = 50;
            this.ZC.Scroll += new System.EventHandler(this.ZC_Scroll);
            // 
            // Y2C
            // 
            this.Y2C.Location = new System.Drawing.Point(219, 486);
            this.Y2C.Maximum = 101;
            this.Y2C.Name = "Y2C";
            this.Y2C.Size = new System.Drawing.Size(684, 45);
            this.Y2C.TabIndex = 28;
            this.Y2C.Value = 50;
            this.Y2C.Scroll += new System.EventHandler(this.Y2C_Scroll);
            // 
            // XC
            // 
            this.XC.Location = new System.Drawing.Point(219, 459);
            this.XC.Maximum = 96;
            this.XC.Name = "XC";
            this.XC.Size = new System.Drawing.Size(684, 45);
            this.XC.TabIndex = 27;
            this.XC.Value = 50;
            this.XC.Scroll += new System.EventHandler(this.XC_Scroll);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 558);
            this.Controls.Add(this.zl);
            this.Controls.Add(this.y2l);
            this.Controls.Add(this.xl);
            this.Controls.Add(this.ZC);
            this.Controls.Add(this.Y2C);
            this.Controls.Add(this.XC);
            this.Controls.Add(this.yl);
            this.Controls.Add(this.ml);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.YS);
            this.Controls.Add(this.MS);
            this.Controls.Add(this.CS);
            this.Controls.Add(this.v2l);
            this.Controls.Add(this.ul);
            this.Controls.Add(this.ll);
            this.Controls.Add(this.V2S);
            this.Controls.Add(this.US);
            this.Controls.Add(this.LS);
            this.Controls.Add(this.vl);
            this.Controls.Add(this.sl);
            this.Controls.Add(this.hl);
            this.Controls.Add(this.VS);
            this.Controls.Add(this.SS);
            this.Controls.Add(this.HS);
            this.Controls.Add(this.al);
            this.Controls.Add(this.bl);
            this.Controls.Add(this.gl);
            this.Controls.Add(this.rl);
            this.Controls.Add(this.alphaS);
            this.Controls.Add(this.blueS);
            this.Controls.Add(this.greenS);
            this.Controls.Add(this.redS);
            this.Controls.Add(this.BOX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form";
            this.Text = "Color converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V2S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.US)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y2C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BOX;
        private System.Windows.Forms.TrackBar redS;
        private System.Windows.Forms.TrackBar greenS;
        private System.Windows.Forms.TrackBar blueS;
        private System.Windows.Forms.TrackBar alphaS;
        private System.Windows.Forms.Label rl;
        private System.Windows.Forms.Label gl;
        private System.Windows.Forms.Label bl;
        private System.Windows.Forms.Label al;
        private System.Windows.Forms.TrackBar VS;
        private System.Windows.Forms.TrackBar SS;
        private System.Windows.Forms.TrackBar HS;
        private System.Windows.Forms.Label vl;
        private System.Windows.Forms.Label sl;
        private System.Windows.Forms.Label hl;
        private System.Windows.Forms.Label v2l;
        private System.Windows.Forms.Label ul;
        private System.Windows.Forms.Label ll;
        private System.Windows.Forms.TrackBar V2S;
        private System.Windows.Forms.TrackBar US;
        private System.Windows.Forms.TrackBar LS;
        private System.Windows.Forms.Label yl;
        private System.Windows.Forms.Label ml;
        private System.Windows.Forms.Label cl;
        private System.Windows.Forms.TrackBar YS;
        private System.Windows.Forms.TrackBar MS;
        private System.Windows.Forms.TrackBar CS;
        private System.Windows.Forms.Label zl;
        private System.Windows.Forms.Label y2l;
        private System.Windows.Forms.Label xl;
        private System.Windows.Forms.TrackBar ZC;
        private System.Windows.Forms.TrackBar Y2C;
        private System.Windows.Forms.TrackBar XC;
    }
}

