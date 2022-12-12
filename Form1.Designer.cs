namespace CS311_FinalProject_ATW
{
    partial class frmMain
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
            this.lblEnterUnit = new System.Windows.Forms.Label();
            this.txtEnterUnit = new System.Windows.Forms.TextBox();
            this.txtConvertedUnit = new System.Windows.Forms.TextBox();
            this.grpFromTemperature = new System.Windows.Forms.GroupBox();
            this.rdoFromFahrenheit = new System.Windows.Forms.RadioButton();
            this.rdoFromCelsius = new System.Windows.Forms.RadioButton();
            this.grpFromWeight = new System.Windows.Forms.GroupBox();
            this.rdoFromOunces = new System.Windows.Forms.RadioButton();
            this.rdoFromGrams = new System.Windows.Forms.RadioButton();
            this.rdoFromPounds = new System.Windows.Forms.RadioButton();
            this.rdoFromKilograms = new System.Windows.Forms.RadioButton();
            this.grpFromDistance = new System.Windows.Forms.GroupBox();
            this.rdoFromFeet = new System.Windows.Forms.RadioButton();
            this.rdoFromMeters = new System.Windows.Forms.RadioButton();
            this.rdoFromMiles = new System.Windows.Forms.RadioButton();
            this.rdoFromKilometers = new System.Windows.Forms.RadioButton();
            this.grpToTemperature = new System.Windows.Forms.GroupBox();
            this.rdoToFahrenheit = new System.Windows.Forms.RadioButton();
            this.rdoToCelsius = new System.Windows.Forms.RadioButton();
            this.grpToWeight = new System.Windows.Forms.GroupBox();
            this.rdoToOunces = new System.Windows.Forms.RadioButton();
            this.rdoToGrams = new System.Windows.Forms.RadioButton();
            this.rdoToPounds = new System.Windows.Forms.RadioButton();
            this.rdoToKilograms = new System.Windows.Forms.RadioButton();
            this.grpToDistance = new System.Windows.Forms.GroupBox();
            this.rdoToFeet = new System.Windows.Forms.RadioButton();
            this.rdoToMeters = new System.Windows.Forms.RadioButton();
            this.rdoToMiles = new System.Windows.Forms.RadioButton();
            this.rdoToKilometers = new System.Windows.Forms.RadioButton();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblConvertedUnit = new System.Windows.Forms.Label();
            this.grpFromTemperature.SuspendLayout();
            this.grpFromWeight.SuspendLayout();
            this.grpFromDistance.SuspendLayout();
            this.grpToTemperature.SuspendLayout();
            this.grpToWeight.SuspendLayout();
            this.grpToDistance.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterUnit
            // 
            this.lblEnterUnit.AutoSize = true;
            this.lblEnterUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnterUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnterUnit.Location = new System.Drawing.Point(46, 23);
            this.lblEnterUnit.Name = "lblEnterUnit";
            this.lblEnterUnit.Size = new System.Drawing.Size(194, 23);
            this.lblEnterUnit.TabIndex = 0;
            this.lblEnterUnit.Text = "Enter number of unit(s):";
            // 
            // txtEnterUnit
            // 
            this.txtEnterUnit.Location = new System.Drawing.Point(259, 23);
            this.txtEnterUnit.Name = "txtEnterUnit";
            this.txtEnterUnit.Size = new System.Drawing.Size(132, 23);
            this.txtEnterUnit.TabIndex = 2;
            this.txtEnterUnit.TextChanged += new System.EventHandler(this.txtEnterUnit_TextChanged);
            // 
            // txtConvertedUnit
            // 
            this.txtConvertedUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtConvertedUnit.Location = new System.Drawing.Point(259, 400);
            this.txtConvertedUnit.Name = "txtConvertedUnit";
            this.txtConvertedUnit.Size = new System.Drawing.Size(190, 29);
            this.txtConvertedUnit.TabIndex = 3;
            this.txtConvertedUnit.TextChanged += new System.EventHandler(this.txtConvertedUnit_TextChanged);
            // 
            // grpFromTemperature
            // 
            this.grpFromTemperature.Controls.Add(this.rdoFromFahrenheit);
            this.grpFromTemperature.Controls.Add(this.rdoFromCelsius);
            this.grpFromTemperature.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.grpFromTemperature.Location = new System.Drawing.Point(259, 63);
            this.grpFromTemperature.Name = "grpFromTemperature";
            this.grpFromTemperature.Size = new System.Drawing.Size(133, 90);
            this.grpFromTemperature.TabIndex = 4;
            this.grpFromTemperature.TabStop = false;
            this.grpFromTemperature.Text = "Temperature";
            // 
            // rdoFromFahrenheit
            // 
            this.rdoFromFahrenheit.AutoSize = true;
            this.rdoFromFahrenheit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoFromFahrenheit.Location = new System.Drawing.Point(14, 64);
            this.rdoFromFahrenheit.Name = "rdoFromFahrenheit";
            this.rdoFromFahrenheit.Size = new System.Drawing.Size(86, 21);
            this.rdoFromFahrenheit.TabIndex = 1;
            this.rdoFromFahrenheit.TabStop = true;
            this.rdoFromFahrenheit.Text = "Fahrenheit";
            this.rdoFromFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rdoFromCelsius
            // 
            this.rdoFromCelsius.AutoSize = true;
            this.rdoFromCelsius.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoFromCelsius.Location = new System.Drawing.Point(14, 34);
            this.rdoFromCelsius.Name = "rdoFromCelsius";
            this.rdoFromCelsius.Size = new System.Drawing.Size(66, 21);
            this.rdoFromCelsius.TabIndex = 0;
            this.rdoFromCelsius.TabStop = true;
            this.rdoFromCelsius.Text = "Celsius";
            this.rdoFromCelsius.UseVisualStyleBackColor = true;
            this.rdoFromCelsius.CheckedChanged += new System.EventHandler(this.rdoFromCelsius_CheckedChanged);
            // 
            // grpFromWeight
            // 
            this.grpFromWeight.Controls.Add(this.rdoFromOunces);
            this.grpFromWeight.Controls.Add(this.rdoFromGrams);
            this.grpFromWeight.Controls.Add(this.rdoFromPounds);
            this.grpFromWeight.Controls.Add(this.rdoFromKilograms);
            this.grpFromWeight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.grpFromWeight.Location = new System.Drawing.Point(398, 63);
            this.grpFromWeight.Name = "grpFromWeight";
            this.grpFromWeight.Size = new System.Drawing.Size(133, 148);
            this.grpFromWeight.TabIndex = 5;
            this.grpFromWeight.TabStop = false;
            this.grpFromWeight.Text = "Weight";
            // 
            // rdoFromOunces
            // 
            this.rdoFromOunces.AutoSize = true;
            this.rdoFromOunces.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoFromOunces.Location = new System.Drawing.Point(14, 118);
            this.rdoFromOunces.Name = "rdoFromOunces";
            this.rdoFromOunces.Size = new System.Drawing.Size(69, 21);
            this.rdoFromOunces.TabIndex = 3;
            this.rdoFromOunces.TabStop = true;
            this.rdoFromOunces.Text = "Ounces";
            this.rdoFromOunces.UseVisualStyleBackColor = true;
            // 
            // rdoFromGrams
            // 
            this.rdoFromGrams.AutoSize = true;
            this.rdoFromGrams.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoFromGrams.Location = new System.Drawing.Point(14, 91);
            this.rdoFromGrams.Name = "rdoFromGrams";
            this.rdoFromGrams.Size = new System.Drawing.Size(64, 21);
            this.rdoFromGrams.TabIndex = 2;
            this.rdoFromGrams.TabStop = true;
            this.rdoFromGrams.Text = "Grams";
            this.rdoFromGrams.UseVisualStyleBackColor = true;
            // 
            // rdoFromPounds
            // 
            this.rdoFromPounds.AutoSize = true;
            this.rdoFromPounds.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoFromPounds.Location = new System.Drawing.Point(14, 64);
            this.rdoFromPounds.Name = "rdoFromPounds";
            this.rdoFromPounds.Size = new System.Drawing.Size(69, 21);
            this.rdoFromPounds.TabIndex = 1;
            this.rdoFromPounds.TabStop = true;
            this.rdoFromPounds.Text = "Pounds";
            this.rdoFromPounds.UseVisualStyleBackColor = true;
            // 
            // rdoFromKilograms
            // 
            this.rdoFromKilograms.AutoSize = true;
            this.rdoFromKilograms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoFromKilograms.Location = new System.Drawing.Point(14, 34);
            this.rdoFromKilograms.Name = "rdoFromKilograms";
            this.rdoFromKilograms.Size = new System.Drawing.Size(85, 21);
            this.rdoFromKilograms.TabIndex = 0;
            this.rdoFromKilograms.TabStop = true;
            this.rdoFromKilograms.Text = "Kilograms";
            this.rdoFromKilograms.UseVisualStyleBackColor = true;
            // 
            // grpFromDistance
            // 
            this.grpFromDistance.Controls.Add(this.rdoFromFeet);
            this.grpFromDistance.Controls.Add(this.rdoFromMeters);
            this.grpFromDistance.Controls.Add(this.rdoFromMiles);
            this.grpFromDistance.Controls.Add(this.rdoFromKilometers);
            this.grpFromDistance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.grpFromDistance.Location = new System.Drawing.Point(537, 63);
            this.grpFromDistance.Name = "grpFromDistance";
            this.grpFromDistance.Size = new System.Drawing.Size(133, 148);
            this.grpFromDistance.TabIndex = 6;
            this.grpFromDistance.TabStop = false;
            this.grpFromDistance.Text = "Distance";
            // 
            // rdoFromFeet
            // 
            this.rdoFromFeet.AutoSize = true;
            this.rdoFromFeet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoFromFeet.Location = new System.Drawing.Point(14, 118);
            this.rdoFromFeet.Name = "rdoFromFeet";
            this.rdoFromFeet.Size = new System.Drawing.Size(50, 21);
            this.rdoFromFeet.TabIndex = 3;
            this.rdoFromFeet.TabStop = true;
            this.rdoFromFeet.Text = "Feet";
            this.rdoFromFeet.UseVisualStyleBackColor = true;
            // 
            // rdoFromMeters
            // 
            this.rdoFromMeters.AutoSize = true;
            this.rdoFromMeters.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoFromMeters.Location = new System.Drawing.Point(14, 91);
            this.rdoFromMeters.Name = "rdoFromMeters";
            this.rdoFromMeters.Size = new System.Drawing.Size(67, 21);
            this.rdoFromMeters.TabIndex = 2;
            this.rdoFromMeters.TabStop = true;
            this.rdoFromMeters.Text = "Meters";
            this.rdoFromMeters.UseVisualStyleBackColor = true;
            // 
            // rdoFromMiles
            // 
            this.rdoFromMiles.AutoSize = true;
            this.rdoFromMiles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoFromMiles.Location = new System.Drawing.Point(14, 64);
            this.rdoFromMiles.Name = "rdoFromMiles";
            this.rdoFromMiles.Size = new System.Drawing.Size(57, 21);
            this.rdoFromMiles.TabIndex = 1;
            this.rdoFromMiles.TabStop = true;
            this.rdoFromMiles.Text = "Miles";
            this.rdoFromMiles.UseVisualStyleBackColor = true;
            // 
            // rdoFromKilometers
            // 
            this.rdoFromKilometers.AutoSize = true;
            this.rdoFromKilometers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoFromKilometers.Location = new System.Drawing.Point(14, 34);
            this.rdoFromKilometers.Name = "rdoFromKilometers";
            this.rdoFromKilometers.Size = new System.Drawing.Size(88, 21);
            this.rdoFromKilometers.TabIndex = 0;
            this.rdoFromKilometers.TabStop = true;
            this.rdoFromKilometers.Text = "Kilometers";
            this.rdoFromKilometers.UseVisualStyleBackColor = true;
            // 
            // grpToTemperature
            // 
            this.grpToTemperature.Controls.Add(this.rdoToFahrenheit);
            this.grpToTemperature.Controls.Add(this.rdoToCelsius);
            this.grpToTemperature.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.grpToTemperature.Location = new System.Drawing.Point(259, 226);
            this.grpToTemperature.Name = "grpToTemperature";
            this.grpToTemperature.Size = new System.Drawing.Size(133, 90);
            this.grpToTemperature.TabIndex = 7;
            this.grpToTemperature.TabStop = false;
            this.grpToTemperature.Text = "Temperature";
            this.grpToTemperature.Enter += new System.EventHandler(this.grpToTemperature_Enter);
            // 
            // rdoToFahrenheit
            // 
            this.rdoToFahrenheit.AutoSize = true;
            this.rdoToFahrenheit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoToFahrenheit.Location = new System.Drawing.Point(14, 64);
            this.rdoToFahrenheit.Name = "rdoToFahrenheit";
            this.rdoToFahrenheit.Size = new System.Drawing.Size(86, 21);
            this.rdoToFahrenheit.TabIndex = 1;
            this.rdoToFahrenheit.TabStop = true;
            this.rdoToFahrenheit.Text = "Fahrenheit";
            this.rdoToFahrenheit.UseVisualStyleBackColor = true;
            this.rdoToFahrenheit.CheckedChanged += new System.EventHandler(this.rdoToFahrenheit_CheckedChanged);
            // 
            // rdoToCelsius
            // 
            this.rdoToCelsius.AutoSize = true;
            this.rdoToCelsius.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoToCelsius.Location = new System.Drawing.Point(14, 34);
            this.rdoToCelsius.Name = "rdoToCelsius";
            this.rdoToCelsius.Size = new System.Drawing.Size(66, 21);
            this.rdoToCelsius.TabIndex = 0;
            this.rdoToCelsius.TabStop = true;
            this.rdoToCelsius.Text = "Celsius";
            this.rdoToCelsius.UseVisualStyleBackColor = true;
            this.rdoToCelsius.CheckedChanged += new System.EventHandler(this.rdoToCelsius_CheckedChanged);
            // 
            // grpToWeight
            // 
            this.grpToWeight.Controls.Add(this.rdoToOunces);
            this.grpToWeight.Controls.Add(this.rdoToGrams);
            this.grpToWeight.Controls.Add(this.rdoToPounds);
            this.grpToWeight.Controls.Add(this.rdoToKilograms);
            this.grpToWeight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.grpToWeight.Location = new System.Drawing.Point(398, 226);
            this.grpToWeight.Name = "grpToWeight";
            this.grpToWeight.Size = new System.Drawing.Size(133, 148);
            this.grpToWeight.TabIndex = 8;
            this.grpToWeight.TabStop = false;
            this.grpToWeight.Text = "Weight";
            // 
            // rdoToOunces
            // 
            this.rdoToOunces.AutoSize = true;
            this.rdoToOunces.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoToOunces.Location = new System.Drawing.Point(14, 118);
            this.rdoToOunces.Name = "rdoToOunces";
            this.rdoToOunces.Size = new System.Drawing.Size(69, 21);
            this.rdoToOunces.TabIndex = 3;
            this.rdoToOunces.TabStop = true;
            this.rdoToOunces.Text = "Ounces";
            this.rdoToOunces.UseVisualStyleBackColor = true;
            // 
            // rdoToGrams
            // 
            this.rdoToGrams.AutoSize = true;
            this.rdoToGrams.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoToGrams.Location = new System.Drawing.Point(14, 91);
            this.rdoToGrams.Name = "rdoToGrams";
            this.rdoToGrams.Size = new System.Drawing.Size(64, 21);
            this.rdoToGrams.TabIndex = 2;
            this.rdoToGrams.TabStop = true;
            this.rdoToGrams.Text = "Grams";
            this.rdoToGrams.UseVisualStyleBackColor = true;
            // 
            // rdoToPounds
            // 
            this.rdoToPounds.AutoSize = true;
            this.rdoToPounds.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoToPounds.Location = new System.Drawing.Point(14, 64);
            this.rdoToPounds.Name = "rdoToPounds";
            this.rdoToPounds.Size = new System.Drawing.Size(69, 21);
            this.rdoToPounds.TabIndex = 1;
            this.rdoToPounds.TabStop = true;
            this.rdoToPounds.Text = "Pounds";
            this.rdoToPounds.UseVisualStyleBackColor = true;
            // 
            // rdoToKilograms
            // 
            this.rdoToKilograms.AutoSize = true;
            this.rdoToKilograms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoToKilograms.Location = new System.Drawing.Point(14, 34);
            this.rdoToKilograms.Name = "rdoToKilograms";
            this.rdoToKilograms.Size = new System.Drawing.Size(85, 21);
            this.rdoToKilograms.TabIndex = 0;
            this.rdoToKilograms.TabStop = true;
            this.rdoToKilograms.Text = "Kilograms";
            this.rdoToKilograms.UseVisualStyleBackColor = true;
            // 
            // grpToDistance
            // 
            this.grpToDistance.Controls.Add(this.rdoToFeet);
            this.grpToDistance.Controls.Add(this.rdoToMeters);
            this.grpToDistance.Controls.Add(this.rdoToMiles);
            this.grpToDistance.Controls.Add(this.rdoToKilometers);
            this.grpToDistance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.grpToDistance.Location = new System.Drawing.Point(537, 226);
            this.grpToDistance.Name = "grpToDistance";
            this.grpToDistance.Size = new System.Drawing.Size(133, 148);
            this.grpToDistance.TabIndex = 9;
            this.grpToDistance.TabStop = false;
            this.grpToDistance.Text = "Distance";
            // 
            // rdoToFeet
            // 
            this.rdoToFeet.AutoSize = true;
            this.rdoToFeet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoToFeet.Location = new System.Drawing.Point(14, 118);
            this.rdoToFeet.Name = "rdoToFeet";
            this.rdoToFeet.Size = new System.Drawing.Size(50, 21);
            this.rdoToFeet.TabIndex = 3;
            this.rdoToFeet.TabStop = true;
            this.rdoToFeet.Text = "Feet";
            this.rdoToFeet.UseVisualStyleBackColor = true;
            // 
            // rdoToMeters
            // 
            this.rdoToMeters.AutoSize = true;
            this.rdoToMeters.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoToMeters.Location = new System.Drawing.Point(14, 91);
            this.rdoToMeters.Name = "rdoToMeters";
            this.rdoToMeters.Size = new System.Drawing.Size(67, 21);
            this.rdoToMeters.TabIndex = 2;
            this.rdoToMeters.TabStop = true;
            this.rdoToMeters.Text = "Meters";
            this.rdoToMeters.UseVisualStyleBackColor = true;
            // 
            // rdoToMiles
            // 
            this.rdoToMiles.AutoSize = true;
            this.rdoToMiles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoToMiles.Location = new System.Drawing.Point(14, 64);
            this.rdoToMiles.Name = "rdoToMiles";
            this.rdoToMiles.Size = new System.Drawing.Size(57, 21);
            this.rdoToMiles.TabIndex = 1;
            this.rdoToMiles.TabStop = true;
            this.rdoToMiles.Text = "Miles";
            this.rdoToMiles.UseVisualStyleBackColor = true;
            // 
            // rdoToKilometers
            // 
            this.rdoToKilometers.AutoSize = true;
            this.rdoToKilometers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoToKilometers.Location = new System.Drawing.Point(14, 34);
            this.rdoToKilometers.Name = "rdoToKilometers";
            this.rdoToKilometers.Size = new System.Drawing.Size(88, 21);
            this.rdoToKilometers.TabIndex = 0;
            this.rdoToKilometers.TabStop = true;
            this.rdoToKilometers.Text = "Kilometers";
            this.rdoToKilometers.UseVisualStyleBackColor = true;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTo.Location = new System.Drawing.Point(41, 226);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(199, 23);
            this.lblTo.TabIndex = 10;
            this.lblTo.Text = "Select unit to convert to:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFrom.Location = new System.Drawing.Point(20, 63);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(220, 23);
            this.lblFrom.TabIndex = 11;
            this.lblFrom.Text = "Select unit to convert from:";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConvert.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnConvert.FlatAppearance.BorderSize = 3;
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConvert.Location = new System.Drawing.Point(117, 379);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(123, 77);
            this.btnConvert.TabIndex = 12;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(130, 476);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 36);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblConvertedUnit
            // 
            this.lblConvertedUnit.AutoSize = true;
            this.lblConvertedUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblConvertedUnit.Location = new System.Drawing.Point(455, 409);
            this.lblConvertedUnit.Name = "lblConvertedUnit";
            this.lblConvertedUnit.Size = new System.Drawing.Size(13, 20);
            this.lblConvertedUnit.TabIndex = 14;
            this.lblConvertedUnit.Text = " ";
            this.lblConvertedUnit.Click += new System.EventHandler(this.lblConvertedUnit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 556);
            this.Controls.Add(this.lblConvertedUnit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.grpToDistance);
            this.Controls.Add(this.grpToWeight);
            this.Controls.Add(this.grpToTemperature);
            this.Controls.Add(this.grpFromDistance);
            this.Controls.Add(this.grpFromWeight);
            this.Controls.Add(this.grpFromTemperature);
            this.Controls.Add(this.txtConvertedUnit);
            this.Controls.Add(this.txtEnterUnit);
            this.Controls.Add(this.lblEnterUnit);
            this.Name = "frmMain";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpFromTemperature.ResumeLayout(false);
            this.grpFromTemperature.PerformLayout();
            this.grpFromWeight.ResumeLayout(false);
            this.grpFromWeight.PerformLayout();
            this.grpFromDistance.ResumeLayout(false);
            this.grpFromDistance.PerformLayout();
            this.grpToTemperature.ResumeLayout(false);
            this.grpToTemperature.PerformLayout();
            this.grpToWeight.ResumeLayout(false);
            this.grpToWeight.PerformLayout();
            this.grpToDistance.ResumeLayout(false);
            this.grpToDistance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEnterUnit;
        private TextBox txtEnterUnit;
        private TextBox txtConvertedUnit;
        private GroupBox grpFromTemperature;
        private RadioButton rdoFromFahrenheit;
        private RadioButton rdoFromCelsius;
        private GroupBox grpFromWeight;
        private RadioButton rdoFromOunces;
        private RadioButton rdoFromGrams;
        private RadioButton rdoFromPounds;
        private RadioButton rdoFromKilograms;
        private GroupBox grpFromDistance;
        private RadioButton rdoFromFeet;
        private RadioButton rdoFromMeters;
        private RadioButton rdoFromMiles;
        private RadioButton rdoFromKilometers;
        private GroupBox grpToTemperature;
        private RadioButton rdoToFahrenheit;
        private RadioButton rdoToCelsius;
        private GroupBox grpToWeight;
        private RadioButton rdoToOunces;
        private RadioButton rdoToGrams;
        private RadioButton rdoToPounds;
        private RadioButton rdoToKilograms;
        private GroupBox grpToDistance;
        private RadioButton rdoToFeet;
        private RadioButton rdoToMeters;
        private RadioButton rdoToMiles;
        private RadioButton rdoToKilometers;
        private Label lblTo;
        private Label lblFrom;
        private Button btnConvert;
        private Button btnClear;
        private Label lblConvertedUnit;
    }
}