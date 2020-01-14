using System;

namespace HackerRank
{
    class Solution
    {

        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            float positive = 0;
            float negative = 0;
            float zero = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positive++;
                }
                else if (arr[i] < 0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }
            }
            float[] result = { positive / arr.Length, negative / arr.Length, zero / arr.Length };
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine(result[2]);

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
        }
    }
}
