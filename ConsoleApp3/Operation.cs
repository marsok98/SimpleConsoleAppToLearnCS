using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Operation
    {
        public enum operation 
        {
            add,
            subtract,
            multiply,
            divide,
            nothing
        }

        public operation op;

        public Operation(char sign)
        {
            switch (sign)
            {
                case '+': op = operation.add;       break;
                case '-': op = operation.subtract;  break;
                case '*': op = operation.multiply;  break;
                case '/': op = operation.divide;    break;
                default:  op = operation.nothing;   break;
            }
        }
        public Operation() { op = operation.nothing; }
    }
}
