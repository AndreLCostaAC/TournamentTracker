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

        private void TeamMembersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.Name = FirstNameValue.Text;
                p.LastName = LastNameValue.Text;
                p.PhoneNumber = PhoneNumberLabel.Text;
                p.EmailAddress = EmailLabel.Text;

                //GlobalConfig.Connections.CreatePerson(p);
            }
            else { MessageBox.Show("You need to fill in all the fields"); }
        }

        private bool ValidateForm()
        {
            //if (FirstNameValue.Text.Length == 0)
            //{
            //    return false;
            //}
            //if (LastNameValue.Text.Length == 0)
            //{
            //    return false;
            //}
            if (!string.IsNullOrEmpty(FirstNameValue.Text)) { return false; }
            if (!string.IsNullOrEmpty(LastNameValue.Text) ) { return false; }
            if(EmailLabel.Text.Length == 0){return false;}
            if(PhoneNumberLabel.Text.Length == 0) {  return false; }

            return true;
        }
    }
}
