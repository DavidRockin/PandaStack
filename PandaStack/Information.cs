using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace PandaStack
{

    class Information
    {

        public static frmMain form;

        public static void addMessage(string message)
        {
            Information.addMessage(message, InfoType.Info);
        }

        public static void addMessage(string message, InfoType type)
        {
            String msg = "[" + DateTime.Now.ToShortTimeString() + "] [" + type.ToString() + "] " + message + "\r\n";
            Information.form.rtbConsole.Text += msg;
        }

        public static void addMessage(string[] messages)
        {
            foreach (String message in messages)
            {
                Information.addMessage(message, InfoType.Info);
            }
        }

        public static void addMessage(string[] messages, InfoType type)
        {
            foreach (String message in messages)
            {
                Information.addMessage(message, type);
            }
        }

        public static void clearMessages()
        {
            Information.form.rtbConsole.Clear();
        }

        public static void handleException(Exception ex)
        {
            StackTrace stackTrace = new StackTrace(ex, true);
            StackFrame stackFrame = stackTrace.GetFrame(0);
            string message = ex.Message + " " + ex.InnerException + "\r\n" + stackFrame.GetFileName() + ":" +
                                stackFrame.GetFileLineNumber() + " -> " + stackFrame.GetMethod();
            Information.addMessage(message, InfoType.Exception);
        }

    }

}
