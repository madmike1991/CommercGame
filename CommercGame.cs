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
            Player player;
            bool isGameRunning = true;
            Console.WriteLine("Commerc\n\nNavigating the world on Command Line! \n\nWhat is your name, traveller?\n\n");
            var name = Console.ReadLine();
            player = new Player(name);
            Console.WriteLine($"\nHi {name}!\nSo you can start your journey, we have given you 500 coins of the finest gold!\nWhy not buy a ship so you can travel further?");
           
            
            while (isGameRunning)
            {
                Console.WriteLine("\nWhich ship would you like to buy?");
                Console.WriteLine("\n1 - Rubber Dinghy 100$. Can take up to 100Kg of merchandise.\n2 - Jon Boat 250$. Can take up to 200Kg of merchandise.\n3 - Pontoon Boat 350$. Can take up to 400Kg of merchandise.");

                var Choice = (Console.ReadLine());
                int i;
                bool IsNumeric = int.TryParse(Choice, out i);
                while (!IsNumeric)
                {
                    Console.WriteLine("Please type the correct option");
                    Console.ReadLine();

                    return;
                }

                switch (i)
                {
                    case 1:

                        var shipType = "Rubber Dinghy";
                        var shipSize = 100;
                        var shipPrice = 600.0;
                        if (shipPrice < player.Money)
                        {
                            var money = player.Money - shipPrice;
                            player.SetMoney(money);
                            player.SetPShip(shipType);
                            Console.WriteLine($"That won't get you very far, but I guess it's better than nothing...\nYou paid 100$ for the Boat. You have {player.Money}$ left");
                        }
                        else
                        {
                            Console.WriteLine("You cannot afford this boat at the moment!");
                        }
                        break;

                     case 2:
                            shipType = "Jon Boat";
                            shipSize = 200;
                            shipPrice = 250.0;
                            if (shipPrice < player.Money)
                            {
                                 var money = player.Money - shipPrice;
                                 player.SetMoney(money);
                                 player.SetPShip(shipType);
                                 Console.WriteLine($"AH! A Jon Boat... This one is in good condition. Happy travelling!\nYou paid 250$ for the Boat. You have {player.Money}$ left");
                            }
                        else
                        {
                            Console.WriteLine("You cannot afford this boat at the moment!");
                        }
                        break;

                     case 3:
                            shipType = "Pontoon Boat";
                            shipSize = 400;
                            shipPrice = 350.0;
                            if (shipPrice < player.Money)
                            {
                            var money = player.Money - shipPrice;
                            player.SetMoney(money);
                            player.SetPShip(shipType);
                            Console.WriteLine($"A fine choice! This one got loads of storage!\nYou paid 350$ for the Boat. You have {player.Money}$ left");

                        }
                        else
                        {
                            Console.WriteLine("You cannot afford this boat at the moment!");
                        }
                        break;
                }
                player.PlayerStats();


            }
        }
    }
}
