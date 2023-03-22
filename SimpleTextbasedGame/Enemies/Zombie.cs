using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextbasedGame.Enemies
{
    public class Zombie : Enemy
    {
        public int Damage { get; set; }
        public Zombie()
        {
            Health = 100;
            Damage = 10;
        }
        public void Speak()
        {
            Console.WriteLine("Gueeeg, I'm a zombie.");
        }

        public void Attack()
        {
            Console.WriteLine($"Zombie attacks for {Damage} damage!");
        }


        public void ShowHealth()
        {
            if (Health <= 0)
                Console.WriteLine("You killed it!");
            else
                Console.WriteLine($"A fine hit! The Zombie has {Health} health left.");
        }
    }
}
