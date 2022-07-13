using System.Linq;

namespace CodeWarsTask.Counting_sheep
{
    public class Kata
    {
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(sheep => sheep);
        }
    }
}