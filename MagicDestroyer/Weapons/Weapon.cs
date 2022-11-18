using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyer.Weapons
{
    public abstract class Weapon
    {
        private int damage;

        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value >= 1)
                {
                    this.damage = value;
                }
                else
                {
                    System.Console.WriteLine("Inapproparate value! Damage on Weapons should only be 1 or higher! \nDefault is set to 1");
                    this.damage = 1;
                }

            }
        }

        protected Weapon()
        {
            this.Damage = 5;
        }
    }
}
