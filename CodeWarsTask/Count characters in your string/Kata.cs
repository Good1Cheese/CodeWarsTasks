using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTask.Count_characters_in_your_string
{
    public class Kata
    {
        //public static Dictionary<char, int> CountWithoutLinq(string str)
        //{
        //    var result = new Dictionary<char, int>();

        //    foreach (char c in str)
        //    {
        //        if (result.ContainsKey(c))
        //        {
        //            result[c]++;
        //            continue;
        //        }

        //        result[c] = 1;
        //    }

        //    return result;
        //}

        //public static Dictionary<char, int> CountWithLinq(string str)
        //{
        //    var result = new Dictionary<char, int>();
        //    var uniqueLetters = str.Distinct();

        //    foreach (var letter in uniqueLetters)
        //    {
        //        int lettersCount = str.Count(c => c == letter);

        //        result.Add(letter, lettersCount);
        //    }

        //    return result;
        //}

        public static Dictionary<char, int> CountWithGroupBy(string str)
        {
            return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        }
    }
}