using System;

namespace Lab2
{
    public class Task3
    {
        public static void Execute()
        {
            Console.Write("Enter the number of rows (n): ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Enter the number of columns (m): ");
            int m = int.Parse(Console.ReadLine()!);

            int[] initialData = new int[n * m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    initialData[i * m + j] = int.Parse(Console.ReadLine()!);
                }
            }

            Console.WriteLine("\n--- Solving with 2D Array ---");
            SolveWith2DArray(n, m, initialData);

            Console.WriteLine("\n--- Solving with 1D Array (Simulated 2D) ---");
            SolveWith1DArray(n, m, initialData);
        }
        
        public static void SolveWith2DArray(int n, int m, int[] data)
        {
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = data[i * m + j];
                }
            }

            int col1 = m % 2 == 0 ? m / 2 - 1 : 0;
            int col2 = m / 2;

            for (int i = 0; i < n; i++)
            {
                int temp = array[i, col1];
                array[i, col1] = array[i, col2];
                array[i, col2] = temp;
            }

            Console.WriteLine("Modified 2D Array:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{array[i, j],4}");
                }
                Console.WriteLine();
            }
        }

        public static void SolveWith1DArray(int n, int m, int[] data)
        {
            int[] array = new int[n * m];
            Array.Copy(data, array, data.Length);

            int col1 = m % 2 == 0 ? m / 2 - 1 : 0;
            int col2 = m / 2;

            for (int i = 0; i < n; i++)
            {
                int temp = array[i * m + col1];
                array[i * m + col1] = array[i * m + col2];
                array[i * m + col2] = temp;
            }

            Console.WriteLine("Modified 1D Array (Printed as 2D):");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{array[i * m + j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}