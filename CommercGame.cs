using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercGame
{
    internal class CommercGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Commerc \nNavigating the world on Command Line! \nWhat is your name, traveller?");
            var Name = Console.ReadLine();
            var Money = 500.0;
            Player name = new Player(Name, Money);
            Console.WriteLine($"Hi {Name}!");
            Console.WriteLine("So you can start your journey, we have given you 500 coins of the finest gold! Why not buy a ship so you can travel further?");
            Console.ReadLine();




        }
    }
}
