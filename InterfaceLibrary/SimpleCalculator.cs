using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary
{
    public class SimpleCalculator : ICalculatable
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
                Console.WriteLine("Division by zero is not allowed.");
                return double.NaN;
            }
            return a / b;
        }

        public void DisplayResult(double result)
        {
            Console.WriteLine("Result: " + result);
        }
    }
}
