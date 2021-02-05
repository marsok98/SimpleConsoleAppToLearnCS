using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string napis;
            ComplexNumber x = new ComplexNumber();
            ComplexNumber y = new ComplexNumber();
            Console.WriteLine("Hello World!");
            Console.WriteLine("First ingredients");
            napis = Console.ReadLine();
            x.ReadTheNumber(napis);

            Console.WriteLine("Second ingredients");
            napis = Console.ReadLine();
            y.ReadTheNumber(napis);

            ComplexNumber z = new ComplexNumber();
            z = x + y;
            Console.WriteLine("Wynik");
            z.DisplayTheNumber();

        }
    }
}

