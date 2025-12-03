using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part6
{
    /*
     
     A permutation perm of n + 1 integers of all the integers in the range [0, n] can be represented as a string s of length n where:

s[i] == 'I' if perm[i] < perm[i + 1], and
s[i] == 'D' if perm[i] > perm[i + 1].
Given a string s, reconstruct the permutation perm and return it. If there are multiple valid permutations perm, return any of them.

 

Example 1:

Input: s = "IDID"
Output: [0,4,1,3,2]
Example 2:

Input: s = "III"
Output: [0,1,2,3]
Example 3:

Input: s = "DDI"
Output: [3,2,0,1]
 

Constraints:

1 <= s.length <= 105
s[i] is either 'I' or 'D'.
     
     
     */
    class DIStringMatch
    {
        public int[] DiStringMatchFlow(string s)
        {
            int n = s.Length;
            int low = 0, high = n;
            int[] result = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'I')
                {
                    result[i] = low++;
                }
                else
                { // 'D'
                    result[i] = high--;
                }
            }

            // Last number remaining
            result[n] = low; // or high, both are equal here
            return result;
        }
    }
}
