using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int uselessIInt = 5;
            int uselessIInt = 5;
            int uselessIInt = 5;
            for(int i= 0; i < 5; i++){
                Console.WriteLine(i);
            }
            for(int i= 0; i < 5; i++){
                Console.WriteLine(i);
            }
            Console.WriteLine(uselessIInt);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MusicPlayerApp());
        }
    }
}
