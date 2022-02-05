using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class FightShip : Ship
    {
        int areaOfAccess = 4;

        public FightShip(int size, int speed, Point point, Enums.ShipDirection direction) :base( size,  speed, point, direction)
        {
            
        }

        public FightShip()
        {

        }

        public void Shoot()
        {
            Console.WriteLine("I shoot!");
        }

        public override string ToString()
        {
            return "FightShip " + speed + " " + ShipSize;
        }
    }
}
