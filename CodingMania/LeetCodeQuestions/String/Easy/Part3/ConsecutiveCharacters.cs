using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part3
{
    /*
     The power of the string is the maximum length of a non-empty substring that contains only one unique character.

Given a string s, return the power of s.

 

Example 1:

Input: s = "leetcode"
Output: 2
Explanation: The substring "ee" is of length 2 with the character 'e' only.
Example 2:

Input: s = "abbcccddddeeeeedcba"
Output: 5
Explanation: The substring "eeeee" is of length 5 with the character 'e' only.
 

Constraints:

1 <= s.length <= 500
s consists of only lowercase English letters.
     
     
     
     
     */
    class ConsecutiveCharacters
    {
        public int MaxPower(string s)
        {
            int maxPower = 1;
            int currentPower = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    currentPower++;
                    maxPower = Math.Max(maxPower, currentPower);
                }
                else
                {
                    currentPower = 1;
                }
            }

            return maxPower;
        }
    }
}
