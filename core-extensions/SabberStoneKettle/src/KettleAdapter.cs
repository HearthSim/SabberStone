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
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace SabberStoneKettle
{
	public class KettleAdapter
	{
		private NetworkStream Stream;
		private BinaryWriter Writer;

		// Handlers for each packet type
		public delegate void OnCreateGameDelegate(KettleCreateGame CreateGame);
		public delegate void OnConcedeDelegate(int Concede);
		public delegate void OnSendOptionDelegate(KettleSendOption SendOption);
		public delegate void OnChooseEntitiesDelegate(KettleChooseEntities ChooseEntities);
		public delegate void OnGameJoinedDelegate(KettleGameJoined GameJoined);
		public delegate void OnEntityChoicesDelegate(KettleEntityChoices EntityChoices);
		public delegate void OnEntitiesChosenDelegate(KettleEntitiesChosen EntitiesChosen);
		public delegate void OnOptionsBlockDelegate(KettleOptionsBlock OptionsBlock);
		public delegate void OnUserUIDelegate(KettleUserUI UserUI);
		public delegate void OnJoinGameDelegate(KettleJoinGame JoinGame);
		public delegate void OnStartClientDelegate(KettleStartClient JoinGame);
		public delegate void OnHistoryDelegate(List<KettleHistoryEntry> History);

		public OnCreateGameDelegate OnCreateGame;
		public OnConcedeDelegate OnConcede;
		public OnSendOptionDelegate OnSendOption;
		public OnChooseEntitiesDelegate OnChooseEntities;
		public OnGameJoinedDelegate OnGameJoined;
		public OnEntityChoicesDelegate OnEntityChoices;
		public OnEntitiesChosenDelegate OnEntitiesChosen;
		public OnOptionsBlockDelegate OnOptionsBlock;
		public OnUserUIDelegate OnUserUI;
		public OnJoinGameDelegate OnJoinGame;
		public OnStartClientDelegate OnStartClient;
		public OnHistoryDelegate OnHistory;

		public KettleAdapter(NetworkStream stream)
		{
			Stream = stream;
			Writer = new BinaryWriter(Stream);
		}

		// returns true if the handle was successfull
		public bool HandleNextPacket()
		{
			try
			{
				// read the int saying how much data we will receive
				byte[] intbuffer = new byte[4];
				if (!ReadBytes(intbuffer, 0, 4))
					return false;

				int length = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(intbuffer, 0));
				Console.WriteLine("Read length:" + length);

				// now read the actual payload
				byte[] pbuffer = new byte[length];
				if (!ReadBytes(pbuffer, 0, length))
					return false;

				// convert the buffer to a string
				String payload = System.Text.Encoding.UTF8.GetString(pbuffer);
				Console.WriteLine("Read data:" + payload);

				// make a json array from it
				JArray jpayload = JArray.Parse(payload);

				// and parse each object in the array
				HandlePacket(jpayload);

				return true;
			}
			catch (SocketException)
			{
				return false;
			}
		}

		private bool ReadBytes(byte[] buffer, int offset, int count)
		{
			while (count > 0)
			{
				int read = Stream.Read(buffer, offset, count);

				if (read == 0)
					return false;

				count -= read;
				offset += read;
			}

			return true;
		}

		private void HandlePacket(JArray jpacket)
		{
			String type = (String)jpacket[0]["Type"];

			if (type == "Concede")
			{
				OnConcede(((JValue)jpacket[0][type]).Value<int>());
				return;
			}

			JObject obj = (JObject)jpacket[0][type];

			Console.WriteLine("Received packet of type: " + type);

			/*        
        public OnCreateGameDelegate OnCreateGame;
        public OnConcedeDelegate OnConcede;
        public OnSendOptionDelegate OnSendOption;
        public OnChooseEntitiesDelegate OnChooseEntities;
        public OnGameJoinedDelegate OnGameJoined;
        public OnEntityChoicesDelegate OnEntityChoices;
        public OnEntitiesChosenDelegate OnEntitiesChosen;
        public OnOptionsBlockDelegate OnOptionsBlock;
        public OnUserUIDelegate OnUserUI;
        public OnHistoryDelegate OnHistory;*/

			switch (type)
			{
				case KettleCreateGame.KettleName:
					OnCreateGame(obj.ToObject<KettleCreateGame>());
					break;
				case KettleSendOption.KettleName:
					OnSendOption(obj.ToObject<KettleSendOption>());
					break;
				case KettleChooseEntities.KettleName:
					OnChooseEntities(obj.ToObject<KettleChooseEntities>());
					break;
				case KettleGameJoined.KettleName:
					OnGameJoined(obj.ToObject<KettleGameJoined>());
					break;
				case KettleEntityChoices.KettleName:
					OnEntityChoices(obj.ToObject<KettleEntityChoices>());
					break;
				case KettleEntitiesChosen.KettleName:
					OnEntitiesChosen(obj.ToObject<KettleEntitiesChosen>());
					break;
				case KettleOptionsBlock.KettleName:
					OnOptionsBlock(obj.ToObject<KettleOptionsBlock>());
					break;
				case KettleUserUI.KettleName:
					OnUserUI(obj.ToObject<KettleUserUI>());
					break;
				case KettleJoinGame.KettleName:
					OnJoinGame(obj.ToObject<KettleJoinGame>());
					break;
				case KettleStartClient.KettleName:
					OnStartClient(obj.ToObject<KettleStartClient>());
					break;
				case KettleHistoryBlockBegin.KettleName:
				case KettleHistoryBlockEnd.KettleName:
				case KettleHistoryChangeEntity.KettleName:
				case KettleHistoryCreateGame.KettleName:
				case KettleHistoryFullEntity.KettleName:
				case KettleHistoryHideEntity.KettleName:
				case KettleHistoryShowEntity.KettleName:
				case KettleHistoryTagChange.KettleName:
				case KettleHistoryMetaData.KettleName:
					var history = jpacket.AsEnumerable().Select(packet =>
					{
						string ptype = (String)packet["Type"];
						switch (ptype)
						{
							case KettleHistoryBlockBegin.KettleName:
								return (KettleHistoryEntry)packet[ptype].ToObject<KettleHistoryBlockBegin>();
							case KettleHistoryBlockEnd.KettleName:
								return packet[ptype].ToObject<KettleHistoryBlockEnd>();
							case KettleHistoryChangeEntity.KettleName:
								return packet[ptype].ToObject<KettleHistoryChangeEntity>();
							case KettleHistoryCreateGame.KettleName:
								return packet[ptype].ToObject<KettleHistoryCreateGame>();
							case KettleHistoryFullEntity.KettleName:
								return packet[ptype].ToObject<KettleHistoryFullEntity>();
							case KettleHistoryHideEntity.KettleName:
								return packet[ptype].ToObject<KettleHistoryHideEntity>();
							case KettleHistoryShowEntity.KettleName:
								return packet[ptype].ToObject<KettleHistoryShowEntity>();
							case KettleHistoryTagChange.KettleName:
								return packet[ptype].ToObject<KettleHistoryTagChange>();
							case KettleHistoryMetaData.KettleName:
								return packet[ptype].ToObject<KettleHistoryMetaData>();
							default:
								return null;
						}
					}).ToList();
					OnHistory(history);
					break;
				default:
					Console.WriteLine("Received unhandled packet:");
					Console.WriteLine(jpacket[0].ToString());
					break;
			}
		}

		private void SendPacket(JArray packet)
		{
			// Get the corresponding json string 
			String data = Newtonsoft.Json.JsonConvert.SerializeObject(packet);

			// first send the length of the data
			Writer.Write(IPAddress.HostToNetworkOrder(data.Length));


			// and then send the data
			Writer.Write(System.Text.Encoding.UTF8.GetBytes(data));
		}

		public void SendMessage(KettlePayload payload)
		{
			SendPacket(new JArray(payload.ToPayload()));
		}

		public void SendMessage(List<KettlePayload> payload)
		{
			List<JObject> message = new List<JObject>();

			foreach (KettlePayload p in payload)
				message.Add(p.ToPayload());

			SendPacket(new JArray(message));
		}
	}
}
