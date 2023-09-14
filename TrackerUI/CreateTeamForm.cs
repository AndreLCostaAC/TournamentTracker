using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            //Forces the refresh in the dropdown
            SelectTeamLabel.DataSource = null;

            SelectTeamLabel.DataSource = availableTeamMembers;
            SelectTeamLabel.DisplayMember = "FullName";

            //Forces the refresh in the ListBox
            TeamMembersListBox.DataSource = null;

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

                selectedTeamMembers.Add(p);
                WireUpLists();

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


        private void AddMemberLabel_Click(object sender, EventArgs e)
        {

            PersonModel p = SelectTeamLabel.SelectedItem as PersonModel;

            if(p != null)
            {
                selectedTeamMembers.Add(p);
                availableTeamMembers.Remove(p);
                WireUpLists();
            }
            else
            {
                MessageBox.Show("Nenhum membro selecionado");
            }



        }

        private void DeleteSelectedMember_Click(object sender, EventArgs e)
        {

            PersonModel p = TeamMembersListBox.SelectedItem as PersonModel;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }

            else
            {
                MessageBox.Show("Nenhum membro selecionado");
            }

        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {

        }
    }
} 
