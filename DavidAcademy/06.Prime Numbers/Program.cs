namespace _06.Prime_Numbers
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            List<int> primeNumbers = new List<int>();

            Console.Write("Enter a number: ");
            number = uint.Parse(Console.ReadLine());

            
            bool isPrime = true;
            for (int i = 2; i < number; i++)
            {
                for (int a = 2; a <= i / 2; a++)
                {
                    if (i % a == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }

                if (isPrime)
                {
                    primeNumbers.Add(i);
                }
                else
                {
                    isPrime = true;
                    continue;
                }
                
            }
            Console.WriteLine("The Prime numbers are:");
            Console.WriteLine(string.Join(", ", primeNumbers));            
        }
    }
}
