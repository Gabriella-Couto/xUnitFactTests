using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Calculator
    {
        public Calculator() { }

        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public double SumDouble(double number1, double number2)
        {
            return number1 + number2;
        }

        public int SubtractionInt(int number1, int number2)
        {
            return number1 - number2;
        }

        public double SubtractionDouble(double number1, double number2)
        {
            return number1 - number2;
        }
    }
}
