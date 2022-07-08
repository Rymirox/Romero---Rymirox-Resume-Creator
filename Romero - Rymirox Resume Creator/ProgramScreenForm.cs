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
using Newtonsoft.Json;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Text.Json;


namespace Romero___Rymirox_Resume_Creator
{
    public partial class ProgramScreenForm : Form
    {
        private readonly string _path = @"C:\\Users\\Romero\\source\\repos\\Romero - Rymirox Resume Creator\\Rymirox Resume Creator.json";

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
            public string skill1 { get; set; }

        }


        private void buttonPSF3_Click(object sender, EventArgs e)
        {
            this.Close();
            StartingScreenForm startingScreenForm = new StartingScreenForm();
            startingScreenForm.Show();
        }

        private void buttonPSF2_Click(object sender, EventArgs e)
        {
            

            try
            {
                string jsonFromFile;
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }

                textBoxPSF3.Text = jsonFromFile;

                var ResumeInfo = JsonConvert.DeserializeObject<infoResume>(jsonFromFile);
                


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

                    // Draw the text
                    gfx.DrawString(textBoxPSF3.Text, normalfont, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.TopLeft);

                    // Save the document...
                    document.Save(saveFileDialog.FileName);
                }
            }
        }
    }
}
