using JMOServer.Net;
using JMOServer.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMOServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Log(typeof(Program), $"Starting server {Settings.SERVER_NAME}:{Settings.PORT}");
            new GameServer().InitiateServer();

            Console.ReadKey();
        }
    }
}
