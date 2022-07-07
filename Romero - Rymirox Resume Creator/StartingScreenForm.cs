namespace Romero___Rymirox_Resume_Creator
{
    public partial class StartingScreenForm : Form
    {
        public StartingScreenForm()
        {
            InitializeComponent();
        }

        private void buttonSSF1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProgramScreenForm programScreenForm = new ProgramScreenForm();
            programScreenForm.ShowDialog();
        }

        private void buttonSSF2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSSF3_Click(object sender, EventArgs e)
        {

        }
    }
}