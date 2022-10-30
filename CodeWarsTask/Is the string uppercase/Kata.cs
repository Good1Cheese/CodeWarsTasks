using System.Linq;

namespace CodeWarsTask.Is_the_string_uppercase;

public static class StringExtensions
{
    public static bool IsUpperCase(this string text)
    {
        return text.ToUpper() == text;
    }
}