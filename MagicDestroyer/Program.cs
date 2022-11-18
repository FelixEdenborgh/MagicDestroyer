using MagicDestroyer.Characters;
using MagicDestroyer.Characters.Mele;
using MagicDestroyer.Characters.Spellcasters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            bool gameOver = false;


            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Warrior(),
                new Warrior(),
                //new Knight(),
                //new Assassin(),
                new Mage(),
                new Mage(),
                new Mage()
                //new Druid(),
                //new Necromancer()
            };

            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellcasterTeam= new List<Spellcaster>();


            foreach (var character in characters)
            {
                if(character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if(character is Spellcaster)
                {
                    spellcasterTeam.Add((Spellcaster)character);
                }
            }

            int currentMele;
            int currentSpellcast;


            while (!gameOver)
            {
                currentMele = rng.Next(0, meleeTeam.Count);
                currentSpellcast = rng.Next(0, spellcasterTeam.Count);

                spellcasterTeam[currentSpellcast].TakeDamage(meleeTeam[currentMele].Attack(), meleeTeam[currentMele].Name);

                if (!spellcasterTeam[currentSpellcast].IsAlive)
                {
                    meleeTeam[currentMele].WonBattle();
                    spellcasterTeam.Remove(spellcasterTeam[currentSpellcast]);

                    if (spellcasterTeam.Count == 0)
                    {
                        Console.WriteLine("Melee team Win!");
                        break;
                    }
                    else
                    {
                        currentSpellcast = rng.Next(0, spellcasterTeam.Count);
                    }
                }

                meleeTeam[currentMele].TakeDamage(Convert.ToInt32(spellcasterTeam[currentSpellcast].Attack()), spellcasterTeam[currentSpellcast].Name);

                if (!meleeTeam[currentMele].IsAlive)
                {
                    spellcasterTeam[currentSpellcast].WonBattle();
                    meleeTeam.Remove(meleeTeam[currentMele]);

                    if (meleeTeam.Count == 0)
                    {
                        Console.WriteLine("Spellcaster team Win!");
                        break;
                    }
                    else
                    {
                        currentMele = rng.Next(0, meleeTeam.Count);
                    }
                }
            }
        }
    }
}
