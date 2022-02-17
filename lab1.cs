using System;

namespace Lab1
{
    class Program
    {
        public const int count = 3;
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 3, 10 };
            WH1.QueueTime(arr1, 2);

            int[] arr2 = { 10, 2, 3, 3 };
            WH1.QueueTime(arr2, 2);

            int[] arr3 = { 5, 3, 4 };
            WH1.QueueTime(arr3, 1);
        }
    }

    public class WH1
    {
        public static long QueueTime(int[] customers, int n)
        {
            int[] Cash = new int[n];
            int[] AllTime = new int[customers.Length];
            int temp = 0, min = 0, max = 0;
            for (int i = 0; i < n; i++)
            {
                Cash[i] = customers[i];
            }
            for (int i = n; i < customers.Length; i++)
            {
                min = Cash[0];
                temp = 0;
                for (int j = 0; j < n; j++)
                {
                    if (Cash[j] < min)
                    {
                        min = Cash[j];
                        temp = j;

                    }
                }
                Cash[temp] += customers[i];
            }
            max = Cash[0];
            for (int i = 0; i < n; i++)
            {
                if (Cash[i] > max)
                {
                    max = Cash[i];
                }
            }
            Console.WriteLine(max);
            return 0;
        }
    }
}
