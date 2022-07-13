using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsKata.Tribonacci_Sequence
{
    public class Kata
    {
    }

    public class Xbonacci
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            if (signature == null) { return null; }

            double[] result = new double[n];
            var newArrayLength = n < signature.Length ? n : signature.Length;

            for (int i = 0; i < newArrayLength; i++)
            {
                result[i] = signature[i];
            }

            for (int i = signature.Length; i < n; i++)
            {
                result[i] = result[i - 1] + result[i - 2] + result[i - 3];
            }

            return result;
        }
    }
}