namespace _17.WeekTemperatures
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = new double[7, 6];

            Console.WriteLine("Please enter the temperature throughout the day: ");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                double[] newRow = Console.ReadLine().Split().Select(double.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = newRow[col];
                }
            }
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                double sumRow = 0;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sumRow += matrix[row, col];
                }
                Console.WriteLine($"Average teperature of day {row + 1} = {sumRow / 6.0:f2}C");
            }

            for (int row = 0; row <= matrix.GetLength(0); row++)
            {
                double sumCol = 0;
                for (int col = 0; col <= matrix.GetLength(1); col++)
                {

                    sumCol += matrix[col, row];
                }
                switch (row)
                {
                    case 0:
                        Console.WriteLine($"Average temperature at 00:00 = {sumCol / 7.0:f2}C");
                        break;                                                        
                    case 1:                                                           
                        Console.WriteLine($"Average temperature at 04:00 = {sumCol / 7.0:f2}C");
                        break;                                                        
                    case 2:                                                           
                        Console.WriteLine($"Average temperature at 08:00 = {sumCol / 7.0:f2}C");
                        break;                                                        
                    case 3:                                                           
                        Console.WriteLine($"Average temperature at 12:00 = {sumCol / 7.0:f2}C");
                        break;                                                        
                    case 4:                                                           
                        Console.WriteLine($"Average temperature at 16:00 = {sumCol / 7.0:f2}C");
                        break;
                    case 5:
                        Console.WriteLine($"Average temperature at 20:00 = {sumCol / 7.0:f2}C");
                        break;

                    default:
                        break;
                }
            }


        }
    }
}
