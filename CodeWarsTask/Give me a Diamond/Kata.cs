using System.Text;

namespace CodeWarsTask.Give_me_a_Diamond;

public class Kata
{
    public static string print(int n)
    {
        bool isNegativOrOdd = n <= 0 || n % 2 == 0;

        if (isNegativOrOdd) { return null; }

        StringBuilder stringBuilder = new();
        int layersCount = n / 2;
        int spaceCount = layersCount;
        string[] layers = new string[n];

        for (int i = 0, starCount = 1; i < layersCount + 1; i++, spaceCount--, starCount += 2)
        {
            stringBuilder.Append(' ', spaceCount);
            stringBuilder.Append('*', starCount);
            stringBuilder.Append('\n');

            layers[i] = stringBuilder.ToString();

            if (i == layersCount) { break; }

            layers[layers.Length - 1 - i] = stringBuilder.ToString();

            stringBuilder.Clear();
        }

        return string.Join("", layers);
    }
}
