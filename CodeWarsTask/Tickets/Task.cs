namespace CodeWarsTask.Tickets
{
    public class Task
    {
        private static string Tickets(int[] peopleInLine)
        {
            int moneyForChange = 0;
            int moneyToChange = 0;
            for (int i = 0; i < peopleInLine.Length; i++)
            {
                if (peopleInLine[i] > 25)
                {
                    moneyToChange += peopleInLine[i] - 25;
                    continue;
                }
                moneyForChange += peopleInLine[i];
            }

            if (moneyForChange >= moneyToChange)
            {
                return string.Format("YES");
            }
            return string.Format("NO");
        }
    }
}