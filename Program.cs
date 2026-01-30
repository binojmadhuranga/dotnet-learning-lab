using System;
using CalculatorCLI;

namespace CalculatorCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("=== Simple CLI Calculator ===");

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nChoose operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;

            try
            {
                result = choice switch
                {
                    1 => calculator.Add(num1, num2),
                    2 => calculator.Subtract(num1, num2),
                    3 => calculator.Multiply(num1, num2),
                    4 => calculator.Divide(num1, num2),
                    _ => throw new Exception("Invalid choice")
                };

                Console.WriteLine($"\nResult: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
