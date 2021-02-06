using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class ListOfExpression
    {
        List<ComplexExpression> expresions = new List<ComplexExpression>();

        public ListOfExpression(List<string> equationsAsString)
        {
            foreach(String singleEquationAsString in equationsAsString)
            {
                try
                {
                    expresions.Add(new ComplexExpression(singleEquationAsString));
                }
                catch (ExceptionOfComplexExpression ex1)
                {
                    Console.WriteLine(ex1.Message);
                }
            }
        }
        public List<string> GetExpresionInListString()
        {
            List<string> expresionInListString = new List<string>();

            foreach(ComplexExpression expresion in expresions)
            {
                expresionInListString.Add(expresion.GetComplexExpressionInString());
            }

            return expresionInListString;
        }

        public List<string> GetSolvedExpression()
        {
            List<string> solutionInString = new List<string>();

            foreach(ComplexExpression expresion in expresions)
            {
                solutionInString.Add(expresion.Result.GetComplexNumberInString());
            }

            return solutionInString;   
        }
    }
}
