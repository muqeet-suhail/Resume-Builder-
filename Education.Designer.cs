namespace Assignment_2
{
    partial class Education
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_back = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_Educationadd = new System.Windows.Forms.Button();
            this.flp_education = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_Degree = new System.Windows.Forms.TextBox();
            this.textBox_uniname = new System.Windows.Forms.TextBox();
            this.textBox_StartDate = new System.Windows.Forms.TextBox();
            this.textBox_enddate = new System.Windows.Forms.TextBox();
            this.lbl_edu_and_certification = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flp_education.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Controls.Add(this.button_next);
            this.panel1.Controls.Add(this.button_Educationadd);
            this.panel1.Controls.Add(this.flp_education);
            this.panel1.Controls.Add(this.lbl_edu_and_certification);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 1123);
            this.panel1.TabIndex = 11;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Location = new System.Drawing.Point(49, 399);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(80, 23);
            this.button_back.TabIndex = 15;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_next.Location = new System.Drawing.Point(589, 399);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(80, 23);
            this.button_next.TabIndex = 14;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_Educationadd
            // 
            this.button_Educationadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Educationadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Educationadd.Location = new System.Drawing.Point(535, 91);
            this.button_Educationadd.Name = "button_Educationadd";
            this.button_Educationadd.Size = new System.Drawing.Size(80, 23);
            this.button_Educationadd.TabIndex = 13;
            this.button_Educationadd.Text = "Add ";
            this.button_Educationadd.UseVisualStyleBackColor = false;
            this.button_Educationadd.Click += new System.EventHandler(this.button_Educationadd_Click);
            // 
            // flp_education
            // 
            this.flp_education.AutoSize = true;
            this.flp_education.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp_education.Controls.Add(this.textBox_Degree);
            this.flp_education.Controls.Add(this.textBox_uniname);
            this.flp_education.Controls.Add(this.textBox_StartDate);
            this.flp_education.Controls.Add(this.textBox_enddate);
            this.flp_education.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_education.Location = new System.Drawing.Point(103, 125);
            this.flp_education.Name = "flp_education";
            this.flp_education.Padding = new System.Windows.Forms.Padding(5, 4, 0, 4);
            this.flp_education.Size = new System.Drawing.Size(512, 112);
            this.flp_education.TabIndex = 12;
            // 
            // textBox_Degree
            // 
            this.textBox_Degree.Location = new System.Drawing.Point(8, 7);
            this.textBox_Degree.Name = "textBox_Degree";
            this.textBox_Degree.Size = new System.Drawing.Size(501, 20);
            this.textBox_Degree.TabIndex = 3;
            this.textBox_Degree.Text = "Enter Degree Name";
            this.textBox_Degree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Degree.Click += new System.EventHandler(this.textBox_Degree_Click);
            // 
            // textBox_uniname
            // 
            this.textBox_uniname.Location = new System.Drawing.Point(8, 33);
            this.textBox_uniname.Name = "textBox_uniname";
            this.textBox_uniname.Size = new System.Drawing.Size(501, 20);
            this.textBox_uniname.TabIndex = 0;
            this.textBox_uniname.Text = "Enter University Name";
            this.textBox_uniname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_uniname.Click += new System.EventHandler(this.textBox_uniname_Click);
            // 
            // textBox_StartDate
            // 
            this.textBox_StartDate.Location = new System.Drawing.Point(8, 59);
            this.textBox_StartDate.Name = "textBox_StartDate";
            this.textBox_StartDate.Size = new System.Drawing.Size(501, 20);
            this.textBox_StartDate.TabIndex = 1;
            this.textBox_StartDate.Text = "Enter Staring Date in (mm-yy) format";
            this.textBox_StartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_StartDate.Click += new System.EventHandler(this.textBox_StartDate_Click);
            // 
            // textBox_enddate
            // 
            this.textBox_enddate.Location = new System.Drawing.Point(8, 85);
            this.textBox_enddate.Name = "textBox_enddate";
            this.textBox_enddate.Size = new System.Drawing.Size(501, 20);
            this.textBox_enddate.TabIndex = 2;
            this.textBox_enddate.Text = "Enter End Date in (mm-yy) format";
            this.textBox_enddate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_enddate.Click += new System.EventHandler(this.textBox_enddate_Click);
            // 
            // lbl_edu_and_certification
            // 
            this.lbl_edu_and_certification.AutoSize = true;
            this.lbl_edu_and_certification.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_edu_and_certification.Location = new System.Drawing.Point(214, 56);
            this.lbl_edu_and_certification.Name = "lbl_edu_and_certification";
            this.lbl_edu_and_certification.Size = new System.Drawing.Size(297, 36);
            this.lbl_edu_and_certification.TabIndex = 11;
            this.lbl_edu_and_certification.Text = "Education and Certification";
            // 
            // Education
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(742, 467);
            this.Controls.Add(this.panel1);
            this.Name = "Education";
            this.Text = "Education";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Education_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flp_education.ResumeLayout(false);
            this.flp_education.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_Educationadd;
        private System.Windows.Forms.FlowLayoutPanel flp_education;
        private System.Windows.Forms.TextBox textBox_Degree;
        private System.Windows.Forms.TextBox textBox_uniname;
        private System.Windows.Forms.TextBox textBox_StartDate;
        private System.Windows.Forms.TextBox textBox_enddate;
        private System.Windows.Forms.Label lbl_edu_and_certification;
    }
}