using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWarsKata.Square_into_Squares._Protect_trees_;

public class Kata
{
    //private static void Main()
    //{
    //    Decompose d = new();

    //    Console.WriteLine(d.decompose(12));
    //    //Console.WriteLine(d.decompose(625));
    //    //Console.WriteLine(d.decompose(7100));
    //    //Console.WriteLine(d.decompose(1234567));
    //}
}

public class Decompose
{
    public string decompose(long n)
    {
        long squaredN = n * n;
        string result = string.Empty;

        for (long i = n - 1; squaredN > 0; i--)
        {
            if (i < 0) { return null; }

            long remainder = squaredN - i * i;

            if (remainder >= 0)
            {
                squaredN = remainder;
                result = $"{i} {result}";
            }
        }

        return result.TrimEnd();
    }
}