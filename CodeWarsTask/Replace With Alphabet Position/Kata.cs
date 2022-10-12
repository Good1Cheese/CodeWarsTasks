using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTask.Replace_With_Alphabet_Position;

public static class Kata
{
    private const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string WHITE_SPACE = " ";

    private static IEnumerable<string> _result;

    private static void Main()
    {
        AlphabetPosition("The sunset sets at twelve o' clock.");
    }

    public static string AlphabetPosition(string str)
    {
        _result = from c in str
                  let letter = char.ToUpper(c)
                  where char.IsLetter(letter)
                  select GetLetterIndex(letter).ToString();

        return ConvertResultToString();
    }

    private static string ConvertResultToString()
    {
        return string.Join(WHITE_SPACE, _result).Trim();
    }

    private static int GetLetterIndex(char letter)
    {
        return ALPHABET.IndexOf(letter) + 1;
    }
}