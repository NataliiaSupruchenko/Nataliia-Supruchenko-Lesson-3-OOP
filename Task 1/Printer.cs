using System;

namespace Task_1
{
    class Printer
    {
        protected ConsoleColor color;

        public Printer(ConsoleColor color)
        {
            this.color = color;
        }
        public virtual void Print(string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
