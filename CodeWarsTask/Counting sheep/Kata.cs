using System.Linq;

namespace CodeWars.Counting_sheep
{
    public class Kata
    {
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(sheep => sheep);
        }
    }
}