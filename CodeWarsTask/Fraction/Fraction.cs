using static CodeWarsKata.Fraction.Program;

namespace CodeWarsKata.Fraction
{
    public class Fraction
    {
        protected int numerator;
        protected int denominator;
        public int Numerator => numerator;
        public int Denominator => denominator;

        public Fraction(int _numerator, int _denominator)
        {
            numerator = _numerator;
            denominator = _denominator;
        }

        public static void ReduceFraction(Fraction _fraction)
        {
            int commonFactor = 0;
            while (FindCommonFactor(_fraction, out commonFactor) && (_fraction.numerator != 1 && _fraction.numerator != -1))
            {
                _fraction.numerator /= commonFactor;
                _fraction.denominator /= commonFactor;
            }
            return;
        }

        private static bool FindCommonFactor(Fraction _fraction, out int _commonFactor)
        {
            _commonFactor = 0;
            int numerator = _fraction.numerator;
            int denominator = _fraction.denominator;

            int maxNumber = (numerator > denominator) ? numerator : denominator;
            for (int factor = 2; factor < maxNumber; factor++)
            {
                bool isICommonfactor = (numerator % factor) == 0 && (denominator % factor) == 0;
                if (isICommonfactor)
                {
                    _commonFactor = factor;
                    return true;
                }
            }
            return false;
        }

        public MixedFriction ToMixedFraction()
        {
            return new MixedFriction(Numerator, Denominator);
        }

        public new string ToString()
        {
            return string.Format($"{numerator}/{denominator}");
        }
    }
}