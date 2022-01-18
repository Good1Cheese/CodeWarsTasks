namespace CodeWarsTask.ReplaceWithAlphabetPosition
{
    public class Task
    {
        private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private static string ReplaceWithAlphabetPosition(string str)
        {
            string result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                string upperedLetter = str[i].ToString().ToUpper();
                int letterIndex = alphabet.IndexOf(upperedLetter) + 1;

                if (letterIndex == 0) { continue; }
                result += $"{letterIndex} ";
            }
            return result.Trim();
        }

        private static string RevertedReplaceWithAlphabetPosition(string str)
        {
            string result = string.Empty;
            string[] allLettersIndex = str.Split(' ');
            for (int i = 0; i < allLettersIndex.Length; i++)
            {
                int convertedIndex = int.Parse(allLettersIndex[i].ToString());
                result += $"{alphabet[convertedIndex - 1]} ";
            }
            return result;
        }
    }
}