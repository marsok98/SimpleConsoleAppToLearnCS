using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Tell expression");
            //ComplexExpression z = new ComplexExpression(Console.ReadLine());

            string filePathToSolve = @"C:\pliki_CS\toSolve.txt";
            string filePathSolved = @"C:\pliki_CS\solved.txt";

            List<string> equations = new List<string>();
            equations = File.ReadAllLines(filePathToSolve).ToList();

            List < ComplexExpression >  expresions = new List<ComplexExpression>();

            foreach (String equation in equations)
            {
                expresions.Add(new ComplexExpression(equation));
            }

            foreach (ComplexExpression i in expresions )
            {
                i.Result.DisplayTheNumber();
            }




        }
    }
}

