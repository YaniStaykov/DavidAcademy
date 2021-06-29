namespace _11.ConsoleCalculator
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Select an arithmetic operation: ");
            while (true)
            {                               
                string input = Console.ReadLine();
                Console.Write("Enter a value for a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter a value for b = ");
                double b = double.Parse(Console.ReadLine());

                if (input.ToLower() == "end")
                {
                    break;
                }
                if (input.ToLower() == "addition")
                {
                    Addition(a, b);                
                }
                else if (input.ToLower() == "subtraction")
                {
                    Subtraction(a, b);
                }
                else if (input.ToLower() == "multiplication")
                {
                    Multiplication(a, b);
                }
                else if (input.ToLower() == "division")
                {
                    Division(a, b);
                }

                Console.WriteLine("Select an arithmetic operation or type End to quit: ");
            }

        }

        static void Addition(double a, double b)
        {
            double result = a + b;
            Console.WriteLine($"The result is: {result:f2}");
        }
        static void Subtraction(double a, double b)
        {
            double result = a - b;
            Console.WriteLine($"The result is: {result:f2}");
        }
        static void Multiplication(double a, double b)
        {
            double result = a * b;
            Console.WriteLine($"The result is: {result:f2}");
        }
        static void Division(double a, double b)
        {
            double result = a / b;
            Console.WriteLine($"The result is: {result:f2}");
        }
    }
}
