namespace _16.SumOfElementsInMatrix
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter matrix size: ");
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            double primarySum = 0;
            double topSum = 0;
            double bottomSum = 0;
            int rows = size[0];
            int cols = size[0];
            double[,] matrix = new double[rows, cols];

            Console.WriteLine("Enter matrix elements: ");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                double[] newRow = Console.ReadLine().Split().Select(double.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = newRow[col];
                    if (col > row)
                    {
                        topSum += matrix[row, col];
                    }
                    else if (row > col)
                    {
                        bottomSum += matrix[row, col];
                    }
                }
                primarySum += matrix[row, row];
            }

            Console.WriteLine($"The sum of the Primary Diagonal is: {primarySum}");
            Console.WriteLine($"The sum of the top elements is: {topSum}");
            Console.WriteLine($"The sum of the bottom elements is: {bottomSum}");
        }
    }
}
