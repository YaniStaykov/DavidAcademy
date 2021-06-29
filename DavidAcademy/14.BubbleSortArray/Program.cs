using System;

namespace _14.BubbleSortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array lenght = ");
            int lenght = int.Parse(Console.ReadLine());

            double[] array = new double[lenght];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter element {i + 1} = ");
                double element = double.Parse(Console.ReadLine());

                array[i] = element;
            }

            Console.WriteLine("Choose Ascending or Descending sort.");
            string input = Console.ReadLine();

            if (input.ToLower() == "ascending")
            {
                Ascending(array);
            }
            else if (input.ToLower() == "descending")
            {
                Descending(array);
            }


            static void Ascending(double[] array)
            {
                double temp;

                for (int i = 0; i <= array.Length - 1; i++)
                {
                    for (int j = 0; j <= array.Length - 2; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            temp = array[j + 1];
                            array[j + 1] = array[j];
                            array[j] = temp;
                        }
                    }
                }

                foreach (var element in array)
                {
                    Console.Write($"{element} ");
                }
            }

            static void Descending(double[] array)
            {
                double temp;

                for (int i = 0; i <= array.Length - 1; i++)
                {
                    for (int j = 0; j <= array.Length - 2; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            temp = array[j + 1];
                            array[j + 1] = array[j];
                            array[j] = temp;
                        }
                    }
                }

                foreach (var element in array)
                {
                    Console.Write($"{element} ");
                }
            }
        }
    }
}
