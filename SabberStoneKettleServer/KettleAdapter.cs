using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SabberStoneKettleServer
{
    class KettleAdapter
    {
        private NetworkStream Stream;
        private BinaryWriter Writer;

        // Handlers for each packet type
        public delegate void OnCreateGameDelegate(KettleCreateGame CreateGame);
        public delegate void OnConcedeDelegate(int Concede);
        public delegate void OnSendOptionDelegate(KettleSendOption SendOption);
        public delegate void OnChooseEntitiesDelegate(List<int> ChooseEntities);

        public OnCreateGameDelegate OnCreateGame;
        public OnConcedeDelegate OnConcede;
        public OnSendOptionDelegate OnSendOption;
        public OnChooseEntitiesDelegate OnChooseEntities;


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
                foreach (JObject obj in jpayload)
                    HandlePayload(obj);

                return true;
            } catch (SocketException)
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

        private void HandlePayload(JObject jpayload)
        {
            String type = (String)jpayload["Type"];
            JObject obj = (JObject)jpayload[type];

            Console.WriteLine("Received packet of type: " + type);

            switch (type)
            {
                case "CreateGame":
                    OnCreateGame(obj.ToObject<KettleCreateGame>());
                    break;
                case "Concede":
                    OnConcede(obj.ToObject<int>());
                    break;
                case "SendOption":
                    OnSendOption(obj.ToObject<KettleSendOption>());
                    break;
                case "ChooseEntities":
                    OnChooseEntities(obj.ToObject<List<int>>());
                    break;
                default:
                    Console.WriteLine("Received unhandled packet:");
                    Console.WriteLine(jpayload.ToString());
                    break;
            }
        }

        private JArray CreateKettlePacket(String name, object payload)
        {
            JObject packet = new JObject();
            packet.Add("Type", name);

            packet.Add(name, JObject.FromObject(payload));

            return new JArray(packet);
        }

        private void SendPacket(String name, object payload)
        {
            Console.WriteLine("Sending packet with type " + name + ".");
            // Create a kettle packet to serialize
            JArray packet = CreateKettlePacket(name, payload);

            // Get the corresponding json string 
            String data = Newtonsoft.Json.JsonConvert.SerializeObject(packet);

            // first send the length of the data
            Writer.Write(IPAddress.HostToNetworkOrder(data.Length));
            

            // and then send the data
            Writer.Write(System.Text.Encoding.UTF8.GetBytes(data));
        }

        public void SendMessage(KettleHistoryTagChange message)
        {
            SendPacket("HistoryTagChange", message);
        }

        public void SendMessage(KettleHistoryCreateGame message)
        {
            SendPacket("HistoryCreateGame", message);
        }

        public void SendMessage(KettleHistoryFullEntity message)
        {
            SendPacket("HistoryFullEntity", message);
        }

        public void SendMessage(KettleHistoryShowEntity message)
        {
            SendPacket("HistoryShowEntity", message);
        }

        public void SendMessage(KettleHistoryChangeEntity message)
        {
            SendPacket("HistoryChangeEntity", message);
        }

        public void SendMessage(List<KettleOption> message)
        {
            SendPacket("Options", message);
        }

        public void SendMessage(KettleEntityChoices message)
        {
            SendPacket("EntityChoices", message);
        }
    }
}
