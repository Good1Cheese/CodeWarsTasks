using System.Text;

namespace CodeWarsTask.Alphabet_war___Wo_lo_loooooo_priests_join_the_war
{
    public class Task
    {
        private const string RIGHT_SIDE_WON = "Right side wins!";
        private const string LEFT_SIDE_WON = "Left side wins!";
        private const string DRAW = "Let's fight again!";

        public static string AlphabetWar(string fight)
        {
            int warScore = 0;

            int lastPriestUnitIndex = -1;
            for (int i = 0; i < fight.Length; i++)
            {
                (int, string) currentLetterPower = GetLetterPower(fight[i]);
                if (currentLetterPower.Item1 == 0 && lastPriestUnitIndex < i)
                {
                    fight = AppyPriestUnitPower(fight, i, currentLetterPower.Item2);
                    lastPriestUnitIndex = i;
                    warScore = 0;
                    i = -1;
                    continue;
                }

                if (currentLetterPower.Item1 == -1) { continue; }
                if (currentLetterPower.Item2 == RIGHT_SIDE_LETTERS)
                {
                    warScore -= currentLetterPower.Item1;
                    continue;
                }
                warScore += currentLetterPower.Item1;
            }

            if (warScore > 0) { return LEFT_SIDE_WON; }
            if (warScore < 0) { return RIGHT_SIDE_WON; }

            return DRAW;
        }

        private const string LEFT_SIDE_LETTERS = "tsbpw";
        private const string RIGHT_SIDE_LETTERS = "jzdqm";

        private static (int, string) GetLetterPower(char letter)
        {
            string side = LEFT_SIDE_LETTERS;
            int letterPower = LEFT_SIDE_LETTERS.IndexOf(letter);

            if (letterPower == -1)
            {
                side = RIGHT_SIDE_LETTERS;
                letterPower = RIGHT_SIDE_LETTERS.IndexOf(letter);
            }

            return (letterPower, side);
        }

        private static string AppyPriestUnitPower(string fight, int unitIndex, string preisetletterSide)
        {
            StringBuilder sb = new StringBuilder(fight);

            if (unitIndex - 1 >= 0)
            {
                NewMethod(unitIndex - 1, sb, preisetletterSide);
            }

            if (unitIndex + 1 <= fight.Length - 1)
            {
                if (unitIndex + 1 + 1 >= 0) { if (GetLetterPower(sb[unitIndex]).Item1 == 0) { return sb.ToString(); } }
                NewMethod(unitIndex + 1, sb, preisetletterSide);
            }

            return sb.ToString();
        }

        private static void NewMethod(int unitIndex, StringBuilder sb, string preisetletterSide)
        {
            (int, string) currentLetterPower = GetLetterPower(sb[unitIndex]);

            if (preisetletterSide == currentLetterPower.Item2 || currentLetterPower.Item1 == 0 || currentLetterPower.Item1 == -1) { return; }
            string anotherSource = (currentLetterPower.Item2 == RIGHT_SIDE_LETTERS) ? LEFT_SIDE_LETTERS : RIGHT_SIDE_LETTERS;
            sb[unitIndex] = anotherSource[currentLetterPower.Item1];
        }
    }
}