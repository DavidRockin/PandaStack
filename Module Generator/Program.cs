using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace DavidRockin.PandaStack.ModuleGenerator
{
    static class Program
    {

        public static PandaStack PandaStack;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Check if the PandaClass.dll exists, perhaps we should also make sure it
            // is registered for PandaStack to use?
            if (!File.Exists("PandaClass.dll"))
            {
                MessageBox.Show("PandaClass.dll is required for PandaStack", "PandaStack Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.PandaStack = new PandaStack();
            Application.Run(new frmMain());
        }
    }
}
