using System;

namespace CodeWarsKata.Build_a_pile_of_Cubes
{
    public class Kata
    {
        // https://www.codewars.com/kata/5592e3bd57b64d00f3000047/train/csharp

        public static long findNb(long m)
        {
            for (long i = 0; ; i++)
            {
                m -= i * i * i;

                if (m == 0) { return i; }

                if (m < 0) { break; }
            }

            return -1;
        }
    }
}