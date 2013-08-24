using LicitatiiDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cumparator
{
    static class Program
    {

        public static LicitatiiDAL.Cumparator Cumparator { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var ctx = new LicitatiiContext())
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var formAuth = new FormAutentificare();
                var ret = formAuth.ShowDialog();
                if (ret == DialogResult.OK)
                {
                    Application.Run(new FormCumparator());
                }
            }

            
        }
    }
}
