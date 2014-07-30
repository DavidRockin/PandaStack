using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Security.Principal;
using System.Diagnostics;

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
            if (!Program.isAdministrator())
                Program.launchAsAdmin();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Program.pandaStack = new PandaStack();
            Application.Run(new frmMain());
        }

        /**
         * <summary>
         * Check to see if PandaStack is running as administrator
         * </summary>
         * <returns>
         * Returns true if it ran with administrator privileges
         * </returns>
         */
        public static bool isAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        /**
         * <summary>
         * Attempt to restart PandaStack as an administrator
         * </summary>
         */
        private static void launchAsAdmin()
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.WorkingDirectory = Environment.CurrentDirectory;
            proc.FileName = Application.ExecutablePath;
            proc.Verb = "runas";

            try
            {
                Process.Start(proc);
            }
            catch
            {
                // Let the user know that PandaStack requires to run as an administrator
                DialogResult msg = MessageBox.Show("PandaStack requires administrator privileges, please relaunch PandaStack as an administrator, otherwise you will not be able to carry out certain actions.", "Admin Rights required", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);

                if (msg == DialogResult.Retry)
                {
                    Program.launchAsAdmin();
                }
                else if (msg == DialogResult.Ignore)
                {
                    return;
                }
            }

            Application.Exit();
        }

    }

}
