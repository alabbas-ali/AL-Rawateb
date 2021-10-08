using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AL_Rawateb
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DateTime now_ = DateTime.Now;
            //DateTime now_date = new DateTime(now_.Year, now_.Month, now_.Day);
            //DateTime mydate = new DateTime(2012, 3, 15);

            //if (now_date.CompareTo(mydate) < 0)
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Master_form());
            //}
            //else
            //{
             //   MessageBox.Show("you Have a problem with your Application!!! \n you Application is out of date!!", "Failed to Run!!");
            //}
        }
    }
}
