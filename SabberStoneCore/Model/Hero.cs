using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;

namespace SabberStoneCore.Model
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

        public string FullPrint()
        {
            var str = new StringBuilder();
            var mStr = Weapon != null ? $"[{Weapon.Card.Name}[{Weapon.AttackDamage}/{Weapon.Durability}]]" :"[NO WEAPON]";
            str.Append($"[HERO][{this}][ATK{AttackDamage}/AR{Armor}/HP{Health}][{mStr}][SP{SpellPowerDamage}]");
            str.Append($"[ENCH {Enchants.Count}]");
            str.Append($"[TRIG {Triggers.Count}]");
            return str.ToString();
        }
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