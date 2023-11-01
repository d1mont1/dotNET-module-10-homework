using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary
{
    public class AdvancedCalculator : ICalculatable, IStorable
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

        public double Power(double baseValue, double exponent)
        {
            return Math.Pow(baseValue, exponent);
        }

        public double SquareRoot(double number)
        {
            if (number < 0)
            {
                Console.WriteLine("Square root of a negative number is not allowed.");
                return double.NaN;
            }
            return Math.Sqrt(number);
        }

        public void DisplayResult(double result)
        {
            Console.WriteLine("Result: " + result);
        }

        public void SaveState(string fileName)
        {
            // Реализация сохранения состояния в файл
            Console.WriteLine($"Saving state to {fileName}");
        }

        public void LoadState(string fileName)
        {
            // Реализация загрузки состояния из файла
            Console.WriteLine($"Loading state from {fileName}");
        }
    }
}
