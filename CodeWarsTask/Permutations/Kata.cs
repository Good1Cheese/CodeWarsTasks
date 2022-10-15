using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTask.Permutations;

public class Kata
{
    public static List<string> SinglePermutations(string str)
    {
        IEnumerable<string> result = new List<string>() { string.Empty };

        foreach (var _ in str)
        {
            result = (from s in str
                      from r in result
                      select $"{r}{s}").ToList();
        }

        result = result.Where(s => HasSameLetters(s, str));

        return result.Distinct().ToList();
    }

    private static bool HasSameLetters(string s1, string s2)
    {
        var arr1 = s1.OrderBy(c => c);
        var arr2 = s2.OrderBy(c => c);

        return arr1.SequenceEqual(arr2);
    }
}
