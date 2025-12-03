using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part4
{
    /*
     You are given an array of strings words and a string chars.

A string is good if it can be formed by characters from chars (each character can only be used once for each word in words).

Return the sum of lengths of all good strings in words.

 

Example 1:

Input: words = ["cat","bt","hat","tree"], chars = "atach"
Output: 6
Explanation: The strings that can be formed are "cat" and "hat" so the answer is 3 + 3 = 6.
Example 2:

Input: words = ["hello","world","leetcode"], chars = "welldonehoneyr"
Output: 10
Explanation: The strings that can be formed are "hello" and "world" so the answer is 5 + 5 = 10.
 

Constraints:

1 <= words.length <= 1000
1 <= words[i].length, chars.length <= 100
words[i] and chars consist of lowercase English letters.
     
     */
    class FinalWordsThatCanBeFormedByCharacters
    {
        public int CountCharacters(List<string> words, string chars)
        {
            // Step 1: Count frequency of each character in chars
            var charCount = new Dictionary<char, int>();
            foreach (char c in chars)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            int totalLength = 0;

            // Step 2: For each word in words, check if it can be formed with chars
            foreach (string word in words)
            {
                var wordCount = new Dictionary<char, int>();
                bool canForm = true;

                // Count frequency of each character in the word
                foreach (char c in word)
                {
                    if (wordCount.ContainsKey(c))
                        wordCount[c]++;
                    else
                        wordCount[c] = 1;
                }

                // Step 3: Check if we can form the word from chars
                foreach (var pair in wordCount)
                {
                    char c = pair.Key;
                    int requiredCount = pair.Value;

                    if (!charCount.ContainsKey(c) || charCount[c] < requiredCount)
                    {
                        canForm = false;
                        break;
                    }
                }

                // If the word can be formed, add its length to the total
                if (canForm)
                    totalLength += word.Length;
            }

            return totalLength;
        }
    }
}
