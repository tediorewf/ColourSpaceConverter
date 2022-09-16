namespace ColourSpaceConverter
{
    partial class RGBChannelsExtractionForm
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
            this.baseImagePictureBox = new System.Windows.Forms.PictureBox();
            this.redChannelPictureBox = new System.Windows.Forms.PictureBox();
            this.greenChannelPictureBox = new System.Windows.Forms.PictureBox();
            this.blueChannelPictureBox = new System.Windows.Forms.PictureBox();
            this.baseImageLabel = new System.Windows.Forms.Label();
            this.redChannelLabel = new System.Windows.Forms.Label();
            this.greenChannelLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chooseImageButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.buildHystogramsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.baseImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redChannelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenChannelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueChannelPictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseImagePictureBox
            // 
            this.baseImagePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baseImagePictureBox.Location = new System.Drawing.Point(3, 3);
            this.baseImagePictureBox.Name = "baseImagePictureBox";
            this.baseImagePictureBox.Size = new System.Drawing.Size(300, 400);
            this.baseImagePictureBox.TabIndex = 0;
            this.baseImagePictureBox.TabStop = false;
            // 
            // redChannelPictureBox
            // 
            this.redChannelPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redChannelPictureBox.Location = new System.Drawing.Point(3, 3);
            this.redChannelPictureBox.Name = "redChannelPictureBox";
            this.redChannelPictureBox.Size = new System.Drawing.Size(300, 400);
            this.redChannelPictureBox.TabIndex = 1;
            this.redChannelPictureBox.TabStop = false;
            // 
            // greenChannelPictureBox
            // 
            this.greenChannelPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.greenChannelPictureBox.Location = new System.Drawing.Point(3, 3);
            this.greenChannelPictureBox.Name = "greenChannelPictureBox";
            this.greenChannelPictureBox.Size = new System.Drawing.Size(300, 400);
            this.greenChannelPictureBox.TabIndex = 2;
            this.greenChannelPictureBox.TabStop = false;
            // 
            // blueChannelPictureBox
            // 
            this.blueChannelPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blueChannelPictureBox.Location = new System.Drawing.Point(3, 3);
            this.blueChannelPictureBox.Name = "blueChannelPictureBox";
            this.blueChannelPictureBox.Size = new System.Drawing.Size(300, 400);
            this.blueChannelPictureBox.TabIndex = 3;
            this.blueChannelPictureBox.TabStop = false;
            // 
            // baseImageLabel
            // 
            this.baseImageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baseImageLabel.AutoSize = true;
            this.baseImageLabel.Location = new System.Drawing.Point(3, 406);
            this.baseImageLabel.Name = "baseImageLabel";
            this.baseImageLabel.Size = new System.Drawing.Size(249, 25);
            this.baseImageLabel.TabIndex = 4;
            this.baseImageLabel.Text = "Исходное изображение";
            // 
            // redChannelLabel
            // 
            this.redChannelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redChannelLabel.AutoSize = true;
            this.redChannelLabel.Location = new System.Drawing.Point(3, 406);
            this.redChannelLabel.Name = "redChannelLabel";
            this.redChannelLabel.Size = new System.Drawing.Size(212, 25);
            this.redChannelLabel.TabIndex = 5;
            this.redChannelLabel.Text = "Составляющая RED";
            // 
            // greenChannelLabel
            // 
            this.greenChannelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.greenChannelLabel.AutoSize = true;
            this.greenChannelLabel.Location = new System.Drawing.Point(3, 406);
            this.greenChannelLabel.Name = "greenChannelLabel";
            this.greenChannelLabel.Size = new System.Drawing.Size(242, 25);
            this.greenChannelLabel.TabIndex = 6;
            this.greenChannelLabel.Text = "Составляющая GREEN";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Составляющая BLUE";
            // 
            // chooseImageButton
            // 
            this.chooseImageButton.Location = new System.Drawing.Point(3, 3);
            this.chooseImageButton.Name = "chooseImageButton";
            this.chooseImageButton.Size = new System.Drawing.Size(634, 92);
            this.chooseImageButton.TabIndex = 8;
            this.chooseImageButton.Text = "Выбрать изображение";
            this.chooseImageButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.baseImagePictureBox);
            this.flowLayoutPanel1.Controls.Add(this.baseImageLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(319, 438);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.redChannelPictureBox);
            this.flowLayoutPanel2.Controls.Add(this.redChannelLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(328, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(309, 438);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.greenChannelPictureBox);
            this.flowLayoutPanel3.Controls.Add(this.greenChannelLabel);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(643, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(312, 439);
            this.flowLayoutPanel3.TabIndex = 11;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.blueChannelPictureBox);
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(961, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(313, 439);
            this.flowLayoutPanel4.TabIndex = 12;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1299, 449);
            this.flowLayoutPanel5.TabIndex = 13;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(14, 12);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel6.Size = new System.Drawing.Size(1311, 572);
            this.flowLayoutPanel6.TabIndex = 14;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel7.Controls.Add(this.chooseImageButton);
            this.flowLayoutPanel7.Controls.Add(this.buildHystogramsButton);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 458);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(1299, 100);
            this.flowLayoutPanel7.TabIndex = 14;
            // 
            // buildHystogramsButton
            // 
            this.buildHystogramsButton.Location = new System.Drawing.Point(643, 3);
            this.buildHystogramsButton.Name = "buildHystogramsButton";
            this.buildHystogramsButton.Size = new System.Drawing.Size(631, 92);
            this.buildHystogramsButton.TabIndex = 9;
            this.buildHystogramsButton.Text = "Построить гистограммы";
            this.buildHystogramsButton.UseVisualStyleBackColor = true;
            this.buildHystogramsButton.Click += new System.EventHandler(this.buildHistogramsButton_Click);
            // 
            // RGBChannelsExtractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 596);
            this.Controls.Add(this.flowLayoutPanel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RGBChannelsExtractionForm";
            this.Text = "Выделение из полноцветного изображения каждого из каналов R, G, B";
            this.Load += new System.EventHandler(this.RGBChannelsExtractionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redChannelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenChannelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueChannelPictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox baseImagePictureBox;
        private System.Windows.Forms.PictureBox redChannelPictureBox;
        private System.Windows.Forms.PictureBox greenChannelPictureBox;
        private System.Windows.Forms.PictureBox blueChannelPictureBox;
        private System.Windows.Forms.Label baseImageLabel;
        private System.Windows.Forms.Label redChannelLabel;
        private System.Windows.Forms.Label greenChannelLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button chooseImageButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Button buildHystogramsButton;
    }
}