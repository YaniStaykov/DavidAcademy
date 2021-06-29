using System;

namespace _15.NumberOfInversionsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array lenght = ");
            int lenght = int.Parse(Console.ReadLine());

            int[] array = new int[lenght];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter element {i + 1} = ");
                int element = int.Parse(Console.ReadLine());

                array[i] = element;
            }

            int invCount = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        invCount++;
                    }
                }
            }

            Console.WriteLine($"Number of inversions are: {invCount}");
        }
    }
}
