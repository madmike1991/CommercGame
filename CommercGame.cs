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
            Console.WriteLine("Commerc\nNavigating the world on Command Line! \nWhat is your name, traveller?\n");
            var name = Console.ReadLine();
            Player Player = new Player();
            Player.name = name;
            Console.WriteLine($"Hi {name}!\n So you can start your journey, we have given you 500 coins of the finest gold!\n Why not buy a ship so you can travel further?");
            Ship ship = new Ship();
            ship.BuyShip();    
            
            





        }
    }
}
