/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;


using System;

namespace Lab1
{
    class Program
    {
        public const int count = 3;
        static void Main(string[] args)
        {
            long print;
            int[] arr1 = { 2, 3, 10 };
            print = WH1.QueueTime(arr1, 2);
            Console.WriteLine(print);

            int[] arr2 = { 10, 2, 3, 3 };
            print = WH1.QueueTime(arr2, 2);
            Console.WriteLine(print);


            int[] arr3 = { 5, 3, 4 };
            print = WH1.QueueTime(arr3, 1);
            Console.WriteLine(print);

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
            return max;
        }
    }
}

