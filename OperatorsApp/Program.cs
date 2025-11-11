using System;

namespace OperatorsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of Calculator class
            Calculator calc = new Calculator();

            // Perform operations
            Console.WriteLine("Addition: " + calc.Add(10, 5));
            Console.WriteLine("Subtraction: " + calc.Subtract(10, 5));
            Console.WriteLine("Multiplication: " + calc.Multiply(10, 5));
            Console.WriteLine("Division: " + calc.Divide(10, 5));

            // Check Odd or Even
            Console.Write("Enter a number to check Odd or Even: ");
            int number = Convert.ToInt32(Console.ReadLine());
            calc.OddEvenFinder(number);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
