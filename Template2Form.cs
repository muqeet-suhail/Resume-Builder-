using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.Drawing.Imaging;
using Microsoft.Win32.SafeHandles;

namespace Assignment_2
{
    public partial class Template2Form : Form
    {
        public Choose_Template_Form Form;
        public int count_of_experience = 2;
        public int count_of_education_title = 2;
        public int count_of_skill_set = 2;
        private int MoveFactor = 1;
        public int count_of_image_sections = 0;
        public Template2Form()
        {
            InitializeComponent();
        }
        public void ExportToPdf()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Output.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string fileOutputPath = sfd.FileName;
                try
                {
                    if (File.Exists(fileOutputPath))
                    {
                        File.Delete(fileOutputPath);
                    }
                    using (FileStream Stream = new FileStream(fileOutputPath, FileMode.Create))
                    {
                        float leftMargin = 1;
                        float rightMargin = 1;
                        float topMargin = 1*18;
                        float bottomMargin = 1;
                        Document pdfDoc = new Document(PageSize.A4, leftMargin, rightMargin, topMargin, bottomMargin);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Stream);
                        pdfDoc.Open();
                        WriteImagesToPdf(pdfDoc);
                        pdfDoc.Close();
                        Stream.Close();
                        FileOpenParallel(fileOutputPath);
                        Application.Restart();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void WriteImagesToPdf(Document pdf)
        {
            int panelHeight = Template_panel1.Height;
            int pageHeight = 1123; // A4 page height in pixels
            int numPages = (int)Math.Ceiling((double)panelHeight / pageHeight);
            int minusfactor = 0;
            int minusfactorsectioncapturedheight = 52;
            // Capture the entire panel as an image
            Bitmap panelImage = CapturePanel(Template_panel1);

            for (int i = 0; i < numPages; i++)
            {
                if (i > 0)
                {
                    pdf.NewPage();
                    minusfactor = 52;  
                }


                int startY = (i * pageHeight) - minusfactor;
                int height = Math.Min(pageHeight, panelHeight - startY);

                if (i == numPages - 1)
                {
                    minusfactorsectioncapturedheight = 0;
                }
                // Crop the section of the panel image for the current page
                Bitmap sectionBitmap = CropBitmap(panelImage, new System.Drawing.Rectangle(0, startY, panelImage.Width, height - minusfactorsectioncapturedheight));

                // Add the cropped section to the PDF
                AddImageToPdf(pdf, sectionBitmap);
            }
        }

        private Bitmap CropBitmap(Bitmap bitmap, System.Drawing.Rectangle cropArea)
        {
            Bitmap croppedBitmap = bitmap.Clone(cropArea, bitmap.PixelFormat);
            return croppedBitmap;
        }

        private void AddImageToPdf(Document pdf, Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                ms.Position = 0;
                iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(ms);

                // Scale the image to fit the page
                pdfImage.ScaleToFit(pdf.PageSize.Width - pdf.LeftMargin - pdf.RightMargin, pdf.PageSize.Height - pdf.TopMargin + 0.5f);

                pdf.Add(pdfImage);
                count_of_image_sections = 0;
            }
        }

        private Bitmap CapturePanel(Panel panel)
        {
            float scaleFactor = 1.0f; // Adjust this to increase resolution
            Bitmap bmp = new Bitmap((int)(panel.Width * scaleFactor), (int)(panel.Height * scaleFactor));
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.ScaleTransform(scaleFactor, scaleFactor);
                panel.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, panel.Width, panel.Height));
            }
            return bmp;
        }

        private void FileOpenParallel(string path)
        {
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToPdf();
        }

        private void Template1Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
        public void ExportContent(string username, string AboutUser, string email, string number, string address, List<string> Experienceandcommunityservice, List<string> Educationandcertification, List<string> Skills)
        {
            label_Name.Text = username;
            textbox_AboutText.Text = AboutUser;
            label_Email.Text = email;
            if (String.IsNullOrEmpty(number))
            {
                label_Number.Hide();
            }
            else
            {
                label_Number.Text = number;
            }
            label_Location.Text = address;
            for (int i = 0; i < Experienceandcommunityservice.Count; i = i + 4)
            {
                if (i == 0)
                {
                    if (i + 3 == Experienceandcommunityservice.Count)
                    {
                        AddExperience("1. " + Experienceandcommunityservice[i], "From " + Experienceandcommunityservice[i + 1] + " To " + Experienceandcommunityservice[i + 2], Experienceandcommunityservice[i + 3]);
                        break;
                    }
                    else
                    {
                        AddExperience("1. " + Experienceandcommunityservice[i], "From " + Experienceandcommunityservice[i + 1] + " To " + Experienceandcommunityservice[i + 2], Experienceandcommunityservice[i + 3]);
                    }
                }
                else
                {
                    if (i + 3 == Experienceandcommunityservice.Count)
                    {
                        AddNewExperience(Experienceandcommunityservice[i], "From " + Experienceandcommunityservice[i + 1] + " To " + Experienceandcommunityservice[i + 2], Experienceandcommunityservice[i + 3]);
                        break;
                    }
                    else
                    {
                        AddNewExperience(Experienceandcommunityservice[i], "From " + Experienceandcommunityservice[i + 1] + "To" + Experienceandcommunityservice[i + 2], Experienceandcommunityservice[i + 3]);
                    }
                }
            }

            for (int i = 0; i < Educationandcertification.Count; i = i + 4)
            {
                if (i == 0)
                {
                    if (i + 3 == Educationandcertification.Count)
                    {
                        AddEducation("1. " + Educationandcertification[i] + "                    " + Educationandcertification[i + 1], "From " + Educationandcertification[i + 2] + " To " + Educationandcertification[i + 3]);
                        break;
                    }
                    else
                    {
                        AddEducation("1. " + Educationandcertification[i] + "                    " + Educationandcertification[i + 1], "From " + Educationandcertification[i + 2] + " To " + Educationandcertification[i + 3]);
                    }
                }
                else
                {
                    if (i + 3 == Educationandcertification.Count)
                    {
                        AddNewEducation(Educationandcertification[i] + "                    " + Educationandcertification[i + 1], "From " + Educationandcertification[i + 2] + " To " + Educationandcertification[i + 3]);
                        break;
                    }
                    else
                    {
                        AddNewEducation(Educationandcertification[i] + "                    " + Educationandcertification[i + 1], "From " + Educationandcertification[i + 2] + " To " + Educationandcertification[i + 3]);

                    }
                }
            }

            for (int i = 0; i < Skills.Count; i = i + 1)
            {
                if (i == 0)
                {
                    AddSkills("1." + Skills[i]);
                }
                else
                {
                    AddNewSkills(Skills[i]);
                }
            }
            this.Show();
            this.ExportToPdf();
        }

        private void AddExperience(string organizationname, string experiencedate, string experiencedescription)
        {
            label_CompanyName1.Text = organizationname;
            label_ExperienceDate1.Text = experiencedate;
            rtb_ExperienceDescription.Text = experiencedescription;
        }
        private void AddNewExperience(string organizationname, string experiencedate, string experiencedescription)
        {
            Label label_company = new Label();
            label_company.Text = (count_of_experience) + ". " + organizationname;
            label_company.Name = "label_CompanyName " + count_of_experience;
            Label label_date = new Label();
            label_date.Text = experiencedate;
            label_date.Name = "labelExpDate " + count_of_experience;
            RichTextBox description = new RichTextBox();
            description.Text = experiencedescription;
            description.Name = "rtb_JobDescription " + count_of_experience;
            CopyLabelProperties(label_CompanyName1, label_company);
            CopyLabelProperties(label_ExperienceDate1, label_date);
            CopyRichTextBoxProperties(rtb_ExperienceDescription, description);
            flp_Experience.Controls.Add(label_company);
            flp_Experience.Controls.Add(label_date);
            flp_Experience.Controls.Add(description);

            while (flp_Experience.Bounds.IntersectsWith(label_Education.Bounds))
            {
                System.Drawing.Point newPointofeducationlabel = new System.Drawing.Point(label_Education.Location.X, label_Education.Location.Y + MoveFactor);
                label_Education.Location = newPointofeducationlabel;
                while (label_Education.Bounds.IntersectsWith(pictureBox_LineUnderEducation.Bounds))
                {
                    System.Drawing.Point PointofEducationLine = new System.Drawing.Point(pictureBox_LineUnderEducation.Location.X, pictureBox_LineUnderEducation.Location.Y + MoveFactor);
                    pictureBox_LineUnderEducation.Location = PointofEducationLine;
                    System.Drawing.Point PointofflpEducation = new System.Drawing.Point(flp_EducationContent.Location.X, flp_EducationContent.Location.Y + MoveFactor);
                    flp_EducationContent.Location = PointofflpEducation;

                    while (flp_EducationContent.Bounds.IntersectsWith(label_Skills.Bounds))
                    {
                        System.Drawing.Point newPointofskilllabel = new System.Drawing.Point(label_Skills.Location.X, label_Skills.Location.Y + MoveFactor);
                        label_Skills.Location = newPointofskilllabel;
                        while (label_Skills.Bounds.IntersectsWith(pictureBox_LineUnderSkills.Bounds))
                        {
                            System.Drawing.Point PointofSkillLine = new System.Drawing.Point(pictureBox_LineUnderSkills.Location.X, pictureBox_LineUnderSkills.Location.Y + MoveFactor);
                            pictureBox_LineUnderSkills.Location = PointofSkillLine;
                            System.Drawing.Point Pointofflpskillset = new System.Drawing.Point(flp_skillset.Location.X, flp_skillset.Location.Y + MoveFactor);
                            flp_skillset.Location = Pointofflpskillset;
                        }
                    }
                }
            }

            count_of_experience++;
        }
        private void AddEducation(string educationtitle, string educationdate)
        {
            label_EducationTitleandUni.Text = educationtitle;
            label_Education_Date.Text = educationdate;
        }
        private void AddNewEducation(string educationtitle, string educationdate)
        {
            Label label_educationdate = new Label();
            label_educationdate.Text = educationdate;
            Label label_educationtitle = new Label();
            label_educationtitle.Text = (count_of_education_title) + ". " + educationtitle;
            CopyLabelProperties(label_Education_Date, label_educationdate);
            CopyLabelProperties(label_EducationTitleandUni, label_educationtitle);

            flp_EducationContent.Controls.Add(label_educationtitle);
            flp_EducationContent.Controls.Add(label_educationdate);

            while (flp_EducationContent.Bounds.IntersectsWith(label_Skills.Bounds))
            {
                System.Drawing.Point newPointofskilllabel = new System.Drawing.Point(label_Skills.Location.X, label_Skills.Location.Y + MoveFactor);
                label_Skills.Location = newPointofskilllabel;
                while (label_Skills.Bounds.IntersectsWith(pictureBox_LineUnderSkills.Bounds))
                {
                    System.Drawing.Point PointofSkillLine = new System.Drawing.Point(pictureBox_LineUnderSkills.Location.X, pictureBox_LineUnderSkills.Location.Y + MoveFactor);
                    pictureBox_LineUnderSkills.Location = PointofSkillLine;
                    System.Drawing.Point Pointofflpskillset = new System.Drawing.Point(flp_skillset.Location.X, flp_skillset.Location.Y + MoveFactor);
                    flp_skillset.Location = Pointofflpskillset;
                }
            }

            while (!flp_Experience.Bounds.IntersectsWith(label_Education.Bounds))
            {
                System.Drawing.Point newPointofeducationlabel = new System.Drawing.Point(label_Education.Location.X, label_Education.Location.Y - MoveFactor);
                label_Education.Location = newPointofeducationlabel;
            }
            System.Drawing.Point newPointofeducationlabel2 = new System.Drawing.Point(label_Education.Location.X, label_Education.Location.Y + MoveFactor);
            label_Education.Location = newPointofeducationlabel2;


            count_of_education_title++;
        }
        public void AddSkills(string skilltext)
        {
            label_skillset.Text = skilltext;
        }
        public void AddNewSkills(string skilltext)
        {
            Label skillset = new Label();
            skillset.Text = count_of_skill_set.ToString() + ". " + skilltext;
            CopyLabelProperties(label_skillset, skillset);
            flp_skillset.Controls.Add(skillset);

            while (!flp_Experience.Bounds.IntersectsWith(label_Education.Bounds))
            {
                System.Drawing.Point newPointofeducationlabel = new System.Drawing.Point(label_Education.Location.X, label_Education.Location.Y - MoveFactor);
                label_Education.Location = newPointofeducationlabel;
            }
            System.Drawing.Point newPointofeducationlabel2 = new System.Drawing.Point(label_Education.Location.X, label_Education.Location.Y + MoveFactor);
            label_Education.Location = newPointofeducationlabel2;

            while (!flp_EducationContent.Bounds.IntersectsWith(label_Skills.Bounds))
            {
                System.Drawing.Point newPointofskillslabel1 = new System.Drawing.Point(label_Skills.Location.X, label_Skills.Location.Y - MoveFactor);
                label_Skills.Location = newPointofskillslabel1;
            }
            System.Drawing.Point newPointofskillslabel2 = new System.Drawing.Point(label_Skills.Location.X, label_Skills.Location.Y + MoveFactor);
            label_Skills.Location = newPointofskillslabel2;
            count_of_skill_set++;
        }
        private void CopyLabelProperties(Label source, Label target)
        {
            target.Font = source.Font;
            target.ForeColor = source.ForeColor;
            target.BackColor = source.BackColor;
            target.Size = source.Size;
            target.Location = source.Location;
            target.Padding = source.Padding;
            target.Margin = source.Margin;
            target.AutoSize = source.AutoSize;
            target.TextAlign = source.TextAlign;
            target.BorderStyle = source.BorderStyle;
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

       
    }
}
