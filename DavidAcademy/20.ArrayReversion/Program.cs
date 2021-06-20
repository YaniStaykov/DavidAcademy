namespace _20.ArrayReversion
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lenght of the array: ");
            int lenght;
            while (true)
            {
                string input = Console.ReadLine();
                bool parseSuccess = int.TryParse(input, out lenght);
                if (parseSuccess)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid lenght: ");
                }
            }
            int[] array = new int[lenght];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Add number at position {i} = ");
                string input = Console.ReadLine();
                int number;
                bool parseSuccess = int.TryParse(input, out number);
                if (parseSuccess)
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine("Please enter a integer: ");                    
                    i -= 1;
                }
            }
            Console.WriteLine($"State of the array : ");
            ShowArray(array);

            Console.Write("Choose a method of reversion. Recursively or Iteratively: ");
            while (true)
            {
                
                string input = Console.ReadLine();
                if (input.ToLower() == "recursively")
                {
                    ReverseArrayRecursively(array);
                    ShowArray(array);
                    return;
                }
                else if (input.ToLower() == "iteratively")
                {
                    ReverseArrayIteratively(array);
                    ShowArray(array);
                    return;
                }
                else
                {
                    Console.Write("Please choose a valid method:");
                }
            }                                                                      
        }

        static void ReverseArrayIteratively(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;

                // 1 2 3 4 5 = 5 4 3 2 1
            }
        }

        static void ReverseArrayRecursively(int[] a)
        {
            ReverseArrayRecursively(a, 0, a.Length - 1);
        }

        static void ReverseArrayRecursively(int[] a, int lo, int hi)
        {
            if (lo >= hi) return;

            
            var temp = a[lo];
            a[lo] = a[hi];
            a[hi] = temp;

            ReverseArrayRecursively(a, lo + 1, hi - 1);
        }

        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array.Length - 1 == i)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(array[i] + ", ");
                }              
            }
            Console.WriteLine();
        }
    }
}
