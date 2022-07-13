using System;

namespace CodeWarsKata.PerfectPower
{
    public class Kata
    {
        public static (int, int)? IsPerfectPower(int n)
        {
            int squaredN = (int)MathF.Ceiling(MathF.Sqrt(n));
            for (int m = 1; m < squaredN + 1; m++)
            {
                for (int k = 2; k < squaredN + 1; k++)
                {
                    int powerPair = MyPow(m, k);

                    if (powerPair == n)
                    {
                        return (m, k);
                    }
                }
            }
            return null;
        }

        private static int MyPow(int m, int k)
        {
            int result = 1;

            for (int i = 0; i < k; i++)
            {
                result *= m;
            }
            return result;
        }
    }
}