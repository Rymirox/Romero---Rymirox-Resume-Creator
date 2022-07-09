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
        //public class Program
        //{
        //    public void Main()
        //    {
        //        string jsonString =
        //            @" {
        //""firstName"": ""John Michael Vincent"",
        //""middleName"": ""Pucnos"",
        //""lastName"": ""Romero"",
        //""homeAddress"": ""Marilao, Bulacan"",
        //""contactNumber"": ""09280699382"",
        //""emailAddress"": ""jm.romero011@yahoo.com"",
        //""skill1"": ""Python Programming"",
        //""skill2"": ""C# Programming"",
        //""skill3"": ""SQL Programming"",
        //""skill4"": ""Logic  Skills"",
        //""skill5"": ""Communication Skills"",
        //""interest1"": ""Computer Games"",
        //""interest2"": ""Mathematics"",
        //""interest3"": ""Programming"",
        //""interest4"": ""Computer Based Software"",
        //""interest5"": ""Logic"",
        //""college"": ""Polytechnic University of the Philippines"",
        //""collegeCourse"": ""Bachelor of Science in Computer Engineering"",
        //""collegeYearGraduated"": ""Present - 2021"",
        //""seniorHighSchool"": ""Polytechnic University of the Philippines"",
        //""seniorHighSchoolStrand"": ""Science, Technology, Engineering, and Mathematics"",
        //""seniorHighSchoolYearGraduated"": ""September 2021"",
        //""juniorHighSchool"": ""Assemblywoman Felicita G. Bernardino Memorial Trade School"",
        //""juniorHighSchoolYearGraduated"": ""March 2019"",
        //""achievement1"": ""With High Honors (Weighted Average Grade of 96) - Senior High School"",
        //""achievement2"": ""Regional Level Robotics Competition - 3rd Place"",
        //""achievement3"": ""School Programming Quiz Bee (Grade 10) - 2nd Place"",
        //""achievement4"": ""Certificate of Completion: Graphic Design Foundations: Layout and Composition - LinkedIn Learning"",
        //""achievement5"": ""Cyber Security Foundation Professional Certificate - March 2021""
        //}
        //";
        //        infoResume? info = JsonSerializer.Deserialize<infoResume>(jsonString);
        //    }
        //}


       


        private void buttonPSF3_Click(object sender, EventArgs e)
        {
            this.Close();
            StartingScreenForm startingScreenForm = new StartingScreenForm();
            startingScreenForm.Show();
        }

        private void buttonPSF2_Click(object sender, EventArgs e)
        {
        //    string jsonString =
        //           @" {
        //""firstName"": ""John Michael Vincent"",
        //""middleName"": ""Pucnos"",
        //""lastName"": ""Romero"",
        //""homeAddress"": ""Marilao, Bulacan"",
        //""contactNumber"": ""09280699382"",
        //""emailAddress"": ""jm.romero011@yahoo.com"",
        //""skill1"": ""Python Programming"",
        //""skill2"": ""C# Programming"",
        //""skill3"": ""SQL Programming"",
        //""skill4"": ""Logic  Skills"",
        //""skill5"": ""Communication Skills"",
        //""interest1"": ""Computer Games"",
        //""interest2"": ""Mathematics"",
        //""interest3"": ""Programming"",
        //""interest4"": ""Computer Based Software"",
        //""interest5"": ""Logic"",
        //""college"": ""Polytechnic University of the Philippines"",
        //""collegeCourse"": ""Bachelor of Science in Computer Engineering"",
        //""collegeYearGraduated"": ""Present - 2021"",
        //""seniorHighSchool"": ""Polytechnic University of the Philippines"",
        //""seniorHighSchoolStrand"": ""Science, Technology, Engineering, and Mathematics"",
        //""seniorHighSchoolYearGraduated"": ""September 2021"",
        //""juniorHighSchool"": ""Assemblywoman Felicita G. Bernardino Memorial Trade School"",
        //""juniorHighSchoolYearGraduated"": ""March 2019"",
        //""achievement1"": ""With High Honors (Weighted Average Grade of 96) - Senior High School"",
        //""achievement2"": ""Regional Level Robotics Competition - 3rd Place"",
        //""achievement3"": ""School Programming Quiz Bee (Grade 10) - 2nd Place"",
        //""achievement4"": ""Certificate of Completion: Graphic Design Foundations: Layout and Composition - LinkedIn Learning"",
        //""achievement5"": ""Cyber Security Foundation Professional Certificate - March 2021""
        //}
        //";


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
                    string fileName1 = "bg for resume.png";
                    string fileName2 = "2x2.jpg";
                    string fileName3 = "emailicon.png";
                    string fileName4 = "contacticon.png";
                    string fileName5 = "addressicon.png";
                    
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    
                    //background for resume
                    XImage image = XImage.FromFile(fileName1);
                    gfx.DrawImage(image, 0, 0, 612, 792);
                    
                    //2x2 picture
                    XImage image2x2 = XImage.FromFile(fileName2);
                    gfx.DrawImage(image2x2, 50, 90, 150, 150);

                    //emailicon
                    XImage imageEmail = XImage.FromFile(fileName3);
                    gfx.DrawImage(imageEmail, 290, 144, 50, 50);

                    //contacticon
                    XImage imageContact = XImage.FromFile(fileName4);
                    gfx.DrawImage(imageContact, 290, 174, 50, 50);

                    //addressicon
                    XImage imageAddress = XImage.FromFile(fileName5);
                    gfx.DrawImage(imageAddress, 290, 204, 50, 50);


                    // Create a font
                    XFont normalfont = new XFont("Rockwell", 12, XFontStyle.Regular);
                    XFont specialfont = new XFont("Impact", 12, XFontStyle.Italic);
                    XFont boldfont = new XFont("Rockwell", 12, XFontStyle.Bold);
                    XFont otherfont  = new XFont("Rockwell", 18, XFontStyle.Bold);

                    //Draw rectangle
                    XPen pen = new XPen(XColors.Gold, Math.PI);
                    //gfx.DrawRectangle(pen, XBrushes.DarkOrange, 150, 80, 60, 60);
                    //gfx.DrawRectangle(pen, 10, 0, 100, 60);
                    gfx.DrawRectangle(pen, 305, 270, 1, 130);


                    // Draw the text
                    //BasicInformation
                    XRect rectFullName = new XRect(230, 90, 250, 200);
                    XRect rectRole = new XRect(300, 125, 250, 250);
                    XRect rectEmail = new XRect(342, 160, 250, 250);
                    XRect rectContact = new XRect(375, 192, 250, 250);
                    XRect rectAddress = new XRect(365, 222, 250, 200);
                    gfx.DrawString(info.firstName + " " + info.middleName + " " + info.lastName, otherfont, XBrushes.White, rectFullName, XStringFormats.TopLeft);
                    gfx.DrawString("COMPUTER ENGINEERING 1ST YEAR STUDENT", specialfont, XBrushes.White, rectRole, XStringFormats.TopLeft);
                    gfx.DrawString(info.emailAddress, normalfont, XBrushes.White, rectEmail, XStringFormats.TopLeft);
                    gfx.DrawString(info.contactNumber, normalfont, XBrushes.White, rectContact, XStringFormats.TopLeft);
                    gfx.DrawString(info.homeAddress, normalfont, XBrushes.White, rectAddress, XStringFormats.TopLeft);

                    //Skills
                    XRect rectSkillsTitle = new XRect(120, 270, 250, 250);                    
                    XRect rectSkill1 = new XRect(90, 300, 250, 250);
                    XRect rectSkill2 = new XRect(90, 320, 250, 250);
                    XRect rectSkill3 = new XRect(90, 340, 250, 250);
                    XRect rectSkill4 = new XRect(90, 360, 250, 250);
                    XRect rectSkill5 = new XRect(90, 380, 250, 250);

                    gfx.DrawString("SKILLS", otherfont, XBrushes.Gold, rectSkillsTitle, XStringFormats.TopLeft);
                    gfx.DrawString("•   " + info.skill1, normalfont, XBrushes.White, rectSkill1, XStringFormats.TopLeft);
                    gfx.DrawString("•   " + info.skill2, normalfont, XBrushes.White, rectSkill2, XStringFormats.TopLeft);
                    gfx.DrawString("•   " + info.skill3, normalfont, XBrushes.White, rectSkill3, XStringFormats.TopLeft);
                    gfx.DrawString("•   " + info.skill4, normalfont, XBrushes.White, rectSkill4, XStringFormats.TopLeft);
                    gfx.DrawString("•   " + info.skill5, normalfont, XBrushes.White, rectSkill5, XStringFormats.TopLeft);

                    //Interests
                    XRect rectInterestsTitle = new XRect(415, 270, 250, 250);
                    XRect rectInterest1 = new XRect(395, 300, 250, 250);
                    XRect rectInterest2 = new XRect(395, 320, 250, 250);
                    XRect rectInterest3 = new XRect(395, 340, 250, 250);
                    XRect rectInterest4 = new XRect(395, 360, 250, 250);
                    XRect rectInterest5 = new XRect(395, 380, 250, 250);

                    gfx.DrawString("INTERESTS", otherfont, XBrushes.Gold, rectInterestsTitle, XStringFormats.TopLeft);
                    gfx.DrawString("•   " + info.interest1, normalfont, XBrushes.White, rectInterest1, XStringFormats.TopLeft);
                    gfx.DrawString("•   " + info.interest2, normalfont, XBrushes.White, rectInterest2, XStringFormats.TopLeft);
                    gfx.DrawString("•   " + info.interest3, normalfont, XBrushes.White, rectInterest3, XStringFormats.TopLeft);
                    gfx.DrawString("•   " + info.interest4, normalfont, XBrushes.White, rectInterest4 , XStringFormats.TopLeft);
                    gfx.DrawString("•   " + info.interest5 , normalfont, XBrushes.White, rectInterest5 , XStringFormats.TopLeft);

                    //EducationalBackground
                    //College
                    XRect rectEducBackTitle = new XRect(170, 420, 250, 250);
                    XRect rectCollege = new XRect(280, 450, 250, 250);
                    XRect rectCourse = new XRect(180, 465, 250, 250);
                    XRect rectCollegeName = new XRect(195, 480, 250, 250);
                    XRect rectYearGrad = new XRect(265, 495, 250, 250);

                    gfx.DrawString("EDUCATIONAL BACKGROUND", otherfont, XBrushes.Gold, rectEducBackTitle, XStringFormats.TopLeft);
                    gfx.DrawString("College", boldfont, XBrushes.White, rectCollege, XStringFormats.TopLeft);
                    gfx.DrawString(info.collegeCourse, normalfont, XBrushes.White, rectCourse , XStringFormats.TopLeft); 
                    gfx.DrawString(info.college, normalfont, XBrushes.White, rectCollegeName, XStringFormats.TopLeft);  
                    gfx.DrawString(info.collegeYearGraduated, normalfont, XBrushes.White, rectYearGrad , XStringFormats.TopLeft);

                    //SeniorHighSchool
                    XRect rectSHS = new XRect(250, 525, 250, 250);
                    XRect rectStrand = new XRect(165, 540, 250, 250);
                    XRect rectSHSName = new XRect(195, 555, 250, 250);
                    XRect rectSHSYrGrad = new XRect(260, 570, 250, 250);

                    gfx.DrawString("Senior High School", boldfont, XBrushes.White, rectSHS, XStringFormats.TopLeft);
                    gfx.DrawString(info.seniorHighSchoolStrand, normalfont, XBrushes.White, rectStrand, XStringFormats.TopLeft);
                    gfx.DrawString(info.seniorHighSchool, normalfont, XBrushes.White, rectSHSName, XStringFormats.TopLeft);
                    gfx.DrawString(info.seniorHighSchoolYearGraduated, normalfont, XBrushes.White, rectSHSYrGrad, XStringFormats.TopLeft);

                    //Skills
                    XRect rectAchievements = new XRect(230, 600, 250, 250);
                    XRect rectAchievement1 = new XRect(90, 630, 250, 250);
                    XRect rectAchievement2 = new XRect(90, 645, 250, 250);
                    XRect rectAchievement3 = new XRect(90, 660, 250, 250);
                    XRect rectAchievement4 = new XRect(90, 675, 250, 250);
                    XRect rectAchievement5 = new XRect(90, 690, 250, 250);

                    gfx.DrawString("ACHIEVEMENTS", otherfont, XBrushes.Gold, rectAchievements, XStringFormats.TopLeft);
                    gfx.DrawString("•   " + info.achievement1, normalfont, XBrushes.White, rectAchievement1, XStringFormats.TopLeft);
                    gfx.DrawString("•   " + info.achievement2, normalfont, XBrushes.White, rectAchievement2, XStringFormats.TopLeft);
                    gfx.DrawString("•   " + info.achievement3, normalfont, XBrushes.White, rectAchievement3, XStringFormats.TopLeft);
                    gfx.DrawString("•   " + info.achievement4, normalfont, XBrushes.White, rectAchievement4, XStringFormats.TopLeft);
                    gfx.DrawString("•   " + info.achievement5, normalfont, XBrushes.White, rectAchievement5, XStringFormats.TopLeft);




                    // Save the document...
                    document.Save(saveFileDialog.FileName);
                }
            }
        }
    }
}
