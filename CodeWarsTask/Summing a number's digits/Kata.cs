using System.Linq;

namespace CodeWarsTask.Summing_a_number_s_digits;

public class Kata
{
    public static int SumDigits(int number)
    {
        var digits = from c in number.ToString()
                     where char.IsDigit(c)
                     let s = c.ToString()
                     select int.Parse(s);

        return digits.Sum();
    }
}
