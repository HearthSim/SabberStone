using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace SabberStoneKettleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Invalid arguments, run as: SabberStoneKettleServer.exe PORT");
                return;
            }
            
            KettleServer server = new KettleServer(new System.Net.IPEndPoint(System.Net.IPAddress.Any, int.Parse(args[0])));
            server.Enter();
        }
    }
}