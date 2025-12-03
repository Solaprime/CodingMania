using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part5
{
    /*
     
     Your friend is typing his name into a keyboard. Sometimes, when typing a character c, the key might get long pressed, and the character will be typed 1 or more times.

You examine the typed characters of the keyboard. Return True if it is possible that it was your friends name, with some characters (possibly none) being long pressed.

 

Example 1:

Input: name = "alex", typed = "aaleex"
Output: true
Explanation: 'a' and 'e' in 'alex' were long pressed.
Example 2:

Input: name = "saeed", typed = "ssaaedd"
Output: false
Explanation: 'e' must have been pressed twice, but it was not in the typed output.
 

Constraints:

1 <= name.length, typed.length <= 1000
name and typed consist of only lowercase English letters.
     
     */
    class LongPressedNameQuestionFlow
    {
        public bool IsLongPressedName(string name, string typed)
        {
            int i = 0, j = 0;

            while (j < typed.Length)
            {
                // If characters match, move both pointers
                if (i < name.Length && name[i] == typed[j])
                {
                    i++;
                }
                // If the current character in typed matches the previous character
                // in typed (long press), just move j
                else if (j > 0 && typed[j] == typed[j - 1])
                {
                    j++;
                }
                else
                {
                    // Characters don't match and no long press is occurring
                    return false;
                }
                j++;
            }

            // Check if we've used up all characters in name
            return i == name.Length;
        }
    }
}
