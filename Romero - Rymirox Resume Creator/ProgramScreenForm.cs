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

namespace Romero___Rymirox_Resume_Creator
{
    public partial class ProgramScreenForm : Form
    {
        private readonly string _path = @"C:\\Users\\Romero\\source\\repos\\Romero - Rymirox Resume Creator\\Rymirox Resume Creator.json";
       
        public ProgramScreenForm()
        {
            InitializeComponent();
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
            }
            catch (Exception)
            {
                //ignored
                //throw;
            }
        }
    }
}
