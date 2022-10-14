namespace CodeWarsTask.Large_Factorials;

public class Kata
{
    private const string ONE = "1";

    public static string Factorial(int n)
    {
        string result = ONE;

        for (int i = 1; i < n + 1; i++)
        {
            result = Multiply(result, i);
        }

        return result;
    }

    private static string Multiply(string n1, int n2)
    {
        string result = string.Empty;

        int next = 0;

        for (int i = n1.Length - 1; i >= 0; i--)
        {
            int digit = GetDigit(n1, i);

            digit = (digit * n2) + next;
            next = digit / 10;

            result = string.Concat(digit % 10, result);
        }

        return GetResult(result, next);

        static string GetResult(string result, int next)
        {
            if (next == 0)
            {
                return result;
            }

            return string.Concat(next, result);
        }
    }

    private static int GetDigit(string number, int index)
    {
        char c = number[index];

        return int.Parse(c.ToString());
    }
}