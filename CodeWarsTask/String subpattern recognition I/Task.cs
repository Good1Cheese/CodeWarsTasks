using System;

namespace CodeWarsTask.String_subpattern_recognition_I
{
    public class Task
    {
        private const char COMMA = ',';

        public static string NumberFormat(int number)
        {
            string strNumber = number.ToString();
            int absoluteNumberLength = Math.Abs(number).ToString().Length;

            int commaCount = absoluteNumberLength / 3;

            if (absoluteNumberLength % 3 == 0) { commaCount--; }

            for (int i = strNumber.Length - 3; commaCount > 0; i -= 3, commaCount--)
            {
                strNumber = AddCommaInString(strNumber, i);
            }

            return strNumber;
        }

        private static string AddCommaInString(string str, int index)
        {
            string newString = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (i == index)
                {
                    newString += COMMA;
                }
                newString += str[i];
            }

            return newString;
        }
    }
}