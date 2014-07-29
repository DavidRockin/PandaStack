using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PandaStack
{

    static class Program
    {

        public static PandaStack pandaStack;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Program.pandaStack = new PandaStack();
            Application.Run(new frmMain());
        }

    }

}
