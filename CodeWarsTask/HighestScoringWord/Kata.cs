namespace CodeWarsKata.HighestScoringWord
{
    public class Kata
    {
        private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static string High(string str)
        {
            HighestScoringWord highestScoringWord = new HighestScoringWord();
            string[] splitedInput = str.Split(' ');
            for (int i = 0; i < splitedInput.Length; i++)
            {
                int wordScore = FindScoreOfWord(splitedInput[i]);

                if (wordScore > highestScoringWord.Score)
                {
                    highestScoringWord.Score = wordScore;
                    highestScoringWord.Word = splitedInput[i];
                }
            }
            return highestScoringWord.Word;
        }

        private static int FindScoreOfWord(string word)
        {
            int wordScore = 0;
            for (int a = 0; a < word.Length; a++)
            {
                string upperedLetter = word[a].ToString().ToUpper();
                wordScore += alphabet.IndexOf(upperedLetter) + 1;
            }

            return wordScore;
        }

        public struct HighestScoringWord
        {
            public int Score { get; set; }
            public string Word { get; set; }
        }
    }
}