using System;

namespace Task_1
{
    class Program
    {
        /*
         Используя Visual Studio, создайте проект по шаблону Console Application. 
         Требуется: 
         Создайте класс Printer. 
         В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента. 
         Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове 
         соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились разными цветами. 
         Обязательно используйте приведение типов.
        */
        static void Main(string[] args)
        {
            ColorPrinter print = new ColorPrinter(ConsoleColor.Yellow);
            print.Print("Hello");

            Printer printUp = print;
            printUp.Print("Hello");

            ColorPrinter print1 = new ColorPrinter(ConsoleColor.Red);
            print1.Print("Hello");

        }
    }
}
