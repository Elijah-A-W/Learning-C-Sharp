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
            if (ValidateForm)
            {
                PrizeModel model = new PrizeModel();

                model.PlaceName = placeNameValue.Text;
                model.PlaceNumber = placeNumberValue.Text;


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
            bool prizePercentageValid =double.TryParse(
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
