using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class ComplexExpression
    {

        ComplexNumber argument1;
        Operation operation;
        ComplexNumber argument2;
        ComplexNumber result;

        public ComplexNumber Argument1
        {
            get => argument1;
            set => argument1 = value;
        }
        public ComplexNumber Argument2
        {
            get => argument1;
            set => argument1 = value;
        }
        public Operation Operation
        {
            get => operation;
            set => operation = value;
        }
        public ComplexNumber Result
        {
            get { return result; }
            set => result = value;
        }

        public void calculate()
        {
            switch(operation.op)
            {

                case Operation.operation.add:
                {
                    result = argument1 + argument2;
                    break;
                }
                case Operation.operation.subtract:
                {
                    result = argument1 - argument2;
                    break;
                }
                case Operation.operation.multiply:
                {
                    result = argument1 * argument2;
                    break;
                }
                case Operation.operation.divide:
                {
                    result = argument1 / argument2;
                    break;
                }
                default:
                {
                    break;
                }
            }
        }

        
        public ComplexExpression(ComplexNumber arg1, Operation mathOperation, ComplexNumber arg2)
        {
            this.argument1 = arg1;
            this.argument2 = arg2;
            this.operation = mathOperation;
            this.calculate();
        }
        public  ComplexExpression(string line)
        {
            int downLimit = 5;
            int indexOfSign = 0;
            bool foundedSign = false;
            string firstArg;
            char sign;
            string secondArg;

            for(int i = downLimit;i<line.Length -2 ;i++)
            {
                if(line[i] == ')' && line[i+2] == '(' )
                {
                    indexOfSign = i + 1;
                    foundedSign = true;
                }
            }
            if(foundedSign)
            {
                firstArg = line[0..(indexOfSign)];
                sign = line[indexOfSign];
                secondArg = line.Substring(indexOfSign + 1);

                try
                {
                    argument1 = new ComplexNumber(firstArg);
                    argument2 = new ComplexNumber(secondArg);
                    operation = new Operation(sign);
                    calculate();
                }
                catch(ExceptionOfComplexNumber e1)
                {
                    throw new ExceptionOfComplexExpression(e1.Message);
                }
                catch(ExceptionOfOperation e2)
                {
                    throw new ExceptionOfComplexExpression(e2.Message);
                }
            }
            else
            {
                throw new ExceptionOfComplexExpression("There is no sign between complex numbers");
            }


        }
    }
}
