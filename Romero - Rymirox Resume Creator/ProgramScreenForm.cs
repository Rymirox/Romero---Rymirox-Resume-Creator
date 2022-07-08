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
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Romero___Rymirox_Resume_Creator
{
    public partial class ProgramScreenForm : Form
    {
        //private readonly string _path = @"C:\\Users\\Romero\\source\\repos\\Romero - Rymirox Resume Creator\\Rymirox Resume Creator.json";

        public ProgramScreenForm()
        {

            InitializeComponent();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


        }





        public class infoResume
    {
            //basicInformation
            public string firstName { get; set; }
            public string middleName { get; set; }
            public string lastName { get; set; }
            public string homeAddress { get; set; }
            public string contactNumber { get; set; }
            public string emailAddress { get; set; }
            
            //skills
            public string skill1 { get; set; }
            public string skill2 { get; set; }
            public string skill3 { get; set; }
            public string skill4 { get; set; }
            public string skill5 { get; set; }

            //interests
            public string interest1 { get; set; }
            public string interest2 { get; set; }
            public string interest3 { get; set; }
            public string interest4 { get; set; }
            public string interest5 { get; set; }

            //educ 
            public string college { get; set; }
            public string collegeCourse { get; set; }
            public string collegeYearGraduated { get; set; }
            public string seniorHighSchool { get; set; }
            public string seniorHighSchoolStrand { get; set; }
            public string seniorHighSchoolYearGraduated { get; set; }
            public string juniorHighSchool { get; set; }
            public string juniorHighSchoolYearGraduated { get; set; }

            //achievements
            public string achievement1 { get; set; }
            public string achievement2 { get; set; }
            public string achievement3 { get; set; }
            public string achievement4 { get; set; }
            public string achievement5 { get; set; }


    }
        public class Program
        {
            public void Main()
            {
                string jsonString =
                    @" {
        ""firstName"": ""John Michael Vincent"",
        ""middleName"": ""Pucnos"",
        ""lastName"": ""Romero"",
        ""homeAddress"": ""Marilao, Bulacan"",
        ""contactNumber"": ""09280699382"",
        ""emailAddress"": ""jm.romero011@yahoo.com"",
        ""skill1"": ""Python Programming"",
        ""skill2"": ""C# Programming"",
        ""skill3"": ""SQL Programming"",
        ""skill4"": ""Logic  Skills"",
        ""skill5"": ""Communication Skills"",
        ""interest1"": ""Computer Games"",
        ""interest2"": ""Mathematics"",
        ""interest3"": ""Programming"",
        ""interest4"": ""Computer Based Software"",
        ""interest5"": ""Logic"",
        ""college"": ""Polytechnic University of the Philippines"",
        ""collegeCourse"": ""Bachelor of Science in Computer Engineering"",
        ""collegeYearGraduated"": ""Present - 2021"",
        ""seniorHighSchool"": ""Polytechnic University of the Philippines"",
        ""seniorHighSchoolStrand"": ""Science, Technology, Engineering, and Mathematics"",
        ""seniorHighSchoolYearGraduated"": ""September 2021"",
        ""juniorHighSchool"": ""Assemblywoman Felicita G. Bernardino Memorial Trade School"",
        ""juniorHighSchoolYearGraduated"": ""March 2019"",
        ""achievement1"": ""With High Honors (Weighted Average Grade of 96) - Senior High School"",
        ""achievement2"": ""Regional Level Robotics Competition - 3rd Place"",
        ""achievement3"": ""School Programming Quiz Bee (Grade 10) - 2nd Place"",
        ""achievement4"": ""Certificate of Completion: Graphic Design Foundations: Layout and Composition - LinkedIn Learning"",
        ""achievement5"": ""Cyber Security Foundation Professional Certificate - March 2021""
        }
        ";
                infoResume? info = JsonSerializer.Deserialize<infoResume>(jsonString);
            }
        }


       


        private void buttonPSF3_Click(object sender, EventArgs e)
        {
            this.Close();
            StartingScreenForm startingScreenForm = new StartingScreenForm();
            startingScreenForm.Show();
        }

        private void buttonPSF2_Click(object sender, EventArgs e)
        {
            string jsonString =
                   @" {
        ""firstName"": ""John Michael Vincent"",
        ""middleName"": ""Pucnos"",
        ""lastName"": ""Romero"",
        ""homeAddress"": ""Marilao, Bulacan"",
        ""contactNumber"": ""09280699382"",
        ""emailAddress"": ""jm.romero011@yahoo.com"",
        ""skill1"": ""Python Programming"",
        ""skill2"": ""C# Programming"",
        ""skill3"": ""SQL Programming"",
        ""skill4"": ""Logic  Skills"",
        ""skill5"": ""Communication Skills"",
        ""interest1"": ""Computer Games"",
        ""interest2"": ""Mathematics"",
        ""interest3"": ""Programming"",
        ""interest4"": ""Computer Based Software"",
        ""interest5"": ""Logic"",
        ""college"": ""Polytechnic University of the Philippines"",
        ""collegeCourse"": ""Bachelor of Science in Computer Engineering"",
        ""collegeYearGraduated"": ""Present - 2021"",
        ""seniorHighSchool"": ""Polytechnic University of the Philippines"",
        ""seniorHighSchoolStrand"": ""Science, Technology, Engineering, and Mathematics"",
        ""seniorHighSchoolYearGraduated"": ""September 2021"",
        ""juniorHighSchool"": ""Assemblywoman Felicita G. Bernardino Memorial Trade School"",
        ""juniorHighSchoolYearGraduated"": ""March 2019"",
        ""achievement1"": ""With High Honors (Weighted Average Grade of 96) - Senior High School"",
        ""achievement2"": ""Regional Level Robotics Competition - 3rd Place"",
        ""achievement3"": ""School Programming Quiz Bee (Grade 10) - 2nd Place"",
        ""achievement4"": ""Certificate of Completion: Graphic Design Foundations: Layout and Composition - LinkedIn Learning"",
        ""achievement5"": ""Cyber Security Foundation Professional Certificate - March 2021""
        }
        ";


            try
            {

                string filename = "Rymirox Resume Creator.json";
                string jsonstring = File.ReadAllText(filename);
                infoResume info = JsonSerializer.Deserialize<infoResume>(jsonstring)!;

                //Convert to string variable
                //basicInformation
                string FirstName = info.firstName;
                string MiddleName = info.middleName;
                string LastName = info.lastName;
                string Address = info.homeAddress;
                string EmailAddress = info.emailAddress;
                string ContactNumber = info.contactNumber;

                //skills
                string Skill1 = info.skill1;
                string Skill2 = info.skill2;
                string Skill3 = info.skill3;
                string Skill4 = info.skill4;
                string Skill5 = info.skill5;


                //Education
                string College = info.college;
                string CollegeCourse = info.collegeCourse;
                string collegeYearGraduated = info.collegeYearGraduated;
                string seniorHighSchool = info.seniorHighSchool;
                string seinorHighSchoolStrand = info.seniorHighSchoolStrand;
                string seniorHighYearGraduated = info.seniorHighSchoolYearGraduated;
                string juniorHighSchool = info.juniorHighSchool;
                string juniorHighSchoolYearGraduated = info.juniorHighSchoolYearGraduated;

                //achievements
                string achievement1 = info.achievement1;
                string achievement2 = info.achievement2;
                string achievement3 = info.achievement3;
                string achievement4 = info.achievement4;
                string achievement5 = info.achievement5;

                //Display the info :>
                //BasicInformation
                txtbxFirstName.Text = info.firstName;
                txtbxMiddleName.Text = info.middleName;
                txtbxLastName.Text = info.lastName;
                txtbxAddress.Text = info.homeAddress;
                txtbxContact.Text = info.contactNumber;
                txtbxEmail.Text = info.emailAddress;

                //Skills
                txtBxSkill1.Text = info.skill1;
                txtBxSkill2.Text = info.skill2;
                txtBxSkill3.Text = info.skill3;
                txtBxSkill4.Text = info.skill4;
                txtBxSkill5.Text = info.skill5;

                //Interests
                txtBxInterest1.Text = info.interest1;
                txtBxInterest2.Text = info.interest2;
                txtBxInterest3.Text = info.interest3;
                txtBxInterest4.Text = info.interest4;
                txtBxInterest5.Text = info.interest5;

                //EducationBackground
                txtBxCollege.Text = info.college;
                txtBxCourse.Text = info.collegeCourse;
                txtBxYrGraduated.Text = info.collegeYearGraduated;
                txtBxSHS.Text = info.seniorHighSchool;
                txtBxStrand.Text = info.seniorHighSchoolStrand;
                txtBxSHSYrGraduated.Text = info.seniorHighSchoolYearGraduated;

                //Achievements
                txtBxAchievement1.Text = info.achievement1;
                txtBxAchievement2.Text = info.achievement2;
                txtBxAchievement3.Text = info.achievement3;
                txtBxAchievement4.Text = info.achievement4;
                txtBxAchievement5.Text = info.achievement5;

            }
            catch (Exception)
            {
                //ignored
                //throw;
            }
        }

        private void buttonPSF1_Click(object sender, EventArgs e)
        {
            string lastName = textBoxPSF1.Text;
            string firstName = textBoxPSF2.Text;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {

                saveFileDialog.InitialDirectory = @"C:\\Users\\Romero\\source\\repos\\Romero - Rymirox Resume Creator\\Rymirox Resume Creator.json";
                saveFileDialog.FileName = lastName + ", " + firstName + " - Resume" + ".pdf";
                saveFileDialog.Filter = "PDF|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Create a new PDF document
                    PdfDocument document = new PdfDocument();
                    document.Info.Title = "Rymirox Resume Creator";

                    // Create an empty page
                    PdfPage page = document.AddPage();

                    // Get an XGraphics object for drawing
                    XGraphics gfx = XGraphics.FromPdfPage(page);

                 
                    

                    // Create a font
                    XFont normalfont = new XFont("Arial", 12, XFontStyle.Regular);
                    XFont boldfont = new XFont("Arial", 15, XFontStyle.Bold);
                    XFont otherfont  = new XFont("Rockwell", 18, XFontStyle.Regular);

                    //Draw rectangle
                    XPen pen = new XPen(XColors.Navy, Math.PI);
                    //gfx.DrawRectangle(pen, XBrushes.DarkOrange, 150, 80, 60, 60);
                    //gfx.DrawRectangle(pen, 10, 0, 100, 60);

                    //Add margin


                    // Draw the text
                    XRect rect = new XRect(210, 70, 250, 200);
                    gfx.DrawString(txtbxFirstName.Text, normalfont, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString("JOHN MICHAEL VINCENT P. ROMERO", otherfont, XBrushes.Black, rect, XStringFormats.TopLeft);

                    // Save the document...
                    document.Save(saveFileDialog.FileName);
                }
            }
        }
    }
}
