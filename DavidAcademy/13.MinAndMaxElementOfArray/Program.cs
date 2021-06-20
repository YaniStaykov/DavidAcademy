using System;

namespace _13.MinAndMaxElementOfArray
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

            int maxValue = int.MinValue;
            int minValue = int.MaxValue;
            int totalValueArray = 0;

            for (int i = 0; i < array.Length; i++)
            {
                totalValueArray += array[i];
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            int averageValueArray = totalValueArray / array.Length;

            Console.WriteLine($"Array Max value is {maxValue}");
            Console.WriteLine($"Array Min value is {minValue}");
            Console.WriteLine($"Array average value is {averageValueArray}");
        }
    }
}
