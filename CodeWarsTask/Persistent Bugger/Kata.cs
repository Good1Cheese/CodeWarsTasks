namespace CodeWarsKata.Persistent_Bugger
{
    public class Kata
    {
        public static int Persistence(long n)
        {
            int count = 0;
            long current = n;

            while (current >= 10)
            {
                current = GetNext(current);
                count++;
            }

            return count;
        }

        private static long GetNext(long n)
        {
            string str = n.ToString();
            long result = 1;

            for (int i = 0; i < str.Length; i++)
            {
                string letter = str[i].ToString();

                result *= int.Parse(letter);
            }

            return result;
        }
    }
}