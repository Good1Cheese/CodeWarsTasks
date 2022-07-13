using System;
using System.Linq;

namespace CodeWarsKata.Highest_and_Lowest
{
    public class Kata
    {
        public static string HighAndLow(string numbers)
        {
            int[] convertedNumbers = ConvertStringToArray(numbers);

            int max = convertedNumbers.Max();
            int min = convertedNumbers.Min();

            return $"{max} {min}";
        }

        private static int[] ConvertStringToArray(string numbers)
        {
            string[] strNumbers = numbers.Split(" ");

            return Array.ConvertAll(strNumbers, s => int.Parse(s));
        }
    }
}
