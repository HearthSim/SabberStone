using System;

namespace SabberStoneKettleClient
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length != 1)
			{
				Console.WriteLine("Invalid arguments, run as: SabberStoneKettleClient.exe PORT");
				return;
			}

			KettleClientServer server = new KettleClientServer(new System.Net.IPEndPoint(System.Net.IPAddress.Any, int.Parse(args[0])));
			server.Enter();
		}
	}
}