using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part5
{
    /*
     
     
     
     Given a string s, reverse the string according to the following rules:

All the characters that are not English letters remain in the same position.
All the English letters (lowercase or uppercase) should be reversed.
Return s after reversing it.

 

Example 1:

Input: s = "ab-cd"
Output: "dc-ba"
Example 2:

Input: s = "a-bC-dEf-ghIj"
Output: "j-Ih-gfE-dCba"
Example 3:

Input: s = "Test1ng-Leet=code-Q!"
Output: "Qedo1ct-eeLg=ntse-T!"
 

Constraints:

1 <= s.length <= 100
s consists of characters with ASCII values in the range [33, 122].
s does not contain '\"' or '\\'.
     
     */
    class ReverseOnlyLetters
    {
        public string ReverseOnlyLettersFlow(string s)
        {
            // Convert the string into a character array to modify it
            char[] arr = s.ToCharArray();
            int left = 0;
            int right = arr.Length - 1;

            // Traverse with two pointers
            while (left < right)
            {
                // If both left and right are letters, swap them
                if (Char.IsLetter(arr[left]) && Char.IsLetter(arr[right]))
                {
                    // Swap the letters
                    char temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                    // Move both pointers inward
                    left++;
                    right--;
                }
                // If the left pointer is not a letter, move it to the right
                else if (!Char.IsLetter(arr[left]))
                {
                    left++;
                }
                // If the right pointer is not a letter, move it to the left
                else
                {
                    right--;
                }
            }

            // Convert the character array back to a string
            return new string(arr);
        }
    }
}
