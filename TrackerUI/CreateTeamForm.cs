using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using TrackerLibrary;


namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connections.GetPerson_ALL();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();

        }
       
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { Name = "Andre", LastName = "Alexandre" });
            availableTeamMembers.Add(new PersonModel { Name = "Tomas", LastName = "Silva" });

            selectedTeamMembers.Add(new PersonModel { Name = "Rita", LastName = "Rodrigues" });
            selectedTeamMembers.Add(new PersonModel { Name = "Ana", LastName = "Lelo" });

        }
        private void WireUpLists()
        {
            SelectTeamLabel.DataSource = availableTeamMembers;
            SelectTeamLabel.DisplayMember = "FullName";

            TeamMembersListBox.DataSource = selectedTeamMembers;
            TeamMembersListBox.DisplayMember = "FullName";
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

                GlobalConfig.Connections.CreatePerson(p);


                //foreach (IDataConnection db in GlobalConfig.Connections)
                //{
                //    db.CreatePerson(p);
                //}

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

        private void TeamMembersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
