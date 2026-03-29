using System;

namespace Lab2
{
    public class Task2
    {
        public static void Execute()
        {
            Console.Write("Enter the size of the sequence: ");
            int n = int.Parse(Console.ReadLine()!);
            double[] array = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element [{i}]: ");
                array[i] = double.Parse(Console.ReadLine()!);
            }

            int lastMaxIndex = 0;
            double max = array[0];

            for (int i = 1; i < n; i++)
            {
                if (array[i] >= max)
                {
                    max = array[i];
                    lastMaxIndex = i;
                }
            }

            Console.WriteLine($"Index of the last maximum element: {lastMaxIndex}");
        }
    }
}