using System;


namespace Task_3
{
    class Plane : Vehicle
    {
        public Plane(int xLocation, int yLocation, uint price, uint speed, uint year)
            : base(xLocation, yLocation, price, speed, year)
        {

        }

        public Plane(uint price, uint speed, uint year)
            : base(price, speed, year)
        {

        }

        public int Hight { get; set; }
        private int passengers;
        public int Passengers
        {
            get { return passengers; }
            set
            {
                if (passengers < 0)
                {
                    Console.WriteLine("The number of passengers could't be negative");
                }
                else
                {
                    passengers = value;
                }
            }
        }
    }
}
