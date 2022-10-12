using System.Collections.Generic;

namespace CodeWarsTask.Two_Sum;

public class Kata
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return null;
    }
}