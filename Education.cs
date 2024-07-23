using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Education : Form
    {
        public InputForm form_i;
        public Skillset skillform;
        private int count_of_education_details = 2;
        private int MoveFactor = 1;
        public List<string> educationlist;
        public Education(InputForm form_input)
        {
            InitializeComponent();
            this.form_i = form_input;
            educationlist = new List<string>();
            skillform = new Skillset(form_i);
        }
        
        private void CopyTextBoxProperties(TextBox source, TextBox target)
        {
            target.Font = source.Font;
            target.ForeColor = source.ForeColor;
            target.BackColor = source.BackColor;
            target.Size = source.Size;
            target.Location = source.Location;
            target.Padding = source.Padding;
            target.Margin = source.Margin;
            target.ReadOnly = source.ReadOnly;
            target.ScrollBars = source.ScrollBars;
            target.BorderStyle = source.BorderStyle;
            target.TextAlign = source.TextAlign;
        }

        private void Education_FormClosed(object sender, FormClosedEventArgs e)
        {
            skillform.Close();
            this.Owner.Show();
        }

        private void button_Educationadd_Click(object sender, EventArgs e)
        {
            TextBox textbox_university = new TextBox();
            textbox_university.Text = "Enter University Name";
            textbox_university.Name = "textbox_CompanyName " + count_of_education_details;
            TextBox textbox_education_title = new TextBox();
            textbox_education_title.Text = "Enter Degree / Certification Name";
            textbox_education_title.Name = "Textbox_degreetitle " + count_of_education_details;
            TextBox textbox_startd = new TextBox();
            textbox_startd.Text = "Enter Staring Date in (mm-yy) format";
            textbox_startd.Name = "textbox_startDate " + count_of_education_details;
            TextBox textbox_endd = new TextBox();
            textbox_endd.Text = "Enter Ending Date in (mm-yy) format";
            textbox_endd.Name = "textbox_endDate " + count_of_education_details;
            CopyTextBoxProperties(textBox_Degree, textbox_education_title);
            CopyTextBoxProperties(textBox_uniname, textbox_university);
            CopyTextBoxProperties(textBox_StartDate, textbox_startd);
            CopyTextBoxProperties(textBox_enddate, textbox_endd);
            flp_education.Controls.Add(textbox_education_title);
            flp_education.Controls.Add(textbox_university);
            flp_education.Controls.Add(textbox_startd);
            flp_education.Controls.Add(textbox_endd);
            while (flp_education.Bounds.IntersectsWith(button_back.Bounds))
            {
                System.Drawing.Point point_of_back_btn = new System.Drawing.Point(button_back.Location.X, button_back.Location.Y + MoveFactor);
                System.Drawing.Point point_of_save_btn = new System.Drawing.Point(button_next.Location.X, button_next.Location.Y + MoveFactor);
                button_back.Location = point_of_back_btn;
                button_next.Location = point_of_save_btn;
            }
            count_of_education_details++;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            educationlist.Clear();
            foreach (var education_flp in flp_education.Controls)
            {
                if (education_flp is TextBox textbox_edu)
                {
                    if (!String.IsNullOrEmpty(textbox_edu.Text))
                    {
                        educationlist.Add(textbox_edu.Text);

                    }
                    else
                    {
                        MessageBox.Show("Education Fields can't be Null");
                        return;
                    } 
                }

            }
            form_i.Educationandcertification = educationlist;

            skillform.Show(this);
            this.Hide();
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you want to close!!!", "All data will be lost!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }

            }
        }

        private void textBox_Degree_Click(object sender, EventArgs e)
        {
            textBox_Degree.Text = null;
        }

        private void textBox_uniname_Click(object sender, EventArgs e)
        {
            textBox_uniname.Text = null;
        }

        private void textBox_StartDate_Click(object sender, EventArgs e)
        {
            textBox_StartDate.Text = null;
        }

        private void textBox_enddate_Click(object sender, EventArgs e)
        {
            textBox_enddate.Text = null;
        }
    }
}
