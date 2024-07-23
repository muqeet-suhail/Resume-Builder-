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
    public partial class InputForm : Form
    {
        public InputForm form_to_input;
        public string template_to_use;
        public Experience expform;
        public string username;
        public string AboutUser;
        public string email;
        public string number;
        public string address;
        public List<string> Experienceandcommunityservice;
        public List<string> Educationandcertification;
        public List<string> Skills;
        public int max_text_Length_in_about_section = 65;
        public int number_of_spaces_between_education_title_and_uni = 20;
        public InputForm(string template)
        {
            InitializeComponent();
            if (template != null)
            {
                template_to_use = template;
            }
            else
            {
                MessageBox.Show("Template Can't be Null");
                return;
            }
            form_to_input = this;
            Experienceandcommunityservice = new List<string>();
            Educationandcertification = new List<string>();
            Skills = new List<string>();
            expform = new Experience(form_to_input);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_name.Text) && !String.IsNullOrEmpty(textBox_email.Text) && !String.IsNullOrEmpty(textBox_address.Text) && !String.IsNullOrEmpty(richTextBox_About.Text))
            {
                username = textBox_name.Text;
                number = textBox_number.Text;
                if (number == "Enter number (optional)")
                {
                    number = null;
                }
                email = textBox_email.Text;
                address = textBox_address.Text;
                AboutUser = richTextBox_About.Text;
            }
            else
            {
                MessageBox.Show("User Fields can't be Null");
                return;
            }
            
            expform.Show(this);
            this.Hide();
        }

        private void InputForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            expform.Close();
            this.Owner.Show();
        }

        private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void textBox_name_Click(object sender, EventArgs e)
        {
            textBox_name.Text = null;
        }

        private void textBox_number_Click(object sender, EventArgs e)
        {
            textBox_number.Text = null;
        }

        private void textBox_email_Click(object sender, EventArgs e)
        {
            textBox_email.Text = null;
        }

        private void textBox_address_Click(object sender, EventArgs e)
        {
            textBox_address.Text = null;
        }

        private void richTextBox_About_Click(object sender, EventArgs e)
        {
            richTextBox_About.Text = null;
        }
    }
}
