using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part6
{
    /*
     
     
     Given a binary string s, return the number of non-empty substrings that have the same number of 0's and 1's, and all the 0's and all the 1's in these substrings are grouped consecutively.

Substrings that occur multiple times are counted the number of times they occur.

 

Example 1:

Input: s = "00110011"
Output: 6
Explanation: There are 6 substrings that have equal number of consecutive 1's and 0's: "0011", "01", "1100", "10", "0011", and "01".
Notice that some of these substrings repeat and are counted the number of times they occur.
Also, "00110011" is not a valid substring because all the 0's (and 1's) are not grouped together.
Example 2:

Input: s = "10101"
Output: 4
Explanation: There are 4 substrings: "10", "01", "10", "01" that have equal number of consecutive 1's and 0's.
 

Constraints:

1 <= s.length <= 105
s[i] is either '0' or '1'.
     
     */
    class CountBinarySubStrings
    {
        public int CountBinarySubstrings(string s)
        {
            // Step 1: Group consecutive characters
            List<int> groups = new List<int>();
            int count = 1;  // Start with the first character
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    count++;
                }
                else
                {
                    groups.Add(count);
                    count = 1; // Reset count for new group
                }
            }
            groups.Add(count); // Add the last group

            // Step 2: Count valid substrings
            int result = 0;
            for (int i = 1; i < groups.Count; i++)
            {
                result += Math.Min(groups[i - 1], groups[i]); // Count the valid substrings
            }

            return result;
        }
    }
}
