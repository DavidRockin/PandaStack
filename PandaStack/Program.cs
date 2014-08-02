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

        public static PandaStack PandaStack;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Program.IsAdministrator())
            {
                Program.LaunchAsAdmin();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Program.PandaStack = new PandaStack();
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
        public static bool IsAdministrator()
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
        private static void LaunchAsAdmin()
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
                // Application didn't run as administrator
            }

            Application.Exit();
        }

    }

}
