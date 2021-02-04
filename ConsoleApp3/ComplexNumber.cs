﻿using System;
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
        public double Module()
        {
            return Math.Pow(this.real, 2) + Math.Pow(this.imaginary, 2);
        }

        public ComplexNumber Conjugation()
        {
            double minusImaginary = (-1) * this.real;
            return new ComplexNumber(real, minusImaginary);
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
        
        public bool ReadTheNumber()
        {
            string loadedString=null;
            string loadedRealString=null;
            string loadedImaginaryString=null;
            double real=0;
            double imaginary=0;
            bool beginWasFound = false;
            bool breakWasFound = false;
            bool jWasFound = false;
            bool endWasFound = false;
            int indexOfBreak = 0;
            int indexOfJ = 0;
            int indexOfEnd = 0;

            loadedString = Console.ReadLine();
            if (loadedString[0] == '(' ) beginWasFound = true;
            
            for (int i = 1;i<loadedString.Length;i++)
            {
                if(loadedString[i] == '+' || loadedString[i] == '-') { indexOfBreak = i;breakWasFound = true; }
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


    }

   
}

