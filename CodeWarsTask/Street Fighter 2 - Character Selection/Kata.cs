namespace CodeWarsKata.StreetFighter2CharacterSelection
{
    public class Kata
    {
        private const int minTopPosition = 0;
        private const int maxTopPosition = 1;
        private const int minLeftPosition = 0;
        private const int maxLeftPosition = 5;

        public string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
        {
            string[] touchedFighter = new string[moves.Length];

            for (int i = 0; i < moves.Length; i++)
            {
                GetMoveDirection(moves[i], position);
                touchedFighter[i] = GetFighterByPosition(fighters, position);
            }
            return touchedFighter;
        }

        private static void GetMoveDirection(string move, int[] position)
        {
            int verticalPosition = position[0];
            int horizontalPosition = position[1];
            switch (move.ToUpper())
            {
                case "UP":
                    if (verticalPosition != minTopPosition) { verticalPosition--; }
                    break;
                case "DOWN":
                    if (verticalPosition != maxTopPosition) { verticalPosition++; }
                    break;
                case "LEFT":
                    if (horizontalPosition == minLeftPosition) { horizontalPosition = maxLeftPosition; break; }
                    horizontalPosition--;
                    break;
                case "RIGHT":
                    if (horizontalPosition == maxLeftPosition) { horizontalPosition = minLeftPosition; break; }
                    horizontalPosition++;
                    break;
            }
            position[0] = verticalPosition;
            position[1] = horizontalPosition;
        }

        private static string GetFighterByPosition(string[][] fighters, int[] position)
        {
            return fighters[position[0]][position[1]];
        }
    }
}