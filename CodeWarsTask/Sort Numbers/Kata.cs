using System;
using System.Linq;

namespace CodeWarsTask.Sort_Numbers;

public class Kata
{
    public static int[] SortNumbers(int[] nums)
    {
        if (nums == null) return Array.Empty<int>();

        return nums.OrderBy(n => n).ToArray();
    }
}