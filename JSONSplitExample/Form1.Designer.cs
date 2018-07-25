namespace JSONSplitExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxWeather = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelWeather = new System.Windows.Forms.Label();
            this.labelTemperaature = new System.Windows.Forms.Label();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.textBoxPressure = new System.Windows.Forms.TextBox();
            this.labelPressure = new System.Windows.Forms.Label();
            this.textBoxHumidity = new System.Windows.Forms.TextBox();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxSunrise = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSunset = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(193, 103);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(228, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxWeather
            // 
            this.textBoxWeather.Location = new System.Drawing.Point(193, 169);
            this.textBoxWeather.Name = "textBoxWeather";
            this.textBoxWeather.ReadOnly = true;
            this.textBoxWeather.Size = new System.Drawing.Size(228, 20);
            this.textBoxWeather.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "GetTheWeather";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(87, 110);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Enter the city Name";
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.Location = new System.Drawing.Point(87, 176);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(48, 13);
            this.labelWeather.TabIndex = 4;
            this.labelWeather.Text = "Weather";
            // 
            // labelTemperaature
            // 
            this.labelTemperaature.AutoSize = true;
            this.labelTemperaature.Location = new System.Drawing.Point(87, 209);
            this.labelTemperaature.Name = "labelTemperaature";
            this.labelTemperaature.Size = new System.Drawing.Size(67, 13);
            this.labelTemperaature.TabIndex = 5;
            this.labelTemperaature.Text = "Temperature";
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Location = new System.Drawing.Point(193, 202);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.ReadOnly = true;
            this.textBoxTemperature.Size = new System.Drawing.Size(228, 20);
            this.textBoxTemperature.TabIndex = 6;
            // 
            // textBoxPressure
            // 
            this.textBoxPressure.Location = new System.Drawing.Point(193, 235);
            this.textBoxPressure.Name = "textBoxPressure";
            this.textBoxPressure.ReadOnly = true;
            this.textBoxPressure.Size = new System.Drawing.Size(228, 20);
            this.textBoxPressure.TabIndex = 8;
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Location = new System.Drawing.Point(87, 242);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(48, 13);
            this.labelPressure.TabIndex = 7;
            this.labelPressure.Text = "Pressure";
            // 
            // textBoxHumidity
            // 
            this.textBoxHumidity.Location = new System.Drawing.Point(193, 268);
            this.textBoxHumidity.Name = "textBoxHumidity";
            this.textBoxHumidity.ReadOnly = true;
            this.textBoxHumidity.Size = new System.Drawing.Size(228, 20);
            this.textBoxHumidity.TabIndex = 10;
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Location = new System.Drawing.Point(87, 275);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(47, 13);
            this.labelHumidity.TabIndex = 9;
            this.labelHumidity.Text = "Humidity";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(89, 378);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Country";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(193, 136);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.ReadOnly = true;
            this.textBoxCountry.Size = new System.Drawing.Size(228, 20);
            this.textBoxCountry.TabIndex = 12;
            // 
            // textBoxSunrise
            // 
            this.textBoxSunrise.Location = new System.Drawing.Point(193, 301);
            this.textBoxSunrise.Name = "textBoxSunrise";
            this.textBoxSunrise.ReadOnly = true;
            this.textBoxSunrise.Size = new System.Drawing.Size(228, 20);
            this.textBoxSunrise.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sunrise (UTC)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxSunset
            // 
            this.textBoxSunset.Location = new System.Drawing.Point(193, 334);
            this.textBoxSunset.Name = "textBoxSunset";
            this.textBoxSunset.ReadOnly = true;
            this.textBoxSunset.Size = new System.Drawing.Size(228, 20);
            this.textBoxSunset.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sunset (UTC)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 432);
            this.Controls.Add(this.textBoxSunset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSunrise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxHumidity);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.textBoxPressure);
            this.Controls.Add(this.labelPressure);
            this.Controls.Add(this.textBoxTemperature);
            this.Controls.Add(this.labelTemperaature);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxWeather);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "GetCurrentWeather";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxWeather;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWeather;
        private System.Windows.Forms.Label labelTemperaature;
        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.TextBox textBoxPressure;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.TextBox textBoxHumidity;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxSunrise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSunset;
        private System.Windows.Forms.Label label3;
    }
}

