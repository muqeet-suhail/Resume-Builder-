namespace Assignment_2
{
    partial class Experience
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_back = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_Experienceadd = new System.Windows.Forms.Button();
            this.flp_experience = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_Organizationname = new System.Windows.Forms.TextBox();
            this.textBox_startdate = new System.Windows.Forms.TextBox();
            this.textBox_enddate = new System.Windows.Forms.TextBox();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.flp_experience.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.AutoSize = true;
            this.panel_main.Controls.Add(this.button_back);
            this.panel_main.Controls.Add(this.button_next);
            this.panel_main.Controls.Add(this.button_Experienceadd);
            this.panel_main.Controls.Add(this.flp_experience);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Location = new System.Drawing.Point(-4, 1);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(738, 1123);
            this.panel_main.TabIndex = 3;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Location = new System.Drawing.Point(48, 419);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(80, 23);
            this.button_back.TabIndex = 7;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_next.Location = new System.Drawing.Point(588, 419);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(80, 23);
            this.button_next.TabIndex = 6;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_Experienceadd
            // 
            this.button_Experienceadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Experienceadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Experienceadd.Location = new System.Drawing.Point(588, 73);
            this.button_Experienceadd.Name = "button_Experienceadd";
            this.button_Experienceadd.Size = new System.Drawing.Size(80, 23);
            this.button_Experienceadd.TabIndex = 5;
            this.button_Experienceadd.Text = "Add ";
            this.button_Experienceadd.UseVisualStyleBackColor = false;
            this.button_Experienceadd.Click += new System.EventHandler(this.button_Experienceadd_Click);
            // 
            // flp_experience
            // 
            this.flp_experience.AutoSize = true;
            this.flp_experience.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp_experience.Controls.Add(this.textBox_Organizationname);
            this.flp_experience.Controls.Add(this.textBox_startdate);
            this.flp_experience.Controls.Add(this.textBox_enddate);
            this.flp_experience.Controls.Add(this.richTextBox_description);
            this.flp_experience.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_experience.Location = new System.Drawing.Point(48, 102);
            this.flp_experience.Name = "flp_experience";
            this.flp_experience.Padding = new System.Windows.Forms.Padding(5, 4, 0, 4);
            this.flp_experience.Size = new System.Drawing.Size(619, 187);
            this.flp_experience.TabIndex = 4;
            // 
            // textBox_Organizationname
            // 
            this.textBox_Organizationname.Location = new System.Drawing.Point(8, 7);
            this.textBox_Organizationname.Name = "textBox_Organizationname";
            this.textBox_Organizationname.Size = new System.Drawing.Size(358, 20);
            this.textBox_Organizationname.TabIndex = 0;
            this.textBox_Organizationname.Text = "Enter Organization Name";
            this.textBox_Organizationname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Organizationname.Click += new System.EventHandler(this.textBox_Organizationname_Click);
            // 
            // textBox_startdate
            // 
            this.textBox_startdate.Location = new System.Drawing.Point(8, 33);
            this.textBox_startdate.Name = "textBox_startdate";
            this.textBox_startdate.Size = new System.Drawing.Size(358, 20);
            this.textBox_startdate.TabIndex = 1;
            this.textBox_startdate.Text = "Enter Staring Date in (mm-yy) format";
            this.textBox_startdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_startdate.Click += new System.EventHandler(this.textBox_startdate_Click);
            // 
            // textBox_enddate
            // 
            this.textBox_enddate.Location = new System.Drawing.Point(8, 59);
            this.textBox_enddate.Name = "textBox_enddate";
            this.textBox_enddate.Size = new System.Drawing.Size(358, 20);
            this.textBox_enddate.TabIndex = 2;
            this.textBox_enddate.Text = "Enter End Date in (mm-yy) format";
            this.textBox_enddate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_enddate.Click += new System.EventHandler(this.textBox_enddate_Click);
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richTextBox_description.ForeColor = System.Drawing.Color.Gray;
            this.richTextBox_description.Location = new System.Drawing.Point(8, 85);
            this.richTextBox_description.MaxLength = 463;
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(608, 95);
            this.richTextBox_description.TabIndex = 3;
            this.richTextBox_description.Text = "Enter Experience Description (Max 65 Words)";
            this.richTextBox_description.Click += new System.EventHandler(this.richTextBox_description_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(150, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Experience And Community Service Info ";
            // 
            // Experience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 467);
            this.Controls.Add(this.panel_main);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Experience";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Experience";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Experience_FormClosed);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.flp_experience.ResumeLayout(false);
            this.flp_experience.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button button_Experienceadd;
        private System.Windows.Forms.FlowLayoutPanel flp_experience;
        private System.Windows.Forms.TextBox textBox_Organizationname;
        private System.Windows.Forms.TextBox textBox_startdate;
        private System.Windows.Forms.TextBox textBox_enddate;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_back;
    }
}