using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    /*
     You are given a license key represented as a string s that consists of only alphanumeric characters and dashes. The string is separated into n + 1 groups by n dashes. You are also given an integer k.

We want to reformat the string s such that each group contains exactly k characters, except for the first group, which could be shorter than k but still must contain at least one character. Furthermore, there must be a dash inserted between two groups, and you should convert all lowercase letters to uppercase.

Return the reformatted license key.

 

Example 1:

Input: s = "5F3Z-2e-9-w", k = 4
Output: "5F3Z-2E9W"
Explanation: The string s has been split into two parts, each part has 4 characters.
Note that the two extra dashes are not needed and can be removed.
Example 2:

Input: s = "2-5g-3-J", k = 2
Output: "2-5G-3J"
Explanation: The string s has been split into three parts, each part has 2 characters except the first part as it could be shorter as mentioned above.
 

Constraints:

1 <= s.length <= 105
s consists of English letters, digits, and dashes '-'.
1 <= k <= 104
     
     */
    class LicenseKeyFormattingQuestions
    {
        public string LicenseKeyFormatting(string s, int k)
        {
            // Remove dashes and convert to uppercase
            s = s.Replace("-", "").ToUpper();

            // Find the length of the remaining string
            int n = s.Length;

            // StringBuilder to build the result
            StringBuilder result = new StringBuilder();

            // The first group will be shorter or equal to k
            //If n % k == 0, then use k
          //  Else, use n % k
            int firstGroupLength = n % k == 0 ? k : n % k;

            //The FiRST iTEM HAS A uNIQUE coditopn 
            //to it

            //It makes NO sENE TO ujSE THESE
            // Add the first group (if it exists)
            if (firstGroupLength > 0)
            {
                result.Append(s.Substring(0, firstGroupLength));
            }

            // Now handle the rest of the string in chunks of k
            //iNCREMENT WITH k
            for (int i = firstGroupLength; i < n; i += k)
            {
                //if LENGTH is less  than Zero do
                //not append it means dASH IS STARTING 
                if (result.Length > 0)
                {
                    result.Append("-");
                }

                //USE I AND K INDEX
                result.Append(s.Substring(i, k));
            }

            return result.ToString();
        }
    }
}
