namespace _08.Fibonacci_Sequence
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number n = ");
            int number = int.Parse(Console.ReadLine());

            int n = number - 1;  
            int[] fib = new int[n + 1];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }

            Console.WriteLine($"The {number} number of Fibonacci Sequence is : {fib[n]}");

        }
    }
}
