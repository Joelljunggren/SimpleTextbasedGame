using SimpleTextbasedGame;
using SimpleTextbasedGame.Enemies;
using System.Security.Cryptography.X509Certificates;

public class App
{
    PlayerClass player = new PlayerClass();

    public void Run()
    {
        Zombie zombie = new Zombie();
        //PlayerClass player = new PlayerClass();

        Console.Write("Enter your name: ");
        player.Name = Console.ReadLine();
        Console.WriteLine("You reach a fork in the road, will you go left or right?");
        var whereToGo = Console.ReadLine().ToLower();
        if (whereToGo == "left")
            GoingLeft();
        //if (whereToGo == "right")
        //    GoingRight();
    }
    public void GoingLeft()
    {
        Console.Clear();
        Console.WriteLine("You stumble upon a werewolf, having some tea, minding its own bussiness.");
        Console.Write("\nWill you attack this curious tea-drinking werewolf? Yes/No: ");
        var choice = Console.ReadLine().ToLower();
        if (choice == "yes")
            AttackWerewolf();
    }

    public void AttackWerewolf()
    {
        Console.Clear();
        Werewolf werewolf = new Werewolf();
        Console.WriteLine($"The werewolf currently sits on a mighty {werewolf.Health} health.\n");
        Console.WriteLine("You get first stab at it, literally.\n");

        Console.Write("Commence epic battle? Yes/No: ");
        var choice = Console.ReadLine().ToLower();
        if (choice == "yes")
        {
            Console.Clear();
            Console.WriteLine("QUEUE INTENSE BOSS MUSIC!\n");
            while (werewolf.Health >= 0 && player.Health >= 0)
            {
                Convert.ToInt32(player.AttackChance());
                if (player.AttackChance() <= 5)
                    Console.WriteLine("You missed, how tragic!\n");
                else
                {
                    werewolf.Health -= player.Damage;
                    werewolf.ShowHealth();
                    Console.WriteLine();
                }
                Convert.ToInt32(werewolf.AttackChance());
                if (werewolf.AttackChance() <= 5)
                    Console.WriteLine("The werewolf swipes, and misses!\n");
                else
                {
                    player.Health -= werewolf.Damage;
                    player.ShowHealth();
                    Console.WriteLine();
                }
            }
            Console.WriteLine("The battle is over!");
            Console.WriteLine($"You survived with {player.Health} health left.");
        }
    }
}