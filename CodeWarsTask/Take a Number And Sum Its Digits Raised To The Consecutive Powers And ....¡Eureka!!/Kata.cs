using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTask.Take_a_Number_And_Sum_Its_Digits_Raised_To_The_Consecutive_Powers_And_._Eureka__;

public class SumDigPower
{
    public static long[] SumDigPow(long a, long b)
    {
        List<long> result = new();

        for (; a < b; a++)
        {
            bool isValid = GetSumDigPow(a.ToString()) == a;

            if (!isValid) continue;

            result.Add(a);
        }

        return result.ToArray();
    }

    private static int GetSumDigPow(string str)
    {
        return str.Select((num, index) => GetSumNumPow(num, index)).Sum();

        static int GetSumNumPow(char c, int index)
        {
            int n = int.Parse(c.ToString());

            float result = MathF.Pow(n, index + 1);

            return (int)result;
        }
    }
}
