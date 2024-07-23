namespace Assignment_2
{
    partial class Choose_Template_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose_Template_Form));
            this.picBox_Welcome = new System.Windows.Forms.PictureBox();
            this.lbl_Choose_Template = new System.Windows.Forms.Label();
            this.pictureBox_Template1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Template2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Welcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Template1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Template2)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_Welcome
            // 
            this.picBox_Welcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBox_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBox_Welcome.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Welcome.Image")));
            this.picBox_Welcome.Location = new System.Drawing.Point(227, 82);
            this.picBox_Welcome.Name = "picBox_Welcome";
            this.picBox_Welcome.Size = new System.Drawing.Size(352, 56);
            this.picBox_Welcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox_Welcome.TabIndex = 0;
            this.picBox_Welcome.TabStop = false;
            // 
            // lbl_Choose_Template
            // 
            this.lbl_Choose_Template.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Choose_Template.AutoSize = true;
            this.lbl_Choose_Template.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Choose_Template.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_Choose_Template.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Choose_Template.Location = new System.Drawing.Point(151, 164);
            this.lbl_Choose_Template.Name = "lbl_Choose_Template";
            this.lbl_Choose_Template.Size = new System.Drawing.Size(498, 48);
            this.lbl_Choose_Template.TabIndex = 1;
            this.lbl_Choose_Template.Text = "Choose Template For The Resume ";
            this.lbl_Choose_Template.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Template1
            // 
            this.pictureBox_Template1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Template1.Image = global::Assignment_2.Properties.Resources.Template1;
            this.pictureBox_Template1.Location = new System.Drawing.Point(173, 233);
            this.pictureBox_Template1.Name = "pictureBox_Template1";
            this.pictureBox_Template1.Size = new System.Drawing.Size(206, 233);
            this.pictureBox_Template1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Template1.TabIndex = 4;
            this.pictureBox_Template1.TabStop = false;
            this.pictureBox_Template1.Click += new System.EventHandler(this.pictureBox_Template1_Click);
            // 
            // pictureBox_Template2
            // 
            this.pictureBox_Template2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Template2.Image = global::Assignment_2.Properties.Resources.Template2;
            this.pictureBox_Template2.Location = new System.Drawing.Point(414, 233);
            this.pictureBox_Template2.Name = "pictureBox_Template2";
            this.pictureBox_Template2.Size = new System.Drawing.Size(206, 233);
            this.pictureBox_Template2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Template2.TabIndex = 5;
            this.pictureBox_Template2.TabStop = false;
            this.pictureBox_Template2.Click += new System.EventHandler(this.pictureBox_Template2_Click);
            // 
            // Choose_Template_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Assignment_2.Properties.Resources.BackImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 549);
            this.Controls.Add(this.lbl_Choose_Template);
            this.Controls.Add(this.picBox_Welcome);
            this.Controls.Add(this.pictureBox_Template2);
            this.Controls.Add(this.pictureBox_Template1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Choose_Template_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resume Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Choose_Template_Form_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Welcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Template1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Template2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Welcome;
        private System.Windows.Forms.Label lbl_Choose_Template;
        private System.Windows.Forms.PictureBox pictureBox_Template1;
        private System.Windows.Forms.PictureBox pictureBox_Template2;
    }
}

