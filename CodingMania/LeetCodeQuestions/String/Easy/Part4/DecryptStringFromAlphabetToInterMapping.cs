using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part4
{
    /*
   
     You are given a string s formed by digits and '#'. We want to map s to English lowercase characters as follows:

Characters ('a' to 'i') are represented by ('1' to '9') respectively.
Characters ('j' to 'z') are represented by ('10#' to '26#') respectively.
Return the string formed after mapping.

The test cases are generated so that a unique mapping will always exist.

 

Example 1:

Input: s = "10#11#12"
Output: "jkab"
Explanation: "j" -> "10#" , "k" -> "11#" , "a" -> "1" , "b" -> "2".
Example 2:

Input: s = "1326#"
Output: "acz"
 

Constraints:

1 <= s.length <= 1000
s consists of digits and the '#' letter.
s will be a valid string such that mapping is always possible.
     
     */
    class DecryptStringFromAlphabetToInterMapping
    {

        public string FreqAlphabets(string s)
        {
            StringBuilder result = new StringBuilder();
            int i = 0;

            while (i < s.Length)
            {
                // Check if we have a valid two-digit number followed by '#'
                if (i + 2 < s.Length && s[i + 2] == '#')
                {
                    // Map two-digit number (e.g., "10#", "11#") to a character
                    int num = (s[i] - '0') * 10 + (s[i + 1] - '0');
                    result.Append((char)('a' + num - 1));  // Convert number to corresponding character
                    i += 3;  // Skip over the two digits and '#'
                }
                else
                {
                    // Map single digit (e.g., "1" to "9") to a character
                    result.Append((char)('a' + (s[i] - '1')));  // Convert single digit to corresponding character
                    i += 1;  // Move to next character
                }
            }

            return result.ToString();
        }
    }
}
