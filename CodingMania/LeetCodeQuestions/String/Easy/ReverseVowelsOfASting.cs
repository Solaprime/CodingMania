using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    /*
     Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

 

Example 1:

Input: s = "IceCreAm"

Output: "AceCreIm"

Explanation:

The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".

Example 2:

Input: s = "leetcode"

Output: "leotcede"

 

Constraints:

1 <= s.length <= 3 * 105
s consist of printable ASCII characters.
     */
    class ReverseVowelsOfASting
    {
        public string ReverseVowels(string s)
        {
            // 1. Store all vowels (both lowercase and uppercase) in a HashSet for quick lookup
            //A HashSet provides O(1) average time complexity for .Contains(char) checks.
            //We need to frequently check whether a character is a vowel:
            //Using a HashSet makes this check very fast — better than using a List or multiple if/switch statements.
            HashSet<char> vowels = new HashSet<char>
    {
        'a', 'e', 'i', 'o', 'u',
        'A', 'E', 'I', 'O', 'U'
    };
            // 2. Convert the input string into a char array (since strings are immutable)

            char[] chars = s.ToCharArray();

            int left = 0, right = chars.Length - 1;

            // 3. Use two pointers: one from the left, one from the right
            while (left < right)
            {
                // Move left forward until a vowel is found
                while (left < right && !vowels.Contains(chars[left]))
                {
                    left++;
                }

                // Move right backward until a vowel is found
                while (left < right && !vowels.Contains(chars[right]))
                {
                    right--;
                }

                // Swap the vowels
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;
                right--;
            }

            return new string(chars);
        }

    }
}
/*
 
  What do you need to do?
Identify the vowels in the string.

Reverse the positions of these vowels only.

Keep the positions of all non-vowel characters unchanged.
 */
