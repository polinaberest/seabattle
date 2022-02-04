using System;

namespace game1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите размер поля");
            var scena = new Scene(int.Parse(Console.ReadLine()));
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("type\n1-fight\n2-mixed\n3-fix");
                int type = int.Parse(Console.ReadLine());
                Ship ship = null;
                switch (type)
                {
                    case 1:
                        ship = new FightShip();
                        break;
                    case 2:
                        ship = new MixedShip();
                        break;
                    case 3:
                        ship = new FixShip();
                        break;
                    default:
                        Console.WriteLine("Incorrect value!!!");
                        break;
                }

                Console.WriteLine("длина");
                var size = int.Parse(Console.ReadLine());
                ship.ShipSize = size;

                Console.WriteLine("speed");
                ship.Speed = int.Parse(Console.ReadLine());

                ship.point = new Point(0, 0);
                Console.WriteLine("X point");
                ship.point.X = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("Y point");
                ship.point.Y = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("direction\n1-bottom\n2-right");
                ship.shipDirection = (Ship.ShipDirection)int.Parse(Console.ReadLine()) - 1;

                scena.PlaceShip(ship);
                scena.PrintScene();
            }
         

            
        }
        
    }
}
