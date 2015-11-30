namespace RecoveryModification
{
    partial class StartForm
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
            this.maneGroupBox = new System.Windows.Forms.GroupBox();
            this.warningText2 = new System.Windows.Forms.Label();
            this.warningText1 = new System.Windows.Forms.Label();
            this.originalSizeCheckBox = new System.Windows.Forms.CheckBox();
            this.startProcessingButton = new System.Windows.Forms.Button();
            this.sizeText = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.maneGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // maneGroupBox
            // 
            this.maneGroupBox.Controls.Add(this.warningText2);
            this.maneGroupBox.Controls.Add(this.warningText1);
            this.maneGroupBox.Controls.Add(this.originalSizeCheckBox);
            this.maneGroupBox.Controls.Add(this.startProcessingButton);
            this.maneGroupBox.Controls.Add(this.sizeText);
            this.maneGroupBox.Controls.Add(this.sizeLabel);
            this.maneGroupBox.Controls.Add(this.previewPictureBox);
            this.maneGroupBox.Controls.Add(this.browseButton);
            this.maneGroupBox.Location = new System.Drawing.Point(13, 13);
            this.maneGroupBox.Name = "maneGroupBox";
            this.maneGroupBox.Size = new System.Drawing.Size(277, 165);
            this.maneGroupBox.TabIndex = 0;
            this.maneGroupBox.TabStop = false;
            // 
            // warningText2
            // 
            this.warningText2.AutoSize = true;
            this.warningText2.Location = new System.Drawing.Point(7, 112);
            this.warningText2.Name = "warningText2";
            this.warningText2.Size = new System.Drawing.Size(90, 13);
            this.warningText2.TabIndex = 7;
            this.warningText2.Text = "takes a lot of time";
            // 
            // warningText1
            // 
            this.warningText1.AutoSize = true;
            this.warningText1.Location = new System.Drawing.Point(7, 95);
            this.warningText1.Name = "warningText1";
            this.warningText1.Size = new System.Drawing.Size(102, 13);
            this.warningText1.TabIndex = 6;
            this.warningText1.Text = "Work with large size";
            // 
            // originalSizeCheckBox
            // 
            this.originalSizeCheckBox.AutoSize = true;
            this.originalSizeCheckBox.Location = new System.Drawing.Point(10, 71);
            this.originalSizeCheckBox.Name = "originalSizeCheckBox";
            this.originalSizeCheckBox.Size = new System.Drawing.Size(100, 17);
            this.originalSizeCheckBox.TabIndex = 5;
            this.originalSizeCheckBox.Text = "use original size";
            this.originalSizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // startProcessingButton
            // 
            this.startProcessingButton.Location = new System.Drawing.Point(7, 133);
            this.startProcessingButton.Name = "startProcessingButton";
            this.startProcessingButton.Size = new System.Drawing.Size(265, 23);
            this.startProcessingButton.TabIndex = 4;
            this.startProcessingButton.Text = "Start processing!";
            this.startProcessingButton.UseVisualStyleBackColor = true;
            this.startProcessingButton.Click += new System.EventHandler(this.StartProcessing);
            // 
            // sizeText
            // 
            this.sizeText.AutoSize = true;
            this.sizeText.Location = new System.Drawing.Point(44, 50);
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(24, 13);
            this.sizeText.TabIndex = 3;
            this.sizeText.Text = "?x?";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(7, 50);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(30, 13);
            this.sizeLabel.TabIndex = 2;
            this.sizeLabel.Text = "Size:";
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.previewPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPictureBox.Location = new System.Drawing.Point(133, 20);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(138, 107);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 1;
            this.previewPictureBox.TabStop = false;
            this.previewPictureBox.Click += new System.EventHandler(this.Browse);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(7, 20);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(120, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.Browse);
            // 
            // StartForm
            // 
            this.AcceptButton = this.startProcessingButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 190);
            this.Controls.Add(this.maneGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.Text = "Recovery modification";
            this.maneGroupBox.ResumeLayout(false);
            this.maneGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox maneGroupBox;
        private System.Windows.Forms.CheckBox originalSizeCheckBox;
        private System.Windows.Forms.Button startProcessingButton;
        private System.Windows.Forms.Label sizeText;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label warningText2;
        private System.Windows.Forms.Label warningText1;
    }
}