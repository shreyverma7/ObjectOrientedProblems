using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblems
{
    public class ReverseEach
    {
        public string reverseWords(string input)
        {
            // Split the input string into words based on spaces
            string[] words = input.Split(' ');

            // Reverse each word and build the reversed string
            string reversedString = "";
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                string reversedWord = "";

                // Reverse the current word character by character
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    reversedWord += word[j];
                }

                // Append the reversed word to the result string
                reversedString += reversedWord;

                // Append space after each word (except the last one)
                if (i < words.Length - 1)
                {
                    reversedString += " ";
                }
            }

            return reversedString;
        }
    }
}
