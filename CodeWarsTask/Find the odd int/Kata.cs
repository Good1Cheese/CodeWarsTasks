using System.Linq;

namespace CodeWarsTask.Find_the_odd_int;

public class Kata
{
    public static int find_it(int[] seq)
    {
        var result = seq.GroupBy(n => n)
                        .SingleOrDefault(n => IsOdd(n.Count()));

        return result.Key;
    }

    private static bool IsOdd(int n) => n % 2 != 0;
}