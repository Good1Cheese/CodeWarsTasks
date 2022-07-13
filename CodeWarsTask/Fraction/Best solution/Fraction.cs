namespace CodeWarsKata.Fraction.BestSotution
{
    public class Fraction
    {
        private const char DELIMITER = '/';

        public int Numerator { get; }
        public int Denominator { get; }

        public Fraction(string fraction)
        {
            (int numerator, int denominator) parsedFraction = Parse(fraction);

            //if (parsedFraction.denominator == 0)
            //{
            //    throw new DivideByZeroException();
            //}

            Numerator = parsedFraction.numerator;
            Denominator = parsedFraction.denominator;
        }

        public string ToMixedFraction()
        {
            if (Numerator == 0) { return "0"; }
            if (Numerator == Denominator) { return "1"; }

            (int integer, int numerator, int denominator) fraction = Math_1.ToMixedFraction(Numerator, Denominator);

            if (fraction.numerator == 0) { return fraction.integer.ToString(); }

            return Format(fraction);
        }

        private static string Format((int integer, int numerator, int denominator) fraction)
        {
            string formatedFraction = $"{fraction.numerator}{DELIMITER}{fraction.denominator}";

            if (fraction.integer != 0)
            {
                return $"{fraction.integer} {formatedFraction}";
            }

            return formatedFraction;
        }

        private static (int numerator, int denominator) Parse(string fraction)
        {
            string[] splitedFraction = fraction.Split(DELIMITER);

            int numerator = int.Parse(splitedFraction[0]);
            int denominator = int.Parse(splitedFraction[1]);

            return (numerator, denominator);
        }
    }
}