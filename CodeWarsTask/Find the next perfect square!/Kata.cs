using System;
using static System.Console;

namespace CodeWarsTask.Find_the_next_perfect_square_;

public class Kata
{
    public static long FindNextSquare(long number)
    {
        double squaredNumber = Math.Sqrt(number);

        bool isPerfectSquare = squaredNumber % 1 == 0;

        if (number <= 0 || !isPerfectSquare) { return -1; }

        int smthSmart = 3 + 2 * ((int)squaredNumber - 1);

        return number + smthSmart;
    }
}