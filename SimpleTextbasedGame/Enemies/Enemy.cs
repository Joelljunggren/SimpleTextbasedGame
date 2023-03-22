using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextbasedGame.Enemies
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }


        public void Speak()
        {
            Console.WriteLine("Hello there, I am a generic enemy");
        }
    }
}
