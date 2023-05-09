using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentTracker;
using TournamentTracker.DataAccess;
using TournamentTracker.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }



        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // passing the data to the PrizeModel incase its valid--//

            // IF form is valid 
            if (ValidateForm())
            {
                // pass the data to the PrizeModel
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                // for each of the storage types in the list Connections
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    // create a Prize model
                    db.CreatePrize(model);
                }

                // Pass empty value strings the form 
                // when its done submitting data to the storage types.
                placeNameValue.Text = " ";
                placeNumberValue.Text = " ";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
            else
            {
                // Display this message incase of invalid form
                MessageBox.Show("This form has invalid data Please correct");
            }

        }


        private bool ValidateForm()
        {
            bool output = true;

            //------------Validating Place Number-------------//
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text,
                                                            out placeNumber);
            // If the placeNumberValue tryparse isnt successful
            // returns false validation
            if (placeNumberValidNumber)
            {
                output = false;
            }
            // User cant insert figure < 1
            // return false
            if (placeNumber < 1)
            {
                output = false;
            }


            //------Validating Prize Amount & Prize Percentage-----//
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(
                prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(
                prizePercentageValue.Text, out prizePercentage);


            // If prizeAmountValue or prizePercentageValue tryparse fails
            // return false validation
            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }


            // User cant insert money < 0 
            // or have Percentage < 0
            // Return false validation 
            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            // User cant have prize percentage
            // less than 0 or greater than 0
            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }


            return output;
        }
    }
}
