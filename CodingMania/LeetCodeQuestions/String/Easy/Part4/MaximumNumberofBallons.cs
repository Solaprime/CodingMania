using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part4
{
    /*
     Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.

You can use each character in text at most once. Return the maximum number of instances that can be formed.

 

Example 1:



Input: text = "nlaebolko"
Output: 1
Example 2:



Input: text = "loonbalxballpoon"
Output: 2
Example 3:

Input: text = "leetcode"
Output: 0
 

Constraints:

1 <= text.length <= 104
text consists of lower case English letters only.
 

Note: This question is the same as 2287: Rearrange Characters to Make Target String.
     
     
     */
    class MaximumNumberofBallons
    {
        public int MaxNumberOfBalloons(string text)
        {
            // Count the frequency of each character in the input text
            var count = new Dictionary<char, int>();
            foreach (var c in text)
            {
                if (count.ContainsKey(c))
                {
                    count[c]++;
                }
                else
                {
                    count[c] = 1;
                }
            }

            // The required characters for forming the word "balloon"
            string balloon = "balloon";

            // Initialize the minimum number of "balloon" words we can form
            int result = int.MaxValue;

            // Iterate over the characters of "balloon" and check the number of occurrences
            // in the text. For characters that are missing, the answer is 0.
            foreach (var c in balloon)
            {
                if (c == 'l' || c == 'o')
                {
                    // For 'l' and 'o', we need at least two of them
                    if (count.ContainsKey(c))
                    {
                        result = Math.Min(result, count[c] / (c == 'l' ? 2 : 2));
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    // For 'b', 'a', and 'n', we need at least one of them
                    if (count.ContainsKey(c))
                    {
                        result = Math.Min(result, count[c]);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

            return result;
        }
    }
}
