using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercGame
{
    internal class Ship
    {
        String ShipName;
        String ShipType;
        String ShipSize;

        public Ship(String ShipName,  String ShipType, String ShipSize) 
        
        {
            this.ShipName = ShipName;
            this.ShipType = ShipType;
            this.ShipSize = ShipSize;
        }   

        public string GetShipName()
        {
            return ShipName;
        } 
        public string GetShipType()
        {
            return ShipType;
        }

        public String GetShipSize()
        {
            return ShipSize;
        }
    }
}
