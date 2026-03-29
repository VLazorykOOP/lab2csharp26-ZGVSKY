using System;

namespace Lab2
{
    public class Task1
    {
        public static void Execute()
        {
            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element [{i}]: ");
                array[i] = int.Parse(Console.ReadLine()!);
            }

            int oddCount = CountOddElements(array);
            Console.WriteLine($"Number of odd elements: {oddCount}");
        }

       
        public static int CountOddElements(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) % 2 == 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}