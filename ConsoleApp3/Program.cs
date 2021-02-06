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

            
            string filePathToSolve = @"C:\pliki_CS\toSolve.txt";
            string filePathSolved = @"C:\pliki_CS\solved.txt";

            List<string> equations = new List<string>();
            equations = File.ReadAllLines(filePathToSolve).ToList();

            ListOfExpression list1 = new ListOfExpression(equations);

            File.WriteAllLines(filePathSolved, list1.GetSolvedExpression().ToArray());

        }
    }
}

