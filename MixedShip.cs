using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class MixedShip : Ship, IShipMethods
    {
        int areaOfAccess = 2;

        public MixedShip()
        {

        }

        public MixedShip(int size, int speed, Point point, Enums.ShipDirection direction) : base(size, speed, point, direction)
        {
            
        }
        
        public void Shoot(){}
        
        public void Fix(){}

        public override string ToString()
        {
            return "MixedShip "+speed+" "+ShipSize;
        }

    }
}
