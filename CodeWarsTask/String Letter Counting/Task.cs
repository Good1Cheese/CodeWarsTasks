using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTask.String_Letter_Counting
{
    public class Task
    {
        private const string alphabet = "abcdefghijklmnopqrstuvwxyz";

        public static string StringLetterCount(string str)
        {
            Dictionary<string, int> lettertsWithTheirCount = new Dictionary<string, int>();
            for (int i = 0; i < str.Length; i++)
            {
                string letter = str[i].ToString().ToLower();
                if (alphabet.Contains(letter))
                {
                    bool containsAlphabetLetter = lettertsWithTheirCount.Keys.Contains(letter);
                    if (!containsAlphabetLetter)
                    {
                        lettertsWithTheirCount.Add(letter, 1);
                        continue;
                    }
                    lettertsWithTheirCount[letter]++;
                }
            }

            return string.Empty;
            //return GetStringLetterCount(lettertsWithTheirCount.OrderBy(c => c.Key));
        }

        public static string StringLetterCount2(string str)
        {
            Dictionary<string, int> lettertsWithTheirCount = new Dictionary<string, int>();
            for (int i = 0; i < str.Length; i++)
            {
                string letter = str[i].ToString().ToLower();
                if (alphabet.Contains(letter))
                {
                    bool containsAlphabetLetter = lettertsWithTheirCount.Keys.Contains(letter);
                    if (!containsAlphabetLetter)
                    {
                        lettertsWithTheirCount.Add(letter, 1);
                        continue;
                    }
                    lettertsWithTheirCount[letter]++;
                }
            }

            return GetStringLetterCount(SortByASC(lettertsWithTheirCount));
        }

        private static string GetStringLetterCount(Dictionary<string, int> dictionary)
        {
            string anser = string.Empty;

            foreach (KeyValuePair<string, int> keyValuePair in dictionary)
            {
                string a = string.Format($"{keyValuePair.Value}{keyValuePair.Key}");
                anser += a;
            }
            return anser;
        }

        public static Dictionary<string, int> SortByASC(Dictionary<string, int> dictionary)
        {

            return null;
        }
    }
}