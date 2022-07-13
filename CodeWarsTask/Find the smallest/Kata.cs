using System;
using System.Text;

namespace CodeWarsKata._1_n__Cycle
{
    public class Kata
    {
        // https://www.codewars.com/kata/573992c724fc289553000e95/train/csharp

        private const int ANSER_LENGHT = 3;

        public static long[] Smallest(long n)
        {
            string strNum = n.ToString();
            long[] anser = new long[ANSER_LENGHT];

            int smallestNum = FindSmallestNumber(ref strNum, (int)n);
            MakeNumberSmaller(strNum, smallestNum);

            return anser;
        }

        private static void MakeNumberSmaller(string strNum, int smallestNum)
        {
            var newString = new StringBuilder(strNum);

            for (int i = 0; i < strNum.Length; i++)
            {
                int num = int.Parse(strNum[i].ToString());
                if (num < smallestNum) { return; }

                Console.WriteLine($"{smallestNum}{strNum}");
                break;
            }
        }

        private static int FindSmallestNumber(ref string strNum, int n)
        {
            int smallestNum = n;
            int smallestNumIndex = 0;

            for (int i = 0; i < strNum.Length; i++)
            {
                int num = int.Parse(strNum[i].ToString());
                if (num == 0 || smallestNum < num) { continue; }
                Console.WriteLine(num);
                smallestNumIndex = i;
                smallestNum = num;
            }

            strNum = strNum.Remove(smallestNumIndex, 1);
            return smallestNum;
        }
    }
}