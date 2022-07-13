using System;
using System.Text;

namespace CodeWarsTask.Adding_Big_Numbers
{
    public class Kata
    {
        //private static void Main()
        //{
        //    Console.WriteLine(Add("111111", "9"));
        //    Console.WriteLine(Add("1", "111111"));

        //    Console.WriteLine(Add("11", "99"));

        //    // Add("823094582094385190384102934810293481029348123094818923749817", "234758927345982475298347523984572983472398457293847594193837");
        //}

        public static string Add(string a, string b)
        {
            BringNumbersToOneFormat(ref a, ref b);

            string result = string.Empty;
            int remainder = 0;

            for (int i = a.Length - 1; i > 0; i--)
            {
                string strA = a[i].ToString();
                string strB = b[i].ToString();

                int c = int.Parse(strA) + int.Parse(strB);
                c += remainder;

                remainder = c / 10;
                c -= 10 * remainder;

                result = c + result;
            }

            return result;
        }

        private static void BringNumbersToOneFormat(ref string a, ref string b)
        {
            var lenghtDifference = a.Length - b.Length;
            StringBuilder zeros = GetZeros(Math.Abs(lenghtDifference));

            if (lenghtDifference > 0)
            {
                b = zeros + b;
                return;
            }

            a = zeros + a;
        }

        private static StringBuilder GetZeros(int lenght)
        {
            var zeros = new StringBuilder();
            zeros.Append('0', lenght);

            return zeros;
        }
    }
}
