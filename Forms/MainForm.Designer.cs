namespace RecoveryModification
{
    partial class MainForm
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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.GroupBox groupBox3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.GroupBox groupBox4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.StatusStrip statusStrip;
            this.sourcePictureBox = new System.Windows.Forms.PictureBox();
            this.bluredPictureBox = new System.Windows.Forms.PictureBox();
            this.standardTransitionDeviation = new System.Windows.Forms.Label();
            this.standardColorDeviation = new System.Windows.Forms.Label();
            this.reconstructedPictureBox = new System.Windows.Forms.PictureBox();
            this.modifiedTransitionDeviation = new System.Windows.Forms.Label();
            this.modifiedColorDeviation = new System.Windows.Forms.Label();
            this.modifiedReconstructedPictureBox = new System.Windows.Forms.PictureBox();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            statusStrip = new System.Windows.Forms.StatusStrip();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bluredPictureBox)).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reconstructedPictureBox)).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifiedReconstructedPictureBox)).BeginInit();
            statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.sourcePictureBox);
            groupBox1.Location = new System.Drawing.Point(13, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(266, 210);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Source image";
            // 
            // sourcePictureBox
            // 
            this.sourcePictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sourcePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sourcePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourcePictureBox.Image = global::RecoveryModification.Properties.Resources.Loading;
            this.sourcePictureBox.Location = new System.Drawing.Point(6, 19);
            this.sourcePictureBox.Name = "sourcePictureBox";
            this.sourcePictureBox.Size = new System.Drawing.Size(254, 185);
            this.sourcePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourcePictureBox.TabIndex = 2;
            this.sourcePictureBox.TabStop = false;
            this.sourcePictureBox.Click += new System.EventHandler(this.SaveImage);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.bluredPictureBox);
            groupBox2.Location = new System.Drawing.Point(285, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(266, 210);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Blured image";
            // 
            // bluredPictureBox
            // 
            this.bluredPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bluredPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bluredPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bluredPictureBox.Image = global::RecoveryModification.Properties.Resources.Loading;
            this.bluredPictureBox.Location = new System.Drawing.Point(6, 19);
            this.bluredPictureBox.Name = "bluredPictureBox";
            this.bluredPictureBox.Size = new System.Drawing.Size(254, 185);
            this.bluredPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bluredPictureBox.TabIndex = 3;
            this.bluredPictureBox.TabStop = false;
            this.bluredPictureBox.Click += new System.EventHandler(this.SaveImage);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(this.standardTransitionDeviation);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(this.standardColorDeviation);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(this.reconstructedPictureBox);
            groupBox3.Location = new System.Drawing.Point(13, 248);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(266, 264);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Reconstructed image";
            // 
            // standardTransitionDeviation
            // 
            this.standardTransitionDeviation.AutoSize = true;
            this.standardTransitionDeviation.Location = new System.Drawing.Point(64, 242);
            this.standardTransitionDeviation.Name = "standardTransitionDeviation";
            this.standardTransitionDeviation.Size = new System.Drawing.Size(13, 13);
            this.standardTransitionDeviation.TabIndex = 7;
            this.standardTransitionDeviation.Text = "?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 242);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 13);
            label4.TabIndex = 6;
            label4.Text = "Transitions:";
            // 
            // standardColorDeviation
            // 
            this.standardColorDeviation.AutoSize = true;
            this.standardColorDeviation.Location = new System.Drawing.Point(64, 229);
            this.standardColorDeviation.Name = "standardColorDeviation";
            this.standardColorDeviation.Size = new System.Drawing.Size(13, 13);
            this.standardColorDeviation.TabIndex = 5;
            this.standardColorDeviation.Text = "?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 229);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 13);
            label2.TabIndex = 4;
            label2.Text = "Colors:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 211);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 13);
            label1.TabIndex = 3;
            label1.Text = "Mean square deviation:";
            // 
            // reconstructedPictureBox
            // 
            this.reconstructedPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.reconstructedPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reconstructedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reconstructedPictureBox.Image = global::RecoveryModification.Properties.Resources.Loading;
            this.reconstructedPictureBox.Location = new System.Drawing.Point(6, 19);
            this.reconstructedPictureBox.Name = "reconstructedPictureBox";
            this.reconstructedPictureBox.Size = new System.Drawing.Size(254, 185);
            this.reconstructedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reconstructedPictureBox.TabIndex = 2;
            this.reconstructedPictureBox.TabStop = false;
            this.reconstructedPictureBox.Click += new System.EventHandler(this.SaveImage);
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(this.modifiedTransitionDeviation);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(this.modifiedColorDeviation);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(this.modifiedReconstructedPictureBox);
            groupBox4.Location = new System.Drawing.Point(285, 248);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(266, 264);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Reconstructed by modified algorithm";
            // 
            // modifiedTransitionDeviation
            // 
            this.modifiedTransitionDeviation.AutoSize = true;
            this.modifiedTransitionDeviation.Location = new System.Drawing.Point(64, 242);
            this.modifiedTransitionDeviation.Name = "modifiedTransitionDeviation";
            this.modifiedTransitionDeviation.Size = new System.Drawing.Size(13, 13);
            this.modifiedTransitionDeviation.TabIndex = 7;
            this.modifiedTransitionDeviation.Text = "?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 242);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(61, 13);
            label5.TabIndex = 6;
            label5.Text = "Transitions:";
            // 
            // modifiedColorDeviation
            // 
            this.modifiedColorDeviation.AutoSize = true;
            this.modifiedColorDeviation.Location = new System.Drawing.Point(64, 229);
            this.modifiedColorDeviation.Name = "modifiedColorDeviation";
            this.modifiedColorDeviation.Size = new System.Drawing.Size(13, 13);
            this.modifiedColorDeviation.TabIndex = 5;
            this.modifiedColorDeviation.Text = "?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 229);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(39, 13);
            label7.TabIndex = 4;
            label7.Text = "Colors:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 211);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(118, 13);
            label8.TabIndex = 3;
            label8.Text = "Mean square deviation:";
            // 
            // modifiedReconstructedPictureBox
            // 
            this.modifiedReconstructedPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.modifiedReconstructedPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.modifiedReconstructedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modifiedReconstructedPictureBox.Image = global::RecoveryModification.Properties.Resources.Loading;
            this.modifiedReconstructedPictureBox.Location = new System.Drawing.Point(6, 19);
            this.modifiedReconstructedPictureBox.Name = "modifiedReconstructedPictureBox";
            this.modifiedReconstructedPictureBox.Size = new System.Drawing.Size(254, 185);
            this.modifiedReconstructedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.modifiedReconstructedPictureBox.TabIndex = 2;
            this.modifiedReconstructedPictureBox.TabStop = false;
            this.modifiedReconstructedPictureBox.Click += new System.EventHandler(this.SaveImage);
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            statusStrip.Location = new System.Drawing.Point(0, 519);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new System.Drawing.Size(563, 22);
            statusStrip.TabIndex = 9;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newImageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newImageToolStripMenuItem
            // 
            this.newImageToolStripMenuItem.Name = "newImageToolStripMenuItem";
            this.newImageToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.newImageToolStripMenuItem.Text = "New Image";
            this.newImageToolStripMenuItem.Click += new System.EventHandler(this.ChooseNewImage);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 541);
            this.Controls.Add(statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(groupBox4);
            this.Controls.Add(groupBox3);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Recovery modification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClose);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bluredPictureBox)).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reconstructedPictureBox)).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifiedReconstructedPictureBox)).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox bluredPictureBox;
        private System.Windows.Forms.Label standardTransitionDeviation;
        private System.Windows.Forms.Label standardColorDeviation;
        private System.Windows.Forms.PictureBox reconstructedPictureBox;
        private System.Windows.Forms.Label modifiedTransitionDeviation;
        private System.Windows.Forms.Label modifiedColorDeviation;
        private System.Windows.Forms.PictureBox modifiedReconstructedPictureBox;
        private System.Windows.Forms.PictureBox sourcePictureBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newImageToolStripMenuItem;
    }
}

