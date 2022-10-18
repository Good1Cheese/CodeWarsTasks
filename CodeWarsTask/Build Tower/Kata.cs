using System;

namespace CodeWarsTask.Build_Tower;

public class Kata
{
    private const char WHITE_SPACE = ' ';
    private const char STAR_SYMBOL = '*';

    public static string[] TowerBuilder(int nFloors)
    {
        string[] result = new string[nFloors];
        int spaces = nFloors - 1;

        for (int i = 0; i < nFloors; i++, spaces--)
        {
            int startsCount = i * 2 + 1;

            var passes = new string(WHITE_SPACE, spaces);
            var stars = new string(STAR_SYMBOL, startsCount);

            result[i] = string.Format($"{passes}{stars}{passes}");
        }

        return result;
    }
}
