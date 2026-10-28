using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*
     
     125. Valid Palindrome
Easy
Topics
premium lock icon
Companies
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

 

Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.
 

Constraints:

1 <= s.length <= 2 * 105
s consists only of printable ASCII characters.
     */
    class _125_Valid_Palindrome
    {
        //my Solution

        public bool Ispalindrome(string p)
        {
            string s = p.ToLowerInvariant();

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                //Use if, else if and Else has a three Nexted Conditions Flow

                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }

                else if (!char.IsLetterOrDigit(s[left]))
                {
                    right--;
                }

                else
                {
                    
                    if (s[left] != s[right])
                    {
                        return false;
                    }
                    //dONT fOREGT TO push the Pointer towards the Middle
                    left++;
                    right--;
                }
                

            }

            return true;


        }

    }
}
