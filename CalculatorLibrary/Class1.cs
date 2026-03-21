using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно");
            }
            return a / b;
        }
        public double Power(double a, double b)
        {
            return Math.Pow(a,b);
        }

        public double Calculate(double a, double b,string Operation)
        {
            switch (Operation)
            {
                case "+":
                    return Add(a,b);
                case "-":
                    return Subtract(a, b);
                case "*":
                    return Multiply(a, b);
                case "/":
                    return Divide(a, b);
                case "^":
                    return Power(a, b);
                default:
                    throw new InvalidOperationException("Неизвестная операция");
            }
        }
    }
}
