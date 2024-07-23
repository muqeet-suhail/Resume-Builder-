namespace Assignment_2
{
    partial class Skillset
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
            this.lbl_skill_hobbies = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_back = new System.Windows.Forms.Button();
            this.button_export_to_pdf = new System.Windows.Forms.Button();
            this.button_skilladd = new System.Windows.Forms.Button();
            this.flp_skills = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_skillset = new System.Windows.Forms.TextBox();
            this.panel_main.SuspendLayout();
            this.flp_skills.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_skill_hobbies
            // 
            this.lbl_skill_hobbies.AutoSize = true;
            this.lbl_skill_hobbies.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_skill_hobbies.Location = new System.Drawing.Point(279, 58);
            this.lbl_skill_hobbies.Name = "lbl_skill_hobbies";
            this.lbl_skill_hobbies.Size = new System.Drawing.Size(191, 36);
            this.lbl_skill_hobbies.TabIndex = 11;
            this.lbl_skill_hobbies.Text = "Skill and Hobbies";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.button_back);
            this.panel_main.Controls.Add(this.button_export_to_pdf);
            this.panel_main.Controls.Add(this.button_skilladd);
            this.panel_main.Controls.Add(this.flp_skills);
            this.panel_main.Controls.Add(this.lbl_skill_hobbies);
            this.panel_main.Location = new System.Drawing.Point(-1, -2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(730, 1123);
            this.panel_main.TabIndex = 12;
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
            // button_export_to_pdf
            // 
            this.button_export_to_pdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_export_to_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_export_to_pdf.Location = new System.Drawing.Point(589, 399);
            this.button_export_to_pdf.Name = "button_export_to_pdf";
            this.button_export_to_pdf.Size = new System.Drawing.Size(80, 23);
            this.button_export_to_pdf.TabIndex = 14;
            this.button_export_to_pdf.Text = "Export";
            this.button_export_to_pdf.UseVisualStyleBackColor = false;
            this.button_export_to_pdf.Click += new System.EventHandler(this.button_export_to_pdf_Click);
            // 
            // button_skilladd
            // 
            this.button_skilladd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_skilladd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_skilladd.Location = new System.Drawing.Point(535, 91);
            this.button_skilladd.Name = "button_skilladd";
            this.button_skilladd.Size = new System.Drawing.Size(80, 23);
            this.button_skilladd.TabIndex = 13;
            this.button_skilladd.Text = "Add ";
            this.button_skilladd.UseVisualStyleBackColor = false;
            this.button_skilladd.Click += new System.EventHandler(this.button_skilladd_Click);
            // 
            // flp_skills
            // 
            this.flp_skills.AutoSize = true;
            this.flp_skills.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp_skills.Controls.Add(this.textBox_skillset);
            this.flp_skills.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_skills.Location = new System.Drawing.Point(103, 125);
            this.flp_skills.Name = "flp_skills";
            this.flp_skills.Padding = new System.Windows.Forms.Padding(5, 4, 0, 4);
            this.flp_skills.Size = new System.Drawing.Size(512, 34);
            this.flp_skills.TabIndex = 12;
            // 
            // textBox_skillset
            // 
            this.textBox_skillset.Location = new System.Drawing.Point(8, 7);
            this.textBox_skillset.Name = "textBox_skillset";
            this.textBox_skillset.Size = new System.Drawing.Size(501, 20);
            this.textBox_skillset.TabIndex = 3;
            this.textBox_skillset.Text = "Enter Skill / Hobby Name";
            this.textBox_skillset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_skillset.Click += new System.EventHandler(this.textBox_skillset_Click);
            // 
            // Skillset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.panel_main);
            this.Name = "Skillset";
            this.Text = "Skillset";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Skillset_FormClosed);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.flp_skills.ResumeLayout(false);
            this.flp_skills.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_skill_hobbies;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_export_to_pdf;
        private System.Windows.Forms.Button button_skilladd;
        private System.Windows.Forms.FlowLayoutPanel flp_skills;
        private System.Windows.Forms.TextBox textBox_skillset;
    }
}