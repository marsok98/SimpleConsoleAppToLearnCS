using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace ConsoleApp3
{
    class ComplexNumber
    {
        double real { get; set; }
        double imaginary { get; set; }

        public ComplexNumber(double re, double im)
        {
            this.real = re;
            this.imaginary = im;
        }

        public ComplexNumber()
        {
            this.real = 0;
            this.imaginary = 0;
        }
        
        public ComplexNumber(string number)
        {
            ReadTheNumber(number);
        }
        public double Module()
        {
            return Math.Pow(this.real, 2) + Math.Pow(this.imaginary, 2);
        }

        public ComplexNumber Conjugation()
        {
            double minusImaginary = (-1) * this.real;
            return new ComplexNumber(real, minusImaginary);
        }

        public ComplexNumber DivideByDouble(double divider)
        {
            ComplexNumber result = new ComplexNumber();
            if(divider!=0)
            {
                result.real = this.real / divider;
                result.imaginary = this.imaginary / divider;
            }
            return result;  
        }

        public void DisplayTheNumber()
        {
            if(this.imaginary>0)
            {
                Console.WriteLine("( " + Convert.ToString(this.real) + '+' + Convert.ToString(this.imaginary) + "j )");
            }
            else
            {
                Console.WriteLine("( " + this.real + this.imaginary + "j )");
            }   
        }

        public bool ReadTheNumber(string loadedString)
        {
            string loadedRealString = null;
            string loadedImaginaryString = null;
            bool beginWasFound = false;
            bool breakWasFound = false;
            bool jWasFound = false;
            bool endWasFound = false;
            int indexOfBreak = 0;
            int indexOfJ = 0;
            int indexOfEnd = 0;

            if (loadedString[0] == '(') beginWasFound = true;

            for (int i = 1; i < loadedString.Length; i++)
            {
                if (loadedString[i] == '+' || loadedString[i] == '-') { indexOfBreak = i; breakWasFound = true; }
                if (loadedString[i] == 'j') { indexOfJ = i; jWasFound = true; }
                if (loadedString[i] == ')') { indexOfEnd = i; endWasFound = true; }
            }
            if (breakWasFound) { loadedRealString = loadedString[1..(indexOfBreak)]; }

            if (endWasFound) { loadedImaginaryString = loadedString[indexOfBreak..(indexOfJ)]; }

            if (beginWasFound && breakWasFound && jWasFound && endWasFound)
            {
                this.real = Convert.ToDouble(loadedRealString);
                this.imaginary = Convert.ToDouble(loadedImaginaryString);
                return true;
            }
            else
            {
                Console.WriteLine("You have written wrong number");
                return false;
            }
        }

        public static ComplexNumber operator +(ComplexNumber com1, ComplexNumber com2)
        {
            return new ComplexNumber(com1.real + com2.real, com1.imaginary + com2.imaginary);
        }
        public static ComplexNumber operator -( ComplexNumber  com1, ComplexNumber com2)
        {
            return new ComplexNumber(com1.real - com2.real, com1.imaginary - com2.imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber com1, ComplexNumber com2)
        {
            ComplexNumber result = new ComplexNumber();
            result.real = (com1.real * com2.real) - (com1.imaginary * com2.imaginary);
            result.imaginary = (com2.imaginary * com1.real) + (com1.imaginary * com2.real);
            return result;
        }

        public static ComplexNumber operator /(ComplexNumber com1, ComplexNumber com2)
        {
            ComplexNumber result = new ComplexNumber();
            ComplexNumber numerator = new ComplexNumber();
            double denominator;

            numerator = com1 * com2.Conjugation();
            denominator = com2.Module();

            result = numerator.DivideByDouble(denominator);
            return result;
        }

        public static bool operator == (ComplexNumber com1, ComplexNumber com2)
        {
            if (com1.real == com2.real && com1.imaginary == com2.imaginary) return true;
            else return false;
        }

        public static bool operator !=(ComplexNumber com1, ComplexNumber com2)
        {
            if (com1.real != com2.real || com1.imaginary != com2.imaginary) return true;
            else return false;
        }


        




    }

   
}

