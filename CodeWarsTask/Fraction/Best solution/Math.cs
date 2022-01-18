using System;

namespace CodeWarsTask.Fraction.BestSotution
{
    public static class Math_1
    {
        public static (int integer, int numerator, int denominator) ToMixedFraction(int numerator, int denominator)
        {
            int integer = GetIntegerFractionPart(numerator, denominator);

            // Отнимаем от числителя целые части, чтобы найти остаток
            if (integer != 0) { numerator -= integer * denominator; }

            // Если целая часть отрицательна, то числитель тоже выдаётся отрицатеьный.
            // Чтобы избавится от этого, инвертируем числитель
            if (integer < 0) { numerator = -numerator; }

            MinimizeFraction(ref numerator, ref denominator);

            return (integer, numerator, denominator);
        }

        private static int GetIntegerFractionPart(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        private static int GetGreatCommonDenominator(int firstValue, int secondValue)
        {
            while (secondValue != 0)
            {
                secondValue = firstValue % (firstValue = secondValue);
            }

            return firstValue;
        }

        private static void MinimizeFraction(ref int numerator, ref int denominator)
        {
            int greatCommonDenominator = GetGreatCommonDenominator(numerator, denominator);

            if (greatCommonDenominator != 1)
            {
                numerator /= greatCommonDenominator;
                denominator /= greatCommonDenominator;
            }
        }

        internal static object Sqrt(double v)
        {
            throw new NotImplementedException();
        }
    }
}