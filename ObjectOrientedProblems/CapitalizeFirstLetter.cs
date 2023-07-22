using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblems
{
    public class CapitalizeFirstLetter
    {
        public string convertToTitleCase(string input)
        {
            char[] charArray = input.ToCharArray();
            int length = charArray.Length;

            // First letter of the sentence should be capitalized
            if (length > 0 && char.IsLower(charArray[0]))
            {
                charArray[0] = char.ToUpper(charArray[0]);
            }

            // Loop to capitalize the first letter of each word
            for (int i = 1; i < length; i++)
            {
                if (charArray[i - 1] == ' ' && char.IsLower(charArray[i]))
                {
                    charArray[i] = char.ToUpper(charArray[i]);
                }
            }

            return new string(charArray);
        }
    }
}
