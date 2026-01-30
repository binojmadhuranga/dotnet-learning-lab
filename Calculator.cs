using System;

namespace CalculatorCLI
{
    class Calculation
    {
        static void Main(string[] args)
        {
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

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = Add(num1, num2);
                    break;

                case 2:
                    result = Subtract(num1, num2);
                    break;

                case 3:
                    result = Multiply(num1, num2);
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    result = Divide(num1, num2);
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            Console.WriteLine($"\nResult: {result}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
