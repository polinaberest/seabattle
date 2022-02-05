using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class FixShip : Ship 
    {
        int areaOfAccess = 4;

        public FixShip(int size, int speed, Point point, Enums.ShipDirection direction) : base(size, speed, point, direction)
        {
            
        }

        public FixShip()
        {

        }

        public void Fix()
        {
            Console.WriteLine("I`m fixing your boat, wait a second!");
        }

        public override string ToString()
        {
            return "FixShip " + speed + " " + ShipSize;
        }
    }
}
