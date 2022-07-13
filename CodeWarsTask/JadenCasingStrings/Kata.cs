using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsKata.JadenCasingStrings
{
    public static class Kata
    {
        public static string ToJadenCase(this string phrase)
        {
            string[] words = phrase.Split(' ');
            StringBuilder result = new();

            for (int i = 0; i < words.Length; i++)
            {
                string firstUpperedLetter = words[i][0].ToString().ToUpper();
                string word = words[i][1..];

                result.Append($"{firstUpperedLetter}{word} ");
            }

            return result.ToString().TrimEnd();
        }
    }
}