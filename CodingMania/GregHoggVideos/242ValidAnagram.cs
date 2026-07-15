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

            foreach (char  c  in s)
            {
                count[c - 'a']++;
            }

            foreach (char c in t)
            {
                count[c - 'a']--;
            }

            foreach (int value in count)
            {
                if (value != 0)
                    return false;
            }

            return true;
        }
    }
}
