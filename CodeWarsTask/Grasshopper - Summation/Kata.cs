using System;

namespace CodeWarsKata.Grasshopper___Summation
{
    public class Kata
    {
        public static int summation(int num)
        {
            return GetSumOfAnArithmeticProgression(num);
        }

        private static int GetSumOfAnArithmeticProgression(int num)
        {
            var v = (int)Math.Ceiling((double)num / (double)2);

            return (1 + num) * v;
        }
    }
}