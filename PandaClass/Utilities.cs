using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using System.Diagnostics;

namespace DavidRockin.PandaStack.PandaClass
{
    public static class Utilities
    {
        /**
        * <summary>
        * Check to see if PandaStack is running as administrator
        * </summary>
        * <returns>
        * Returns true if it ran with administrator privileges, false if otherwise
        * </returns>
        */
        public static bool RunningAsAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
