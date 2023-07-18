using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercGame
{
     public class Ship
    {
        
         public String ShipType;
         public int ShipSize;
         public double ShipPrice;

        public Ship() 
        
        {
            
        }
        public string GetShipType()
        {
            return ShipType;
        }

        public int GetShipSize()
        {
            return ShipSize;
        }

        public double GetShipPrice()
        {
            return ShipPrice;
        }

        public void BuyShip()
        {
            
            Console.WriteLine("Which ship would you like to buy?");
            Console.WriteLine("1 - Rubber Dinghy 100$. Can take up to 100Kg of merchandise.\n2 - Jon Boat 250$. Can take up to 200Kg of merchandise.\n3 - Pontoon Boat 350$. Can take up to 400Kg of merchandise.");
            var Choice = Console.ReadLine();
            switch(Choice)
                {
                    case "1":
                    ShipType = "Rubber Dinghy";
                    ShipSize = 100;
                    ShipPrice = 100.0;
                    Player.money -= ShipPrice;
                    Console.WriteLine($"That won't get you very far, but I guess it's better than nothing...\n You paid 100$ for the Boat. You have {Player.money}$ left");
                    Console.ReadLine();
                    break;

                    case "2":
                    ShipType = "Jon Boat";
                    ShipSize = 200;
                    ShipPrice = 250.0;
                    Player.money -= ShipPrice;
                    Console.WriteLine($"AH! A Jon Boat... This one is in good condition. Happy travelling!\n You paid 250$ for the Boat. You have {Player.money}$ left");
                    Console.ReadLine();
                    break;
                    
                    case "3":
                    ShipType = "Pontoon Boat";
                    ShipSize = 400;
                    ShipPrice = 350.0;
                    Player.money -= ShipPrice;
                    Console.WriteLine($"A fine choice! This one got loads of storage!\n You paid 350$ for the Boat. You have {Player.money}$ left");
                    Console.ReadLine();
                    break;

                 }
            } 
        }
    }

