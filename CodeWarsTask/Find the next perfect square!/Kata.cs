using System;

namespace CodeWarsTask.Find_the_next_perfect_square_;

public class Kata
{
    public static long FindNextSquare(long number)
    {
        long sqrt = (long)Math.Sqrt(number);

        if (sqrt * sqrt != number) { return -1; }

        var next = sqrt + 1;

        return next * next;
    }
}