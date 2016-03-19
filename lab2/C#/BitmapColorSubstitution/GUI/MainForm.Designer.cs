namespace ColorReplacer
{
    partial class MainForm
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
            this.picSource = new System.Windows.Forms.PictureBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.hueTB = new System.Windows.Forms.TrackBar();
            this.btnSelectReplacementColor = new System.Windows.Forms.Button();
            this.pnlResultColor = new System.Windows.Forms.Panel();
            this.lblReplacementColor = new System.Windows.Forms.Label();
            this.btnSelectColorToReplace = new System.Windows.Forms.Button();
            this.pnlSourceColor = new System.Windows.Forms.Panel();
            this.lblSourceColor = new System.Windows.Forms.Label();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.trcThreshHold = new System.Windows.Forms.TrackBar();
            this.lblColorFilter = new System.Windows.Forms.Label();
            this.btnResultAsSource = new System.Windows.Forms.Button();
            this.picker = new System.Windows.Forms.Label();
            this.picker2 = new System.Windows.Forms.PictureBox();
            this.inLabcb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hueTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcThreshHold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picker2)).BeginInit();
            this.SuspendLayout();
            // 
            // picSource
            // 
            this.picSource.BackColor = System.Drawing.Color.Silver;
            this.picSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSource.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picSource.InitialImage = null;
            this.picSource.Location = new System.Drawing.Point(12, 37);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(400, 400);
            this.picSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSource.TabIndex = 0;
            this.picSource.TabStop = false;
            this.picSource.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1MouseUpEventHandler);
            // 
            // picResult
            // 
            this.picResult.BackColor = System.Drawing.Color.Silver;
            this.picResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picResult.Location = new System.Drawing.Point(418, 37);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(400, 400);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult.TabIndex = 1;
            this.picResult.TabStop = false;
            this.picResult.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picResult_MouseMove);
            // 
            // lblSource
            // 
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(12, 7);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(97, 25);
            this.lblSource.TabIndex = 2;
            this.lblSource.Text = "Source";
            this.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(413, 7);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(102, 25);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(824, 367);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(149, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load Source";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(824, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Result";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlFilter
            // 
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.hueTB);
            this.pnlFilter.Controls.Add(this.btnSelectReplacementColor);
            this.pnlFilter.Controls.Add(this.pnlResultColor);
            this.pnlFilter.Controls.Add(this.lblReplacementColor);
            this.pnlFilter.Controls.Add(this.btnSelectColorToReplace);
            this.pnlFilter.Controls.Add(this.pnlSourceColor);
            this.pnlFilter.Controls.Add(this.lblSourceColor);
            this.pnlFilter.Controls.Add(this.lblThreshold);
            this.pnlFilter.Controls.Add(this.trcThreshHold);
            this.pnlFilter.Enabled = false;
            this.pnlFilter.Location = new System.Drawing.Point(824, 37);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(149, 326);
            this.pnlFilter.TabIndex = 6;
            // 
            // hueTB
            // 
            this.hueTB.AutoSize = false;
            this.hueTB.Location = new System.Drawing.Point(3, 295);
            this.hueTB.Maximum = 360;
            this.hueTB.Name = "hueTB";
            this.hueTB.Size = new System.Drawing.Size(141, 32);
            this.hueTB.TabIndex = 10;
            this.hueTB.TickFrequency = 10;
            this.hueTB.Scroll += new System.EventHandler(this.hueTB_Scroll);
            // 
            // btnSelectReplacementColor
            // 
            this.btnSelectReplacementColor.Location = new System.Drawing.Point(53, 266);
            this.btnSelectReplacementColor.Name = "btnSelectReplacementColor";
            this.btnSelectReplacementColor.Size = new System.Drawing.Size(81, 23);
            this.btnSelectReplacementColor.TabIndex = 9;
            this.btnSelectReplacementColor.Text = "Select";
            this.btnSelectReplacementColor.UseVisualStyleBackColor = true;
            this.btnSelectReplacementColor.Click += new System.EventHandler(this.ShowColorDialogButtonClickEventHandler);
            // 
            // pnlResultColor
            // 
            this.pnlResultColor.BackColor = System.Drawing.Color.YellowGreen;
            this.pnlResultColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResultColor.Location = new System.Drawing.Point(53, 180);
            this.pnlResultColor.Name = "pnlResultColor";
            this.pnlResultColor.Size = new System.Drawing.Size(80, 80);
            this.pnlResultColor.TabIndex = 8;
            // 
            // lblReplacementColor
            // 
            this.lblReplacementColor.Location = new System.Drawing.Point(51, 151);
            this.lblReplacementColor.Name = "lblReplacementColor";
            this.lblReplacementColor.Size = new System.Drawing.Size(82, 26);
            this.lblReplacementColor.TabIndex = 7;
            this.lblReplacementColor.Text = "Replacement Colour";
            this.lblReplacementColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectColorToReplace
            // 
            this.btnSelectColorToReplace.Location = new System.Drawing.Point(54, 121);
            this.btnSelectColorToReplace.Name = "btnSelectColorToReplace";
            this.btnSelectColorToReplace.Size = new System.Drawing.Size(80, 23);
            this.btnSelectColorToReplace.TabIndex = 6;
            this.btnSelectColorToReplace.Text = "Select";
            this.btnSelectColorToReplace.UseVisualStyleBackColor = true;
            this.btnSelectColorToReplace.Click += new System.EventHandler(this.ShowColorDialogButtonClickEventHandler);
            // 
            // pnlSourceColor
            // 
            this.pnlSourceColor.BackColor = System.Drawing.Color.White;
            this.pnlSourceColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSourceColor.Location = new System.Drawing.Point(54, 35);
            this.pnlSourceColor.Name = "pnlSourceColor";
            this.pnlSourceColor.Size = new System.Drawing.Size(80, 80);
            this.pnlSourceColor.TabIndex = 3;
            // 
            // lblSourceColor
            // 
            this.lblSourceColor.Location = new System.Drawing.Point(57, 6);
            this.lblSourceColor.Name = "lblSourceColor";
            this.lblSourceColor.Size = new System.Drawing.Size(77, 26);
            this.lblSourceColor.TabIndex = 2;
            this.lblSourceColor.Text = "Colour to Replace";
            this.lblSourceColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(3, 6);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(54, 26);
            this.lblThreshold.TabIndex = 1;
            this.lblThreshold.Text = "Threshold\r\n10%";
            this.lblThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcThreshHold
            // 
            this.trcThreshHold.AutoSize = false;
            this.trcThreshHold.BackColor = System.Drawing.Color.LightGray;
            this.trcThreshHold.Location = new System.Drawing.Point(13, 35);
            this.trcThreshHold.Maximum = 100;
            this.trcThreshHold.Minimum = 1;
            this.trcThreshHold.Name = "trcThreshHold";
            this.trcThreshHold.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcThreshHold.Size = new System.Drawing.Size(31, 254);
            this.trcThreshHold.TabIndex = 0;
            this.trcThreshHold.Value = 10;
            this.trcThreshHold.Scroll += new System.EventHandler(this.trcThreshHold_Scroll);
            // 
            // lblColorFilter
            // 
            this.lblColorFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorFilter.Location = new System.Drawing.Point(824, 7);
            this.lblColorFilter.Name = "lblColorFilter";
            this.lblColorFilter.Size = new System.Drawing.Size(149, 25);
            this.lblColorFilter.TabIndex = 8;
            this.lblColorFilter.Text = "Colour Filter";
            this.lblColorFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResultAsSource
            // 
            this.btnResultAsSource.Enabled = false;
            this.btnResultAsSource.Location = new System.Drawing.Point(824, 414);
            this.btnResultAsSource.Name = "btnResultAsSource";
            this.btnResultAsSource.Size = new System.Drawing.Size(149, 23);
            this.btnResultAsSource.TabIndex = 9;
            this.btnResultAsSource.Text = "Set Result as Source";
            this.btnResultAsSource.UseVisualStyleBackColor = true;
            this.btnResultAsSource.Click += new System.EventHandler(this.btnResultAsSource_Click);
            // 
            // picker
            // 
            this.picker.AutoSize = true;
            this.picker.Location = new System.Drawing.Point(418, 447);
            this.picker.Name = "picker";
            this.picker.Size = new System.Drawing.Size(99, 13);
            this.picker.TabIndex = 10;
            this.picker.Text = "R:000 G:000 B:000";
            // 
            // picker2
            // 
            this.picker2.Location = new System.Drawing.Point(523, 443);
            this.picker2.Name = "picker2";
            this.picker2.Size = new System.Drawing.Size(23, 21);
            this.picker2.TabIndex = 11;
            this.picker2.TabStop = false;
            // 
            // inLabcb
            // 
            this.inLabcb.AutoSize = true;
            this.inLabcb.Checked = true;
            this.inLabcb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inLabcb.Location = new System.Drawing.Point(12, 446);
            this.inLabcb.Name = "inLabcb";
            this.inLabcb.Size = new System.Drawing.Size(57, 17);
            this.inLabcb.TabIndex = 12;
            this.inLabcb.Text = "in LAB";
            this.inLabcb.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 484);
            this.Controls.Add(this.inLabcb);
            this.Controls.Add(this.picker2);
            this.Controls.Add(this.picker);
            this.Controls.Add(this.btnResultAsSource);
            this.Controls.Add(this.lblColorFilter);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.picSource);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Replacer";
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hueTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcThreshHold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picker2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSource;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Button btnSelectReplacementColor;
        private System.Windows.Forms.Panel pnlResultColor;
        private System.Windows.Forms.Label lblReplacementColor;
        private System.Windows.Forms.Button btnSelectColorToReplace;
        private System.Windows.Forms.Panel pnlSourceColor;
        private System.Windows.Forms.Label lblSourceColor;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.TrackBar trcThreshHold;
        private System.Windows.Forms.Label lblColorFilter;
        private System.Windows.Forms.Button btnResultAsSource;
        private System.Windows.Forms.TrackBar hueTB;
        private System.Windows.Forms.Label picker;
        private System.Windows.Forms.PictureBox picker2;
        private System.Windows.Forms.CheckBox inLabcb;
    }
}

