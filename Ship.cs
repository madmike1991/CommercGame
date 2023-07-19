using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

        }
    }

