using System;

namespace _22.BinarySearchInSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Console.WriteLine("Enter number to search?");
            int number = int.Parse(Console.ReadLine());
            int index = 0;

            ReturnData result = new ReturnData();

            if (!CheckIfSorted(array))
            {
                throw new ArgumentException("Array is not sorted");
            }

            result = BinSearchArrayIteratively(array, 0, array.Length, number);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == result.index)
                {
                    index = array[i];
                }
            }

            if (result.index == -1)
            {
                Console.WriteLine($"Number {number} is not contained in the array!");
                Console.WriteLine(result.isFound);
            }
            else
            {
                Console.WriteLine($"Number {number} is at position {index}!");
                Console.WriteLine(result.isFound);
            }
        }

        private static ReturnData BinSearchArrayRecursively(int[] array, int first, int last, int number)
        {
            int middle = (first + last) / 2;
            ReturnData returnData = new ReturnData();
            if (array[middle] == number)
            {
                returnData.index = array[middle];
                returnData.isFound = true;
                return returnData;
            }
            else if (first >= last || number > last)
            {
                returnData.index = -1;
                returnData.isFound = false;
                return returnData;
            }
            else if (number < array[middle])
            {
                return BinSearchArrayRecursively(array, first, middle, number);
            }
            else
            {
                return BinSearchArrayRecursively(array, middle, last, number);
            }
        }

        private static ReturnData BinSearchArrayIteratively(int[] array, int first, int last, int number)
        {
            ReturnData returnResult = new ReturnData();
            while (first <= last)
            {
                int middle = (first + last) / 2;
                if (array[middle] == number)
                {
                    returnResult.index = array[middle];
                    returnResult.isFound = true;
                    break;
                }
                else if (first >= last || number > last)
                {
                    returnResult.index = -1;
                    returnResult.isFound = false;
                    return returnResult;
                }
                else if (number < array[middle])
                {
                    last = middle;
                }
                else
                {
                    first = middle;
                }
            }
            return returnResult;
        }

        private static bool CheckIfSorted(int[] array)
        {
            //Checks only in ascending order
            //TODO: check in descending
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    return false;
                }
            }
            return true;
        }

        private struct ReturnData
        {
            internal int index;
            internal bool isFound;

            public ReturnData(int index, bool isFound)
            {
                this.index = -1;
                this.isFound = false;
            }
        }
    }
}
