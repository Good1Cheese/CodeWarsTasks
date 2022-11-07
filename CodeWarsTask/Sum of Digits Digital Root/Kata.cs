using System.Linq;

namespace CodeWarsTask.Sum_of_Digits_Digital_Root;

public class Kata
{
    public static int DigitalRoot(long n)
    {
        while (n >= 10)
        {
            var nums = from c in n.ToString()
                       select int.Parse(c.ToString());

            n = nums.Sum();
        }

        return (int)n;
    }
}
