using System;

namespace Lab2
{
    public class Task4
    {
        public static void Execute()
        {
            Console.Write("Enter the number of rows: ");
            int n = int.Parse(Console.ReadLine()!);
            int[][] jaggedArray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the number of elements in row {i}: ");
                int cols = int.Parse(Console.ReadLine()!);
                jaggedArray[i] = new int[cols];

                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i}][{j}]: ");
                    jaggedArray[i][j] = int.Parse(Console.ReadLine()!);
                }
            }

            int[] resultArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int lastEven = 0; 
                for (int j = jaggedArray[i].Length - 1; j >= 0; j--)
                {
                    if (jaggedArray[i][j] % 2 == 0)
                    {
                        lastEven = jaggedArray[i][j];
                        break;
                    }
                }
                resultArray[i] = lastEven;
            }

            Console.WriteLine("Resulting array of last even elements:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{resultArray[i]} ");
            }
            Console.WriteLine();
        }
    }
}