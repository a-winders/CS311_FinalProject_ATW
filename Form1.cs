namespace CS311_FinalProject_ATW
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        } // end frmMain

        private void Form1_Load(object sender, EventArgs e)
        {

        } // end Form1_Load

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        } // end radioButton1

        private void grpToTemperature_Enter(object sender, EventArgs e)
        {

        } // end grpToTemperature

        private void rdoToCelsius_CheckedChanged(object sender, EventArgs e)
        {

        } // end rdoToCelsius

        private void txtEnterUnit_TextChanged(object sender, EventArgs e)
        {

        } // end txtEnterUnit_TextChanged

        private void txtConvertedUnit_TextChanged(object sender, EventArgs e)
        {

        } // end txtConvertedUnit_TextChanged

        private void btnConvert_Click(object sender, EventArgs e)
        {
            calculateConversion(); // calls calculateConversion method
        } // end btnConvert_Click

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConvertedUnit.Text = ""; //clears out converted units text box
            txtEnterUnit.Text = ""; // clears out initial units text box
            lblConvertedUnit.Text = "";

            // clears all radio button selections in initial unit groups
            rdoFromCelsius.Checked = false;
            rdoFromFahrenheit.Checked = false;
            rdoFromKilograms.Checked = false;
            rdoFromPounds.Checked = false;
            rdoFromGrams.Checked = false;
            rdoFromOunces.Checked = false;
            rdoFromKilometers.Checked = false;
            rdoFromMiles.Checked = false;
            rdoFromMeters.Checked = false;
            rdoFromFeet.Checked = false;

            // clears all radio button selections in converted unit groups
            rdoToCelsius.Checked = false;
            rdoToFahrenheit.Checked = false;
            rdoToKilograms.Checked = false;
            rdoToPounds.Checked = false;
            rdoToGrams.Checked = false;
            rdoToOunces.Checked = false;
            rdoToKilometers.Checked = false;
            rdoToMiles.Checked = false;
            rdoToMeters.Checked = false;
            rdoToFeet.Checked = false;

        } // end btnClear_Click

        private void calculateConversion ()
        {
            double initialUnits = double.Parse(txtEnterUnit.Text); // grabs user input for number of initial units
            double convertedUnits; // calculated converted units

            if (rdoFromCelsius.Checked && rdoToFahrenheit.Checked) // celsius to fahrenheit
            {
                convertedUnits = (initialUnits * 9 / 5) + 32;
                lblConvertedUnit.Text = "Fahrenheit";
            }

            else if (rdoFromFahrenheit.Checked && rdoToCelsius.Checked) // fahrenheit to celsius
            {
                convertedUnits = (initialUnits - 32) * 5 / 9;
                lblConvertedUnit.Text = "Celsius";
            }

            else if (rdoFromKilograms.Checked && rdoToPounds.Checked) // kilograms to pounds
            {
                convertedUnits = (initialUnits * 2.205);
                lblConvertedUnit.Text = "pounds";
            }

            else if (rdoFromPounds.Checked && rdoToKilograms.Checked) // pounds to kilograms
            {
                convertedUnits = (initialUnits / 2.205);
                lblConvertedUnit.Text = "kilograms";
            }

            else if (rdoFromGrams.Checked && rdoToOunces.Checked) // grams to ounces
            {
                convertedUnits = (initialUnits / 28.35);
                lblConvertedUnit.Text = "ounces";
            }

            else if (rdoFromOunces.Checked && rdoToGrams.Checked) // ounces to grams
            {
                convertedUnits = (initialUnits * 28.35);
                lblConvertedUnit.Text = "grams";
            }

            else if (rdoFromKilometers.Checked && rdoToMiles.Checked) // kilometers to miles
            {
                convertedUnits = (initialUnits / 1.609);
                lblConvertedUnit.Text = "miles";
            }

            else if (rdoFromMiles.Checked && rdoToKilometers.Checked) // miles to kilometers
            {
                convertedUnits = (initialUnits * 1.609);
                lblConvertedUnit.Text = "kilometers";
            }

            else if (rdoFromMeters.Checked && rdoToFeet.Checked) // meters to feet
            {
                convertedUnits = (initialUnits * 3.281);
                lblConvertedUnit.Text = "feet";
            }

            else if (rdoFromFeet.Checked && rdoToMeters.Checked) // feet to meters
            {
                convertedUnits = (initialUnits / 3.281);
                lblConvertedUnit.Text = "meters";
            }

            else
            {
                MessageBox.Show("Please select valid conversion units.");
                return;
            }

            txtConvertedUnit.Text = convertedUnits.ToString(""); // displays number of converted units to text box

        } // end calculateConversion

        private void rdoFromCelsius_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoToFahrenheit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblConvertedUnit_Click(object sender, EventArgs e)
        {

        }
    } // end frmMain : Form
} // end namespace