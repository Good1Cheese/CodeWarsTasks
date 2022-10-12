namespace CodeWars.Remove_String_Spaces
{
    public class Kata
    {
        private const string WHITE_SPACE = " ";

        public static string NoSpace(string input)
        {
            return input.Replace(WHITE_SPACE, string.Empty);
        }
    }
}