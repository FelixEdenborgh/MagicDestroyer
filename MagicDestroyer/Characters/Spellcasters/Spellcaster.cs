
namespace MagicDestroyer.Characters.Spellcasters
{
    public abstract class Spellcaster : Character
    {
        private int manaPoints;

        public int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 10 && value <= 20)
                {
                    this.manaPoints = value;
                }
                else
                {
                    System.Console.WriteLine("Inapproparate value! AbilityPoints cant be set to negative. Max = 20 \nDefault set to 10");
                    this.manaPoints = 10;
                }
            }
        }

        public Spellcaster(string name, int level, int manaPoints)
            : base(name, level)
        {
            this.Name = name;
            this.Level = level;
            this.ManaPoints = manaPoints;
        }
    }
}
