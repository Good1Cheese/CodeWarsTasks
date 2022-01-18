using System;

namespace CodeWarsTask.BuingACar
{
    public class Task
    {
        public static int[] nbMonths(double startPriceOld, double startPriceNew, int savingPerMonth, double percentLossByMonth)
        {
            int months = 1;
            double moneyForBuy = -(startPriceNew - startPriceOld);
            for (; moneyForBuy < 0; months++)
            {
                moneyForBuy += savingPerMonth;
                if (months % 2 == 0) { percentLossByMonth += 0.5; }

                double newCarLossSum = CalculatePercentOfNumber(ref startPriceNew, ref percentLossByMonth);
                double oldCarLossSum = CalculatePercentOfNumber(ref startPriceOld, ref percentLossByMonth);

                moneyForBuy += newCarLossSum - oldCarLossSum;
            }

            Console.WriteLine((int)moneyForBuy);
            return new int[] { months - 1, Convert.ToInt32(moneyForBuy) };
        }

        private static double CalculatePercentOfNumber(ref double number, ref double percent)
        {
            double percentOfNumber = number * percent / 100;
            number -= percentOfNumber;
            return percentOfNumber;
        }
    }
}