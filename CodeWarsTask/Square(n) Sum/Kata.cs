namespace CodeWarsKata.Square_n__Sum
{
    public class Kata
    {
        //private static void Main()
        //{
        //    SquareSum(new int[] { 1, 2, 2 });
        //}

        public static int SquareSum(int[] n)
        {
            int result = 0;

            foreach (int num in n)
            {
                result += num * num;
            }

            return result;
        }
    }
}