using System;

namespace CodeWarsKata.Fraction
{
    public class Program
    {
        public static void MixedFraction(string _simpleFraction)
        {
            Fraction fraction = GetFraction(_simpleFraction);

            MixedFriction mixedFraction = fraction.ToMixedFraction();
            Fraction.ReduceFraction(mixedFraction);
            Console.WriteLine(mixedFraction.ToString());
        }

        private static Fraction GetFraction(string _simpleFraction)
        {
            int minusCount = _simpleFraction.Split('-').Length - 1;
            string[] partsOfFraction = _simpleFraction.Split("/");

            int _numerator = int.Parse(partsOfFraction[0]);
            int _denominator = int.Parse(partsOfFraction[1]);

            var fraction = new Fraction(_numerator, _denominator);
            return fraction;
        }
    }
}