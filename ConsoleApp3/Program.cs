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
                        //string filePathSolved = @"C:\pliki_CS\solved.txt";

                        List<string> equations = new List<string>();
                        equations = File.ReadAllLines(filePathToSolve).ToList();

                        List < ComplexExpression >  expresions = new List<ComplexExpression>();

                        foreach (String equation in equations)
                        {
                            try
                            {
                    expresions.Add(new ComplexExpression(equation));
                }
                            catch(ExceptionOfComplexExpression ex)
                {
                    Console.WriteLine(ex.Message);
                }
                        }

                        foreach (ComplexExpression i in expresions )
                        {
                            i.Result.DisplayTheNumber();
                        }

            
           /* ComplexNumber y = new ComplexNumber(2,3);
            List<ComplexNumber> T = new List<ComplexNumber>();
            try
            {
                ComplexNumber z = new ComplexNumber(Console.ReadLine());
                T.Add(z);
            }
            catch(Exception ex)
            {
                Console.WriteLine("jeblo");
            }
            
            T.Add(y);
           


            foreach (ComplexNumber i in T)
            {
                i.DisplayTheNumber();
            }
           */

        }
    }
}

