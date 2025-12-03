using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part2
{
    /*
     
     Given an integer n, add a dot (".") as the thousands separator and return it in string format.

 

Example 1:

Input: n = 987
Output: "987"
Example 2:

Input: n = 1234
Output: "1.234"
 

Constraints:

0 <= n <= 231 - 1
     
     
     
     */
    class ThousandSeperator
    {
        public string ThousandSeparator2(int n)
        {
            string numStr = n.ToString();
            int len = numStr.Length;
            string result = "";

            for (int i = 0; i < len; i++)
            {
                if (i > 0 && (len - i) % 3 == 0)
                {
                    result += ".";
                }
                result += numStr[i];
            }

            return result;
        }
    }
}
