using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell expression");
            ComplexExpression z = new ComplexExpression(Console.ReadLine());

            z.result.DisplayTheNumber();

        }
    }
}

