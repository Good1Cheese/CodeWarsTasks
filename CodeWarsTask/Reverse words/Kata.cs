using System.Linq;

namespace CodeWarsTask.Reverse_words;

public static class Kata
{
    public static string ReverseWords(string str)
    {
        var splited = str.Split();

        var result = string.Join(string.Empty, splited.Select(c => string.Concat(c.Reverse())));

        return result;
    }
}
