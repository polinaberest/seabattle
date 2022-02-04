using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    class Scene
    {
        private int oneBoatCount=4;
        private int twoBoatCount=3;
        private int threeBoatCount=2;
        private int fourBoatCount=1;
        public int[,] scene;
        List<Ship> shipList = new List<Ship>();
        public Scene(int sceneSize)
        {
            scene = new int[Math.Abs(sceneSize), Math.Abs(sceneSize)];
        }
        public void PlaceShip(Ship ship)
        {
            if (ship.ShipSize==4 && fourBoatCount==0||
                ship.ShipSize == 3 && threeBoatCount == 0||
                ship.ShipSize == 2 && twoBoatCount == 0||
                ship.ShipSize == 1 && oneBoatCount == 0) 
            {
                Console.WriteLine("Приходите завтра!");
                return;
            }


            if (ship.shipDirection == Ship.ShipDirection.Bottom)
            {
                if(CanPlaceShip(new Point(ship.point.Y, ship.point.X), ship.ShipSize, "bottom"))
                { 
                    for (int i = ship.ShipSize - 1; i >= 0; i--)
                    {
                        scene[ship.point.Y + i, ship.point.X] = 1;
                        PlaceSpaceAroundShips(new Point(ship.point.Y + i, ship.point.X));
                    }
                }
            }
            else
            {
                if (CanPlaceShip(new Point(ship.point.Y, ship.point.X), ship.ShipSize, "right"))
                {
                    for (int i = ship.ShipSize - 1; i >= 0; i--)
                    {
                        scene[ship.point.Y, ship.point.X + i] = 1;
                        PlaceSpaceAroundShips(new Point(ship.point.Y, ship.point.X + i));
                    }
                }
            }

            shipList.Add(ship);

            switch (ship.ShipSize)
            {
                case 4:
                    fourBoatCount--;
                    break;
                case 3:
                    threeBoatCount--;
                    break;
                case 2:
                    twoBoatCount--;
                    break;
                case 1:
                    oneBoatCount--;
                    break;
                default:
                    break;
            }
        }

        public void PlaceSpaceAroundShips(Point point)
        {
            for (int i = 1; i > -2; i--)
            {
                for (int j = -1; j < 2; j++)
                {
                    try
                    {
                        if (scene[ point.X + j, point.Y - i] == 0)
                        {
                            scene[ point.X + j, point.Y - i] = 2;
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
        }

        public bool CanPlaceShip(Point point, int shipSize, string shipDirection) {
            if (shipDirection == "bottom") 
            {
                int count = 0;
                for (int i = shipSize - 1; i >= 0; i--)
                {
                    if (scene[point.Y + i, point.X] == 0)
                    {
                        count++;
                    }
                }
                if (count == shipSize)
                    return true;
            }
            else if (shipDirection == "right")
            {
                int count = 0;
                for (int i = shipSize - 1; i >= 0; i--)
                {
                    if (scene[point.Y, point.X + i] == 0)
                    {
                        count++;
                    }
                }
                if (count == shipSize)
                    return true;

            }
            return false;
        }

        public void PrintScene() 
        {
            for (int i = 0; i < scene.GetLength(0); i++)
            {
                for (int j = 0; j < scene.GetLength(1); j++)
                {
                    Console.Write(scene[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        
        
    }
}
