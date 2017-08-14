using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using System;
using System.Collections.Generic;

namespace SabberStoneCore.Model.Entities
{
	public partial class Hero : Character<Hero>
	{
		public HeroPower Power { get; set; }

		public Weapon Weapon { get; set; }

		public Hero(Controller controller, Card card, Dictionary<GameTag, int> tags)
			: base(controller, card, tags)
		{
			Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Hero", $"{card.Name} ({card.Class}) was created.");
		}

		public int TotalAttackDamage => AttackDamage + (Weapon?.AttackDamage ?? 0);

		public override bool CanAttack => TotalAttackDamage > 0 && base.CanAttack;

		public override bool HasWindfury => base.HasWindfury || Weapon != null && Weapon.HasWindfury;

		public void AddWeapon(Weapon weapon)
		{
			RemoveWeapon();
			weapon.SetOrderOfPlay("WEAPON");
			Weapon = weapon;
			Weapon[GameTag.ZONE] = (int)Enums.Zone.PLAY;
			Weapon[GameTag.ZONE_POSITION] = 0;
			if (Game.History)
			{
				Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.POWER, Weapon.Id, "", -1, 0));
				Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());
			}
			EquippedWeapon = weapon.Id;
		}

		public void RemoveWeapon()
		{
			if (Weapon == null)
			{
				return;
			}

			if (Weapon.HasDeathrattle)
			{
				Weapon.ApplyEnchantments(EnchantmentActivation.DEATHRATTLE, Enums.Zone.GRAVEYARD);
			}
			Game.Log(LogLevel.INFO, BlockType.PLAY, "Hero", $"Butcher's knife incoming to graveyard, say 'gugus' to {Weapon}");
			Controller.GraveyardZone.Add(Weapon);
			Weapon = null;
			EquippedWeapon = 0;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		protected override void InternalStamp(IModel entity)
		{
			// Do nothing, stamping was taken care of by Controller.InternalStamp
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			// Do nothing, toHash has been taken care of by Controller.InternalToHash
			return String.Empty;
		}

		protected override Entity InternalDeepClone(Game newGame)
		{
			var heroClone = new Hero(newGame.ControllerById(Controller.Id), Card, null)
			{
				// Weapon could be null!
				Weapon = Weapon?.Clone(newGame) as Weapon,
				// Hero power should ALWAYS be set.
				Power = Power.Clone(newGame) as HeroPower,
			};

			// Manually push cloned entities to newGame.
			newGame.EntityContainer[Id] = heroClone;
			if(heroClone.Weapon != null)
			{
				newGame.EntityContainer[Weapon.Id] = heroClone.Weapon;
			}

			return heroClone;
		}

		#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}

	public partial class Hero
	{
		public int SpellPowerDamage
		{
			get { return this[GameTag.SPELLPOWER]; }
			set { this[GameTag.SPELLPOWER] = value; }
		}

		public int EquippedWeapon
		{
			get { return this[GameTag.WEAPON]; }
			set { this[GameTag.WEAPON] = value; }
		}

		public int HeroPowerDamage
		{
			get { return this[GameTag.HEROPOWER_DAMAGE]; }
			set { this[GameTag.HEROPOWER_DAMAGE] = value; }
		}

		public int Fatigue
		{
			get { return this[GameTag.FATIGUE]; }
			set { this[GameTag.FATIGUE] = value; }
		}

	}
}