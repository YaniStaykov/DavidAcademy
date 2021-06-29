using System;

namespace _23.FindingPathInAMaze
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] maze = new char[10, 10];

            ShowMaze(maze);
        }

        static void FindPath(char[,] maze, int startRow, int startCol)
        {
            if (startRow > startCol)
            {

            }
        }

        static void ShowMaze(char[,] maze)
        {
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    Console.Write(maze[row, col] + ".");
                }
                Console.WriteLine();
            }
        }

        static char[,] FillMaze(char[,] maze)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(0); j++)
                {
                    maze[i, j] = ' ';
                }
            }

            return maze;
        }
    }
}
