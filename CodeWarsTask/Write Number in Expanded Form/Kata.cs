namespace CodeWarsKata.Write_Number_in_Expanded_Form
{
    public class Kata
    {
        public static string ExpandedForm(long num)
        {
            string result = string.Empty;

            string strNum = num.ToString();

            for (int i = 0; i < strNum.Length; i++)
            {
                if (int.Parse(strNum[i].ToString()) == 0) { continue; }
                if (i == strNum.Length - 1) { result += string.Format($" {int.Parse(strNum[i].ToString())}"); break; }

                int wholeNumber = int.Parse(strNum);
                int remainingNumbers = int.Parse(strNum.Substring(i + 1, strNum.Length - 1));

                result += string.Format($" {wholeNumber - remainingNumbers} +");
            }
            result = result.TrimStart();

            return result;
        }

        public static string ExpandedForm1(long num)
        {
            string result = string.Empty;

            string strNum = num.ToString();
            long digitClass = GetDigitClass(strNum);

            for (int i = 0; i < strNum.Length; i++, digitClass /= 10)
            {
                long curremtNumber = long.Parse(strNum[i].ToString());

                if (curremtNumber == 0) { continue; }
                result += string.Format($" {curremtNumber * digitClass} +");
            }
            result = result.Trim('+');
            result = result.Trim(' ');

            result = result.TrimStart();

            return result;
        }

        private static long GetDigitClass(string strNum)
        {
            string digitClass = "1";

            for (int i = 0; i < strNum.Length - 1; i++)
            {
                digitClass += "0";
            }
            return long.Parse(digitClass);
        }
    }
}