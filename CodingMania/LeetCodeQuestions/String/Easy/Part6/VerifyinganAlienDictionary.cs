using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part6
{
    /*
     
     
     In an alien language, surprisingly, they also use English lowercase letters, but possibly in a different order. The order of the alphabet is some permutation of lowercase letters.

Given a sequence of words written in the alien language, and the order of the alphabet, return true if and only if the given words are sorted lexicographically in this alien language.

 

Example 1:

Input: words = ["hello","leetcode"], order = "hlabcdefgijkmnopqrstuvwxyz"
Output: true
Explanation: As 'h' comes before 'l' in this language, then the sequence is sorted.
Example 2:

Input: words = ["word","world","row"], order = "worldabcefghijkmnpqstuvxyz"
Output: false
Explanation: As 'd' comes after 'l' in this language, then words[0] > words[1], hence the sequence is unsorted.
Example 3:

Input: words = ["apple","app"], order = "abcdefghijklmnopqrstuvwxyz"
Output: false
Explanation: The first three characters "app" match, and the second string is shorter (in size.) According to lexicographical rules "apple" > "app", because 'l' > '∅', where '∅' is defined as the blank character which is less than any other character (More info).
 

Constraints:

1 <= words.length <= 100
1 <= words[i].length <= 20
order.length == 26
All characters in words[i] and order are English lowercase letters.
     
     
     */
    class VerifyinganAlienDictionary
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            // Create a map of character -> index for quick comparison
            int[] orderIndex = new int[26];
            for (int i = 0; i < order.Length; i++)
            {
                orderIndex[order[i] - 'a'] = i;
            }

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (!InCorrectOrder(words[i], words[i + 1], orderIndex))
                {
                    return false;
                }
            }

            return true;
        }

        private bool InCorrectOrder(string word1, string word2, int[] orderIndex)
        {
            int minLength = Math.Min(word1.Length, word2.Length);

            for (int i = 0; i < minLength; i++)
            {
                char c1 = word1[i];
                char c2 = word2[i];

                if (c1 != c2)
                {
                    return orderIndex[c1 - 'a'] < orderIndex[c2 - 'a'];
                }
            }

            // If all characters so far are equal, shorter word should come first
            return word1.Length <= word2.Length;
        }
    }
}
