using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    /*
     
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
    class ValidPalindrome
    {
        //Convert all upperCase to lowerCase
        //remove all non All-Alphanumeric characters
        //Check if string reads the same forward and backward
        public bool IsPalindrome(string s)
        {
            int left = 0, right = s.Length - 1;

            while (left < right)
            {
                // Skip non-alphanumeric from the left
                // Move left pointer to the next alphanumeric character
                while (left < right && !char.IsLetterOrDigit(s[left]))
                    left++;

                // Skip non-alphanumeric from the right
                // Move right pointer to the previous alphanumeric character
                while (left < right && !char.IsLetterOrDigit(s[right]))
                    right--;

                // Compare characters in lowercase
                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }

        /*🆚 Alternative Approach (Less Efficient)
Another common approach is:

Clean the input string (keep only lowercase alphanumeric).

Reverse the cleaned string.

Compare original cleaned string with the reversed one.

csharp
Copy
Edit
*/
        public bool IsPalindrome2(string s)
        {
            var cleaned = new StringBuilder();

            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                    cleaned.Append(char.ToLower(c));
            }

            string str = cleaned.ToString();
            char[] reversed = str.ToCharArray();
           System.Array.Reverse(reversed);

            return str == new string(reversed);
        }


    }
}
