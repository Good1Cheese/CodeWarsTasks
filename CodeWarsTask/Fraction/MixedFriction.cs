namespace CodeWarsKata.Fraction
{
    public class MixedFriction : Fraction
    {
        private int integerPart;
        public int IntegerPart => integerPart;

        public MixedFriction(int _numerator, int _denominator)
            : base(_numerator, _denominator)
        {
            CalculateIntegerPart(this);
        }

        public static void CalculateIntegerPart(MixedFriction _mixedfraction)
        {
            int integerPart = _mixedfraction.Numerator / _mixedfraction.Denominator;
            CalculateNumeratorAfterCalcutatingIntegerPart(_mixedfraction);
            _mixedfraction.integerPart = integerPart;
        }

        private static void CalculateNumeratorAfterCalcutatingIntegerPart(MixedFriction _mixedfraction)
        {
            int remainderOfDivision = _mixedfraction.Numerator % _mixedfraction.Denominator;
            _mixedfraction.numerator = remainderOfDivision;
        }

        public new string ToString()
        {
            if (Numerator == 0)
            {
                return string.Format($"{IntegerPart}");
            }
            else if (IntegerPart == 0)
            {
                return base.ToString();
            }

            return string.Format($"{IntegerPart} {Numerator}/{Denominator}");
        }
    }
}