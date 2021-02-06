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
            if (op == operation.nothing) throw new ExceptionOfOperation("There is no correct sign");

        }
        public Operation() { op = operation.nothing; }

        public char getOperationSignInChar()
        {
            char signInChar;
            switch(op)
            {
                case operation.add: signInChar = '+';       break;
                case operation.subtract: signInChar = '-';  break;
                case operation.multiply: signInChar = '*';  break;
                case operation.divide: signInChar = '/';    break;
                default: signInChar = ' '; break;
            }
            return signInChar;
        }


    }
}
