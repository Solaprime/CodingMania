using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part3
{
    /*





     You are given an alphanumeric string s. (Alphanumeric string is a string consisting of lowercase English letters and digits).

    You have to find a permutation of the string where no letter is followed by another letter and no digit is followed by another digit. That is, no two adjacent characters have the same type.

    Return the reformatted string or return an empty string if it is impossible to reformat the string.



    Example 1:

    Input: s = "a0b1c2"
    Output: "0a1b2c"
    Explanation: No two adjacent characters have the same type in "0a1b2c". "a0b1c2", "0a1b2c", "0c2a1b" are also valid permutations.
    Example 2:

    Input: s = "leetcode"
    Output: ""
    Explanation: "leetcode" has only characters so we cannot separate them by digits.
    Example 3:

    Input: s = "1229857369"
    Output: ""
    Explanation: "1229857369" has only digits so we cannot separate them by characters.


    Constraints:

    1 <= s.length <= 500
    s consists of only lowercase English letters and/or digits.

     */
    class ReformatTheString
    {
        public string Reformat(string s)
        {
            // Separate letters and digits
            List<char> letters = new List<char>();
            List<char> digits = new List<char>();

            foreach (char c in s)
            {
                if (Char.IsLetter(c))
                    letters.Add(c);
                else
                    digits.Add(c);
            }

            // If the difference in count of letters and digits is greater than 1, return an empty string
            if (Math.Abs(letters.Count - digits.Count) > 1)
            {
                return "";
            }

            // Initialize a StringBuilder for the result
            StringBuilder result = new StringBuilder();

            // If there are more letters, start with a letter, otherwise start with a digit
            bool startWithLetter = letters.Count >= digits.Count;

            while (letters.Count > 0 || digits.Count > 0)
            {
                if (startWithLetter)
                {
                    if (letters.Count > 0)
                    {
                        result.Append(letters[0]);
                        letters.RemoveAt(0);
                    }
                    if (digits.Count > 0)
                    {
                        result.Append(digits[0]);
                        digits.RemoveAt(0);
                    }
                }
                else
                {
                    if (digits.Count > 0)
                    {
                        result.Append(digits[0]);
                        digits.RemoveAt(0);
                    }
                    if (letters.Count > 0)
                    {
                        result.Append(letters[0]);
                        letters.RemoveAt(0);
                    }
                }
            }

            return result.ToString();
        }
    }
}
