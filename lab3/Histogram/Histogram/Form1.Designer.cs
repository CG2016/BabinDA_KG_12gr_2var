namespace Histogram
{
    partial class Histogram
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.myZedGraphControl = new ZedGraph.ZedGraphControl();
            this.loadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myPictureBox
            // 
            this.myPictureBox.Location = new System.Drawing.Point(12, 12);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(424, 586);
            this.myPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myPictureBox.TabIndex = 0;
            this.myPictureBox.TabStop = false;
            this.myPictureBox.Click += new System.EventHandler(this.myPictureBox_Click);
            // 
            // myZedGraphControl
            // 
            this.myZedGraphControl.Location = new System.Drawing.Point(442, 12);
            this.myZedGraphControl.Name = "myZedGraphControl";
            this.myZedGraphControl.ScrollGrace = 0D;
            this.myZedGraphControl.ScrollMaxX = 0D;
            this.myZedGraphControl.ScrollMaxY = 0D;
            this.myZedGraphControl.ScrollMaxY2 = 0D;
            this.myZedGraphControl.ScrollMinX = 0D;
            this.myZedGraphControl.ScrollMinY = 0D;
            this.myZedGraphControl.ScrollMinY2 = 0D;
            this.myZedGraphControl.Size = new System.Drawing.Size(1004, 615);
            this.myZedGraphControl.TabIndex = 1;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 604);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load Image";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 639);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.myZedGraphControl);
            this.Controls.Add(this.myPictureBox);
            this.Name = "Histogram";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox myPictureBox;
        private ZedGraph.ZedGraphControl myZedGraphControl;
        private System.Windows.Forms.Button loadButton;
    }
}

