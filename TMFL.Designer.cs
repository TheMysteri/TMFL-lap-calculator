namespace TMFL
{
    partial class frmTMFL
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTMFL));
            this.lblDryTyre = new System.Windows.Forms.Label();
            this.lblDryFuel = new System.Windows.Forms.Label();
            this.lblDryResText = new System.Windows.Forms.Label();
            this.imgTMFL = new System.Windows.Forms.PictureBox();
            this.sldDryTyre = new System.Windows.Forms.TrackBar();
            this.sldDryFuel = new System.Windows.Forms.TrackBar();
            this.lblWetTyre = new System.Windows.Forms.Label();
            this.lblWetFuel = new System.Windows.Forms.Label();
            this.sldWetTyre = new System.Windows.Forms.TrackBar();
            this.sldWetFuel = new System.Windows.Forms.TrackBar();
            this.lblDryFuelPerc = new System.Windows.Forms.Label();
            this.numDryFuel = new System.Windows.Forms.NumericUpDown();
            this.lblDryTyrePerc = new System.Windows.Forms.Label();
            this.numDryTyre = new System.Windows.Forms.NumericUpDown();
            this.lblWetFuelPerc = new System.Windows.Forms.Label();
            this.numWetFuel = new System.Windows.Forms.NumericUpDown();
            this.lblWetTyrePerc = new System.Windows.Forms.Label();
            this.numWetTyre = new System.Windows.Forms.NumericUpDown();
            this.lblWetResText = new System.Windows.Forms.Label();
            this.lblDryResult = new System.Windows.Forms.Label();
            this.lblWetResult = new System.Windows.Forms.Label();
            this.lblDry = new System.Windows.Forms.Label();
            this.lblWet = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chkStint = new System.Windows.Forms.CheckBox();
            this.numStintLaps = new System.Windows.Forms.NumericUpDown();
            this.lblStintLaps = new System.Windows.Forms.Label();
            this.rdbDry = new System.Windows.Forms.RadioButton();
            this.rdbWet = new System.Windows.Forms.RadioButton();
            this.lblStintResText = new System.Windows.Forms.Label();
            this.lblStintResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgTMFL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldDryTyre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldDryFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldWetTyre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldWetFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDryFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDryTyre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWetFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWetTyre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStintLaps)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDryTyre
            // 
            this.lblDryTyre.AutoSize = true;
            this.lblDryTyre.Location = new System.Drawing.Point(67, 210);
            this.lblDryTyre.Name = "lblDryTyre";
            this.lblDryTyre.Size = new System.Drawing.Size(62, 15);
            this.lblDryTyre.TabIndex = 1;
            this.lblDryTyre.Text = "Tyre usage";
            // 
            // lblDryFuel
            // 
            this.lblDryFuel.AutoSize = true;
            this.lblDryFuel.Location = new System.Drawing.Point(67, 255);
            this.lblDryFuel.Name = "lblDryFuel";
            this.lblDryFuel.Size = new System.Drawing.Size(63, 15);
            this.lblDryFuel.TabIndex = 2;
            this.lblDryFuel.Text = "Fuel usage";
            // 
            // lblDryResText
            // 
            this.lblDryResText.AutoSize = true;
            this.lblDryResText.Location = new System.Drawing.Point(51, 647);
            this.lblDryResText.Name = "lblDryResText";
            this.lblDryResText.Size = new System.Drawing.Size(211, 15);
            this.lblDryResText.TabIndex = 6;
            this.lblDryResText.Text = "Max. amount of laps in dry conditions:";
            // 
            // imgTMFL
            // 
            this.imgTMFL.BackgroundImage = global::TMFL.Properties.Resources.TMFL_logo;
            this.imgTMFL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTMFL.Location = new System.Drawing.Point(108, 23);
            this.imgTMFL.Name = "imgTMFL";
            this.imgTMFL.Size = new System.Drawing.Size(590, 105);
            this.imgTMFL.TabIndex = 14;
            this.imgTMFL.TabStop = false;
            // 
            // sldDryTyre
            // 
            this.sldDryTyre.BackColor = System.Drawing.SystemColors.Control;
            this.sldDryTyre.CausesValidation = false;
            this.sldDryTyre.LargeChange = 10;
            this.sldDryTyre.Location = new System.Drawing.Point(312, 208);
            this.sldDryTyre.Maximum = 100;
            this.sldDryTyre.Minimum = 1;
            this.sldDryTyre.Name = "sldDryTyre";
            this.sldDryTyre.Size = new System.Drawing.Size(419, 45);
            this.sldDryTyre.TabIndex = 15;
            this.sldDryTyre.TabStop = false;
            this.sldDryTyre.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sldDryTyre.Value = 1;
            this.sldDryTyre.ValueChanged += new System.EventHandler(this.sldDryTyre_ValueChanged);
            // 
            // sldDryFuel
            // 
            this.sldDryFuel.LargeChange = 100;
            this.sldDryFuel.Location = new System.Drawing.Point(312, 252);
            this.sldDryFuel.Maximum = 1000;
            this.sldDryFuel.Minimum = 1;
            this.sldDryFuel.Name = "sldDryFuel";
            this.sldDryFuel.Size = new System.Drawing.Size(419, 45);
            this.sldDryFuel.TabIndex = 16;
            this.sldDryFuel.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sldDryFuel.Value = 1;
            this.sldDryFuel.ValueChanged += new System.EventHandler(this.sldDryFuel_ValueChanged);
            // 
            // lblWetTyre
            // 
            this.lblWetTyre.AutoSize = true;
            this.lblWetTyre.Location = new System.Drawing.Point(67, 352);
            this.lblWetTyre.Name = "lblWetTyre";
            this.lblWetTyre.Size = new System.Drawing.Size(62, 15);
            this.lblWetTyre.TabIndex = 4;
            this.lblWetTyre.Text = "Tyre usage";
            // 
            // lblWetFuel
            // 
            this.lblWetFuel.AutoSize = true;
            this.lblWetFuel.Location = new System.Drawing.Point(67, 397);
            this.lblWetFuel.Name = "lblWetFuel";
            this.lblWetFuel.Size = new System.Drawing.Size(63, 15);
            this.lblWetFuel.TabIndex = 5;
            this.lblWetFuel.Text = "Fuel usage";
            // 
            // sldWetTyre
            // 
            this.sldWetTyre.BackColor = System.Drawing.SystemColors.Control;
            this.sldWetTyre.CausesValidation = false;
            this.sldWetTyre.LargeChange = 10;
            this.sldWetTyre.Location = new System.Drawing.Point(312, 349);
            this.sldWetTyre.Maximum = 100;
            this.sldWetTyre.Minimum = 1;
            this.sldWetTyre.Name = "sldWetTyre";
            this.sldWetTyre.Size = new System.Drawing.Size(419, 45);
            this.sldWetTyre.TabIndex = 17;
            this.sldWetTyre.TabStop = false;
            this.sldWetTyre.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sldWetTyre.Value = 1;
            this.sldWetTyre.ValueChanged += new System.EventHandler(this.sldWetTyre_ValueChanged);
            // 
            // sldWetFuel
            // 
            this.sldWetFuel.BackColor = System.Drawing.SystemColors.Control;
            this.sldWetFuel.LargeChange = 100;
            this.sldWetFuel.Location = new System.Drawing.Point(312, 394);
            this.sldWetFuel.Maximum = 1000;
            this.sldWetFuel.Minimum = 1;
            this.sldWetFuel.Name = "sldWetFuel";
            this.sldWetFuel.Size = new System.Drawing.Size(419, 45);
            this.sldWetFuel.TabIndex = 18;
            this.sldWetFuel.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sldWetFuel.Value = 1;
            this.sldWetFuel.ValueChanged += new System.EventHandler(this.sldWetFuel_ValueChanged);
            // 
            // lblDryFuelPerc
            // 
            this.lblDryFuelPerc.AutoSize = true;
            this.lblDryFuelPerc.Location = new System.Drawing.Point(238, 255);
            this.lblDryFuelPerc.Name = "lblDryFuelPerc";
            this.lblDryFuelPerc.Size = new System.Drawing.Size(13, 15);
            this.lblDryFuelPerc.TabIndex = 24;
            this.lblDryFuelPerc.Text = "L";
            // 
            // numDryFuel
            // 
            this.numDryFuel.DecimalPlaces = 1;
            this.numDryFuel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDryFuel.Location = new System.Drawing.Point(155, 253);
            this.numDryFuel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDryFuel.Name = "numDryFuel";
            this.numDryFuel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numDryFuel.Size = new System.Drawing.Size(76, 23);
            this.numDryFuel.TabIndex = 23;
            this.numDryFuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDryFuel.ThousandsSeparator = true;
            this.numDryFuel.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDryFuel.ValueChanged += new System.EventHandler(this.numDryFuel_ValueChanged);
            this.numDryFuel.Click += new System.EventHandler(this.numDryFuel_Click);
            // 
            // lblDryTyrePerc
            // 
            this.lblDryTyrePerc.AutoSize = true;
            this.lblDryTyrePerc.Location = new System.Drawing.Point(238, 210);
            this.lblDryTyrePerc.Name = "lblDryTyrePerc";
            this.lblDryTyrePerc.Size = new System.Drawing.Size(17, 15);
            this.lblDryTyrePerc.TabIndex = 22;
            this.lblDryTyrePerc.Text = "%";
            // 
            // numDryTyre
            // 
            this.numDryTyre.Location = new System.Drawing.Point(155, 208);
            this.numDryTyre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDryTyre.Name = "numDryTyre";
            this.numDryTyre.Size = new System.Drawing.Size(76, 23);
            this.numDryTyre.TabIndex = 21;
            this.numDryTyre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDryTyre.ThousandsSeparator = true;
            this.numDryTyre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDryTyre.ValueChanged += new System.EventHandler(this.numDryTyre_ValueChanged);
            this.numDryTyre.Click += new System.EventHandler(this.numDryTyre_Click);
            // 
            // lblWetFuelPerc
            // 
            this.lblWetFuelPerc.AutoSize = true;
            this.lblWetFuelPerc.Location = new System.Drawing.Point(238, 397);
            this.lblWetFuelPerc.Name = "lblWetFuelPerc";
            this.lblWetFuelPerc.Size = new System.Drawing.Size(13, 15);
            this.lblWetFuelPerc.TabIndex = 28;
            this.lblWetFuelPerc.Text = "L";
            // 
            // numWetFuel
            // 
            this.numWetFuel.DecimalPlaces = 1;
            this.numWetFuel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWetFuel.Location = new System.Drawing.Point(155, 395);
            this.numWetFuel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWetFuel.Name = "numWetFuel";
            this.numWetFuel.Size = new System.Drawing.Size(76, 23);
            this.numWetFuel.TabIndex = 27;
            this.numWetFuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numWetFuel.ThousandsSeparator = true;
            this.numWetFuel.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWetFuel.ValueChanged += new System.EventHandler(this.numWetFuel_ValueChanged);
            this.numWetFuel.Click += new System.EventHandler(this.numWetFuel_Click);
            // 
            // lblWetTyrePerc
            // 
            this.lblWetTyrePerc.AutoSize = true;
            this.lblWetTyrePerc.Location = new System.Drawing.Point(238, 352);
            this.lblWetTyrePerc.Name = "lblWetTyrePerc";
            this.lblWetTyrePerc.Size = new System.Drawing.Size(17, 15);
            this.lblWetTyrePerc.TabIndex = 26;
            this.lblWetTyrePerc.Text = "%";
            // 
            // numWetTyre
            // 
            this.numWetTyre.Location = new System.Drawing.Point(155, 350);
            this.numWetTyre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWetTyre.Name = "numWetTyre";
            this.numWetTyre.Size = new System.Drawing.Size(76, 23);
            this.numWetTyre.TabIndex = 25;
            this.numWetTyre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numWetTyre.ThousandsSeparator = true;
            this.numWetTyre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWetTyre.ValueChanged += new System.EventHandler(this.numWetTyre_ValueChanged);
            this.numWetTyre.Click += new System.EventHandler(this.numWetTyre_Click);
            // 
            // lblWetResText
            // 
            this.lblWetResText.AutoSize = true;
            this.lblWetResText.Location = new System.Drawing.Point(459, 647);
            this.lblWetResText.Name = "lblWetResText";
            this.lblWetResText.Size = new System.Drawing.Size(213, 15);
            this.lblWetResText.TabIndex = 21;
            this.lblWetResText.Text = "Max. amount of laps in wet conditions:";
            // 
            // lblDryResult
            // 
            this.lblDryResult.AutoSize = true;
            this.lblDryResult.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDryResult.ForeColor = System.Drawing.Color.Red;
            this.lblDryResult.Location = new System.Drawing.Point(279, 647);
            this.lblDryResult.Name = "lblDryResult";
            this.lblDryResult.Size = new System.Drawing.Size(56, 15);
            this.lblDryResult.TabIndex = 22;
            this.lblDryResult.Text = "100 laps";
            // 
            // lblWetResult
            // 
            this.lblWetResult.AutoSize = true;
            this.lblWetResult.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblWetResult.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblWetResult.Location = new System.Drawing.Point(690, 647);
            this.lblWetResult.Name = "lblWetResult";
            this.lblWetResult.Size = new System.Drawing.Size(56, 15);
            this.lblWetResult.TabIndex = 23;
            this.lblWetResult.Text = "100 laps";
            // 
            // lblDry
            // 
            this.lblDry.AutoSize = true;
            this.lblDry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDry.Location = new System.Drawing.Point(39, 177);
            this.lblDry.Name = "lblDry";
            this.lblDry.Size = new System.Drawing.Size(50, 15);
            this.lblDry.TabIndex = 29;
            this.lblDry.Text = "No rain:";
            // 
            // lblWet
            // 
            this.lblWet.AutoSize = true;
            this.lblWet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWet.Location = new System.Drawing.Point(39, 320);
            this.lblWet.Name = "lblWet";
            this.lblWet.Size = new System.Drawing.Size(34, 15);
            this.lblWet.TabIndex = 30;
            this.lblWet.Text = "Rain:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(318, 602);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(157, 23);
            this.btnCalculate.TabIndex = 31;
            this.btnCalculate.Text = "Calculate max. laps";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // chkStint
            // 
            this.chkStint.AutoSize = true;
            this.chkStint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkStint.Location = new System.Drawing.Point(39, 457);
            this.chkStint.Name = "chkStint";
            this.chkStint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkStint.Size = new System.Drawing.Size(107, 19);
            this.chkStint.TabIndex = 32;
            this.chkStint.Text = ":Calculate stint";
            this.chkStint.UseVisualStyleBackColor = true;
            this.chkStint.CheckedChanged += new System.EventHandler(this.chkStint_CheckedChanged);
            // 
            // numStintLaps
            // 
            this.numStintLaps.Enabled = false;
            this.numStintLaps.Location = new System.Drawing.Point(155, 500);
            this.numStintLaps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStintLaps.Name = "numStintLaps";
            this.numStintLaps.Size = new System.Drawing.Size(76, 23);
            this.numStintLaps.TabIndex = 35;
            this.numStintLaps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numStintLaps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStintLaps.ValueChanged += new System.EventHandler(this.numStintLaps_ValueChanged);
            this.numStintLaps.Click += new System.EventHandler(this.numStintLaps_Click);
            this.numStintLaps.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numStintLaps_KeyUp);
            // 
            // lblStintLaps
            // 
            this.lblStintLaps.AutoSize = true;
            this.lblStintLaps.Location = new System.Drawing.Point(67, 502);
            this.lblStintLaps.Name = "lblStintLaps";
            this.lblStintLaps.Size = new System.Drawing.Size(34, 15);
            this.lblStintLaps.TabIndex = 36;
            this.lblStintLaps.Text = "Laps:";
            // 
            // rdbDry
            // 
            this.rdbDry.AutoSize = true;
            this.rdbDry.Checked = true;
            this.rdbDry.Enabled = false;
            this.rdbDry.Location = new System.Drawing.Point(360, 500);
            this.rdbDry.Name = "rdbDry";
            this.rdbDry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbDry.Size = new System.Drawing.Size(64, 19);
            this.rdbDry.TabIndex = 37;
            this.rdbDry.TabStop = true;
            this.rdbDry.Text = "No rain";
            this.rdbDry.UseVisualStyleBackColor = true;
            this.rdbDry.CheckedChanged += new System.EventHandler(this.rdbDry_CheckedChanged);
            // 
            // rdbWet
            // 
            this.rdbWet.AutoSize = true;
            this.rdbWet.Enabled = false;
            this.rdbWet.Location = new System.Drawing.Point(579, 500);
            this.rdbWet.Name = "rdbWet";
            this.rdbWet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbWet.Size = new System.Drawing.Size(48, 19);
            this.rdbWet.TabIndex = 38;
            this.rdbWet.Text = "Rain";
            this.rdbWet.UseVisualStyleBackColor = true;
            // 
            // lblStintResText
            // 
            this.lblStintResText.AutoSize = true;
            this.lblStintResText.Location = new System.Drawing.Point(268, 548);
            this.lblStintResText.Name = "lblStintResText";
            this.lblStintResText.Size = new System.Drawing.Size(165, 15);
            this.lblStintResText.TabIndex = 39;
            this.lblStintResText.Text = "Max. amount of laps per stint:";
            // 
            // lblStintResult
            // 
            this.lblStintResult.AutoSize = true;
            this.lblStintResult.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblStintResult.Location = new System.Drawing.Point(452, 548);
            this.lblStintResult.Name = "lblStintResult";
            this.lblStintResult.Size = new System.Drawing.Size(56, 15);
            this.lblStintResult.TabIndex = 40;
            this.lblStintResult.Text = "100 laps";
            // 
            // frmTMFL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 688);
            this.Controls.Add(this.lblStintResult);
            this.Controls.Add(this.lblStintResText);
            this.Controls.Add(this.rdbWet);
            this.Controls.Add(this.rdbDry);
            this.Controls.Add(this.lblStintLaps);
            this.Controls.Add(this.numStintLaps);
            this.Controls.Add(this.chkStint);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblWet);
            this.Controls.Add(this.lblDry);
            this.Controls.Add(this.lblWetFuelPerc);
            this.Controls.Add(this.lblDryFuelPerc);
            this.Controls.Add(this.lblWetTyre);
            this.Controls.Add(this.lblWetResult);
            this.Controls.Add(this.numWetFuel);
            this.Controls.Add(this.lblWetTyrePerc);
            this.Controls.Add(this.numDryFuel);
            this.Controls.Add(this.sldWetFuel);
            this.Controls.Add(this.lblDryResult);
            this.Controls.Add(this.numWetTyre);
            this.Controls.Add(this.lblDryTyrePerc);
            this.Controls.Add(this.lblWetFuel);
            this.Controls.Add(this.lblWetResText);
            this.Controls.Add(this.sldWetTyre);
            this.Controls.Add(this.numDryTyre);
            this.Controls.Add(this.sldDryTyre);
            this.Controls.Add(this.lblDryTyre);
            this.Controls.Add(this.sldDryFuel);
            this.Controls.Add(this.imgTMFL);
            this.Controls.Add(this.lblDryFuel);
            this.Controls.Add(this.lblDryResText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTMFL";
            this.Text = "TMFL lap calculator";
            ((System.ComponentModel.ISupportInitialize)(this.imgTMFL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldDryTyre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldDryFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldWetTyre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldWetFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDryFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDryTyre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWetFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWetTyre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStintLaps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblDryTyre;
        private Label lblDryFuel;
        private Label lblDryResText;
        public PictureBox imgTMFL;
        private TrackBar sldDryTyre;
        private TrackBar sldDryFuel;
        private Label lblWetTyre;
        private Label lblWetFuel;
        private TrackBar sldWetTyre;
        private TrackBar sldWetFuel;
        private Label lblDryFuelPerc;
        private NumericUpDown numDryFuel;
        private Label lblDryTyrePerc;
        private NumericUpDown numDryTyre;
        private Label lblWetFuelPerc;
        private NumericUpDown numWetFuel;
        private Label lblWetTyrePerc;
        private NumericUpDown numWetTyre;
        private Label lblWetResText;
        private Label lblDryResult;
        private Label lblWetResult;
        private Label lblDry;
        private Label lblWet;
        private Button btnCalculate;
        private CheckBox chkStint;
        private NumericUpDown numStintLaps;
        private Label lblStintLaps;
        private RadioButton rdbDry;
        private RadioButton rdbWet;
        private Label lblStintResText;
        private Label lblStintResult;
    }
}