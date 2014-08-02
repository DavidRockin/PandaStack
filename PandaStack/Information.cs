using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace PandaStack
{

    public class Information
    {

        public static frmMain Form;

        public static void AddMessage(string message)
        {
            Information.AddMessage(message, InfoType.Info);
        }

        public static void AddMessage(string message, InfoType type)
        {
            if (type == InfoType.Debug && Program.PandaStack.GetJsonHandler().GetSettings().displayDebug != true)
                return;

            String msg = "[" + DateTime.Now.ToShortTimeString() + "] [" + type.ToString() + "] " + message + "\r\n";
            Information.Form.rtbConsole.Text += msg;
        }

        public static void AddMessage(string[] messages)
        {
            foreach (String message in messages)
            {
                Information.AddMessage(message, InfoType.Info);
            }
        }

        public static void AddMessage(string[] messages, InfoType type)
        {
            foreach (String message in messages)
            {
                Information.AddMessage(message, type);
            }
        }

        public static void HandleException(Exception ex)
        {
            StackTrace stackTrace = new StackTrace(ex, true);
            StackFrame stackFrame = stackTrace.GetFrame(0);
            string message = ex.Message + " " + ex.InnerException + "\r\n" + stackFrame.GetFileName() + ":" +
                                stackFrame.GetFileLineNumber() + " -> " + stackFrame.GetMethod();
            Information.AddMessage(message, InfoType.Exception);
        }

        public static void ClearMessages()
        {
            Information.Form.rtbConsole.Clear();
        }

    }

}
