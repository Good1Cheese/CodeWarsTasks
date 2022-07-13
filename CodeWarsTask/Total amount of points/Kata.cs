using System.Linq;

namespace CodeWarsTask.Total_amount_of_points
{
    public class Kata
    {
        //private static void Main()
        //{
        //    TotalPoints(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" });
        //}

        //public static int TotalPoints(string[] games)
        //{
        //    int result = 0;

        //    foreach (string game in games)
        //    {
        //        char x = game[0];
        //        char y = game[^1];

        //        if (x > y)
        //        {
        //            result += 3;
        //        }

        //        if (x == y)
        //        {
        //            result++;
        //        }
        //    }

        //    return result;
        //}

        public static int TotalPoints(string[] games)
        {
            var xMoreThenY = games.Where(game => game[0] > game[2]);
            var xEqualsY = games.Where(game => game[0] == game[2]);

            return (xMoreThenY.Count() * 3) + xEqualsY.Count();
        }
    }
}
