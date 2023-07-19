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
           // Game starts and asks player for name as an input. Stores player name in variable "name"
            Console.WriteLine("Commerc\n\nNavigating the world on Command Line! \n\nWhat is your name, traveller?\n\n");
            var name = Console.ReadLine();
            Player Player = new Player();
            Player.name = name;
            //Introducts player to BuyShip() function and ahows current player statistics after buying boat. (Name, Money left, Ship Type)
            Console.WriteLine($"Hi {name}!\n So you can start your journey, we have given you 500 coins of the finest gold!\n Why not buy a ship so you can travel further?");
            Ship ship = new Ship();
            ship.BuyShip();
            Player.PlayerStats();
            Console.ReadLine();

            
            
            





        }
    }
}
