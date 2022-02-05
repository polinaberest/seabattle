using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    abstract class Ship
    {
        public enum ShipDirection
        {
            Bottom,
            Right
        }
        public ShipDirection shipDirection;
        public Point point = null;
        private int shipSize;

        public int ShipSize
        {
            get {
                    return shipSize;
            }
            set {
                if (value > 4)
                    shipSize = 4;
                else if (value <= 0)
                    shipSize = 1;
                else
                    shipSize = Math.Abs(value); 
            }
        }

        protected int speed;
        protected int maxSpeed = 100;

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (speed > maxSpeed)
                    speed = maxSpeed;
                else
                    speed = Math.Abs(value);
            }
        }

        public Ship()
        {

        }

        public Ship(int size, int speed, Point point, ShipDirection direction)
        {
            ShipSize = size;
            Speed = speed;
            this.point = point;
            shipDirection = direction;
        }

        public static bool operator ==(Ship shipOne, Ship shipTwo)
        {
            if (shipOne.ToString() == shipTwo.ToString())
                return true;
            return false;
        }
        public static bool operator !=(Ship shipOne, Ship shipTwo)
        {
            return !(shipOne == shipTwo);
        }

        public void Move() { }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
