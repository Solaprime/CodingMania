using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    /*
     Given a string s, return the number of segments in the string.

A segment is defined to be a contiguous sequence of non-space characters.

 

Example 1:

Input: s = "Hello, my name is John"
Output: 5
Explanation: The five segments are ["Hello,", "my", "name", "is", "John"]
Example 2:

Input: s = "Hello"
Output: 1
 

Constraints:

0 <= s.length <= 300
s consists of lowercase and uppercase English letters, digits, or one of the following characters "!@#$%^&*()_+-=',.:".
The only space character in s is ' '.
     */
    class NumberSegementsInaString
    {

        /*
         
         .Trim(): Removes leading and trailing spaces.

     .Split(..., StringSplitOptions.RemoveEmptyEntries): Ignores empty entries caused by multiple spaces.
         

        string s = "   Hello   world  ";

        Trim() → "Hello world"
Split(...) → ["Hello", "world"]
Output: 2
         */
        public int CountSegments(string s)
        {
            // Split the string by spaces and count the non-empty segments
            string[] segments = s.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return segments.Length;
        }


        /*
         string s = "   Hello   world  ";
        Trim() → "Hello world"

Split(' ') → ["Hello", "", "", "world"]

Output: 4 (WRONG)
         
         */
        //
        //My Solution Here Differnce
        public int GetNumberOfSegments(string s)
        {
            var words = s.Trim().Split(' ');
            return words.Length;
        }
    }
}
