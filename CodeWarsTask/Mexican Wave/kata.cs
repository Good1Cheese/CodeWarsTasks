using System.Collections.Generic;
using System.Text;

namespace CodeWars.Mexican_Wave
{
    public class Kata
    {
        public List<string> wave(string str)
        {
            List<string> result = new();
            StringBuilder stringBuilder = new(str);

            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i])) { continue; }

                string waved = BuildNewString(stringBuilder, i);

                result.Add(waved);
            }

            return result;

            string BuildNewString(StringBuilder str, int upperIndex)
            {
                str[upperIndex] = char.ToUpper(str[upperIndex]);

                string result = str.ToString();

                str[upperIndex] = char.ToLower(str[upperIndex]);

                return result;
            }
        }
    }
}