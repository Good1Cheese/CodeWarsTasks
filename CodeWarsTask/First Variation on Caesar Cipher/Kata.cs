using System;
using System.Collections.Generic;

namespace CodeWarsKata.First_Variation_on_Caesar_Cipher
{
    public class Kata1
    {
        protected const string ENGLISH_ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public string MovingShift(string s, int shift)
        {
            string shiftedString = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                int currentShift = shift + i;
                char letter = s[i];
                shiftedString += GetShiftedLetterInCorrectCase(in letter, ref currentShift);
            }

            Console.WriteLine(shiftedString);
            return shiftedString;
        }

        private string GetShiftedLetterInCorrectCase(in char letter, ref int shift)
        {
            if (!char.IsLetter(letter)) { return letter.ToString(); }

            bool wasUpper = char.IsUpper(letter);

            string shiftedLetter = GetShiftedLetter(in letter, ref shift);
            SetStringCase(ref shiftedLetter, wasUpper);

            return shiftedLetter;
        }

        protected virtual string GetShiftedLetter(in char letter, ref int shift)
        {
            string upperedLetter = letter.ToString().ToUpper();
            int letterIndex = ENGLISH_ALPHABET.IndexOf(upperedLetter) + shift;

            if (letterIndex >= ENGLISH_ALPHABET.Length)
            {
                letterIndex %= ENGLISH_ALPHABET.Length;
            }

            return ENGLISH_ALPHABET[letterIndex].ToString();
        }

        private static void SetStringCase(ref string str, bool wasUpper) => str = (wasUpper) ? str.ToUpper() : str.ToLower();
    }

    public class Kata2 : Kata1
    {
        protected override string GetShiftedLetter(in char letter, ref int shift)
        {
            string upperedLetter = letter.ToString().ToUpper();
            int letterIndex = ENGLISH_ALPHABET.IndexOf(upperedLetter);

            if (ENGLISH_ALPHABET.Length < -shift)
            {
                shift %= ENGLISH_ALPHABET.Length;
            }

            letterIndex += shift;

            if (letterIndex < 0)
            {
                letterIndex = ENGLISH_ALPHABET.Length + letterIndex;  
            }

            return ENGLISH_ALPHABET[letterIndex].ToString();
        }
    }
}