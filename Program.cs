using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XO_Game_Final.Properties;

namespace XO_Game_Final
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string SavedLanguage = Settings.Default.Language;

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(SavedLanguage);
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(SavedLanguage);

            Application.Run(new Form1());
        }
    }
}
