using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsPrograms
{
    class Calculator
    {
        // Instance method
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Overloaded instance method
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Static method
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
    public class Methods
    {
        public static void main()
        {
            Calculator calculator = new Calculator();

            // Call instance methods
            int sum1 = calculator.Add(5, 3);
            double sum2 = calculator.Add(3.14, 2.71);

            // Call a static method
            int difference = Calculator.Subtract(10, 5);

            Console.WriteLine("Instance Methods:");
            Console.WriteLine($"Sum of integers: {sum1}");
            Console.WriteLine($"Sum of doubles: {sum2}");
            Console.WriteLine();

            Console.WriteLine("Static Method:");
            Console.WriteLine($"Difference: {difference}");
        }
    }
}
