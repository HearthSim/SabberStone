using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using HearthDb;
using HearthDb.Enums;
using log4net;
using SabberStone.Config;
using SabberStone.Model;
using SabberStone.Tasks.PlayerTasks;
using Card = SabberStone.Model.Card;
using Cards = SabberStone.Model.Cards;
using Generic = SabberStone.Actions.Generic;

namespace SimpleTest
{
    internal class Program
    {
        private static readonly ILog Log =
            LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static Random Rnd = new Random();

        private static void Main(string[] args)
        {
            Log.Info("Starting test setup.");

            //int t = Cards.Count;

            //DruidWildGrowthTest();
            //IronBreakOwl();

            //Log.Info(Cards.Count);
            //Cards.Statistics();

            //BasicHealthAuraTest();

            CardsTest();
            
            
            //Secretkeeper();
            //CardsTest();
            //CloneSameSame();
            //FarSightBug();
            //LoatHoorderMadBomberSplit();

            //IllidanStormrage_EX1_614();
            //dbCheck("Ancient Watcher");
            //FrostWolfWarlord();

            //Log.Info(Cards.FromName("Nerubian Egg").FullPrint(true, true));

            Console.ReadLine();
        }

        public static void CardsTest()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.MAGE,
                Player2HeroClass = CardClass.MAGE,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;
            var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Summoning Stone"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            var spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));
            var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sorcerer's Apprentice"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            var spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Missiles"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));

            Log.Info($"{game.Player2.FullPrint()}");
            Log.Info($"{game.Player2.Hand.FullPrint()}");
            Log.Info($"{game.Player2.Hero.FullPrint()}");
            Log.Info($"{game.Player2.Board.FullPrint()}");
            Log.Info($"{game.Player1.Board.FullPrint()}");
            Log.Info($"{game.Player1.Hero.FullPrint()}");
            Log.Info($"{game.Player1.Hand.FullPrint()}");
            Log.Info($"{game.Player1.FullPrint()}");
        }

        public static void Secretkeeper()
        {
            bool flag = true;
            while (flag)
            {
                var game = new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.HUNTER,
                    Player2HeroClass = CardClass.ROGUE,
                    FillDecks = true
                });
                game.StartGame();
                game.Player1.BaseMana = 10;
                game.Player2.BaseMana = 10;
                var minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Knife Juggler"));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
                var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snake Trap"));
                game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
                game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, minion1));
                Log.Info($"{game.Player2.Hero.FullPrint()}");
                Log.Info($"{game.Player2.Board.FullPrint()}");
                Log.Info($"{game.Player1.Board.FullPrint()}");
                Log.Info($"{game.Player1.Hero.FullPrint()}");
                flag = (game.CurrentPlayer.Hero.Health > 27 ? 2 : 1) == ((Minion) minion1).Health;
            }
        }

        public static void LoatHoorderMadBomberSplit()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.MAGE,
                    Player2HeroClass = CardClass.WARLOCK,
                    FillDecks = true,
                    Splitting = true

                });
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            game.StartGame();

            var minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
            //var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
            //var minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
            //var minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
            //var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
            //var minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
            var minion4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mad Bomber"));

            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            //game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            //game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion4));

            //game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));
            Log.Info($"{game.Player2.Hero.FullPrint()}");
            Log.Info($"{game.Player2.Board.FullPrint()}");
            Log.Info($"{game.Player1.Board.FullPrint()}");
            Log.Info($"{game.Player1.Hero.FullPrint()}");

        }

        public static void SnakeTrap()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.HUNTER,
                Player2HeroClass = CardClass.ROGUE,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Knife Juggler"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Snake Trap"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, minion1));
        }

        public static void SplitTest()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.HUNTER,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });

            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;
            game.StartGame();

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sen'jin Shieldmasta"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion1));

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sen'jin Shieldmasta"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion2));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Arcane Missiles"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));

            Log.Info($"{game.CurrentOpponent.Board.FullPrint()}");
        }

        public static void CloneSameSame()
        {
            var classes = new[]
            {
                CardClass.DRUID, CardClass.HUNTER, CardClass.MAGE, CardClass.PALADIN, CardClass.PRIEST,
                CardClass.ROGUE, CardClass.SHAMAN, CardClass.WARLOCK, CardClass.WARRIOR
            };
            var flag = true;
            for (var i = 0; i < 10 && flag; i++)
            {
                var game = new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = classes[Rnd.Next(classes.Length)],
                    Player2HeroClass = classes[Rnd.Next(classes.Length)],
                    FillDecks = true
                });
                game.StartGame();

                while (game.State != State.COMPLETE)
                {
                    var options = game.CurrentPlayer.Options();
                    var option = options[Rnd.Next(options.Count)];
                    game.Process(option);
                    var cloneGame = game.Clone();
                    var str1 = game.Hash();
                    var str2 = cloneGame.Hash();
                    flag &= str1.Equals(str2);
                    if (!flag)
                    {
                        break;
                    }
                }
            }
            Log.Info($"Same whole game? {flag}");

        }

        public static void Maelstrom()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.PALADIN,
                Player2HeroClass = CardClass.SHAMAN,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Injured Blademaster"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Maelstrom Portal"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));

            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodmage Thalnos"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));

            var spell2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Maelstrom Portal"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));

            Log.Info(game.CurrentOpponent.Board.FullPrint());
            Log.Info(game.CurrentPlayer.Board.FullPrint());
        }

        public static void CloneAssertTest()
        {
            var classes = new[]
            {
                CardClass.DRUID, CardClass.HUNTER, CardClass.MAGE, CardClass.PALADIN, CardClass.PRIEST,
                CardClass.ROGUE, CardClass.SHAMAN, CardClass.WARLOCK, CardClass.WARRIOR
            };
            var flag = true;
            for (var i = 0; i < 100 && flag; i++)
            {
                var game = new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = classes[Rnd.Next(classes.Length)],
                    Player2HeroClass = classes[Rnd.Next(classes.Length)],
                    FillDecks = true
                });
                game.StartGame();

                while (game.State != State.COMPLETE)
                {
                    var options = game.CurrentPlayer.Options();
                    var option = options[Rnd.Next(options.Count)];
                    game.Process(option);
                    var cloneGame = game.Clone();
                    var str1 = game.Hash();
                    var str2 = cloneGame.Hash();
                    flag &= str1.Equals(str2);
                    if (!flag)
                    {
                        Console.WriteLine("ORG.:" + str1);
                        Console.WriteLine("CLO.:" + str2);
                        break;
                    }
                }
            }
            Log.Info($"Same whole game? {flag}");
        }

        public static void CloneRealTest()
        {

            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.SHAMAN,
                Player2HeroClass = CardClass.SHAMAN,
                FillDecks = true
            });
            game.StartGame();

            var turns = 25;
            for (var i = 0; i < turns; i++)
            {
                var options = game.CurrentPlayer.Options();
                var option = options[Rnd.Next(options.Count)];
                game.Process(option);
            }

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Illidan Stormrage"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Knife Juggler"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var cloneGame = game.Clone();

            Log.Info($"is same string? {game.Hash().Equals(cloneGame.Hash())}");

            Log.Info($"--- org. task");
            game.Process(HeroPowerTask.Any(game.CurrentPlayer));
            Log.Info($"--- clone task");
            cloneGame.Process(HeroPowerTask.Any(cloneGame.CurrentPlayer));

            Log.Info($"is same string? {game.Hash().Equals(cloneGame.Hash())}");

        }

        public static void CloneStampTest()
        {
            var turns = 25;

            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.MAGE,
                Player2HeroClass = CardClass.HUNTER,
                FillDecks = true
            });
            game.StartGame();

            for(var i = 0; i < turns; i++)
            {
                var options = game.CurrentPlayer.Options();
                var option = options[Rnd.Next(options.Count)];
                game.Process(option);
            }

            Log.Info($"GameState: {game.State}");

            Log.Info($"{game.FullPrint()}");

            const int total = 10000;
            var watch = Stopwatch.StartNew();
            for (var i = 0; i < total; i++)
            {
                var cloneGame = game.Clone();
                //Log.Info($"{cloneGame.FullPrint()}");
            }
            watch.Stop();

            Log.Info($"{total} games cloned took {watch.ElapsedMilliseconds} ms => " +
                     $"Avg. {watch.ElapsedMilliseconds / total} per clone!");
        }

        public static void OptionsTest()
        {
            const int total = 100;
            var watch = Stopwatch.StartNew();

            var turns = 0;
            var wins = new[] {0, 0};
            for (var i = 0; i < total; i++)
            {
                var game = new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.MAGE,
                    Player2HeroClass = CardClass.HUNTER,
                    FillDecks = true
                });
                game.StartGame();

                while (game.State != State.COMPLETE)
                {
                    var options = game.CurrentPlayer.Options();
                    var option = options[Rnd.Next(options.Count)];
                    game.Process(option);
                }
                turns += game.Turn;
                if (game.Player1.PlayState == PlayState.WON)
                    wins[0]++;
                if (game.Player2.PlayState == PlayState.WON)
                    wins[1]++;

            }
            watch.Stop();
            Log.Info($"{total} games with {turns} turns took {watch.ElapsedMilliseconds} ms => " +
                     $"Avg. {watch.ElapsedMilliseconds/total} per game " +
                     $"and {watch.ElapsedMilliseconds / (total * turns)} per turn!");
            Log.Info($"playerA {wins[0] * 100 / total}% vs. playerB {wins[1] * 100 / total}%!");
        }

        public static void Combo()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.ROGUE,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Defias Ringleader"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cold Blood"));
            var spell2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cold Blood"));

            Log.Info($"Is combo active ? {game.CurrentPlayer.IsComboActive}");

            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion1));

            Log.Info($"{game.CurrentPlayer.Board.FullPrint()}");

            Log.Info($"Is combo active ? {game.CurrentPlayer.IsComboActive}");

            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, minion1));

            Log.Info($"{game.CurrentPlayer.Board.FullPrint()}");
        }

        public static void ChooseOne()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.DRUID,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            game.CurrentPlayer.Hero.Damage = 5;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ancient of Lore"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1, game.CurrentPlayer.Hero, -1));
        }

        public static void DeadlyPhaseLayerDead()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.PALADIN,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Leper Gnome"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Knife Juggler"));
            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Illidan Stormrage"));
            var minion4 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Priestess of Elune"));

            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));
            game.CurrentPlayer.UsedMana = 0;
            game.CurrentPlayer.Hero.Damage = 28;

            Log.Info($"{game.CurrentPlayer.Hero.FullPrint()}");
            Log.Info($"{game.CurrentPlayer.Board.FullPrint()}");
            Log.Info($"{game.CurrentOpponent.Board.FullPrint()}");
            Log.Info($"{game.CurrentOpponent.Hero.FullPrint()}");

            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion4));

            Log.Info($"{game.CurrentPlayer.Hero.FullPrint()}");
            Log.Info($"{game.CurrentPlayer.Board.FullPrint()}");
            Log.Info($"{game.CurrentOpponent.Board.FullPrint()}");
            Log.Info($"{game.CurrentOpponent.Hero.FullPrint()}");

        }

        public static void IllidanStormrage_EX1_614()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.PALADIN,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cult Master"));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));

            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Illidan Stormrage"));
            var minion4 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Knife Juggler"));
            var minion5 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Novice Engineer"));

            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion4));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion5));

            Log.Info($"{game.CurrentPlayer.Hero.FullPrint()}");
            Log.Info($"{game.CurrentPlayer.Board.FullPrint()}");
            Log.Info($"{game.CurrentOpponent.Board.FullPrint()}");
            Log.Info($"{game.CurrentOpponent.Hero.FullPrint()}");
        }

        public static void LeperGnome()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.MAGE,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Leper Gnome"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

            Log.Info($"{game.CurrentOpponent.Board.FullPrint()}");
        }

        public static void BasicHealthAuraTest()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PALADIN,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            game.StartGame();

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stormwind Champion"));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stormwind Champion"));
            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shattered Sun Cleric"));

            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            game.CurrentPlayer.UsedMana = 0;

            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

            game.CurrentPlayer.UsedMana = 0;

            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion3, minion2));

            game.CurrentPlayer.UsedMana = 0;


            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            ((Minion)minion1).Silence();

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            //game.Process(EndTurnTask.Any(game.CurrentPlayer));

            //var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Flamestrike"));
            //game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));

            //game.CurrentPlayer.UsedMana = 0;

            //var spell2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Arcane Explosion"));
            //game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));


            //var spell3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Arcane Explosion"));
            //game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell3));

            //Log.Info($"{game.CurrentOpponent.Board.FullPrint()}");

            //var spell4 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Arcane Explosion"));
            //game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell4));

            Log.Info($"{game.CurrentOpponent.Board.FullPrint()}");
        }

        public static void IronBreakOwl()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.MAGE,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Leper Gnome"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ironbeak Owl"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, minion1));
        }

        public static void Corruption()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PALADIN,
                    Player2HeroClass = CardClass.WARLOCK,
                    FillDecks = true
                });
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            game.StartGame();

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stormwind Champion"));

            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var spell = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Corruption"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, minion1));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            Log.Info("MUST TRIGGER BEFORE HERE !!!!");

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
        }

        public static void TestCard()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PALADIN,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            game.StartGame();

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stormwind Champion"));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stormwind Champion"));
            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shattered Sun Cleric"));

            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            game.CurrentPlayer.UsedMana = 0;

            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

            game.CurrentPlayer.UsedMana = 0;

            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion3, minion2));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            Log.Info($"{game.CurrentPlayer.Hero.FullPrint()}");
            Log.Info($"{game.CurrentPlayer.Board.FullPrint()}");
            Log.Info($"{game.CurrentOpponent.Board.FullPrint()}");
            Log.Info($"{game.CurrentOpponent.Hero.FullPrint()}");

            var spell = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Flamestrike"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

            Log.Info($"{game.CurrentPlayer.Hero.FullPrint()}");
            Log.Info($"{game.CurrentPlayer.Board.FullPrint()}");
            Log.Info($"{game.CurrentOpponent.Board.FullPrint()}");
            Log.Info($"{game.CurrentOpponent.Hero.FullPrint()}");

            //Assert.AreEqual(2, ((ICharacter)minion1).AttackDamage);

            //var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));
            //game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));


            //Assert.AreEqual(2, ((ICharacter)minion2).AttackDamage);

            //Assert.AreEqual(1, ((ICharacter)minion1).AttackDamage);
            //Assert.AreEqual(1, ((ICharacter)minion2).AttackDamage);

            //Log.Info($"{game.CurrentPlayer.Hero.FullPrint()}");
            //Log.Info($"{game.CurrentPlayer.Board.FullPrint()}");
            //Log.Info($"{game.CurrentOpponent.Board.FullPrint()}");
            //Log.Info($"{game.CurrentOpponent.Hero.FullPrint()}");

            //game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion1));
            //game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Board[1]));

            //Log.Info($"{game.CurrentPlayer.Hero.FullPrint()}");
            //Log.Info($"{game.CurrentPlayer.Board.FullPrint()}");
            //Log.Info($"{game.CurrentOpponent.Board.FullPrint()}");
            //Log.Info($"{game.CurrentOpponent.Hero.FullPrint()}");
        }

        public static void SpellDamageTest()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.DRUID,
                    Player2HeroClass = CardClass.PRIEST,
                    FillDecks = true
                });
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            game.StartGame();

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var minionOp1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sen'jin Shieldmasta"));
            var minionOp2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodfen Raptor"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minionOp1));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minionOp2));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            Log.Info($"{game.CurrentPlayer.Hero.FullPrint()}");
            Log.Info($"{game.CurrentPlayer.Board.FullPrint()}");
            Log.Info($"{game.CurrentOpponent.Board.FullPrint()}");
            Log.Info($"{game.CurrentOpponent.Hero.FullPrint()}");

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Kobold Geomancer"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            var spell = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Swipe"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, minionOp2));

            Log.Info($"{game.CurrentPlayer.Hero.FullPrint()}");
            Log.Info($"{game.CurrentPlayer.Board.FullPrint()}");
            Log.Info($"{game.CurrentOpponent.Board.FullPrint()}");
            Log.Info($"{game.CurrentOpponent.Hero.FullPrint()}");
        }


        public static void MindControl_CS1_113()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.SHAMAN,
                    Player2HeroClass = CardClass.PRIEST,
                    FillDecks = true
                });
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            game.StartGame();

            var m1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, m1));

            var m2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sen'jin Shieldmasta"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, m2));

            var m3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodfen Raptor"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, m3));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            Log.Info($"{game.CurrentPlayer.Hero.FullPrint()}");
            Log.Info($"{game.CurrentPlayer.Board.FullPrint()}");

            var spell = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mind Control"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, m2));

            Log.Info($"{game.CurrentPlayer.Hero.FullPrint()}");
            Log.Info($"{game.CurrentPlayer.Board.FullPrint()}");
        }

        public static void Windfury_CS2_039()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.SHAMAN,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            game.StartGame();

            var m2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sen'jin Shieldmasta"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, m2));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            Log.Info($"has windfura: {((ICharacter) m2).HasWindfury} {((ICharacter) m2).NumAttacksThisTurn}");

            var spell = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Windfury"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, m2));

            Log.Info($"has windfura: {((ICharacter) m2).HasWindfury} {((ICharacter) m2).NumAttacksThisTurn}");

            game.Process(MinionAttackTask.Any(game.CurrentPlayer, m2, game.CurrentOpponent.Hero));

            Log.Info($"has windfura: {((ICharacter) m2).HasWindfury} {((ICharacter) m2).NumAttacksThisTurn}");

            game.Process(MinionAttackTask.Any(game.CurrentPlayer, m2, game.CurrentOpponent.Hero));

            Log.Info($"has windfura: {((ICharacter) m2).HasWindfury} {((ICharacter) m2).NumAttacksThisTurn}");
        }

        public static void MindVision()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PRIEST,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });
            game.StartGame();

            var spell = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mind Vision"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));
        }

        private static void ChargeCardTest()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.WARRIOR,
                    Player2HeroClass = CardClass.PALADIN,
                    FillDecks = true
                });
            game.StartGame();

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodfen Raptor"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            var spell = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Charge"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, minion2));
            //game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, game.CurrentOpponent.Board[0]));
            game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, game.CurrentOpponent.Hero));
            //Log.Info($"check: {minion2.CantAttackHeroes}");
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, game.CurrentOpponent.Hero));
        }

        private static void DruidWildGrowthTest()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.DRUID,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });
            game.StartGame();

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Wild Growth"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, spell1));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
        }

        private static void HeroPowerShaman()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.SHAMAN,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });
            game.StartGame();

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));
        }

        private static void HeroPowerWarlock()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.WARLOCK,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });
            game.StartGame();

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));
        }

        private static void StormwindLoopBug()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stormwind Champion"));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stormwind Champion"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            Log.Info($"minion1[GameTag.HEALTH] {minion1[GameTag.HEALTH]}");

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

            //Log.Info($"minion1[GameTag.HEALTH] {minion1[GameTag.HEALTH]}");
            //Log.Info($"minion2[GameTag.HEALTH] {minion2[GameTag.HEALTH]}");
        }

        private static void PlayWeaponCard()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.WARRIOR,
                    Player2HeroClass = CardClass.PALADIN,
                    FillDecks = true
                });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var weapon1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fiery War Axe"));

            game.Process(PlayCardTask.Any(game.CurrentPlayer, weapon1));
            game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            Log.Info($"Hero Health? Before {game.CurrentPlayer.Hero.Health}");

            var weapon2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Truesilver Champion"));
            var weapon3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fiery War Axe"));

            game.Process(PlayCardTask.Any(game.CurrentPlayer, weapon2));
            game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));

            Log.Info($"Hero Health? After {game.CurrentPlayer.Hero.Health}");

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));

            Log.Info($"Hero has still weapon trigger? {game.CurrentPlayer.Hero.Triggers.Count}");

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, weapon3));
            game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));

            Log.Info($"Hero has still weapon trigger? {game.CurrentPlayer.Hero.Triggers.Count}");
        }

        private static void HeroPowerHunter()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.HUNTER,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });
            game.StartGame();

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));
        }

        private static void KillCommand()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.SHAMAN,
                    Player2HeroClass = CardClass.PALADIN,
                    FillDecks = true
                });
            game.StartGame();
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.CurrentPlayer.BaseMana = 10;

            Log.Info(game.CurrentPlayer.Board.FullPrint());
            var mini4 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodfen Raptor"));
            var mini3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Flametongue Totem"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, mini3, 1));

            Log.Info(game.CurrentPlayer.Board.FullPrint());

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));

            Log.Info(game.CurrentPlayer.Board.FullPrint());

            game.Process(MinionAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Board[2], game.CurrentOpponent.Hero));

            game.Process(PlayCardTask.Minion(game.CurrentPlayer, mini4, 2));

            Log.Info(game.CurrentPlayer.Board.FullPrint());
        }

        private static void HolyNova()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PRIEST,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });
            game.StartGame();

            //var minion11 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Northshire Cleric"));
            //game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion11));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion12 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("River Crocolisk"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion12));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion12));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion13 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ironfur Grizzly"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion13));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion24 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Silverback Patriarch"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion24));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion13, (ICharacter) minion24));
            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion13));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion25 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stormwind Knight"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion25));

            game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion25, (ICharacter) minion13));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            Log.Info($"ENEMY   HERO: {game.CurrentOpponent.Hero.FullPrint()}");
            Log.Info($"ENEMYS BOARD: {game.CurrentOpponent.Board.FullPrint()}");
            Log.Info($"MY     BOARD: {game.CurrentPlayer.Board.FullPrint()}");
            Log.Info($"MY      HERO: {game.CurrentPlayer.Hero.FullPrint()}");

            var spell = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Holy Nova"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

            Log.Info($"ENEMY   HERO: {game.CurrentOpponent.Hero.FullPrint()}");
            Log.Info($"ENEMYS BOARD: {game.CurrentOpponent.Board.FullPrint()}");
            Log.Info($"MY     BOARD: {game.CurrentPlayer.Board.FullPrint()}");
            Log.Info($"MY      HERO: {game.CurrentPlayer.Hero.FullPrint()}");
        }

        private static void HeroPowerRogue()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.ROGUE,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });
            game.StartGame();

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));
            Log.Info($"{game.CurrentPlayer.Hero.FullPrint()}");
            game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
        }

        private static void HeroPowerDruid()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.DRUID,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });
            game.StartGame();

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));
            Log.Info($"{game.CurrentPlayer.Hero.FullPrint()}");
            game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
        }

        private static void HeroPowerPaladin()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PALADIN,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });
            game.StartGame();

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));
        }

        private static void Soulfire()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PRIEST,
                    Player2HeroClass = CardClass.WARLOCK,
                    FillDecks = true
                });
            game.StartGame();

            var minion = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Northshire Cleric"));
            Generic.PlayCard(game.Player1, minion);
            //Assert.AreEqual(1, game.CurrentPlayer[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var spell = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Soulfire"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, spell, minion));
            //Assert.AreEqual(1, game.CurrentPlayer[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);
        }

        private static void HeroPowers()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PRIEST,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });
            game.StartGame();

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Northshire Cleric"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            //Assert.AreEqual(3, game.Player1.Board[0][GameTag.HEALTH]);
            Log.Info($"{minion1.Card}: DAMAGE = {minion1[GameTag.DAMAGE]}");

            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

            Log.Info($"{minion1.Card}: DAMAGE = {minion1[GameTag.DAMAGE]}");
        }

        private static void StormwindChampion()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PRIEST,
                    Player2HeroClass = CardClass.PRIEST,
                    FillDecks = true
                });
            game.StartGame();

            game.CurrentPlayer.BaseMana = 10;

            //Assert.AreEqual(0, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Northshire Cleric"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter) minion1));

            //Assert.AreEqual(1, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);
            //Assert.AreEqual(2, game.Player1.Board[0][GameTag.ATK]);

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stormwind Champion"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter) minion2));

            //Assert.AreEqual(2, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);
            //Assert.AreEqual(3, game.Player1.Board[0][GameTag.ATK]);
            //Assert.AreEqual(2, game.Player1.Board[0][GameTag.HEALTH]);
            //Assert.AreEqual(6, game.Player1.Board[1][GameTag.ATK]);
        }

        private static void FrostWolfWarlord()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PRIEST,
                    Player2HeroClass = CardClass.PRIEST,
                    FillDecks = true
                });
            game.StartGame();

            game.CurrentPlayer.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Northshire Cleric"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter) minion1));

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Frostwolf Warlord"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter) minion2));

            Log.Info(
                $"{minion1.Card}: ATK = {minion1[GameTag.ATK]} HEALTH = {minion1[GameTag.HEALTH]} Enchants: {minion1.Enchants.Count}");
            Log.Info(
                $"{minion2.Card}: ATK = {minion2[GameTag.ATK]} HEALTH = {minion2[GameTag.HEALTH]} Enchants: {minion2.Enchants.Count}");

            game.CurrentPlayer.UsedMana = 0;

            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Frostwolf Warlord"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter) minion3));

            Log.Info(
                $"{minion1.Card}: ATK = {minion1[GameTag.ATK]} HEALTH = {minion1[GameTag.HEALTH]} Enchants: {minion1.Enchants.Count}");
            Log.Info(
                $"{minion2.Card}: ATK = {minion2[GameTag.ATK]} HEALTH = {minion2[GameTag.HEALTH]} Enchants: {minion2.Enchants.Count}");
            Log.Info(
                $"{minion3.Card}: ATK = {minion3[GameTag.ATK]} HEALTH = {minion3[GameTag.HEALTH]} Enchants: {minion3.Enchants.Count}");
            Log.Info($"{game.CurrentPlayer.Board.Hash()}");
        }

        private static void NorthShireCleric()
        {
            var game = new Game(new GameConfig {StartPlayer = 1, Player1HeroClass = CardClass.PRIEST, FillDecks = true});
            game.StartGame();

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Northshire Cleric"));

            Generic.PlayCard(game.Player1, minion1);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Frostwolf Grunt"));

            Generic.PlayCard(game.CurrentPlayer, minion2);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, minion2));
            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Frostwolf Grunt"));

            Generic.PlayCard(game.CurrentPlayer, minion3);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shadow Word: Pain"));

            game.Process(PlayCardTask.Any(game.CurrentPlayer, spell1, (ICharacter) minion3));
        }
    }
}