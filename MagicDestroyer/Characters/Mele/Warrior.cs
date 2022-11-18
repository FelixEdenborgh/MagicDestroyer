
namespace MagicDestroyer.Characters.Mele
{
    using MagicDestroyer.Armor.Mail;
    using MagicDestroyer.Characters.Enumerations;
    using MagicDestroyer.Weapons.Blunt;
    using MagicDestroyer.Weapons.Sharp;
    using System;

    public class Warrior : Melee
    {
        private const string DEFAULT_NAME = "Warrior";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int healthPoints = 100;
        private const Factions DEFAULT_FRACTION = Factions.Melee;
        private readonly Axe DEFAULT_WEAPON= new Axe();
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();

        public int Strike() 
        {
            return base.Weapon.Damage + 10;
        }
        public int Execute() 
        {
            return base.Weapon.Damage + 10;
        }
        public int SkinHarden() 
        {
            return base.BodyArmor.ArmorPoints + 1;
        }

        public override int Attack()
        {
            return this.Strike();
        }
        public override int SpecialAttack()
        {
            return this.Execute();
        }
        public override int Defend()
        {
            return this.SkinHarden();
        }

        public Warrior(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FRACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public Warrior(string name, int level)
            : this(name, level, DEFAULT_ABILITY_POINTS)
        {
        }

        public Warrior()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
    }
}