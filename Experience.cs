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
    public partial class Experience : Form
    {
        private InputForm form_got;
        public Education eduForm;
        private int count_of_experience = 2;
        private int MoveFactor = 1;
        public List<string> Experiencecontent;
        public Experience(InputForm form_got_i)
        {
            InitializeComponent();
            this.form_got = form_got_i;
            eduForm = new Education(form_got_i);
            Experiencecontent=new List<string>();
        }

        private void button_Experienceadd_Click(object sender, EventArgs e)
        {
            TextBox textbox_company = new TextBox();
            textbox_company.Text = "Enter Organization Name";
            textbox_company.Name = "textbox_CompanyName " + count_of_experience;
            TextBox textbox_startd = new TextBox();
            textbox_startd.Text = "Enter Staring Date in (mm-yy) format";
            textbox_startd.Name = "textboxExpstartDate " + count_of_experience;
            TextBox textbox_endd = new TextBox();
            textbox_endd.Text = "Enter Ending Date in (mm-yy) format";
            textbox_endd.Name = "textboxExpendDate " + count_of_experience;
            RichTextBox description = new RichTextBox();
            description.Text = "Enter Experience Description (Max 65 words)";
            description.Name = "rtb_JobDescription " + count_of_experience;
            CopyTextBoxProperties(textBox_Organizationname, textbox_company);
            CopyTextBoxProperties(textBox_startdate, textbox_startd);
            CopyTextBoxProperties(textBox_enddate, textbox_endd);
            CopyRichTextBoxProperties(richTextBox_description, description);
            flp_experience.Controls.Add(textbox_company);
            flp_experience.Controls.Add(textbox_startd);
            flp_experience.Controls.Add(textbox_endd);
            flp_experience.Controls.Add(description);
            while (flp_experience.Bounds.IntersectsWith(button_back.Bounds))
            {
                System.Drawing.Point point_of_back_btn = new System.Drawing.Point(button_back.Location.X, button_back.Location.Y + MoveFactor);
                System.Drawing.Point point_of_save_btn = new System.Drawing.Point(button_next.Location.X, button_next.Location.Y + MoveFactor);
                button_back.Location = point_of_back_btn;
                button_next.Location = point_of_save_btn;
            }
            count_of_experience++;
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

        private void CopyRichTextBoxProperties(RichTextBox source, RichTextBox target)
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
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void Experience_FormClosed(object sender, FormClosedEventArgs e)
        {
            eduForm.Close();
            this.Owner.Show();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            Experiencecontent.Clear();
            foreach (var experience_flp in flp_experience.Controls)
            {
                if (experience_flp is TextBox textbox_exp)
                {
                    if (!String.IsNullOrEmpty(textbox_exp.Text))
                    {
                        Experiencecontent.Add(textbox_exp.Text);
                    }
                    else
                    {
                        MessageBox.Show("Experience Fields can't be Null");
                        return;
                    }
                }
                else
                {
                    if (experience_flp is RichTextBox rtbtextbox_exp)
                    {
                        if (!String.IsNullOrEmpty(rtbtextbox_exp.Text))
                        {
                            Experiencecontent.Add(rtbtextbox_exp.Text);

                        }
                        else
                        {
                            MessageBox.Show("Experience Fields can't be Null");
                            return;
                        }
                    }
                }
            }
            form_got.Experienceandcommunityservice = Experiencecontent;

            eduForm.Show(this);
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

        private void textBox_Organizationname_Click(object sender, EventArgs e)
        {
            textBox_Organizationname.Text = null;
        }

        private void textBox_startdate_Click(object sender, EventArgs e)
        {
            textBox_startdate.Text = null;
        }

        private void textBox_enddate_Click(object sender, EventArgs e)
        {
            textBox_enddate.Text = null;
        }

        private void richTextBox_description_Click(object sender, EventArgs e)
        {
            richTextBox_description.Text = null;
        }
    }
}
