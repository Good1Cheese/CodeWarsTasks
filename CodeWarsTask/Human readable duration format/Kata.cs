using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTask.Human_readable_duration_format;

public class Kata
{
    //private static void Main()
    //{
    //    //Console.WriteLine(HumanTimeFormat.formatDuration(0));
    //    //Console.WriteLine(HumanTimeFormat.formatDuration(1));
    //    Console.WriteLine(HumanTimeFormat.formatDuration(62));
    //    Console.WriteLine(HumanTimeFormat.formatDuration(120));
    //    Console.WriteLine(HumanTimeFormat.formatDuration(3662));
    //    Console.WriteLine(HumanTimeFormat.formatDuration(15731080));
    //    Console.WriteLine(HumanTimeFormat.formatDuration(33243586));
    //}

}

public class HumanTimeFormat
{
    private const string NOW = "now";

    private const int SECONDS_IN_YEAR = 31536000;
    private const int SECONDS_IN_DAY = 86400;
    private const int SECONDS_IN_HOUR = 3600;
    private const int SECONDS_IN_MINUTE = 60;

    public static string formatDuration(int seconds)
    {
        if (seconds <= 0) { return NOW; }

        int years = GetAnotherUnitCountFromSeconds(ref seconds, SECONDS_IN_YEAR);
        int days = GetAnotherUnitCountFromSeconds(ref seconds, SECONDS_IN_DAY);
        int hours = GetAnotherUnitCountFromSeconds(ref seconds, SECONDS_IN_HOUR);
        int minutes = GetAnotherUnitCountFromSeconds(ref seconds, SECONDS_IN_MINUTE);

        TimeUnit[] units = new[]
        {
            new TimeUnit(nameof(years), years),
            new TimeUnit(nameof(days), days),
            new TimeUnit(nameof(hours), hours),
            new TimeUnit(nameof(minutes), minutes),
            new TimeUnit(nameof(seconds), seconds)
        };

        var notNullUnits = from unit in units
                           where unit.Value > 0
                           select $"{unit}";

        return JoinUnits(notNullUnits);
    }

    private static int GetAnotherUnitCountFromSeconds(ref int seconds, int secondsInUnit)
    {
        int result = seconds / secondsInUnit;
        seconds %= secondsInUnit;

        return result;
    }

    private static string JoinUnits(IEnumerable<string> notNullUnits)
    {
        return "";
    }
}

public class TimeUnit
{
    public const string SEPARATOR = ", ";

    public TimeUnit(string title, int value)
    {
        Title = title;
        Value = value;
    }

    public int Value { get; set; }
    public string Title { get; set; }

    public override string ToString()
    {
        string result = $"{Value} {Title}";

        if (Value > 1)
        {
            return result;
        }

        return result[..^1];
    }
}

public class Seconds : TimeUnit
{
    public Seconds(string title, int value)
        : base(title, value)
    {
    }

    public new const string SEPARATOR = "and ";
}