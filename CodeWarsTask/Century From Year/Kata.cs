namespace CodeWarsKata.Century_From_Year
{
    public class Kata
    {
        //private static void Main()
        //{
        //    СenturyFromYear(1705);
        //}

        public static int СenturyFromYear(int year)
        {
            int centuary = year / 100;
            int remainder = year % 100;

            return remainder >= 1 ? ++centuary : centuary;
        }
    }
}