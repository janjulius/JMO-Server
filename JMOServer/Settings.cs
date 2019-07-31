using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMOServer
{
    /// <summary>
    /// Genral settings
    /// </summary>
    public sealed class Settings
    {
        /// <summary>
        /// Name of the server
        /// </summary>
        public static readonly string SERVER_NAME = "JMO";

        /// <summary>
        /// Port the server is running on
        /// </summary>
        public static readonly ushort PORT = 3534;

        /// <summary>
        /// Time it takes for the server to poll for new events in ms
        /// </summary>
        public static readonly int SERVER_CYCLE_TIME = 10;

        /// <summary>
        /// Max users allowed on the server at one time
        /// </summary>
        public static readonly int MAX_USERS = 100;

        /// <summary>
        /// Connection key required to establish a connection
        /// </summary>
        public static readonly string CONNECTION_KEY = "0721e5ae-8e62-45d5-995f-d225de67234c";

        private Settings()
        {

        }

       
    }
}
