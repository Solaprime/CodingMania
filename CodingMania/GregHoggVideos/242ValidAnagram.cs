using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*
     242. Valid Anagram
Easy
Topics
premium lock icon
Companies
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

 

Example 1:

Input: s = "anagram", t = "nagaram"

Output: true

Example 2:

Input: s = "rat", t = "car"

Output: false

 

Constraints:

1 <= s.length, t.length <= 5 * 104
s and t consist of lowercase English letters.
s and t consist of lowercase English letters.

     */
    public class _242ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
                return false;

            int[] count = new int[26];

            //Iterate throght the Fist Letter 
            //Populate the Letter that is a -3, b-1 c=0, d-4

            foreach (char  c  in s)
            {
                count[c - 'a']++;
            }

            //Iterate through the Second Letter
            //Find the Letters and decrease theindex
            // a = 3-1, b=1-1
            foreach (char c in t)
            {
                count[c - 'a']--;
            }

            //Iterate through here if any count is Not Equals
            foreach (int value in count)
            {
                if (value != 0)
                    return false;
            }

            return true;
        }
    }
}
