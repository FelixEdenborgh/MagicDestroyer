
namespace MagicDestroyer.Characters.Mele
{
    public abstract class Melee : Character
    {
        private int abilityPoints;

        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 10 && value <= 20)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    System.Console.WriteLine("Inapproparate value! AbilityPoints cant be set to negative. Max = 20 \nDefault set to 10");
                    this.abilityPoints = 10;
                }
            }
        }

        public Melee(string name, int level, int abilityPoints)
            : base(name, level) 
        {
            this.Name = name;
            this.Level = level;
            this.AbilityPoints = abilityPoints;
        }
    }
}
