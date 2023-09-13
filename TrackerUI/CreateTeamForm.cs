using System;
using System.Windows.Forms;
using TrackerLibrary;


namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void TournamentNameValue_TextChanged(object sender, EventArgs e)
        {

        }


        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel(
                FirstNameValue.Text,
                LastNameValue.Text,
                EmailValue.Text,
                PhoneNumberValue.Text);



                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePerson(p);
                }

                FirstNameValue.Text = "";
                LastNameValue.Text = "";
                EmailValue.Text = "";
                PhoneNumberValue.Text = "";

            }
            else { MessageBox.Show("You need to fill in all the fields"); }
        }

        private bool ValidateForm()
        {
            if (FirstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (LastNameValue.Text.Length == 0)
            {
                return false;
            }
            if(EmailValue.Text.Length == 0){return false;}
            if(PhoneNumberValue.Text.Length == 0) {  return false; }

            return true;
        }
    }
}
