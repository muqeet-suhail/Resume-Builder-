namespace Assignment_2
{
    partial class InputForm
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
            this.label_Welcome = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.richTextBox_About = new System.Windows.Forms.RichTextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold);
            this.label_Welcome.Location = new System.Drawing.Point(286, 27);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(165, 51);
            this.label_Welcome.TabIndex = 0;
            this.label_Welcome.Text = "Welcome";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Poppins", 10F);
            this.label_name.Location = new System.Drawing.Point(120, 102);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(96, 25);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Enter Name:";
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.White;
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.ForeColor = System.Drawing.Color.Gray;
            this.textBox_name.Location = new System.Drawing.Point(249, 104);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(318, 20);
            this.textBox_name.TabIndex = 2;
            this.textBox_name.Text = "Enter name";
            this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_name.Click += new System.EventHandler(this.textBox_name_Click);
            // 
            // textBox_number
            // 
            this.textBox_number.BackColor = System.Drawing.Color.White;
            this.textBox_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_number.ForeColor = System.Drawing.Color.Gray;
            this.textBox_number.Location = new System.Drawing.Point(249, 158);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(318, 20);
            this.textBox_number.TabIndex = 4;
            this.textBox_number.Text = "Enter number (optional)";
            this.textBox_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_number.Click += new System.EventHandler(this.textBox_number_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F);
            this.label1.Location = new System.Drawing.Point(120, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Number:";
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.Color.White;
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_email.ForeColor = System.Drawing.Color.Gray;
            this.textBox_email.Location = new System.Drawing.Point(249, 212);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(318, 20);
            this.textBox_email.TabIndex = 6;
            this.textBox_email.Text = "Enter email";
            this.textBox_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_email.Click += new System.EventHandler(this.textBox_email_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10F);
            this.label2.Location = new System.Drawing.Point(120, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Email:";
            // 
            // textBox_address
            // 
            this.textBox_address.BackColor = System.Drawing.Color.White;
            this.textBox_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_address.ForeColor = System.Drawing.Color.Gray;
            this.textBox_address.Location = new System.Drawing.Point(249, 266);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(318, 20);
            this.textBox_address.TabIndex = 8;
            this.textBox_address.Text = "Enter address";
            this.textBox_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_address.Click += new System.EventHandler(this.textBox_address_Click);
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Poppins", 10F);
            this.label_address.Location = new System.Drawing.Point(120, 264);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(109, 25);
            this.label_address.TabIndex = 7;
            this.label_address.Text = "Enter Address:";
            // 
            // richTextBox_About
            // 
            this.richTextBox_About.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_About.ForeColor = System.Drawing.Color.DimGray;
            this.richTextBox_About.Location = new System.Drawing.Point(125, 312);
            this.richTextBox_About.MaxLength = 463;
            this.richTextBox_About.Name = "richTextBox_About";
            this.richTextBox_About.Size = new System.Drawing.Size(442, 96);
            this.richTextBox_About.TabIndex = 9;
            this.richTextBox_About.Text = "Enter About You ( Can Only Be of Maximum 65 Words )";
            this.richTextBox_About.Click += new System.EventHandler(this.richTextBox_About_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_next.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(593, 414);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(96, 24);
            this.btn_next.TabIndex = 10;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.richTextBox_About);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_Welcome);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.RichTextBox richTextBox_About;
        private System.Windows.Forms.Button btn_next;
    }
}