using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMOServer.Util
{
    /// <summary>
    /// Represents the logger
    /// </summary>
    public sealed class Logger
    {
        private Logger() { }

        /// <summary>
        /// Logs an object with a written message to the console
        /// </summary>
        /// <param name="obj">Object</param>
        /// <param name="message">Message</param>
        public static void Log(object obj, object message) 
            => Log(obj.ToString(), message);

        /// <summary>
        /// Logs an object name or given name with a written message to the console
        /// </summary>
        /// <param name="objName">Name</param>
        /// <param name="message">Message</param>
        public static void Log(string objName, object message) 
            => Console.WriteLine($"[{objName}] {message.ToString()}");
    }
}
