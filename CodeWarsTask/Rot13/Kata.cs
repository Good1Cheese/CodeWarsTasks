using System.Linq;

namespace CodeWars.Rot13
{
    public class Kata
    {
        private const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static string Rot13(string message)
        {
            var result = message.Select(c =>
            {
                if (!char.IsLetter(c)) { return c; }

                int newIndex = GetNewIndex(c);
                char letter = ALPHABET[newIndex];

                return char.IsUpper(c) ? letter : char.ToLower(letter);
            });

            return string.Concat(result);

            static int GetNewIndex(char letter)
            {
                string uppered = letter.ToString().ToUpper();

                int index = ALPHABET.IndexOf(uppered);
                return (index + 13) % ALPHABET.Length;
            }
        }
    }
}