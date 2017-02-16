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
            KettleServer server = new KettleServer(new System.Net.IPEndPoint(System.Net.IPAddress.Any, 9001));
            server.Enter();
        }
    }
}