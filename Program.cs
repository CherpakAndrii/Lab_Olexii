using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Курсова
{
    static class Program
    {
        public static List<int> InputedArray = new List<int>();
        public static bool IsClosedByUser = true;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InputForm());
        }
    }
}