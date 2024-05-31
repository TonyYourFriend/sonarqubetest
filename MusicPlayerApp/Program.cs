using MusicPlayerApp.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public static class Program
    {
        public static IApplication ApplicationWrapper { get; set; } = new ApplicationWrapper();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            ApplicationWrapper.EnableVisualStyles();
            ApplicationWrapper.SetCompatibleTextRenderingDefault(false);
            ApplicationWrapper.Run(new MusicPlayerApp());
        }
    }
}