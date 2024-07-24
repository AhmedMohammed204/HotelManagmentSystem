using MyClassLibrary;
using PrecentationLayer.Reservations;
using System;
using System.Windows.Forms;
using UsersBusinessLayer;

namespace PrecentationLayer
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
            Application.Run(new Login());
        }
    }
}
