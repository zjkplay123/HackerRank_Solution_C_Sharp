using System;

namespace HackerRank
{
    class Solution
    {

        // Complete the birthdayCakeCandles function below.
        static int birthdayCakeCandles(int[] ar)
        {
            int max = ar.Max();
            int count = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == max)
                {
                    count++;
                }
            }
            return (count);


        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = birthdayCakeCandles(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
