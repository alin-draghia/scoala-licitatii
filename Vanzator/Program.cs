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
        public static LicitatiiContext Context { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var ctx = new LicitatiiContext())
            {

                //ctx.Configuration.ProxyCreationEnabled = false;
                Context = ctx;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var formularAutentificare = new FormularAutentificare();
                var rezultatAutenficare = formularAutentificare.ShowDialog();
                if (rezultatAutenficare == DialogResult.OK)
                {
                    Application.Run(new FormVanzator());
                }
                //Application.Run();
                //Application.Run(new Form1());
            }
        }
    }
}
