using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part6
{
    /*
     
    Given a string s, return true if the s can be palindrome after deleting at most one character from it.

 

Example 1:

Input: s = "aba"
Output: true
Example 2:

Input: s = "abca"
Output: true
Explanation: You could delete the character 'c'.
Example 3:

Input: s = "abc"
Output: false
 

Constraints:

1 <= s.length <= 105
s consists of lowercase English letters. 

     */
    class ValidPalindrome2
    {
        public bool ValidPalindrome(string s)
        {
            // Helper function to check if a substring is a palindrome
            bool IsPalindrome(string str, int left, int right)
            {
                while (left < right)
                {
                    if (str[left] != str[right])
                    {
                        return false;
                    }
                    left++;
                    right--;
                }
                return true;
            }

            int left = 0, right = s.Length - 1;

            // Use two pointers to check the string
            while (left < right)
            {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    // If characters don't match, try skipping one character
                    return IsPalindrome(s, left + 1, right) || IsPalindrome(s, left, right - 1);
                }
            }

            return true; // If the entire string is a palindrome
        }
    }
}
