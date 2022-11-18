
namespace MagicDestroyer.Armors
{
    public class Armores
    {
        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return this.armorPoints;
            }
            set
            {
                if (value >= 1)
                {
                    this.armorPoints = value;
                }
                else
                {
                    System.Console.WriteLine("Inapproparate value! ArmorPoints should always be set to 1 or higher. \nArmorPoint set to Default: 1");
                }
            }
        }
    }
}
