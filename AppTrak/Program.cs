using System;
using System.Windows.Forms;
using AppTrak.Helpers;
using AppTrak.Models;
using AppTrak.Ui;

namespace AppTrak
{
    static class Program
    {
        public static OpportunityList Opportunities = new OpportunityList();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
