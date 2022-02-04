using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    class MixedShip : Ship
    {
        public MixedShip()
        {

        }

        public MixedShip(int size, int speed, Point point, ShipDirection direction) : base(size, speed, point, direction)
        {
            
        }
        int areaOfAccess = 2;
        public void Shoot(){}
        
        public void Fix(){}

        public override string ToString()
        {
            return "MixedShip "+speed+" "+ShipSize;
        }

    }
}
