using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using SabberStoneCore.Enums;

namespace SabberStonePowerLog
{
    class Interpreter
    {
        private static Regex logRgx = new Regex(@"([D])[ ]([0-9.:]{16})[ ]([A-Z]+)[.]([A-Z]+)[\(\)]+[ ][-][ ](.+)", RegexOptions.IgnoreCase);
        private static Regex fullEntityRgx = new Regex(@"FULL_ENTITY - Creating ID=([0-9]+)[ ]CardID=([A-Z0-9_]*)", RegexOptions.IgnoreCase);
        private static Regex tagValueRgx = new Regex(@"tag=([A-Z0-9_]+)[ ]value=([A-Z0-9]+)", RegexOptions.IgnoreCase);
        private static Regex idRgx = new Regex(@"(Entity|id)=([0-9]+|[A-Z0-9]+)", RegexOptions.IgnoreCase);
        private static Regex blockStartRgx = new Regex(@"BLOCK_START BlockType=([A-Z]+) Entity=([0-9]+|[A-Z0-9]+|\[.*?\]) EffectCardId=([A-Z0-9_]*) EffectIndex=([-0-9]+) Target=([0-9]+|[A-Z0-9]+|\[.*?\])", RegexOptions.IgnoreCase);

        private StreamReader file;

        public string filePath;

        public string fileName;

        public Interpreter(string filePath, string fileName)
        {
            this.filePath = filePath;
            this.fileName = fileName;
            this.file = new StreamReader(File.Open(filePath + fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
        }

        public void Parse()
        {
            List<PowerGame> powerGames = new List<PowerGame>();
            PowerState currentPowerState = PowerState.Start;
            PowerGame currentPowerGame = null;
            PowerType currentPowerType = 0;
            Dictionary<string, int> currentNameToIdDict;
            PowerHistoryEntry currentPowerHistoryEntry = null;


            string line;
            while ((line = file.ReadLine()) != null)
            {
                Match matchLogRgx = logRgx.Match(line);
                if (matchLogRgx.Success)
                {
                    var entryType = matchLogRgx.Groups[1].Value;
                    var timestamp = matchLogRgx.Groups[2].Value;
                    var classType = matchLogRgx.Groups[3].Value;
                    var debugType = matchLogRgx.Groups[4].Value;
                    var content = matchLogRgx.Groups[5].Value;

                    if (!classType.Equals("GameState") || !debugType.Equals("DebugPrintPower"))
                        continue;

                    var contentLine = content.Trim();

                    PowerType nextPowerType;
                    if (Enum.TryParse<PowerType>(contentLine.Split(' ')[0], out nextPowerType))
                    {
                        currentPowerType = nextPowerType;
                    };

                    switch (currentPowerType)
                    {
                        case PowerType.CREATE_GAME:
                            break;
                    }

                    if (contentLine.StartsWith("CREATE_GAME"))
                    {
                        currentPowerState = PowerState.CreateGame;
                        currentPowerGame = new PowerGame();
                        currentNameToIdDict = new Dictionary<string, int>();
                        currentPowerHistoryEntry = new PowerCreateGame();
                        currentPowerGame.PowerHistory.Add(currentPowerHistoryEntry);
                        powerGames.Add(currentPowerGame);
                    }
                    else if (contentLine.StartsWith("Player"))
                    {
                        currentPowerState = PowerState.CreateGamePlayer;
                        Player player = new Player();
                        var createGame = currentPowerHistoryEntry as PowerCreateGame;
                        createGame.Players.Add(player);
                        if (createGame.Players.Count == 1)
                        {
                            currentPowerGame.Player1 = player;
                        }
                        else if (createGame.Players.Count == 2)
                        {
                            currentPowerGame.Player2 = player;
                        }
                    }
                    else if (contentLine.StartsWith("GameEntity"))
                    {
                        currentPowerState = PowerState.CreateGameGameEntity;
                        GameEntity game = new GameEntity();
                        currentPowerGame.Game = game;
                        (currentPowerHistoryEntry as PowerCreateGame).Game = game;
                    }
                    else if (contentLine.StartsWith("FULL_ENTITY"))
                    {
                        currentPowerState = PowerState.FullEntity;
                        currentPowerHistoryEntry = ProcessFullEntity(currentPowerGame, contentLine);
                        if (currentPowerHistoryEntry != null)
                        {
                            currentPowerGame.PowerHistory.Add(currentPowerHistoryEntry);
                        }

                    }
                    else if (contentLine.StartsWith("TAG_CHANGE"))
                    {
                        currentPowerState = PowerState.TagChange;
                        currentPowerHistoryEntry = ProcessTagChange(currentPowerGame, contentLine);
                        if (currentPowerHistoryEntry != null)
                        {
                            currentPowerGame.PowerHistory.Add(currentPowerHistoryEntry);
                        }
                    }
                    else if (contentLine.StartsWith("BLOCK_START"))
                    {
                        currentPowerState = PowerState.BlockStart;
                        currentPowerHistoryEntry = ProcessBlockStart(currentPowerGame, contentLine);
                    }
                    else if (contentLine.StartsWith("BLOCK_END"))
                    {
                        currentPowerState = PowerState.BlockEnd;
                    }
                    else if (contentLine.StartsWith("HIDE_ENTITY"))
                    {
                        currentPowerState = PowerState.HideEntity;
                    }
                    else if (contentLine.StartsWith("SHOW_ENTITY"))
                    {
                        currentPowerState = PowerState.ShowEntity;
                    }
                    else if (contentLine.StartsWith("META_DATA"))
                    {
                        currentPowerState = PowerState.MetaData;
                    }
                    else if (contentLine.StartsWith("Info["))
                    {

                    }
                    else if (contentLine.StartsWith("tag="))
                    {
                        Match matchTagValueRgx = tagValueRgx.Match(contentLine);
                        if (matchTagValueRgx.Success)
                        {
                            var tag = matchTagValueRgx.Groups[1].Value;
                            var value = matchTagValueRgx.Groups[2].Value;

                            switch (currentPowerState)
                            {
                                case PowerState.CreateGameGameEntity:
                                    (currentPowerHistoryEntry as PowerCreateGame).Game.Add(tag, value);
                                    break;

                                case PowerState.CreateGamePlayer:
                                    (currentPowerHistoryEntry as PowerCreateGame).Players.Last().Add(tag, value);
                                    break;

                                case PowerState.FullEntity:
                                    (currentPowerHistoryEntry as PowerFullEntity).PowerEntity.Add(tag, value);
                                    break;

                                default:
                                    //Console.WriteLine("Found unimplemented currentPowerState case: '" + currentPowerState + "'");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Found uninterpreted contentLine: '" + contentLine + "'");
                        }
                    }
                    else
                    {
                        Console.WriteLine("unhandled line: '" + contentLine + "'");
                    }
                }
                else
                {
                    Console.WriteLine("matchLogRgx: '" + line + "'");
                }
            }

            var powerGame = powerGames.First();

            File.WriteAllText(filePath + "powerLog.json", JsonConvert.SerializeObject(powerGame, Formatting.Indented));

            powerGame.PowerHistory.Where(p => p is PowerFullEntity).ToList().ForEach(p => p.Process(powerGame));

            File.WriteAllText(filePath + "powerLogProc.json", JsonConvert.SerializeObject(powerGame, Formatting.Indented));
        }

        private PowerBlockStart ProcessBlockStart(PowerGame powerGame, string str)
        {
            Match match1 = blockStartRgx.Match(str);
            if (!match1.Success)
            {
                Console.WriteLine("blockStartRgx unmatched: '" + str + "'");
                return null;
            }

            var blockType = match1.Groups[1].Value;
            var entity = match1.Groups[2].Value;
            var effectCardId = match1.Groups[3].Value;
            var effectIndex = match1.Groups[4].Value;
            var target = match1.Groups[5].Value;

            int entityId = GetIdFromEntity(entity, powerGame);

            int targetId = GetIdFromEntity(target, powerGame);

            return new PowerBlockStart()
            {
                BlockType = blockType,
            };
        }

        private int GetIdFromEntity(string str, PowerGame powerGame)
        {
            int result;
            if (!int.TryParse(str, out result))
            {
                Match match = idRgx.Match(str);
                if (match.Success)
                {
                    result = int.Parse(match.Groups[2].Value);
                }
                else
                {
                    result = powerGame.GetIdByName(str);
                }
            }
            return result;
        }

        private PowerFullEntity ProcessFullEntity(PowerGame powerGame, string str)
        {
            Match match = fullEntityRgx.Match(str);
            if (!match.Success)
            {
                Console.WriteLine("fullEntityRgx unmatched: '" + str + "'");
                return null;
            }
            var id = match.Groups[1].Value;
            var cardId = match.Groups[2].Value;

            return new PowerFullEntity()
            {
                Id = id,
                CardId = cardId
            };
        }

        private PowerTagChange ProcessTagChange(PowerGame powerGame, string str)
        {
            Match match1 = tagValueRgx.Match(str);
            Match match2 = idRgx.Match(str);
            if (!match1.Success || !match2.Success)
            {
                Console.WriteLine("tagValueRgx or idRgx unmatched: '" + str + "'");
                return null;
            }

            var tag = match1.Groups[1].Value;
            var value = match1.Groups[2].Value;
            var entity = match2.Groups[2].Value;
            int id;
            if (!int.TryParse(entity, out id))
            {
                if (powerGame.Game.Name == null)
                {
                    id = 1;
                    powerGame.Game.Name = entity;
                    Console.WriteLine("Game " + entity);
                }
                else if (powerGame.Player1.Name == null)
                {
                    id = 2;
                    powerGame.Player1.Name = entity;
                    Console.WriteLine("Player1: " + entity);
                }
                else if (powerGame.Player2.Name == null)
                {
                    id = 3;
                    powerGame.Player2.Name = entity;
                    Console.WriteLine("Player2: " + entity);
                }
                else
                {
                    id = powerGame.GetIdByName(entity);
                }

            }

            return new PowerTagChange()
            {
                Id = id,
                Tag = tag,
                Value = value
            };
        }
    }
}
