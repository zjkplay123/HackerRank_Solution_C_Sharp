using System;

namespace HackerRank
{
    class Solution
    {

        /*
         * Complete the timeConversion function below.
         */
        static string timeConversion(string s)
        {
            /*
             * Write your code here.
             */
            if (s.Substring(8, 2) == "AM" && s.Substring(0, 2) != "12")
            {
                s = s.Substring(0, 8);
            }
            else if (s.Substring(8, 2) == "PM" && s.Substring(0, 2) == "12")
            {
                s = s.Substring(0, 8);
            }
            else if (s.Substring(8, 2) == "AM" && s.Substring(0, 2) == "12")
            {
                s = Convert.ToString("00") + s.Substring(2, 6);
            }
            else
            {
                s = Convert.ToString(Convert.ToInt32(s.Substring(0, 2)) + 12) + s.Substring(2, 6);
            }
            return (s);

        }

        static void Main(string[] args)
        {
            TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = timeConversion(s);

            tw.WriteLine(result);

            tw.Flush();
            tw.Close();
        }
    }
}
