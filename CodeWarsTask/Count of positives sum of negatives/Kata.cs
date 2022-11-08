using System;
using System.Linq;

namespace CodeWarsTask.Count_of_positives_sum_of_negatives;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        if (input == null || input.Length == 0) 
        {
            return Array.Empty<int>();
        }

        int positive = input.Where(n => n > 0).Count();
        int negative = input.Where(n => n < 0).Sum();

        return new int[] { positive, negative };
    }
}
