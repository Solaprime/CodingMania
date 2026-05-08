using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.SlidingWindow.Medium
{
    /*
     Given a string s, find the length of the longest substring without duplicate characters.

 

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3. Note that "bca" and "cab" are also correct answers.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 

Constraints:

0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.
     */
    public class _3_LongestSubstringWithoutRepeatingCharacters
    {

        //Comprehend this 
        public int LengthofLongestSubstring(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int left = 0;
            int maxLength = 0;

            for (int right = 0;  right < s.Length;  right++)
            {
                //if Dupplicate Found, Shrink Window
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }

                //ADD cURERNT cARREYT
                set.Add(s[right]);

                //update Max length
                maxLength = Math.Max(maxLength, right - left + 1);

            }
            return maxLength;
        }


        //Using Dictionary___AsSecondSolution
        public int LengthOfLongestSunstring2(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            int left = 0, maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                if (map.ContainsKey(s[right]))
                {
                    left = Math.Max(left, map[s[right]] + 1);
                }

                map[s[right]] = right;
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
