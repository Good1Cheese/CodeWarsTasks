using System;

namespace CodeWars.Human_readable_duration_format;

public class HumanTimeFormat
{
    private const string NOW = "now";

    private static readonly TimeUnit[] _timeUnits = new TimeUnit[] { new Year(), new Day(), new Hour(), new Minute(), new Second() };

    private static string _result;

    public static string formatDuration(int seconds)
    {
        _result = string.Empty;

        if (seconds == 0) return NOW;

        foreach (var unit in _timeUnits)
        {
            int converted = unit.ToSeconds(seconds);

            if (converted == 0) continue;

            seconds -= unit.SecondsCount * converted;

            AddComma(seconds);
            AddAnd(seconds);

            _result += unit.ToString(converted);
        }

        return _result.Trim();
    }

    private static void AddComma(int seconds)
    {
        if (seconds <= 0 || _result == string.Empty) { return; }

        _result += ",";
    }

    private static void AddAnd(int seconds)
    {
        if (seconds != 0 || _result == string.Empty) { return; }

        _result += " and";
    }
}

public abstract class TimeUnit
{
    public const string WHITE_SPACE = " ";
    public const string PLURAL_ENDING = "s";

    public abstract int SecondsCount { get; }
    public abstract string Title { get; }

    public int ToSeconds(int seconds) => seconds / SecondsCount;

    public string ToString(int amount)
    {
        string result = string.Format($"{WHITE_SPACE}{amount} {Title}");

        if (amount > 1)
        {
            result += PLURAL_ENDING;
        }

        return result;
    }
}

public class Year : TimeUnit
{
    public override int SecondsCount => 31536000;
    public override string Title => "year";
}

public class Day : TimeUnit
{
    public override int SecondsCount => 86400;
    public override string Title => "day";
}

public class Hour : TimeUnit
{
    public override int SecondsCount => 3600;
    public override string Title => "hour";
}

public class Minute : TimeUnit
{
    public override int SecondsCount => 60;
    public override string Title => "minute";
}

public class Second : TimeUnit
{
    public override int SecondsCount => 1;
    public override string Title => "second";
}