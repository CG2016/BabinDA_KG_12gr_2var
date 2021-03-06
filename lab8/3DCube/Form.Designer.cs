namespace lab8
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tX = new System.Windows.Forms.TrackBar();
            this.tY = new System.Windows.Forms.TrackBar();
            this.tZ = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.chFront = new System.Windows.Forms.CheckBox();
            this.gFilling = new System.Windows.Forms.GroupBox();
            this.chWires = new System.Windows.Forms.CheckBox();
            this.chBottom = new System.Windows.Forms.CheckBox();
            this.chTop = new System.Windows.Forms.CheckBox();
            this.chRight = new System.Windows.Forms.CheckBox();
            this.chBack = new System.Windows.Forms.CheckBox();
            this.chLeft = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xRotL = new System.Windows.Forms.Label();
            this.yRotL = new System.Windows.Forms.Label();
            this.zRotL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tZ)).BeginInit();
            this.gFilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 275);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z:";
            // 
            // tX
            // 
            this.tX.AutoSize = false;
            this.tX.Location = new System.Drawing.Point(308, 12);
            this.tX.Maximum = 360;
            this.tX.Minimum = -360;
            this.tX.Name = "tX";
            this.tX.Size = new System.Drawing.Size(260, 19);
            this.tX.TabIndex = 10;
            this.tX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tX.Scroll += new System.EventHandler(this.tX_Scroll);
            // 
            // tY
            // 
            this.tY.AutoSize = false;
            this.tY.Location = new System.Drawing.Point(308, 37);
            this.tY.Maximum = 360;
            this.tY.Minimum = -360;
            this.tY.Name = "tY";
            this.tY.Size = new System.Drawing.Size(260, 19);
            this.tY.TabIndex = 11;
            this.tY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tY.Scroll += new System.EventHandler(this.tY_Scroll);
            // 
            // tZ
            // 
            this.tZ.AutoSize = false;
            this.tZ.Location = new System.Drawing.Point(308, 62);
            this.tZ.Maximum = 360;
            this.tZ.Minimum = -360;
            this.tZ.Name = "tZ";
            this.tZ.Size = new System.Drawing.Size(260, 19);
            this.tZ.TabIndex = 12;
            this.tZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tZ.Scroll += new System.EventHandler(this.tZ_Scroll);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(442, 253);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(126, 34);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chFront
            // 
            this.chFront.AutoSize = true;
            this.chFront.Location = new System.Drawing.Point(16, 42);
            this.chFront.Name = "chFront";
            this.chFront.Size = new System.Drawing.Size(50, 17);
            this.chFront.TabIndex = 15;
            this.chFront.Text = "Front";
            this.chFront.UseVisualStyleBackColor = true;
            this.chFront.CheckedChanged += new System.EventHandler(this.chFront_CheckedChanged);
            // 
            // gFilling
            // 
            this.gFilling.Controls.Add(this.chWires);
            this.gFilling.Controls.Add(this.chBottom);
            this.gFilling.Controls.Add(this.chTop);
            this.gFilling.Controls.Add(this.chRight);
            this.gFilling.Controls.Add(this.chBack);
            this.gFilling.Controls.Add(this.chLeft);
            this.gFilling.Controls.Add(this.chFront);
            this.gFilling.Location = new System.Drawing.Point(293, 180);
            this.gFilling.Name = "gFilling";
            this.gFilling.Size = new System.Drawing.Size(126, 36);
            this.gFilling.TabIndex = 16;
            this.gFilling.TabStop = false;
            this.gFilling.Text = "Fill";
            // 
            // chWires
            // 
            this.chWires.AutoSize = true;
            this.chWires.Checked = true;
            this.chWires.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chWires.Location = new System.Drawing.Point(16, 16);
            this.chWires.Name = "chWires";
            this.chWires.Size = new System.Drawing.Size(53, 17);
            this.chWires.TabIndex = 21;
            this.chWires.Text = "Wires";
            this.chWires.UseVisualStyleBackColor = true;
            this.chWires.CheckedChanged += new System.EventHandler(this.chWires_CheckedChanged);
            // 
            // chBottom
            // 
            this.chBottom.AutoSize = true;
            this.chBottom.Location = new System.Drawing.Point(16, 127);
            this.chBottom.Name = "chBottom";
            this.chBottom.Size = new System.Drawing.Size(59, 17);
            this.chBottom.TabIndex = 20;
            this.chBottom.Text = "Bottom";
            this.chBottom.UseVisualStyleBackColor = true;
            this.chBottom.CheckedChanged += new System.EventHandler(this.chBottom_CheckedChanged);
            // 
            // chTop
            // 
            this.chTop.AutoSize = true;
            this.chTop.Location = new System.Drawing.Point(16, 110);
            this.chTop.Name = "chTop";
            this.chTop.Size = new System.Drawing.Size(45, 17);
            this.chTop.TabIndex = 19;
            this.chTop.Text = "Top";
            this.chTop.UseVisualStyleBackColor = true;
            this.chTop.CheckedChanged += new System.EventHandler(this.chTop_CheckedChanged);
            // 
            // chRight
            // 
            this.chRight.AutoSize = true;
            this.chRight.Location = new System.Drawing.Point(16, 93);
            this.chRight.Name = "chRight";
            this.chRight.Size = new System.Drawing.Size(51, 17);
            this.chRight.TabIndex = 18;
            this.chRight.Text = "Right";
            this.chRight.UseVisualStyleBackColor = true;
            this.chRight.CheckedChanged += new System.EventHandler(this.chRight_CheckedChanged);
            // 
            // chBack
            // 
            this.chBack.AutoSize = true;
            this.chBack.Location = new System.Drawing.Point(16, 59);
            this.chBack.Name = "chBack";
            this.chBack.Size = new System.Drawing.Size(51, 17);
            this.chBack.TabIndex = 16;
            this.chBack.Text = "Back";
            this.chBack.UseVisualStyleBackColor = true;
            this.chBack.CheckedChanged += new System.EventHandler(this.chBack_CheckedChanged);
            // 
            // chLeft
            // 
            this.chLeft.AutoSize = true;
            this.chLeft.Location = new System.Drawing.Point(16, 76);
            this.chLeft.Name = "chLeft";
            this.chLeft.Size = new System.Drawing.Size(44, 17);
            this.chLeft.TabIndex = 17;
            this.chLeft.Text = "Left";
            this.chLeft.UseVisualStyleBackColor = true;
            this.chLeft.CheckedChanged += new System.EventHandler(this.chLeft_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 275);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(293, 293);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(275, 275);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zRotL);
            this.groupBox1.Controls.Add(this.yRotL);
            this.groupBox1.Controls.Add(this.xRotL);
            this.groupBox1.Location = new System.Drawing.Point(293, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 87);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotate in degrees";
            // 
            // xRotL
            // 
            this.xRotL.AutoSize = true;
            this.xRotL.Location = new System.Drawing.Point(6, 19);
            this.xRotL.Name = "xRotL";
            this.xRotL.Size = new System.Drawing.Size(26, 13);
            this.xRotL.TabIndex = 0;
            this.xRotL.Text = "X: 0";
            // 
            // yRotL
            // 
            this.yRotL.AutoSize = true;
            this.yRotL.Location = new System.Drawing.Point(6, 42);
            this.yRotL.Name = "yRotL";
            this.yRotL.Size = new System.Drawing.Size(26, 13);
            this.yRotL.TabIndex = 1;
            this.yRotL.Text = "Y: 0";
            // 
            // zRotL
            // 
            this.zRotL.AutoSize = true;
            this.zRotL.Location = new System.Drawing.Point(6, 65);
            this.zRotL.Name = "zRotL";
            this.zRotL.Size = new System.Drawing.Size(26, 13);
            this.zRotL.TabIndex = 2;
            this.zRotL.Text = "Z: 0";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 574);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gFilling);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tZ);
            this.Controls.Add(this.tY);
            this.Controls.Add(this.tX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "lab8";
            this.Load += new System.EventHandler(this.FormRender_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tZ)).EndInit();
            this.gFilling.ResumeLayout(false);
            this.gFilling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tX;
        private System.Windows.Forms.TrackBar tY;
        private System.Windows.Forms.TrackBar tZ;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chFront;
        private System.Windows.Forms.GroupBox gFilling;
        private System.Windows.Forms.CheckBox chBottom;
        private System.Windows.Forms.CheckBox chTop;
        private System.Windows.Forms.CheckBox chRight;
        private System.Windows.Forms.CheckBox chBack;
        private System.Windows.Forms.CheckBox chLeft;
        private System.Windows.Forms.CheckBox chWires;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label zRotL;
        private System.Windows.Forms.Label yRotL;
        private System.Windows.Forms.Label xRotL;
    }
}

