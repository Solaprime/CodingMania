using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part6
{
    /*
 
     Given a string array words, return an array of all characters that show up in all strings within the words (including duplicates). You may return the answer in any order.

 

Example 1:

Input: words = ["bella","label","roller"]
Output: ["e","l","l"]
Example 2:

Input: words = ["cool","lock","cook"]
Output: ["c","o"]
 

Constraints:

1 <= words.length <= 100
1 <= words[i].length <= 100
words[i] consists of lowercase English letters.
     
     
     */
    class FindCommonCharacters
    {
        public IList<string> CommonChars(string[] words)
        {
            int[] minFreq = new int[26];
            System.Array.Fill(minFreq, int.MaxValue);

            foreach (string word in words)
            {
                int[] freq = new int[26];
                foreach (char c in word)
                {
                    freq[c - 'a']++;
                }

                for (int i = 0; i < 26; i++)
                {
                    minFreq[i] = Math.Min(minFreq[i], freq[i]);
                }
            }

            List<string> result = new List<string>();
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < minFreq[i]; j++)
                {
                    result.Add(((char)(i + 'a')).ToString());
                }
            }

            return result;
        }
    }
}
