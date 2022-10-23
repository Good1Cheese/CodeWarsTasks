using System.Linq;

namespace CodeWarsTask.Counting_Duplicates;

public static class Kata
{
    private static void Main()
    {
        System.Console.WriteLine(DuplicateCount("Indivisibility"));
    }

    public static int DuplicateCount(string str)
    {
        var duplicates = str.GroupBy(c => char.ToLower(c)).Where(g => g.Count() > 1);

        return duplicates.Count();
    }
}
