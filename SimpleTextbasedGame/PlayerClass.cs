using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextbasedGame
{
    public class PlayerClass
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public PlayerClass()
        {
            //Ska ändra i app sen så att man kan skapa sina egna karaktärer
            Health = 100;
            Damage = 25;
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
    }
}
