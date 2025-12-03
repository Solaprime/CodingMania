using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    /*
     
     Given a pattern and a string s, find if s follows the same pattern.

Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s. Specifically:

Each letter in pattern maps to exactly one unique word in s.
Each unique word in s maps to exactly one letter in pattern.
No two letters map to the same word, and no two words map to the same letter.
 

Example 1:

Input: pattern = "abba", s = "dog cat cat dog"

Output: true

Explanation:

The bijection can be established as:

'a' maps to "dog".
'b' maps to "cat".
Example 2:

Input: pattern = "abba", s = "dog cat cat fish"

Output: false

Example 3:

Input: pattern = "aaaa", s = "dog cat cat dog"

Output: false

 

Constraints:

1 <= pattern.length <= 300
pattern contains only lower-case English letters.
1 <= s.length <= 3000
s contains only lowercase English letters and spaces ' '.
s does not contain any leading or trailing spaces.
All the words in s are separated by a single space.
     */
    class WordPattern
    {
        public bool WordPatternSolution(string pattern, string s)
        {
            string[] words = s.Split(' ');

            if (pattern.Length != words.Length)
                return false;

            Dictionary<char, string> charToWord = new Dictionary<char, string>();
            Dictionary<string, char> wordToChar = new Dictionary<string, char>();

            for (int i = 0; i < pattern.Length; i++)
            {
                char c = pattern[i];
                string word = words[i];

                // Check character to word mapping
                if (charToWord.ContainsKey(c))
                {
                    if (charToWord[c] != word)
                        return false;
                }
                else
                {
                    charToWord[c] = word;
                }

                // Check word to character mapping
                if (wordToChar.ContainsKey(word))
                {
                    if (wordToChar[word] != c)
                        return false;
                }
                else
                {
                    wordToChar[word] = c;
                }
            }

            return true;
        }
    }
}
