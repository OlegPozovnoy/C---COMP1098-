using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

    namespace JSONSplitExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                WebClient client = new WebClient();
                string JSONStrng = client.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=" + textBoxName.Text.Trim() + "&appid=4e95068af1e64f2308f531b1c388a510");
                dynamic t = JsonConvert.DeserializeObject(JSONStrng);

                textBoxName.Text = t["name"];
                textBoxWeather.Text = t["weather"][0]["description"];
                textBoxTemperature.Text =(t["main"]["temp"] - 273.15) + " C" ;
                textBoxPressure.Text = t["main"]["pressure"] + " hpa";
                textBoxHumidity.Text = t["main"]["humidity"] + "%";
                textBoxCountry.Text = t["sys"]["country"];
                textBoxSunrise.Text  = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).AddSeconds((double)t["sys"]["sunrise"]).ToLocalTime().ToString();
                textBoxSunset.Text = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).AddSeconds((double)t["sys"]["sunset"]).ToLocalTime().ToString();
                labelError.Text = "";

            } catch (Exception exc)
            {
                labelError.Text = exc.StackTrace.ToString() +"\n" + exc.Message;

            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
