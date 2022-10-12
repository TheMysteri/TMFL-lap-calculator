namespace TMFL
{
    public partial class frmTMFL : Form
    {
        public frmTMFL()
        {
            InitializeComponent();
        }

        // Dry tyre usage connections between numeric field and trackbar
        private void sldDryTyre_ValueChanged(object sender, EventArgs e)
        {
            // Set value of numeric field to value of trackbar
            numDryTyre.Value = sldDryTyre.Value;
        }

        private void numDryTyre_ValueChanged(object sender, EventArgs e)
        {
            // Cast value of numeric field to int and set as value of trackbar
            sldDryTyre.Value = ((int)numDryTyre.Value);

            numStintLaps.Maximum = numDryTyre.Value;
        }

        private void numDryTyre_Click(object sender, EventArgs e)
        {
            // Select text in numeric field
            numDryTyre.Select(0, 3);
        }

        // Dry fuel usage connections between numeric field and trackbar
        private void sldDryFuel_ValueChanged(object sender, EventArgs e)
        {
            // Set value of numeric field to value of trackbar, divided by 10 for decimal place
            numDryFuel.Value = ((decimal)sldDryFuel.Value) / 10;
        }

        private void numDryFuel_ValueChanged(object sender, EventArgs e)
        {
            // Multiply value of numeric field by 10 to remove decimal place, cast to int and set as value of trackbar
            sldDryFuel.Value = ((int)(numDryFuel.Value * 10));
        }

        private void numDryFuel_Click(object sender, EventArgs e)
        {
            // Select text in numeric field
            numDryFuel.Select(0, 4);
        }

        // Wet tyre usage connections between numeric field and trackbar
        private void sldWetTyre_ValueChanged(object sender, EventArgs e)
        {
            numWetTyre.Value = sldWetTyre.Value;
        }

        private void numWetTyre_ValueChanged(object sender, EventArgs e)
        {
            sldWetTyre.Value = ((int)numWetTyre.Value);
        }

        private void numWetTyre_Click(object sender, EventArgs e)
        {
            numWetTyre.Select(0, 3);
        }

        // Wet fuel usage connections between numeric field and trackbar
        private void sldWetFuel_ValueChanged(object sender, EventArgs e)
        {
            numWetFuel.Value = ((decimal)sldWetFuel.Value) / 10;
        }

        private void numWetFuel_ValueChanged(object sender, EventArgs e)
        {
            sldWetFuel.Value = ((int)(numWetFuel.Value * 10));
        }

        private void numWetFuel_Click(object sender, EventArgs e)
        {
            numWetFuel.Select(0, 4);
        }

        private void chkStint_CheckedChanged(object sender, EventArgs e)
        {
            // Enable stint controls
            numStintLaps.Enabled = chkStint.Checked;
            rdbDry.Enabled = chkStint.Checked;
            rdbWet.Enabled = chkStint.Checked;

            calculate();
        }

        private void numStintLaps_ValueChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void numStintLaps_Click(object sender, EventArgs e)
        {
            // Select text
            numStintLaps.Select(0, numStintLaps.Value.ToString().Length);
        }

        private void numStintLaps_KeyUp(object sender, KeyEventArgs e)
        {
            calculate();
        }

        public void calculate()
        {
            int tyrePercent;
            int fuelPercent;

            int remainingTyre;
            int remainingFuel;

            int result;

            // Check if dry conditions are selected
            if (rdbDry.Checked)
            {
                // Calculate the usage of both dry tyres and fuel
                tyrePercent = ((int)numStintLaps.Value) * dryTyreUse;
                fuelPercent = ((int)(numStintLaps.Value * dryFuelUse));

                // Calculate the maximum usage of both wet tyres and fuel
                remainingTyre = ((int)((100 - tyrePercent) / wetTyreUse));
                remainingFuel = ((int)((100 - fuelPercent) / wetFuelUse));
            }
            else
            {
                // Calculate the usage of both wet tyres and fuel
                tyrePercent = ((int)numStintLaps.Value) * wetTyreUse;
                fuelPercent = ((int)(numStintLaps.Value * wetFuelUse));

                // Calculate the maximum usage of both dry tyres and fuel
                remainingTyre = ((int)((100 - tyrePercent) / dryTyreUse));
                remainingFuel = ((int)((100 - fuelPercent) / dryFuelUse));
            }

            // Select maximum amount of stint laps based on the lowest amount
            if (remainingTyre < remainingFuel)
            {
                result = ((int)numStintLaps.Value) + remainingTyre;
            }
            else
            {
                result = ((int)numStintLaps.Value) + remainingFuel;
            }

            lblStintResult.Text = result + " laps";
        }

        private void rdbDry_CheckedChanged(object sender, EventArgs e)
        {
            calculate();
        }

        int dryTyreUse = 1;
        decimal dryFuelUse = 0.1m;

        int wetTyreUse = 1;
        decimal wetFuelUse = 0.1m;

        // Calculate maximum amount of laps for both dry and wet conditions, and stints
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Total maximum laps under dry conditions for tyres and fuel separately
            int dryTyreResult = ((int)(100 / numDryTyre.Value));
            int dryFuelResult = ((int)(100 / numDryFuel.Value));

            // Set global variables
            dryTyreUse = ((int)numDryTyre.Value);
            dryFuelUse = numDryFuel.Value;

            // Select total maximum laps based on the lowest value between dry tyres and fuel
            int dryResult = 0;

            if (dryTyreResult < dryFuelResult)
            {
                dryResult = dryTyreResult;
            }
            else
            {
                dryResult = dryFuelResult;
            }

            // Set maximum dry stint value
            if (rdbDry.Checked)
            {
                numStintLaps.Maximum = dryResult;
            }

            // Total maximum laps under wet conditions for tyres and fuel separately
            int wetTyreResult = ((int)(100 / numWetTyre.Value));
            int wetFuelResult = ((int)(100 / numWetFuel.Value));

            // Set global variables
            wetTyreUse = ((int)numWetTyre.Value);
            wetFuelUse = numWetFuel.Value;

            // Select total maximum laps based on the lowest value between wet tyres and fuel
            int wetResult = 0;

            if (wetTyreResult < wetFuelResult)
            {
                wetResult = wetTyreResult;
            }
            else
            {
                wetResult = wetFuelResult;
            }

            // Set maximum wet stint value
            if (rdbWet.Checked)
            {
                numStintLaps.Maximum = wetResult;
            }

            // Show results
            lblDryResult.Text = dryResult.ToString() + " laps";
            lblWetResult.Text = wetResult.ToString() + " laps";

            // Update stint laps
            if (chkStint.Checked)
            {
                calculate();
            }
        }
    }
}