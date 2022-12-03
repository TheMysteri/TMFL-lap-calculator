namespace TMFL
{
    public partial class frmTMFL : Form
    {
        public frmTMFL()
        {
            InitializeComponent();

            numLaps.Controls.RemoveAt(0);

            numSlowTyre.Controls.RemoveAt(0);
            numSlowFuel.Controls.RemoveAt(0);
            numSlowTime.Controls.RemoveAt(0);
            numSlowBox.Controls.RemoveAt(0);

            numFastTyre.Controls.RemoveAt(0);
            numFastFuel.Controls.RemoveAt(0);
            numFastTime.Controls.RemoveAt(0);
            numFastBox.Controls.RemoveAt(0);
        }

        private void btnSlowOut_Click(object sender, EventArgs e)
        {
            if (numSlowTyre.Value > numSlowFuel.Value)
            {
                txbSlowLaps.Text = Math.Floor(100 / numSlowTyre.Value).ToString();
            }
            else
            {
                txbSlowLaps.Text = Math.Floor(100 / numSlowFuel.Value).ToString();
            }

            txbSlowPits.Text = Math.Floor(numLaps.Value / int.Parse(txbSlowLaps.Text)).ToString();

            txbSlowTimeLoss.Text = (numSlowBox.Value - numSlowTime.Value).ToString();

            txbSlowTyresLeft.Text = (100 - (int.Parse(txbSlowLaps.Text) * numSlowTyre.Value)).ToString();

            txbSlowFuelLeft.Text = (100 - (int.Parse(txbSlowLaps.Text) * numSlowFuel.Value)).ToString();

            txbSlowTimeBox.Text = ((100 - decimal.Parse(txbSlowFuelLeft.Text)) / 4).ToString();

            txbSlowFuelLast.Text = ((numLaps.Value - (int.Parse(txbSlowLaps.Text) * int.Parse(txbSlowPits.Text))) * numSlowFuel.Value).ToString();

            txbSlowTimeStint.Text = (((int.Parse(txbSlowLaps.Text) - 1) * numSlowTime.Value) + numSlowBox.Value).ToString();

            decimal slowTimeLeft = (numLaps.Value - (int.Parse(txbSlowLaps.Text) * int.Parse(txbSlowPits.Text))) * numSlowTime.Value;

            txbSlowTimeRace.Text = ((5 + (int.Parse(txbSlowPits.Text) * decimal.Parse(txbSlowTimeStint.Text)) + slowTimeLeft) / 60).ToString("#.##");
        }

        private void btnFastOut_Click(object sender, EventArgs e)
        {
            if (numFastTyre.Value > numFastFuel.Value)
            {
                txbFastLaps.Text = Math.Floor(100 / numFastTyre.Value).ToString();
            }
            else
            {
                txbFastLaps.Text = Math.Floor(100 / numFastFuel.Value).ToString();
            }

            txbFastPits.Text = Math.Floor(numLaps.Value / int.Parse(txbFastLaps.Text)).ToString();

            txbFastTimeLoss.Text = (numFastBox.Value - numFastTime.Value).ToString();

            txbFastTyresLeft.Text = (100 - (int.Parse(txbFastLaps.Text) * numFastTyre.Value)).ToString();

            txbFastFuelLeft.Text = (100 - (int.Parse(txbFastLaps.Text) * numFastFuel.Value)).ToString();

            txbFastTimeBox.Text = ((100 - decimal.Parse(txbFastFuelLeft.Text)) / 4).ToString();

            txbFastFuelLast.Text = ((numLaps.Value - (int.Parse(txbFastLaps.Text) * int.Parse(txbFastPits.Text))) * numFastFuel.Value).ToString();

            txbFastTimeStint.Text = (((int.Parse(txbFastLaps.Text) - 1) * numFastTime.Value) + numFastBox.Value).ToString();

            decimal fastTimeLeft = (numLaps.Value - (int.Parse(txbFastLaps.Text) * int.Parse(txbFastPits.Text))) * numFastTime.Value;

            txbFastTimeRace.Text = ((5 + (int.Parse(txbFastPits.Text) * decimal.Parse(txbFastTimeStint.Text)) + fastTimeLeft) / 60).ToString("#.##");

        }
    }
}