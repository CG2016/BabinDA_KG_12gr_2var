namespace lab6
{
    partial class Lab6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab6));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.invertCB = new System.Windows.Forms.CheckBox();
            this.contrastCorrectionCB = new System.Windows.Forms.CheckBox();
            this.adaptiveSmoothingCB = new System.Windows.Forms.CheckBox();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.gammaCorrectionCB = new System.Windows.Forms.CheckBox();
            this.levelCorrectionCB = new System.Windows.Forms.CheckBox();
            this.binarizationTresholdCB = new System.Windows.Forms.CheckBox();
            this.binarizationJarvisCB = new System.Windows.Forms.CheckBox();
            this.thresholdTextBox = new System.Windows.Forms.TextBox();
            this.thresholdTB = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.binarizationBayerCB = new System.Windows.Forms.CheckBox();
            this.binarizationSierraCB = new System.Windows.Forms.CheckBox();
            this.otsuCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTB)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(442, 248);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(422, 378);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // invertCB
            // 
            this.invertCB.AutoSize = true;
            this.invertCB.Location = new System.Drawing.Point(12, 12);
            this.invertCB.Name = "invertCB";
            this.invertCB.Size = new System.Drawing.Size(52, 17);
            this.invertCB.TabIndex = 2;
            this.invertCB.Text = "invert";
            this.invertCB.UseVisualStyleBackColor = true;
            this.invertCB.CheckedChanged += new System.EventHandler(this.invertCB_CheckedChanged);
            // 
            // contrastCorrectionCB
            // 
            this.contrastCorrectionCB.AutoSize = true;
            this.contrastCorrectionCB.Location = new System.Drawing.Point(12, 35);
            this.contrastCorrectionCB.Name = "contrastCorrectionCB";
            this.contrastCorrectionCB.Size = new System.Drawing.Size(114, 17);
            this.contrastCorrectionCB.TabIndex = 3;
            this.contrastCorrectionCB.Text = "contrast correction";
            this.contrastCorrectionCB.UseVisualStyleBackColor = true;
            this.contrastCorrectionCB.CheckedChanged += new System.EventHandler(this.contrastCorrectionCB_CheckedChanged);
            // 
            // adaptiveSmoothingCB
            // 
            this.adaptiveSmoothingCB.AutoSize = true;
            this.adaptiveSmoothingCB.Location = new System.Drawing.Point(12, 58);
            this.adaptiveSmoothingCB.Name = "adaptiveSmoothingCB";
            this.adaptiveSmoothingCB.Size = new System.Drawing.Size(118, 17);
            this.adaptiveSmoothingCB.TabIndex = 4;
            this.adaptiveSmoothingCB.Text = "adaptive smoothing";
            this.adaptiveSmoothingCB.UseVisualStyleBackColor = true;
            this.adaptiveSmoothingCB.CheckedChanged += new System.EventHandler(this.adaptiveSmoothingCB_CheckedChanged);
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(12, 219);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(75, 23);
            this.LoadImageButton.TabIndex = 5;
            this.LoadImageButton.Text = "Load Image";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // gammaCorrectionCB
            // 
            this.gammaCorrectionCB.AutoSize = true;
            this.gammaCorrectionCB.Location = new System.Drawing.Point(12, 81);
            this.gammaCorrectionCB.Name = "gammaCorrectionCB";
            this.gammaCorrectionCB.Size = new System.Drawing.Size(110, 17);
            this.gammaCorrectionCB.TabIndex = 6;
            this.gammaCorrectionCB.Text = "gamma correction";
            this.gammaCorrectionCB.UseVisualStyleBackColor = true;
            this.gammaCorrectionCB.CheckedChanged += new System.EventHandler(this.gammaCorrectionCB_CheckedChanged);
            // 
            // levelCorrectionCB
            // 
            this.levelCorrectionCB.AutoSize = true;
            this.levelCorrectionCB.Location = new System.Drawing.Point(12, 104);
            this.levelCorrectionCB.Name = "levelCorrectionCB";
            this.levelCorrectionCB.Size = new System.Drawing.Size(98, 17);
            this.levelCorrectionCB.TabIndex = 7;
            this.levelCorrectionCB.Text = "level correction";
            this.levelCorrectionCB.UseVisualStyleBackColor = true;
            this.levelCorrectionCB.CheckedChanged += new System.EventHandler(this.levelCorrectionCB_CheckedChanged);
            // 
            // binarizationTresholdCB
            // 
            this.binarizationTresholdCB.AutoSize = true;
            this.binarizationTresholdCB.Location = new System.Drawing.Point(12, 127);
            this.binarizationTresholdCB.Name = "binarizationTresholdCB";
            this.binarizationTresholdCB.Size = new System.Drawing.Size(123, 17);
            this.binarizationTresholdCB.TabIndex = 8;
            this.binarizationTresholdCB.Text = "binarization Treshold";
            this.binarizationTresholdCB.UseVisualStyleBackColor = true;
            this.binarizationTresholdCB.CheckedChanged += new System.EventHandler(this.binarizationTresholdCB_CheckedChanged);
            // 
            // binarizationJarvisCB
            // 
            this.binarizationJarvisCB.AutoSize = true;
            this.binarizationJarvisCB.Location = new System.Drawing.Point(12, 150);
            this.binarizationJarvisCB.Name = "binarizationJarvisCB";
            this.binarizationJarvisCB.Size = new System.Drawing.Size(106, 17);
            this.binarizationJarvisCB.TabIndex = 9;
            this.binarizationJarvisCB.Text = "binarization jarvis";
            this.binarizationJarvisCB.UseVisualStyleBackColor = true;
            this.binarizationJarvisCB.CheckedChanged += new System.EventHandler(this.binarizationJarvisCB_CheckedChanged);
            // 
            // thresholdTextBox
            // 
            this.thresholdTextBox.Enabled = false;
            this.thresholdTextBox.Location = new System.Drawing.Point(169, 125);
            this.thresholdTextBox.Name = "thresholdTextBox";
            this.thresholdTextBox.Size = new System.Drawing.Size(100, 20);
            this.thresholdTextBox.TabIndex = 10;
            this.thresholdTextBox.Text = "0";
            // 
            // thresholdTB
            // 
            this.thresholdTB.AutoSize = false;
            this.thresholdTB.Location = new System.Drawing.Point(505, 119);
            this.thresholdTB.Maximum = 255;
            this.thresholdTB.Name = "thresholdTB";
            this.thresholdTB.Size = new System.Drawing.Size(144, 25);
            this.thresholdTB.TabIndex = 12;
            this.thresholdTB.Scroll += new System.EventHandler(this.thresholdTB_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "threshold";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // binarizationBayerCB
            // 
            this.binarizationBayerCB.AutoSize = true;
            this.binarizationBayerCB.Location = new System.Drawing.Point(12, 173);
            this.binarizationBayerCB.Name = "binarizationBayerCB";
            this.binarizationBayerCB.Size = new System.Drawing.Size(108, 17);
            this.binarizationBayerCB.TabIndex = 18;
            this.binarizationBayerCB.Text = "binarization bayer";
            this.binarizationBayerCB.UseVisualStyleBackColor = true;
            this.binarizationBayerCB.CheckedChanged += new System.EventHandler(this.binarizationBayerCB_CheckedChanged);
            // 
            // binarizationSierraCB
            // 
            this.binarizationSierraCB.AutoSize = true;
            this.binarizationSierraCB.Location = new System.Drawing.Point(12, 196);
            this.binarizationSierraCB.Name = "binarizationSierraCB";
            this.binarizationSierraCB.Size = new System.Drawing.Size(107, 17);
            this.binarizationSierraCB.TabIndex = 19;
            this.binarizationSierraCB.Text = "binarization sierra";
            this.binarizationSierraCB.UseVisualStyleBackColor = true;
            this.binarizationSierraCB.CheckedChanged += new System.EventHandler(this.binarizationSierraCB_CheckedChanged);
            // 
            // otsuCB
            // 
            this.otsuCB.AutoSize = true;
            this.otsuCB.Location = new System.Drawing.Point(163, 196);
            this.otsuCB.Name = "otsuCB";
            this.otsuCB.Size = new System.Drawing.Size(77, 17);
            this.otsuCB.TabIndex = 20;
            this.otsuCB.Text = "global otsu";
            this.otsuCB.UseVisualStyleBackColor = true;
            this.otsuCB.CheckedChanged += new System.EventHandler(this.otsuCB_CheckedChanged);
            // 
            // Lab6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 638);
            this.Controls.Add(this.otsuCB);
            this.Controls.Add(this.binarizationSierraCB);
            this.Controls.Add(this.binarizationBayerCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.thresholdTB);
            this.Controls.Add(this.thresholdTextBox);
            this.Controls.Add(this.binarizationJarvisCB);
            this.Controls.Add(this.binarizationTresholdCB);
            this.Controls.Add(this.levelCorrectionCB);
            this.Controls.Add(this.gammaCorrectionCB);
            this.Controls.Add(this.LoadImageButton);
            this.Controls.Add(this.adaptiveSmoothingCB);
            this.Controls.Add(this.contrastCorrectionCB);
            this.Controls.Add(this.invertCB);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lab6";
            this.Text = "Lab 6";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox invertCB;
        private System.Windows.Forms.CheckBox contrastCorrectionCB;
        private System.Windows.Forms.CheckBox adaptiveSmoothingCB;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.CheckBox gammaCorrectionCB;
        private System.Windows.Forms.CheckBox levelCorrectionCB;
        private System.Windows.Forms.CheckBox binarizationTresholdCB;
        private System.Windows.Forms.CheckBox binarizationJarvisCB;
        private System.Windows.Forms.TextBox thresholdTextBox;
        private System.Windows.Forms.TrackBar thresholdTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox binarizationBayerCB;
        private System.Windows.Forms.CheckBox binarizationSierraCB;
        private System.Windows.Forms.CheckBox otsuCB;
    }
}

