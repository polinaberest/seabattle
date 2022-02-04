using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    class FightShip : Ship
    {
        int areaOfAccess = 4;
        public FightShip(int size, int speed, Point point, ShipDirection direction) :base( size,  speed, point, direction)
        {
            
        }

        public FightShip()
        {

        }

        public void Shoot() {
            return;
        }

        public override string ToString()
        {
            return "FightShip " + speed + " " + ShipSize;
        }


    }
}
