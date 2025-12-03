using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part2
{
    /*
     Given a string s and an integer k, reverse the first k characters for every 2k characters counting from the start of the string.

If there are fewer than k characters left, reverse all of them. If there are less than 2k but greater than or equal to k characters, then reverse the first k characters and leave the other as original.

 

Example 1:

Input: s = "abcdefg", k = 2
Output: "bacdfeg"
Example 2:

Input: s = "abcd", k = 2
Output: "bacd"
 

Constraints:

1 <= s.length <= 104
s consists of only lowercase English letters.
1 <= k <= 104
     */
    class ReverseString2
    {

       
        public string ReverseStr(string s, int k)
        {
            char[] chars = s.ToCharArray();

            for (int i = 0; i < s.Length; i += 2 * k)
            {
                int left = i;
                int right = Math.Min(i + k - 1, s.Length - 1);

                // Reverse the first k characters in this 2k block
                while (left < right)
                {
                    (chars[left], chars[right]) = (chars[right], chars[left]);
                    left++;
                    right--;
                }
            }

            return new string(chars);
        }
    }
}
