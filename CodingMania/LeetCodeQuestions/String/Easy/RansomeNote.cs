using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    /*
     
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


    Solution Explain
    You can only use each letter in magazine once.

You must check if it’s possible to build the ransomNote using only the letters available in magazine.


       */
    class RansomeNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] letters = new int[26]; // For 'a' to 'z'

            // Count letters in magazine
            foreach (char c in magazine)
            {
                letters[c - 'a']++; // increment frequency of that particular frequescy in the array
            }

            // Try to use letters for ransomNote
            foreach (char c in ransomNote)
            {
                if (letters[c - 'a'] == 0)
                    return false;  // letter not available


                letters[c - 'a']--;  // use the letter, Decrement frequeect of that partcialur char in the array
            }

            return true;
        }


        //Using Dictionary

        public bool CanConstruct2(string ransomNote, string magazine)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Count each character in magazine
            foreach (char c in magazine)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            // Try to use characters from the dictionary
            foreach (char c in ransomNote)
            {
                if (!charCount.ContainsKey(c) || charCount[c] == 0)
                    return false;

                charCount[c]--; // use one instance of the letter
            }

            return true;
        }
        /*
          Problem with this logic:
.Contains() checks if one whole substring exists — not whether the characters can be rearranged to form the ransom note.
        public static bool RansomNote(string ransomNote, string magaZine)
        {
            return magaZine.Contains(ransomNote);
        }

        */



    }
}
