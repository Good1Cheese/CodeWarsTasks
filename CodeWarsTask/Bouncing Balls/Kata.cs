namespace CodeWars.Bouncing_Balls
{
    public class Kata
    {
        public static int bouncingBall(double h, double bounce, double window)
        {
            if (h <= 0 || bounce >= 1 || bounce <= 0 || window >= h) { return -1; }

            int result = 1;

            while ((h = GetNewHeight(h, bounce)) > window)
            {
                result += 2;
            }

            return result;

            static double GetNewHeight(double h, double bounce)
            {
                return h * (bounce * 100) / 100;
            }
        }
    }
}