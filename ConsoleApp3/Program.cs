using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ComplexNumber x = new ComplexNumber(3, 4);
            ComplexNumber y = new ComplexNumber(5, 3);

            ComplexNumber z = x + y;
            z.DisplayTheNumber();

        }
    }
}

