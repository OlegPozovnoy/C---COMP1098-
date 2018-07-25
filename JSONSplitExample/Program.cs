using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONSplitExample
{
    static class OlegPozovnoyJSON
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        //public static string JSONStrng = @"{ 'name' : 'Oleg' , 'email' : 'pozovnoy.oleg@gmail.com' }";

        [STAThread]
        static void Main()
        {

            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://samples.openweathermap.org/data/2.5/weather?q=London,uk&appid=b6907d289e10d714a6e88b30761fae22");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
