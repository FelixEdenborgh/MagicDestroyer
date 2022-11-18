/*
namespace MagicDestroyer.Characters.Mele
{
    using MagicDestroyer.Armor.Leather;
    using MagicDestroyer.Armor.Mail;
    using MagicDestroyer.Characters.Enumerations;
    using MagicDestroyer.Weapons.Blunt;
    using MagicDestroyer.Weapons.Sharp;
    using System;

    public class Assassin : Melee
    {
        private const string DEFAULT_NAME = "Assassin";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const Factions DEFAULT_FRACTION = Factions.Melee;
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();

        private LeatherVest bodyArmor;
        private Sword weapon;

        

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
        public Sword Weapon
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

        public void Raze() 
        {
            throw new NotImplementedException();
        }
        public void Bleed() 
        {
            throw new NotImplementedException();
        }
        public void Survival() 
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            this.Raze();
        }
        public override void SpecialAttack()
        {
            this.Bleed();
        }
        public override void Defend()
        {
            this.Survival();
        }

        public Assassin(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FRACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public Assassin(string name, int level)
            : this(name, level, DEFAULT_ABILITY_POINTS)
        {
        }

        public Assassin()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
    }
}*/