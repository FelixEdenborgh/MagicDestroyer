
using MagicDestroyer.Armor;
using MagicDestroyer.Armor.Mail;
using MagicDestroyer.Armors;
using MagicDestroyer.Characters.Enumerations;
using MagicDestroyer.Characters.Interfaces;
using MagicDestroyer.Weapons;
using MagicDestroyer.Weapons.Sharp;

namespace MagicDestroyer.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private int healthPoints;
        private int level;
        private int scores;

        private Factions faction;
        private string name;

        private bool isAlive;


        private Armores bodyArmor;
        private Weapon weapon;

        public Armores BodyArmor
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
        public Weapon Weapon
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


        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }

        public int Scores
        {
            get
            {
                return scores;
            }
            set 
            {
                scores = value; 
            }

        }
        
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 10)
                {
                    this.healthPoints = value;
                }
                else
                {
                    System.Console.WriteLine("Inapproparate value! HealPoints cant be set under 10.\nMin: 10 Max: 100 \nDefault set to 10");
                }

            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 0)
                {
                    this.level = value;
                }
                else
                {
                    System.Console.WriteLine("Inapproparate value! Level most be between 1 and 100. Default Level = 0");
                    this.level = 0;
                }
            }
        }

        public Factions Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    this.name = value;
                }
                else
                {
                    System.Console.WriteLine("Inapproparate value! Name most be Min: 2 and Max 10 characters!\nDefault set to Warrior");
                    this.name = "Warrior";
                }

            }
        }

        public Character()
        {

        }

        public Character(string name, int level)
        {
            this.Name = name;
            this.level = level;
        }

        public abstract int Attack();

        public abstract int SpecialAttack();

        public abstract int Defend();

        public void TakeDamage(int damage, string attackerName)
        {
            if(this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();

                if (this.healthPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                System.Console.WriteLine("Haha! Your damage was not enough to harm me!");
            }

            if(!this.isAlive)
            {
                System.Console.WriteLine($"{this.name} recived {damage} from {attackerName} damage, and is now dead!");
            }
            else
            {
                System.Console.WriteLine($"{this.name} recived {damage} from {attackerName} damage, and now has {this.healthPoints}!");
            }
            
        }

        public void WonBattle()
        {
            this.scores++;

            if(this.scores % 10 == 0)
            {
                this.level++;
            }
        }

        
    }
}
