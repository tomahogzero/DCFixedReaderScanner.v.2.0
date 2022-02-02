using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

//namespace RFID3Test_PCApp
namespace DCRFIDReader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Check number of instances running:
            // If more than 1 instance, cancel this one.
            // Additionally, if it is the 2nd invocation, show a message and exit.
            var numberOfAppInstances = Assembly.GetExecutingAssembly().HowManyTimesIsAssemblyRunning();
            if (numberOfAppInstances == 2)
            {
                return;
                //MessageBox.Show("The application is already running!" + "\nClick OK to close this dialog, then switch to the application by using WIN + TAB keys.",
                // "RFID App", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
            if (numberOfAppInstances >= 2)
            {
                return;
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenu());
        }
    }
}