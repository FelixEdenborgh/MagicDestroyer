/*
namespace MagicDestroyer.Characters.Spellcasters
{
    using MagicDestroyer.Armor.Leather;
    using MagicDestroyer.Armor.Mail;
    using MagicDestroyer.Characters.Enumerations;
    using MagicDestroyer.Weapons.Blunt;
    using MagicDestroyer.Weapons.Sharp;
    using System;

    public class Druid : Spellcaster
    {
        private const string DEFAULT_NAME = "Druid";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 20;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const Factions DEFAULT_FRACTION = Factions.Spellcaster;
        private readonly Staff DEFAULT_WEAPON = new Staff();
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();

        private LeatherVest bodyArmor;
        private Staff weapon;


        public LeatherVest BodyArmor
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

        public void Moonfire() 
        {
            throw new NotImplementedException();
        }
        public void Starburst() 
        {
            throw new NotImplementedException();
        }
        public void OneWithTheNature() 
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            this.Moonfire();
        }
        public override void SpecialAttack()
        {
            this.Starburst();
        }
        public override void Defend()
        {
            this.OneWithTheNature();
        }

        public Druid(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FRACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public Druid(string name, int level)
            : this(name, level, DEFAULT_MANA_POINTS)
        {
        }

        public Druid()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
    }



}*/