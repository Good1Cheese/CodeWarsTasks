using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsKata.The_observed_PIN;

public class Program
{
    //private static void Main()
    //{
    //    BenchmarkRunner.Run(typeof(Program).Assembly);
    //}

    [Benchmark]
    public void MySolution()
    {
        Kata2.GetPINs("1");
        Kata2.GetPINs("11");
        Kata2.GetPINs("111");
        Kata2.GetPINs("1111");
        Kata2.GetPINs("11111");
        Kata2.GetPINs("111111");
        Kata2.GetPINs("1111111");
        Kata2.GetPINs("11111111");
    }

    [Benchmark]
    public void LinqSolution()
    {
        Kata1.GetPINs("1");
        Kata1.GetPINs("11");
        Kata1.GetPINs("111");
        Kata1.GetPINs("1111");
        Kata1.GetPINs("11111");
        Kata1.GetPINs("111111");
        Kata1.GetPINs("1111111");
        Kata1.GetPINs("11111111");
    }
}

public class Kata1
{
    public static List<string> GetPINs(string observed)
    {
        var result = new List<string>() { string.Empty };

        foreach (var с in observed)
        {
            result = (from r in result
                      from a in _adjacentDigits[с]
                      select $"{r}{a}").ToList();
        }

        return result;
    }

    private static readonly Dictionary<char, string[]> _adjacentDigits =
        new()
        {
            { '0', new[] { "0", "8" } },
            { '1', new[] { "1", "2", "4" } },
            { '2', new[] { "1", "2", "3", "5" } },
            { '3', new[] { "2", "3", "6" } },
            { '4', new[] { "1", "4", "5", "7" } },
            { '5', new[] { "2", "4", "5", "6", "8" } },
            { '6', new[] { "3", "5", "6", "9" } },
            { '7', new[] { "4", "7", "8" } },
            { '8', new[] { "5", "7", "8", "9", "0" } },
            { '9', new[] { "6", "8", "9" } },
        };
}

public class Kata2
{
    public static List<string> GetPINs(string observed)
    {
        List<string[]> adjacentDigits = new();
        List<string> PINs = new();

        int[] indexes = new int[observed.Length];
        int[] targetIndexes = new int[observed.Length];
        int combinationsCount = 1;

        for (int i = 0; i < observed.Length; i++)
        {
            string[] item = PINCode.GetAdjacentDigits(observed[i]);

            adjacentDigits.Add(item);
            combinationsCount *= item.Length;
            targetIndexes[i] = item.Length;
        }

        int iterationsCount = combinationsCount / targetIndexes[^1];

        for (int i = 0; i < iterationsCount; i++)
        {
            GetPINCombinations(adjacentDigits, PINs, indexes, targetIndexes);
            UpdateIndexes(indexes, targetIndexes);
        }

        return PINs;
    }

    private static void GetPINCombinations(List<string[]> adjacentDigits, List<string> PINs, int[] indexes, int[] targetIndexes)
    {
        for (int i = 0; i < targetIndexes[^1]; i++)
        {
            indexes[^1] = i;

            string combination = GetPINCombination(adjacentDigits, indexes);

            PINs.Add(combination);
        }
    }

    private static string GetPINCombination(List<string[]> adjacentDigits, int[] indexes)
    {
        string current = string.Empty;

        for (int i = 0; i < indexes.Length; i++)
        {
            current += adjacentDigits[i][indexes[i]];
        }

        return current;
    }

    private static void UpdateIndexes(int[] indexes, int[] targetIndexes)
    {
        for (int i = indexes.Length - 1; i >= 1; i--)
        {
            if (indexes[i] >= targetIndexes[i] - 1)
            {
                indexes[i - 1]++;
                indexes[i] = 0;

                UpdateUpdatedIndexes(indexes, targetIndexes, i);

                break;
            }
        }
    }

    private static void UpdateUpdatedIndexes(int[] indexes, int[] targetIndexes, int i)
    {
        for (int j = 1; j < indexes.Length - 1; j++)
        {
            if (indexes[i - j] >= targetIndexes[i - j])
            {
                indexes[i - j - 1]++;
                indexes[i - j] = 0;
            }
        }
    }
}

public static class PINCode
{
    private static readonly Dictionary<string, string[]> _adjacentDigits = new()
    {
        { "0", new string[] { "0", "8" } },
        { "1", new string[] { "1", "2", "4" } },
        { "2", new string[] { "1", "2", "3", "5" } },
        { "3", new string[] { "2", "3", "6" } },
        { "4", new string[] { "1", "4", "5", "7" } },
        { "5", new string[] { "2", "4", "5", "6", "8" } },
        { "6", new string[] { "3", "5", "6", "9" } },
        { "7", new string[] { "4", "7", "8" } },
        { "8", new string[] { "5", "7", "8", "9", "0" } },
        { "9", new string[] { "6", "8", "9" } },
    };

    public static string[] GetAdjacentDigits(char digit)
    {
        var result = _adjacentDigits.FirstOrDefault(n =>
        {
            string strDigit = digit.ToString();
            return n.Key == strDigit;
        });

        return result.Value;
    }
}