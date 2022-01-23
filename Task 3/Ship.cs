using System;

namespace Task_3
{
    class Ship : Vehicle
    {
        public Ship(int xLocation, int yLocation, uint price, uint speed, uint year)
        : base(xLocation, yLocation, price, speed, year)
        {

        }

        public Ship(uint price, uint speed, uint year)
        : base(price, speed, year)
        {

        }

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

        private string port;
        public string Port
        {
            get
            {
                if (port == null)
                { return "Port is not set"; }
                else { return port; }
            }
            set
            {
                if (value == null)
                { Console.WriteLine("The value is empty"); }
                else
                {
                    port = value;
                }
            }
        }
    }
}
