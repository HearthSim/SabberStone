#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using SabberStoneKettle;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SabberStoneKettleClient
{
	class KettleClientServer
	{
		private Socket Listener;

		public KettleClientServer(IPEndPoint address)
		{

			Listener = new Socket(SocketType.Stream, ProtocolType.IP);
			Listener.Bind(address);
			Listener.Listen(32);
			Console.WriteLine("Listening on socket.");
			Console.WriteLine("AI Client.");
		}

		public void OnStartClient(KettleStartClient StartClient)
		{
			// and then we start a new session in a new thread
			var session = new KettleAISession(StartClient);
			new Thread(session.Enter).Start();
		}

		public void Enter()
		{
			// We wait until someone connects to this server

			while (true)
			{
				Socket gameserver = Listener.Accept();
				KettleAdapter gameadapter = new KettleAdapter(new NetworkStream(gameserver));
				gameadapter.OnStartClient += OnStartClient;

				try
				{
					while (true)
					{
						if (!gameadapter.HandleNextPacket())
						{
							Console.WriteLine("Kettle AI server ended.");
							break;
						}
					}
				}
				catch (IOException)
				{
					Console.WriteLine("Connection closed");
				}
			}
		}
	}
}
