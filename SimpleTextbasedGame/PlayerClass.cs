using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextbasedGame
{
    public class PlayerClass
    {
        public string Name { get; set; }
        public int Health { get; set ; }
        public int Damage { get; set; }
        public int HealthPotions { get; set; }

        public PlayerClass()
        {
            //Ska ändra i app sen så att man kan skapa sina egna karaktärer
            Health = 100;
            Damage = 25;
            HealthPotions = 5;
        }

        public void PlayerMonologue()
        {
            Console.WriteLine($"I {Name}, have come to free these torrid lands of evil.");
            Console.WriteLine($"Stand before me and my mighty {Health} health and tremble!");
        }

        public void ShowHealth()
        {
            if (Health <= 0)
                Console.WriteLine("You died!");
            else
                Console.WriteLine($"You took quite the hit! You now have {Health} health left.");
        }

        public int AttackChance()
        {
            var random = new Random();
            var attackChance = random.Next(1, 10);
            return attackChance;
        }

        public void DrinkHealingPotion()
        {
            //Player.drinkHealingPotion is probably a better way to go about it.
            Console.WriteLine("The battle is over!");
            Console.WriteLine($"You survived with {Health} health left.\n");

            Console.Write("Drink a Health Potion? Yes/no: ");
            var healing = Console.ReadLine();
            if (healing == "yes")
            {
                HealthPotions -= 1;
                Health += 25;
                Console.WriteLine($"You heal yourself up to {Health} and have {HealthPotions} potions left.");
                Console.Write("Drink another one? Yes/no: ");
                var choice = Console.ReadLine();
                if (choice == "yes")
                {
                    Health += 25;
                    HealthPotions -= 1;
                    Console.WriteLine($"You drink another Health Potion and heal yourself up to {Health}.");
                    Console.WriteLine($"{HealthPotions} potions left now.");
                }
            }
            if (healing == "no")
            {
                Console.WriteLine($"You stay at {Health} and keep moving forward.");
            }

        }
    }
}
