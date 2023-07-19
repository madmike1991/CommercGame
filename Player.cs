using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CommercGame
{ 
    

      public class Player

        {
        public string Name {  get; private set; }
        public double Money { get; private set; }
        public string PShip { get; private set; }


        public Player(string name)
        {
            Name = name;
            Money = 500.0;

         
        }   
        public string GetPlayerShip()
        {
            return PShip;
        }
        public double GetMoney()
        {
            return Money;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetMoney(double value)
        {
            Money = value;
        }
        public void SetPShip(string pship)
        {
            PShip = pship;
        }
        public void PlayerStats()
        {
            Console.WriteLine("Name: " + GetName());
            Console.WriteLine("Money: " + GetMoney());
            Console.WriteLine("Ship: " + GetPlayerShip());
        }
       
    }
    
   
}

