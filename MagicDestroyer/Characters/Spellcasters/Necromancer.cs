/*
namespace MagicDestroyer.Characters.Spellcasters
{
    using MagicDestroyer.Armor.Cloth;
    using MagicDestroyer.Armor.Leather;
    using MagicDestroyer.Characters.Enumerations;
    using MagicDestroyer.Weapons.Blunt;
    using MagicDestroyer.Weapons.Sharp;
    using System;

    public class Necromancer : Spellcaster
    {
        private const string DEFAULT_NAME = "Necromancer";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 20;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const Factions DEFAULT_FRACTION = Factions.Spellcaster;
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

        public void ShadowRage() 
        {
            throw new NotImplementedException();
        }
        public void VampireTouch() 
        {
            throw new NotImplementedException();
        }
        public void BoneShield() 
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            this.ShadowRage();
        }
        public override void SpecialAttack()
        {
            this.VampireTouch();
        }
        public override void Defend()
        {
            this.BoneShield();
        }

        public Necromancer(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FRACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public Necromancer(string name, int level)
            : this(name, level, DEFAULT_MANA_POINTS)
        {
        }

        public Necromancer()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
    }



}*/