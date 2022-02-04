using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    class FixShip : Ship 
    {
        public FixShip(int size, int speed, Point point, ShipDirection direction) : base(size, speed, point, direction)
        {
            
        }

        public FixShip()
        {

        }

        int areaOfAccess = 4;
        public void Fix() { }
        public override string ToString()
        {
            return "FixShip " + speed + " " + ShipSize;
        }


    }
}
