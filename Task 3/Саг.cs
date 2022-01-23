

namespace Task_3
{
    class Car : Vehicle
    {
        public Car(int xLocation, int yLocation, uint price, uint speed, uint year)
            : base(xLocation, yLocation,price,speed,year)
        {
            
        }

        public Car(uint price, uint speed, uint year)
            : base(price, speed, year)
        {

        }
       

    }
}
