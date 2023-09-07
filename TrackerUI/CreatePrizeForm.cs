using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void FirstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void TeamOneScoreValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    PlaceNameValue.Text,
                    PlaceNumber.Text,
                    PrizeAmountValue.Text,
                    PrizePercentageValue.Text);
                foreach(IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
                PlaceNameValue.Text = "";
                PlaceNumber.Text = "";
                PrizeAmountValue.Text = "0";
                PrizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }

        }
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidationNumber = int.TryParse(PlaceNumber.Text, out placeNumber);
            if (!placeNumberValidationNumber)
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }

            if(PlaceNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(PrizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(PrizePercentageValue.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if(prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }



            return output;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrizeAmountValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
