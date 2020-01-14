using System;

namespace HackerRank
{
    class Solution
    {

        // Complete the staircase function below.
        static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int k = n - i;
                for (int j = 1; j <= k; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.Write("\n");
            }


        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
