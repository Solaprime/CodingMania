using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*
    383. Ransom Note
Easy
Topics
premium lock icon
Companies
Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

 

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true
 

Constraints:

1 <= ransomNote.length, magazine.length <= 105
ransomNote and magazine consist of lowercase English letters. 
     */
    public class _383RansomNote
    {
        //First Solution Using Dictionary Count Flow

        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            //Load  the Character to Save and the Count
            foreach (char c in magazine)
            {
                if (freq.ContainsKey(c))
                {
                    freq[c]++;
                }
                else 
                {
                    freq[c] = 1;
                }
                //freq[c] = c;

               
            }
            foreach (char c in ransomNote)
            {
                if (!freq.ContainsKey(c) || freq[c] ==0)
                {
                    return false;
                }
                freq[c]--;
            }
            return true;

        }

        /// <summary>
        /// That's just 26 letters.
        ///  So instead of a Dictionary, use an array.
        /// </summary>
        /// <param name="ransomNote"></param>
        /// <param name="magazine"></param>
        /// <returns></returns>
        public bool CanConstructArraySolutionFlow(string ransomNote, string magazine)
        {
            int[] count = new int[26];

            foreach (char c in magazine)
            {
                count[c - 'a']++;
            }

            foreach (char c in ransomNote)
            {
                if (count[c - 'a'] == 0)
                    return false;

                count[c - 'a']--;
            }

            return true;

            /*
             'a' - 'a' = 0
             'b' - 'a' = 1
              'c' - 'a' = 2
              ...
            'z' - 'a' = 25
             */
        }
    }
}
