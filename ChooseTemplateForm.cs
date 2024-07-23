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
    public partial class Choose_Template_Form : Form
    {
        public InputForm input;
        public Choose_Template_Form()
        {
            InitializeComponent();
        }
        private void pictureBox_Template1_Click(object sender, EventArgs e)
        {
            input = new InputForm("Template1");
            input.Show(this);
            this.Hide();
        }

        private void pictureBox_Template2_Click(object sender, EventArgs e)
        {
            input = new InputForm("Template2");
            input.Show(this);
            this.Hide();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you want to Proceed!!", "All data will be lost!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }

            }
        }

        private void Choose_Template_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (input != null)
            {
                input.Close();
            }
        }
    }
}
