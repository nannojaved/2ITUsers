using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2ITUsers
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
            Application.Run(new Profile());
        }
    }
}

// forklare at dette er main entry point for the application
// Application.Run(new Form1());
/*
 * forklar keywords: namespace, System, internal, static, void 
*/