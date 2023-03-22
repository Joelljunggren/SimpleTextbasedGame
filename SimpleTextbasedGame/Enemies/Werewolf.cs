using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextbasedGame.Enemies
{
    public class Werewolf : Enemy
    {
        public int Damage { get; set; }
        public Werewolf()
        {
            Health = 80;
            Damage = 15;
        }

        public void Speak()
        {
            Console.WriteLine("Roaaar, I'm a werewolf!.");
        }

        public int AttackChance()
        {
            var random = new Random();
            var attackChance = random.Next(1, 10);
            return attackChance;
        }

        public void ShowHealth()
        {
            if (Health <= 0)
                Console.WriteLine("You killed it!");
            else
                Console.WriteLine($"A fine hit! The Werewolf has {Health} health left.");
        }
    }
}
