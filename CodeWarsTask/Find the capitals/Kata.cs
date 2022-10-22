using System.Collections.Generic;

namespace CodeWarsTask.Find_the_capitals;

public static class Kata
{
    public static int[] Capitals(string word)
    {
        List<int> result = new();

        for (int i = 0; i < word.Length; i++)
        {
            char c = word[i];

            if (char.IsUpper(c))
            {
                result.Add(i);
            }
        }

        return result.ToArray();
    }
}
