namespace _07.Factorial
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            long number = long.Parse(Console.ReadLine());

            while (true)
            {
                if (number <= 0)
                {
                    Console.WriteLine("Please enter a positive number.");
                    Console.WriteLine("Enter a number: ");
                    number = long.Parse(Console.ReadLine());
                    continue;
                }
                else
                {
                    Console.WriteLine($"Your number is {number}. Do you want to proceed? (Yes/No)");
                    string response = Console.ReadLine();

                    if (response.ToLower() == "yes")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a number: ");
                        number = long.Parse(Console.ReadLine());
                        continue;
                    }
                }
            }

            Console.WriteLine("Choose a method of calculation: Iteratively or Recursively");

            while (true)
            {
                
                string method = Console.ReadLine();

                if (method.ToLower() == "iteratively")
                {
                    GetFactorialIteratively(number);
                    return;
                }
                else if (method.ToLower() == "recursively")
                {
                    GetFactorialRecursively(number);
                    return;
                }
                else
                {
                    Console.WriteLine("Please enter a valid method.");
                    continue;
                }
            }
        }

        static void GetFactorialIteratively(long number)
        {
            long factorial = 1;

            for (long i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            string result = $"Factorial of {number} is : {factorial}";

            Console.WriteLine(result);
        }

        static void GetFactorialRecursively(long number)
        {
            long factorial = 1;

            for (long i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            string result = $"Factorial of {number} is : {factorial}";

            Console.WriteLine(result);
        }
    }
}
