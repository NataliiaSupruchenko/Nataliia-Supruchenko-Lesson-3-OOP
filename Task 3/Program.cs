using System;

namespace Task_3
{
    class Program
    {
        /*
        Создать класс Vehicle. 
        В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска). 
        Создайте 3 производных класса Plane, Саг и Ship. 
        Для класса Plane должна быть определена высота и количество пассажиров. 
        Для класса Ship — количество пассажиров и порт приписки. 
        Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
        */
        static void Main(string[] args)
        {
            Ship ship = new Ship(50000, 120, 1901);
            ship.Passengers = 25;
            ship.Port = "Odessa";

            Console.WriteLine("Ship price {0}, speed {1}, year {2}, number of passengers {3}, port {4}", ship.Price, ship.Speed, ship.Year, ship.Passengers, ship.Port);

            Plane plane = new Plane(6000, 500, 1992);
            plane.Passengers = 120;
            plane.Hight = 80000;

            Console.WriteLine("Plane price {0}, speed {1}, year {2}, number of passenhers {3}, hight {4}", plane.Price, plane.Speed, plane.Year, plane.Passengers, plane.Hight);

            Car car = new Car(500, 100, 1992);

            Console.WriteLine("Car price {0}, speed {1}, year {2}", car.Price, car.Speed, car.Year);
        }
    }
}
