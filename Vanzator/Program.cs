using LicitatiiDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vanzator
{
    static class Program
    {

        public static LicitatiiDAL.Vanzator Vanzator { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var formularAutentificare = new FormularAutentificare();
            var rezultatAutenficare = formularAutentificare.ShowDialog();

            //Application.Run();
            //Application.Run(new Form1());
        }
    }
}
