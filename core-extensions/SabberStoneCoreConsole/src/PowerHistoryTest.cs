using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using SabberStoneCore.Auras;
using SabberStoneCore.Config;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Tasks.PlayerTasks;
using SabberStoneCore.Triggers;

namespace SabberStoneCoreConsole
{
	public static class PowerHistoryTest
	{
		public static void Run()
		{
			do
			{
				var rnd = new Random();
				Game game = new Game(new GameConfig
				{
					Player1HeroClass = (CardClass) rnd.Next(2, 11),
					Player2HeroClass = (CardClass) rnd.Next(2, 11),
					History = true,
					Logging = true,
					FillDecks = true,
					SkipMulligan = true,
					Shuffle = false,
				});
				game.StartGame();
				do
				{
					Game clone = game.Clone(history: true);

					List<PlayerTask> options = game.CurrentPlayer.Options();
					PlayerTask option = options[rnd.Next(options.Count)];
					game.Process(option);

					StateTransition(clone, game.PowerHistory);

					InequalityFlags flag = Equals(game, clone);
					if (CheckFlag(flag))
						;

				} while (game.State != State.COMPLETE);
			} while (true);
		}

		private static void StateTransition(Game game, PowerHistory history)
		{
			foreach (IPowerHistoryEntry item in history.Last)
			{
				switch (item)
				{
					case PowerHistoryBlockEnd powerHistoryBlockEnd:
						break;
					case PowerHistoryBlockStart powerHistoryBlockStart:
						break;
					case PowerHistoryCreateGame powerHistoryCreateGame:
						break;
					case PowerHistoryFullEntity powerHistoryFullEntity:
						FullEntity(game, powerHistoryFullEntity);
						break;
					case PowerHistoryHideEntity powerHistoryHideEntity:
						break;
					case PowerHistoryMetaData powerHistoryMetaData:
						break;
					case PowerHistoryShowEntity powerHistoryShowEntity:
						break;
					case PowerHistoryTagChange powerHistoryTagChange:
						TagChange(game, powerHistoryTagChange);
						break;
					case PowerHistoryChangeEntity powerHistoryChangeEntity:
						ChangeEntity(game, powerHistoryChangeEntity);
						break;
				}
			}
		}

		private static void TagChange(Game game, PowerHistoryTagChange history)
		{
			IPlayable entity;
			switch (history.EntityId)
			{
				case 1:
					game[history.Tag] = history.Value;
					return;
				case 2:
					ControllerTagChange(game.Player1, history.Tag, history.Value);
					return;
				case 3:
					ControllerTagChange(game.Player2, history.Tag, history.Value);
					return;
				default:
					entity = game.IdEntityDic[history.EntityId];
					entity[history.Tag] = history.Value;
					break;
			}


			switch (history.Tag)
			{
				case GameTag.ZONE:
					entity.Zone?.Remove(entity);
					entity.ActivatedTrigger = null;	// Headcrack
					var zone = (Zone) history.Value;
					if (zone == Zone.PLAY)
					{
						if (entity is Minion m)
						{
							entity.Controller.BoardZone.MoveTo(m);
							entity.ZonePosition = entity.Controller.BoardZone.Count - 1;
						}
					}
					else
					{
						entity.Controller.ControlledZones[zone].MoveTo(entity, -1);
						if (zone == Zone.HAND)
							entity.ZonePosition = entity.Controller.HandZone.Count - 1;
					}
					break;
				case GameTag.ZONE_POSITION:
					int newPos = history.Value - 1;
					if (newPos == entity.ZonePosition) return;
					switch (entity.Zone)
					{
						case HandZone handZone:
							handZone.Swap(entity, handZone[newPos]);
							break;
						case BoardZone boardZone:
							boardZone.Swap((Minion) entity, boardZone[newPos]);
							break;
					}
					break;
			}
		}

		private static void ControllerTagChange(Controller c, GameTag t, int value)
		{
			if (t == GameTag.CURRENT_PLAYER && value == 1)
			{
				c.Game.CurrentPlayer = c;
				return;
			}

			// ControllerAuraEffects.
			// TODO: Remove this switch table.
			switch (t)
			{
				case GameTag.TIMEOUT:
				case GameTag.SPELLPOWER_DOUBLE:
				case GameTag.SPELL_HEALING_DOUBLE:
				case GameTag.HERO_POWER_DOUBLE:
				case GameTag.HEALING_DOES_DAMAGE:
				case GameTag.CHOOSE_BOTH:
				case GameTag.SPELLS_COST_HEALTH:
				case GameTag.EXTRA_BATTLECRIES_BASE:
				case GameTag.EXTRA_END_TURN_EFFECT:
				case GameTag.HERO_POWER_DISABLED:
				case GameTag.ALL_HEALING_DOUBLE:
				case GameTag.EXTRA_MINION_BATTLECRIES_BASE:
				case GameTag.SPELLPOWER:
					c.ControllerAuraEffects[t] = value;
					return;
			}

			c[t] = value;
		}

		private static void FullEntity(Game game, PowerHistoryFullEntity history)
		{
			PowerHistoryEntity phEntity = history.Entity;
			IDictionary<GameTag, int> tags = phEntity.Tags;
			Controller c = tags[GameTag.CONTROLLER] == 1 ? game.Player1 : game.Player2;
			if (phEntity.Name == "")
			{
				var unknown = new Unknown(in c, in tags, phEntity.Id);
				game.IdEntityDic[phEntity.Id] = unknown;
				c.DeckZone.Add(unknown);
				return;
			}
			if (phEntity.Name is null)
			{	// Enchantment
				return;
			}

			IZone zone = null;
			if (/*(CardType) tags[GameTag.CARDTYPE] == CardType.MINION &&*/
			    tags[GameTag.ZONE] == 1)
			{	// Summon
				zone = c.BoardZone;
			}

			Entity.FromCard(
				in c, Cards.FromId(phEntity.Name),
				tags, zone, id: phEntity.Id);
		}

		private static void ChangeEntity(Game game, PowerHistoryChangeEntity history)
		{
			PowerHistoryEntity phEntity = history.Entity;

			Playable oldEntity = (Playable) game.IdEntityDic[phEntity.Id];
			Card newCard = Cards.FromId(history.CardId);
			if (oldEntity.Card.Type == newCard.Type)
			{
				oldEntity.Card = newCard;
			}
			else
			{
				Playable entity;
				switch (newCard.Type)
				{
					case CardType.MINION:
						entity = new Minion(oldEntity.Controller, newCard, oldEntity.NativeTags, oldEntity.Id);
						break;
					case CardType.SPELL:
						entity = new Spell(oldEntity.Controller, newCard, oldEntity.NativeTags, oldEntity.Id);
						break;
					case CardType.HERO:
						entity = new Hero(oldEntity.Controller, newCard, oldEntity.NativeTags, oldEntity.Id);
						break;
					case CardType.WEAPON:
						entity = new Weapon(oldEntity.Controller, newCard, oldEntity.NativeTags, oldEntity.Id);
						break;
					default:
						throw new ArgumentNullException();
				}

				switch (oldEntity.Zone.Type)
				{
					case Zone.PLAY:
						oldEntity.Controller.BoardZone.ChangeEntity((Minion)oldEntity, (Minion)entity);
						break;
					case Zone.DECK:
						oldEntity.Controller.DeckZone.ChangeEntity(oldEntity, entity);
						break;
					case Zone.HAND:
						oldEntity.Controller.HandZone.ChangeEntity(oldEntity, entity);
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}

		private static InequalityFlags Equals(Game a, Game b)
		{
			var flag = InequalityFlags.Game;

			if (!Equals(a.NativeTags, b.NativeTags)) return flag | InequalityFlags.Tags;

			flag |= Equals(a.CurrentPlayer, b.CurrentPlayer);
			if (CheckFlag(flag)) return flag | InequalityFlags.CurrentPlayer;

			flag |= Equals(a.CurrentOpponent, b.CurrentOpponent);
			if (CheckFlag(flag)) return flag | InequalityFlags.CurrentOpponent;

			return InequalityFlags.None;
		}

		private static bool Equals<K, V>(IDictionary<K, V> a, IDictionary<K, V> b)
		{
			if (a.Count != b.Count) return false;

			foreach (KeyValuePair<K, V> item in a)
				if (!b.Contains(item))
					return false;

			return true;
		}

		private static InequalityFlags Equals(Controller a, Controller b)
		{
			var flag = InequalityFlags.None;

			//if (!Equals(a.NativeTags, b.NativeTags)) return InequalityFlags.Tags;

			if (a.ControllerAuraEffects != b.ControllerAuraEffects)
				return InequalityFlags.AuraEffects;

			flag |= Equals(a.Hero, b.Hero);
			if (CheckFlag(flag)) return flag;

			flag |= Equals(a.HandZone, b.HandZone);
			if (CheckFlag(flag)) return flag | InequalityFlags.Hand;
			flag |= Equals(a.BoardZone, b.BoardZone);
			if (CheckFlag(flag)) return flag | InequalityFlags.Board;
			flag |= Equals(a.SecretZone, b.SecretZone);
			if (CheckFlag(flag)) return flag | InequalityFlags.Secrets;
			flag |= Equals(a.DeckZone, b.DeckZone);
			if (CheckFlag(flag)) return flag | InequalityFlags.Deck;

			return InequalityFlags.None;
		}

		private static InequalityFlags Equals<T>(Zone<T> a, Zone<T> b) where T : IPlayable
		{
			if (a.Count != b.Count) return InequalityFlags.Attributes;

			var flag = InequalityFlags.None;

			ReadOnlySpan<T> aSpan = a.GetSpan();
			ReadOnlySpan<T> bSpan = b.GetSpan();

			for (int i = 0; i < aSpan.Length; i++)
			{
				flag |= Equals(aSpan[i], bSpan[i]);
				if (CheckFlag(flag)) return flag;
			}

			return InequalityFlags.None;
		}

		private static InequalityFlags Equals(DeckZone a, DeckZone b)
		{
			if (a.Count == b.Count) return InequalityFlags.None;
			return InequalityFlags.Attributes;

			// TODO
			// Cost, ATK, HEALTH
		}

		private static InequalityFlags Equals(IPlayable a, IPlayable b)
		{
			switch (a)
			{
				case Minion m:
					return Equals(m, (Minion)b);
				case Playable p:
					return Equals(p, (Playable) p);
				default:
					throw new NotImplementedException();
			}
		}

		private static bool Equals(Enchantment a, Enchantment b)
		{
			return a.CapturedCard == b.CapturedCard &&
			       a.Creator.Id == b.Creator.Id &&
			       a.Controller.Id == b.Controller.Id &&
			       a.IsOneTurnActive == b.IsOneTurnActive &&
			       a.ScriptTag1 == b.ScriptTag1 &&
			       a.ScriptTag2 == b.ScriptTag2 &&
			       !CheckFlag(Equals(a.ActivatedTrigger, b.ActivatedTrigger));
		}

		private static InequalityFlags Equals(Trigger a, Trigger b)
		{
			if (a?.Type != b?.Type) return InequalityFlags.Trigger;
			return InequalityFlags.None;
		}

		private static bool Equals(Aura a, Aura b)
		{
			// I guess we don't need to check auras
			return true;
		}

		private static InequalityFlags Equals(Hero a, Hero b)
		{
			var flag = InequalityFlags.Hero;

			if (a.Auras.Count != b.Auras.Count) return flag | InequalityFlags.Attributes;
			for (int i = 0; i < a.Auras.Count; i++)
				if (!Equals(a.Auras[i], b.Auras[i]))
					return flag | InequalityFlags.Attributes;

			flag |= Equals(a.HeroPower, b.HeroPower);
			if (CheckFlag(flag)) return flag;

			flag |= Equals(a.Weapon, b.Weapon);
			if (CheckFlag(flag)) return flag;

			flag |= Equals((Character)a, b);
			if (CheckFlag(flag)) return flag;

			return InequalityFlags.None;
		}

		private static InequalityFlags Equals(Weapon a, Weapon b)
		{
			var flag = InequalityFlags.Weapon;

			if (a is null) return b is null ? InequalityFlags.None : flag;
			if (b is null) return flag;

			flag |= Equals((Playable) a, b);
			if (CheckFlag(flag)) return flag;

			return InequalityFlags.None;
		}

		private static InequalityFlags Equals(Character a, Character b)
		{
			var flag = InequalityFlags.Character;

			if (!(a.AttackDamage != b.AttackDamage ||
			      a.BaseHealth != b.BaseHealth ||
			      a.Damage != b.Damage ||
			      a.NumAttacksThisTurn != b.NumAttacksThisTurn ||
			      a.HasStealth != b.HasStealth ||
			      a.IsImmune != b.IsImmune ||
			      a.HasTaunt != b.HasTaunt ||
			      a.CantBeTargetedBySpells != b.CantBeTargetedBySpells))
				return flag | InequalityFlags.Attributes;

			flag |= Equals((Playable) a, b);
			if (CheckFlag(flag)) return flag;

			return InequalityFlags.None;
		}

		private static InequalityFlags Equals(Playable a, Playable b)
		{
			var flag = InequalityFlags.Playable;

			flag |= Equals(a.ActivatedTrigger, b.ActivatedTrigger);
			if (CheckFlag(flag)) return flag;


			List<Enchantment> aEnchantments = a.AppliedEnchantments;
			List<Enchantment> bEnchantments = b.AppliedEnchantments;

			if (aEnchantments is null)
			{
				if (!(bEnchantments is null)) return flag | InequalityFlags.Enchantments;
			}
			else
			{
				if (bEnchantments is null) return flag | InequalityFlags.Enchantments;
				if (aEnchantments.Count != bEnchantments.Count) return flag | InequalityFlags.Enchantments;
				for (int i = 0; i < aEnchantments.Count; i++)
				{
					if (!Equals(aEnchantments[i], bEnchantments[i]))
						return flag | InequalityFlags.Enchantments;
				}
			}

			if (!(a.IsExhausted == b.IsExhausted &&
			      a.ZonePosition == b.ZonePosition &&
			      a.Cost == b.Cost))
			{
				// Playable attribute mismatch
				return flag | InequalityFlags.Attributes;
			}

			flag |= Equals((Entity) a, b);

			if ((flag & InequalityFlags.None) != InequalityFlags.None) return flag;

			return InequalityFlags.None;
		}

		private static InequalityFlags Equals(Entity a, Entity b)
		{
			InequalityFlags flag = InequalityFlags.Entity;

			if (!Equals(a.NativeTags, b.NativeTags)) return flag | InequalityFlags.Tags;

			if (a.AuraEffects != b.AuraEffects) return flag | InequalityFlags.AuraEffects;

			if (a.OrderOfPlay != b.OrderOfPlay) return flag | InequalityFlags.Attributes;

			return InequalityFlags.None;
		}

		private static InequalityFlags Equals(Unknown a, Playable b)
		{
			return InequalityFlags.None;
		}
		private static InequalityFlags Equals(Playable a, Unknown b)
		{
			return InequalityFlags.None;
		}

		[Flags]
		private enum InequalityFlags
		{
			None = 1,
			Attributes = 1 << 1,
			Trigger = 1 << 2,
			Enchantments = 1 << 3,
			Entity = 1 << 4, Playable = 1 << 5, Character = 1 << 6, Hero = 1 << 7, Minion = 1 << 8,
			Weapon = 1 << 9, HeroPower = 1 << 10,
			Hand = 1 << 11, Board = 1 << 12, Secrets = 1 << 13, Deck = 1 << 14,
			CurrentPlayer = 1 << 15, CurrentOpponent = 1 << 16, AuraEffects = 1 << 17, Game = 1 << 18,
			Tags = 1 << 19
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool CheckFlag(InequalityFlags flag)
		{
			return (flag & InequalityFlags.None) != InequalityFlags.None;
		}

		public static void EqualTest()
		{
			var rnd = new Random();
			Game game = new Game(new GameConfig
			{
				Player1HeroClass = (CardClass) rnd.Next(2, 11),
				Player2HeroClass = (CardClass) rnd.Next(2, 11),
				History = false,
				Logging = false,
				FillDecks = true,
				SkipMulligan = true,
				Shuffle = false,
			});
			game.StartGame();

			Game clone;
			do
			{
				List<PlayerTask> options = game.CurrentPlayer.Options();
				PlayerTask option = options[rnd.Next(options.Count)];
				game.Process(option);
				clone = game.Clone();
				InequalityFlags flag = Equals(game, clone);
				if (CheckFlag(flag))
					throw new Exception(flag.ToString());

			} while (game.State != State.COMPLETE);
		}

		private class Abstraction
		{
			private readonly int[] _data;

			public Abstraction(Game game)
			{
				var data = new List<int>
				{
					(int) game.State,
					game.Turn,
					(int) game.Step,
					game.NumMinionsKilledThisTurn
				};
			}

			private static void ReadController(Controller c)
			{
				var data = new List<int>
				{
					(int) c.PlayState,
					c.BaseMana,
					c.TemporaryMana,
					c.UsedMana,
					c.OverloadLocked,
					c.OverloadThisGame,
					c.IsComboActive.ToInt(),
					c.CurrentSpellPower,
					c.TemporusFlag.ToInt(),
					c.NumCardsDrawnThisTurn,
					c.LastCardDiscarded,
					c.NumCardsPlayedThisTurn,
					c.NumMinionsPlayedThisTurn,
					c.NumOptionsPlayedThisTurn,
					c.NumFriendlyMinionsThatDiedThisTurn,
					c.AmountHeroHealedThisTurn,
					c.NumMinionsPlayerKilledThisTurn,
					c.NumElementalsPlayedThisTurn,
					c.NumFriendlyMinionsThatAttackedThisTurn,
					c.HeroPowerActivationsThisTurn,
					c.NumTotemSummonedThisGame,
					c.TotalManaSpentThisGame,
					c.NumSecretsPlayedThisGame,
					c.NumSpellsPlayedThisGame,
					c.NumWeaponsPlayedThisGame,
					c.NumMurlocsPlayedThisGame,
				};
			}

			private static void ReadHero(Hero h)
			{
				var data = new List<int>
				{
					(int)h.Card.Class,
					h.Health,
					h.Armor,
					h.AttackDamage,
					h.IsExhausted.ToInt(),
					h.HasStealth.ToInt(),
					h.IsImmune.ToInt(),
					h.Fatigue,
					h.HeroPower.Card.AssetId,
					h.HeroPower.Cost,
					h.HeroPower.IsExhausted.ToInt(),
				};
			}

			private static void ReadWeapon(Weapon w)
			{
				if (w is null) return;

				var data = new List<int>
				{
					w.Card.AssetId,
					w.AttackDamage,
					w.Durability,
					w.Poisonous.ToInt(),
					w.IsImmune.ToInt(),
					w.HasLifeSteal.ToInt()
				};
			}
		}

		private static int ToInt(this bool b)
		{
			return b ? 1 : 0;
		}
	}
}
