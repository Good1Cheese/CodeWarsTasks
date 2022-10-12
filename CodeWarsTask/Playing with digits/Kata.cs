using System;
using System.Linq;

namespace CodeWarsTask.Playing_with_digits;

public class Kata
{
    public static long digPow(int n, int p)
    {
        string number = n.ToString();

        long result = (long)number.Select(n => int.Parse(n.ToString()))
                                  .ToArray()
                                  .Select((n, i) => Math.Pow(n, p + i))
                                  .Sum();

        return result % n == 0 ? result / n : -1;
    }
}