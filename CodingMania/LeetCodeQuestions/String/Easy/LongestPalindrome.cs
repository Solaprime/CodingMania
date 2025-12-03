using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    /*
     Given a string s which consists of lowercase or uppercase letters, return the length of the longest palindrome that can be built with those letters.

Letters are case sensitive, for example, "Aa" is not considered a palindrome.

 

Example 1:

Input: s = "abccccdd"
Output: 7
Explanation: One longest palindrome that can be built is "dccaccd", whose length is 7.
Example 2:

Input: s = "a"
Output: 1
Explanation: The longest palindrome that can be built is "a", whose length is 1.
 

Constraints:

1 <= s.length <= 2000
s consists of lowercase and/or uppercase English letters only.
     */
    class LongestPalindrome
    {
        public int LongestPalindromeFunction(string s)
        {
            // Create a dictionary to store the frequency of each character
            Dictionary<char, int> freqMap = new Dictionary<char, int>();

            // Count the frequency of each character in the string
            foreach (char c in s)
            {
                if (freqMap.ContainsKey(c))
                    freqMap[c]++;
                else
                    freqMap[c] = 1;
            }

            int length = 0;
            bool oddFound = false;

            // Iterate over the frequency map
            foreach (var entry in freqMap)
            {
                if (entry.Value % 2 == 0)
                {
                    // Add all even occurrences to the length
                    length += entry.Value;
                }
                else
                {
                    // Add the largest even number of occurrences to the length
                    length += entry.Value - 1;
                    oddFound = true; // We can have one odd count character in the center
                }
            }

            // If we found any odd character, we can place one in the center
            if (oddFound)
            {
                length += 1;
            }

            return length;
        }
    }
}
