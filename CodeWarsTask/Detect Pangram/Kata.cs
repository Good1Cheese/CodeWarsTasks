using System.Linq;

namespace CodeWarsTask.Detect_Pangram;

public static class Kata
{
    private const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static bool IsPangram(string input)
    {
        input = input.ToUpper();

        return ALPHABET.All(c => input.Contains(c));
    }
}
