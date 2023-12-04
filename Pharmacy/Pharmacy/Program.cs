using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;


namespace Pharmacy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            bool result;
            var mutex = new System.Threading.Mutex(true, "UniqueAppId", out result);

            if (!result)
            {
                MessageBox.Show("Another instance is already running.");
                return;
            }

            Application.Run(new frmUserLogin());

            GC.KeepAlive(mutex);
        }
        
    }    

    public class dateObject
    {
        public string strDate;

        public dateObject()
        {
            DateTime dtnow = DateTime.Now;
            strDate = string.Format("{0:MMM_yyyy}", dtnow);

        }

        public dateObject(string strChangeDate)
        {
            DateTime dt = Convert.ToDateTime(strChangeDate);
            strDate = string.Format("{0:yyyyMMdd}", dt);
        }

        public void SetCurrentDate(string strCurrentDate)
        {
            DateTime dtnow = DateTime.Now;

            if (strCurrentDate == "GetCurrentTime12AM")
            { strDate = string.Format("{0:dd-MM-yyyy H:mm:ss}", dtnow); }
            else
            { strDate = string.Format("{0:MM/dd/yyyy H:mm tt}", dtnow); }
        }

    }
}
