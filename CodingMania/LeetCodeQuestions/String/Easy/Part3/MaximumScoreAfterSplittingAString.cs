using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part3
{
    /*
     
     Given a string s of zeros and ones, return the maximum score after splitting the string into two non-empty substrings (i.e. left substring and right substring).

The score after splitting a string is the number of zeros in the left substring plus the number of ones in the right substring.

 

Example 1:

Input: s = "011101"
Output: 5 
Explanation: 
All possible ways of splitting s into two non-empty substrings are:
left = "0" and right = "11101", score = 1 + 4 = 5 
left = "01" and right = "1101", score = 1 + 3 = 4 
left = "011" and right = "101", score = 1 + 2 = 3 
left = "0111" and right = "01", score = 1 + 1 = 2 
left = "01110" and right = "1", score = 2 + 1 = 3
Example 2:

Input: s = "00111"
Output: 5
Explanation: When left = "00" and right = "111", we get the maximum score = 2 + 3 = 5
Example 3:

Input: s = "1111"
Output: 3
 

Constraints:

2 <= s.length <= 500
The string s consists of characters '0' and '1' only.
     
     
     
     
     
     
     
     
     
     
     
     */
    class MaximumScoreAfterSplittingAString
    {
        public int MaxScore(string s)
        {
            int totalOnes = 0;
            int leftZeros = 0;
            int rightOnes = 0;

            // Count the total number of ones in the string (this will be the initial count of ones in the right part)
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    totalOnes++;
                }
            }

            int maxScore = 0;

            // Iterate through the string and calculate the score for each possible split
            for (int i = 0; i < s.Length - 1; i++)  // We stop at length - 1 to ensure both substrings are non-empty
            {
                if (s[i] == '0') leftZeros++;       // Count zeros in the left substring
                if (s[i] == '1') totalOnes--;      // Reduce the number of ones in the right substring

                int score = leftZeros + totalOnes; // Calculate the score for this split
                maxScore = Math.Max(maxScore, score); // Update the max score
            }

            return maxScore;
        }
    }
}
