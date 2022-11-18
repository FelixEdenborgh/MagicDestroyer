
namespace MagicDestroyer.Characters.Spellcasters
{
    using MagicDestroyer.Armor.Cloth;
    using MagicDestroyer.Armor.Leather;
    using MagicDestroyer.Armor.Mail;
    using MagicDestroyer.Characters.Enumerations;
    using MagicDestroyer.Weapons.Blunt;
    using System;

    public class Mage : Spellcaster
    {
        private const string DEFAULT_NAME = "Mage";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 20;
        private const int healthPoints = 100;
        private const Factions DEFAULT_FRACTION = Factions.Spellcaster;
        private readonly Staff DEFAULT_WEAPON = new Staff();
        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();

        private ClothRobe bodyArmor;
        private Staff weapon;

        public ClothRobe BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public Staff Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public int ArcaneWrath() 
        {
            return base.Weapon.Damage + 10;
        }
        public int Firewall() 
        {
            return base.Weapon.Damage + 10;
        }
        public int Meditation() 
        {
            return base.BodyArmor.ArmorPoints + 1;
        }

        public override int Attack()
        {
            return this.Firewall();
        }
        public override int SpecialAttack()
        {
            return this.ArcaneWrath();
        }
        public override int Defend()
        {
            return this.Meditation();
        }

        public Mage(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FRACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public Mage(string name, int level)
            : this(name, level, DEFAULT_MANA_POINTS)
        {
        }

        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
    }



}