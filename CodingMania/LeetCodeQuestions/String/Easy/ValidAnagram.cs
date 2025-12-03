using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    /*
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
 

Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case


They have the same characters,
The same number of each character, and
No extra or missing characters.
     s = "anagram"
t = "nagaram"


    //Wrong
    s = "rat"
t = "car"


 s has: r, a, t
t has: c, a, r
Not the same characters ❌ → Result: false
     */
    class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            // If two strings are different lengths, they can’t be anagrams.
            if (s.Length != t.Length)
                return false;

      
            Dictionary<char, int> charCount = new Dictionary<char, int>();


            /*
       We use a Dictionary<char, int> to:

Count how many times each character appears in s.

      {
'a': 3,
'n': 1,
'g': 1,
'r': 1,
'm': 1
}

       */
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }


            /*
             
             Step 3: Subtract Using Characters from t

            What are we doing here?

For each character in t, we decrease its count from the dictionary.

If the character was not found, return false.

If the count goes below zero (too many of that character in t), return false.

This checks if t has:

Exactly the same letters,

With no extras or mismatche
             */
            foreach (char c in t)
            {
                if (!charCount.ContainsKey(c))
                    return false;

                charCount[c]--;

                if (charCount[c] < 0)
                    return false;
            }

            return true;
        }
    }
}
