using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CommercGame
{ 
    

        class Player

        {
        public String name;
        public static double money = 500.0;
        public static string PShip;


        public Player()
        {
         
        }   
        public string GetPlayerShip()
        {
            return PShip;
        }
        public static double GetMoney()
        {
            return money;
        }
        public string GetName()
        {
            return name;
        }
        public void PlayerStats()
        {
            Console.WriteLine("Name: " + GetName());
            Console.WriteLine("Money: " + GetMoney());
            Console.WriteLine("Ship: " + GetPlayerShip());
        }
       
    }
    
   
}

