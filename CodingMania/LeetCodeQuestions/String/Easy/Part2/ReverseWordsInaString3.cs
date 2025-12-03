using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part2
{
    /*
     Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

 

Example 1:

Input: s = "Let's take LeetCode contest"
Output: "s'teL ekat edoCteeL tsetnoc"
Example 2:

Input: s = "Mr Ding"
Output: "rM gniD"
 

Constraints:

1 <= s.length <= 5 * 104
s contains printable ASCII characters.
s does not contain any leading or trailing spaces.
There is at least one word in s.
All the words in s are separated by a single space.
     */
    class ReverseWordsInaString3
    {
        public string ReverseWords(string s)
        {
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
               System.Array.Reverse(chars);
                words[i] = new string(chars);
            }
            return string.Join(" ", words);
        }
    }
}
