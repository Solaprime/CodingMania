using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions
{
//    Given a string s consisting of words and spaces, return the length of the last word in the string.

//A word is a maximal
//substring
// consisting of non-space characters only.



//Example 1:

//Input: s = "Hello World"
//Output: 5
//Explanation: The last word is "World" with length 5.
//Example 2:

//Input: s = "   fly me   to   the moon  "
//Output: 4
//Explanation: The last word is "moon" with length 4.
//Example 3:

//Input: s = "luffy is still joyboy"
//Output: 6
//Explanation: The last word is "joyboy" with length 6.
 

//Constraints:

//1 <= s.length <= 104
//s consists of only English letters and spaces ' '.
//There will be at least one word in s.

    internal class LengthOfLastWord
    {
        public int LengthOfLastWordsLength(string s)
        {
            // Trim any trailing spaces from the input string
            s = s.Trim();

            // Find the index of the last space in the trimmed string
            int lastSpaceIndex = s.LastIndexOf(' ');

            // The length of the last word is the length of the string
            // after the last space to the end of the string
            return s.Length - lastSpaceIndex - 1;
        }
    }



//    Here's the C# solution to solve the problem:

//Solution in C#
//csharp
//Copy code
//public class Solution
//    {
//        public int LengthOfLastWord(string s)
//        {
//            // Trim any trailing spaces from the input string
//            s = s.Trim();

//            // Find the index of the last space in the trimmed string
//            int lastSpaceIndex = s.LastIndexOf(' ');

//            // The length of the last word is the length of the string
//            // after the last space to the end of the string
//            return s.Length - lastSpaceIndex - 1;
//        }
//    }
//    Explanation
//    The task is to find the length of the last word in a string where words are separated by spaces.The string can contain leading or trailing spaces, which need to be ignored.

//    Steps:
//Trim the String:
//Use s.Trim() to remove leading and trailing spaces.
//Find the Last Space:
//Use s.LastIndexOf(' ') to find the position of the last space in the string.
//If there is no space(single word), LastIndexOf will return -1.
//Calculate the Length:
//Subtract the index of the last space from the total string length and subtract 1 to get the length of the last word.
}
