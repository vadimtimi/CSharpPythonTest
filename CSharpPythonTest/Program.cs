using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSharpPythonTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            { 
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }
            catch(Exception err)
            {
                MessageBox.Show(err.StackTrace);
            }
        }
    }
}
