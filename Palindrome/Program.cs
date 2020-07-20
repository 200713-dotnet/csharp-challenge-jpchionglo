using System;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome Checker! \nEnter a word to be checked:");

            string word = Console.ReadLine();

            bool result = CheckPalindrome(word);

            Console.WriteLine(result);

        }

        public static bool CheckPalindrome(string word){

          var word1 = word.ToUpper();
          var wordArray = word1.ToCharArray();
          var word2 = "";
          for (int i = wordArray.Length -1; i >= 0; i--){

            word2 += wordArray[i];

          }

          if (word1 == word2){

            return true;

          }
          else
          {
            return false;
          }

        }
    }
}
