using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsKata.Consecutive_strings
{
    public class Kata
    {
        //private static void Main()
        //{
        //    Console.WriteLine(LongestConsec(new string[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2));
        //}

        public static string LongestConsec(string[] strarr, int k)
        {
        if (strarr.Length == 0 || k > strarr.Length || k < 0) { return string.Empty; }

            var concatenatedStrarr = GetConcatenatedArray(strarr, k);

            return concatenatedStrarr.OrderByDescending(str => str.Length).First();
        }

        private static List<string> GetConcatenatedArray(string[] strarr, int k)
        {
            var result = new List<string>();

            for (int i = 0; i < strarr.Length; i++)
            {
                string current = GetConcatenatedString(strarr, k, i);

                result.Add(current);
            }

            return result;
        }

        private static string GetConcatenatedString(string[] strarr, int k, int i)
        {
            string result = string.Empty;

            for (int j = 0; j < k; j++)
            {
                if (i + j >= strarr.Length) { break; }

                result += strarr[i + j];
            }

            return result;
        }
    }
}