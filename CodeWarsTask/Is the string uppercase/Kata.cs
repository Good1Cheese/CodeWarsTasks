using System.Linq;

namespace CodeWarsTask.Is_the_string_uppercase;

public static class StringExtensions
{
    public static bool IsUpperCase(this string text)
    {
        var strings = text.Split(' ');

        return strings.All(s =>
        {
            return s.All(c => char.IsUpper(c) || !char.IsLetter(c));
        });
    }
}