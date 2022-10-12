using System.Linq;

namespace CodeWarsTask.How_good_are_you_really;

public class Kata
{
    public static bool BetterThanAverage(int[] classPoints, int yourPoints)
    {
        return yourPoints > classPoints.Average();
    }
}