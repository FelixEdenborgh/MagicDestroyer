/*
namespace MagicDestroyer.Characters.Mele
{
    using MagicDestroyer.Armor.Leather;
    using MagicDestroyer.Armor.Mail;
    using MagicDestroyer.Characters.Enumerations;
    using MagicDestroyer.Weapons.Blunt;
    using MagicDestroyer.Weapons.Sharp;
    using System;

    public class Knight : Melee
    {
        private const string DEFAULT_NAME = "Knight";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const Factions DEFAULT_FRACTION = Factions.Melee;
        private readonly Hammer DEFAULT_WEAPON = new Hammer();
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();

        private Chainlink bodyArmor;
        private Hammer weapon;

        public Chainlink BodyArmor
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
        public Hammer Weapon
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

        public void HolyBlow() 
        {
            throw new NotImplementedException();
        }
        public void PurifySoul() 
        {
            throw new NotImplementedException();
        }
        public void RighteousWings() 
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            this.HolyBlow();
        }
        public override void SpecialAttack()
        {
            this.PurifySoul();
        }
        public override void Defend()
        {
            this.RighteousWings();
        }

        public Knight(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FRACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public Knight(string name, int level)
            : this(name, level, DEFAULT_ABILITY_POINTS)
        {
        }

        public Knight()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
    }
}*/