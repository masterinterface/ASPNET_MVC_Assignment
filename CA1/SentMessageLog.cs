using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace CA1
{
    static class SentMessageLog
    {
        public static void outputToDebugConsole(string message)
        {
            Debug.WriteLine("Sent message: " + message);
        }   
    }
}