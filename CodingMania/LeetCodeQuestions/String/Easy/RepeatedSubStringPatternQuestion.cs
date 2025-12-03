using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    /*
     Given a string s, check if it can be constructed by taking a substring of it and appending multiple copies of the substring together.

 

Example 1:

Input: s = "abab"
Output: true
Explanation: It is the substring "ab" twice.
Example 2:

Input: s = "aba"
Output: false
Example 3:

Input: s = "abcabcabcabc"
Output: true
Explanation: It is the substring "abc" four times or the substring "abcabc" twice.
 

Constraints:

1 <= s.length <= 104
s consists of lowercase English letters.
     */
    class RepeatedSubStringPatternQuestion
    {
        public bool RepeatedSubstringPattern(string s)
        {
            //Get Total Lenght of Input String
            int n = s.Length;

            //Try all Possible sutbring lengths from 1 to n/2
            //  why n/2 if the pattern is Longer than half, it cant
            //repeat at least
            //If the patttern is longet than half, it cant be
            //repeat at least twice 
            for (int len = 1; len <= n / 2; len++)
            {
                //Only consider substring lengths that evenly divide n
                // if n= 6 Only Try lenght 1 , 2 and 3 (6 % len ==0)
                
              
                if (n % len == 0)
                {
                    //Only Consider substring lenghs that evenly divide n
                    //if n =6  try Lengths 1,2 and 3 (6 % len == 0)

                    //Create pattern From 0 to LWN

                    string pattern = s.Substring(0, len);
                    //dECLAERE sTRING bUILDER FOR REPEATED
                    StringBuilder repeated = new StringBuilder();

                    // 6 /2  = 3
                    //'iterate' 3 times
                    for (int i = 0; i < n / len; i++)
                    {
                        repeated.Append(pattern);
                    }

                    //cHECK IF rEPAETED eQUQLS To s 
                    if (repeated.ToString() == s)
                        return true;
                }
            }

            return false;
        }



        public bool RepeatedSubstringPattern2(string s)
        {
            /*
             
            This creates a new string with two copies of s.
            s = "abab"
            s + s = "abababab"

            Substring(1, 2 * s.Length - 2)
            "abababab" → remove first and last → "bababab"


            Now you check if the original string s exists inside this modified version.
            If s is composed of repeated substrings, removing the first and last character from s + s will still contain s.

Example:

s = "abab"

s + s = "abababab"

Removing first and last: "bababab"

"bababab".Contains("abab") → ✅ true

Because "abab" is a repeated pattern.


            s = "aba"

s + s = "abaaba"

Removing first and last: "baab"

"baab".Contains("aba") → ❌ false

Because "aba" is not a repeated substring pattern.
             
             */
            string doubled = (s + s).Substring(1, 2 * s.Length - 2);
            return doubled.Contains(s);
        }
    }
}
