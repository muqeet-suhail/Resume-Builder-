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
    public partial class Skillset : Form
    {
        public InputForm s_input;
        private int count_of_skill_details = 2;
        private int MoveFactor = 1;
        public List<string> skillslist;
        public Skillset(InputForm s_inputform)
        { 
            InitializeComponent();
            this.s_input= s_inputform;
            skillslist = new List<string>();
        }

        private void button_skilladd_Click(object sender, EventArgs e)
        {
            TextBox textbox_skills = new TextBox();
            textbox_skills.Text = "Enter Skills / Hobbies Name";
            textbox_skills.Name = "textbox_skillset " + count_of_skill_details;
            CopyTextBoxProperties(textBox_skillset, textbox_skills);
            flp_skills.Controls.Add(textbox_skills);
            while (flp_skills.Bounds.IntersectsWith(button_back.Bounds))
            {
                System.Drawing.Point point_of_back_btn = new System.Drawing.Point(button_back.Location.X, button_back.Location.Y + MoveFactor);
                System.Drawing.Point point_of_save_btn = new System.Drawing.Point(button_export_to_pdf.Location.X, button_export_to_pdf.Location.Y + MoveFactor);
                button_back.Location = point_of_back_btn;
                button_export_to_pdf.Location = point_of_save_btn;
            }
            count_of_skill_details++;
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

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void Skillset_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
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
        private void button_export_to_pdf_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Export!!!", "All data will be required to input again in case of revision!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                skillslist.Clear();
                foreach (var skills_flp in flp_skills.Controls)
                {
                    if (skills_flp is TextBox textboxskill)
                    {
                        if (!String.IsNullOrEmpty(textboxskill.Text))
                        {
                            skillslist.Add(textboxskill.Text);
                        }
                        else
                        {
                            MessageBox.Show("Skill Fields can't be Null");
                            return;
                        }
                       
                    }
                }
                s_input.Skills = skillslist;

                if(s_input.template_to_use=="Template1")
                {
                    Template1Form TemplatetoUse1 = new Template1Form();
                    TemplatetoUse1.Owner = this;
                    TemplatetoUse1.ExportContent(s_input.username, s_input.AboutUser,s_input.email, s_input.number,s_input.address,s_input.Experienceandcommunityservice, s_input.Educationandcertification, s_input.Skills);
                }
                else
                {
                    if (s_input.template_to_use=="Template2")
                    {
                        Template2Form TemplatetoUse2 = new Template2Form();
                        TemplatetoUse2.Owner = this;
                        TemplatetoUse2.ExportContent(s_input.username, s_input.AboutUser, s_input.email, s_input.number, s_input.address, s_input.Experienceandcommunityservice, s_input.Educationandcertification, s_input.Skills);
                    }
                }
            }

        }

        private void textBox_skillset_Click(object sender, EventArgs e)
        {
            textBox_skillset.Text = null;
        }
    }
}
