using System;

namespace CodeWarsTask.You_re_a_square_;

public class Kata
{
    public static bool IsSquare(int n)
    {
        int sqrt = (int)MathF.Sqrt(n);

        return sqrt * sqrt == n;
    }
}