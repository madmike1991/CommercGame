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
        String name;
        double money;


        public Player(String name, double money)
        {
            this.name = name;
            this.money = money;
        }   

        public double GetMoney()
        {
            return money;
        }
        public string GetName()
        {
            return name;
        }

       
    }
    
   
}

