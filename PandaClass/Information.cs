using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DavidRockin.PandaStack.PandaClass
{
    public class Information
    {
        public static RichTextBox Console;
        public static Boolean ShowDebug = true;

        public static void AddMessage(string message, InfoType type)
        {
            // If the message type is debug, and we don't want debugging, skip
            if (type == InfoType.Debug && !Information.ShowDebug)
                return;

            // If a console was defined, we append messages to it, otherwise use messageboxes
            if (Information.Console != null)
            {
                Information.HandleConsoleMessage(message, type);
            }
            else
            {
                Information.HandleMessageBox(message, type);
            }
        }

        public static void AddMessage(string message)
        {
            Information.AddMessage(message, InfoType.Info);
        }

        public static void AddMessage(string[] messages, InfoType type)
        {
            foreach (string message in messages)
            {
                Information.AddMessage(message, type);
            }
        }

        public static void AddMessage(string[] messages)
        {
            Information.AddMessage(messages, InfoType.Info);
        }

        public static void ClearConsole()
        {
            if (Information.Console != null)
            {
                Information.Console.Clear();
            }
        }

        public static void HandleException(Exception ex)
        {
            StackTrace stackTrace = new StackTrace(ex, true);
            StackFrame stackFrame = stackTrace.GetFrame(0);
            string message = ex.Message + " " + ex.InnerException + "\r\n" + stackFrame.GetFileName() + ":" +
                                stackFrame.GetFileLineNumber() + " @ " + stackFrame.GetMethod();
            Information.AddMessage(message, InfoType.Exception);
        }

        private static void HandleConsoleMessage(string message, InfoType type)
        {
            String msg = "[" + DateTime.Now.ToShortTimeString() + "] [" + type.ToString() + "] " + message + "\r\n";
            Information.Console.Text += msg;
        }

        private static void HandleMessageBox(string message, InfoType type)
        {
            MessageBoxIcon icon = MessageBoxIcon.None;
            switch (type)
            {
                case InfoType.Debug:
                case InfoType.Info:
                    icon = MessageBoxIcon.Information;
                    break;
                case InfoType.Exception:
                case InfoType.Error:
                    icon = MessageBoxIcon.Error;
                    break;
                case InfoType.Important:
                case InfoType.Warning:
                    icon = MessageBoxIcon.Exclamation;
                    break;
            }
            MessageBox.Show(message, "PandaStack", MessageBoxButtons.OK, icon); 
        }

    }
}
