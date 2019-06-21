using System;

namespace InterviewQuestions.CSharp
{
    /// <summary>
    /// A palindrome is a word that reads the same backward or forward.
    /// Write a function that checks if a given word is a palindrome.Character case should be ignored.
    /// For example, IsPalindrome("Deleveled") should return true as character case should be ignored, resulting in "deleveled", which is a palindrome since it reads the same backward and forward.
    /// </summary>
    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            string rev;

            char[] chWord = word.ToCharArray();

            Array.Reverse(chWord);

            rev = new string(chWord);

            bool result = word.Equals(rev, StringComparison.OrdinalIgnoreCase);

            return result;
        }
    }
}
