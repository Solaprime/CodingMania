using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part5
{
    /*
     
     
     
     
     Given a string paragraph and a string array of the banned words banned, return the most frequent word that is not banned. It is guaranteed there is at least one word that is not banned, and that the answer is unique.

The words in paragraph are case-insensitive and the answer should be returned in lowercase.

Note that words can not contain punctuation symbols.

 

Example 1:

Input: paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.", banned = ["hit"]
Output: "ball"
Explanation: 
"hit" occurs 3 times, but it is a banned word.
"ball" occurs twice (and no other word does), so it is the most frequent non-banned word in the paragraph. 
Note that words in the paragraph are not case sensitive,
that punctuation is ignored (even if adjacent to words, such as "ball,"), 
and that "hit" isn't the answer even though it occurs more because it is banned.
Example 2:

Input: paragraph = "a.", banned = []
Output: "a"
 

Constraints:

1 <= paragraph.length <= 1000
paragraph consists of English letters, space ' ', or one of the symbols: "!?',;.".
0 <= banned.length <= 100
1 <= banned[i].length <= 10
banned[i] consists of only lowercase English letters.
     
     
     
     
     */
    class MostCommonWord
    {
        public string MostCommonWordFlow(string paragraph, string[] banned)
        {
            // Convert banned list to HashSet for O(1) lookup
            HashSet<string> bannedSet = new HashSet<string>(banned);

            // Normalize the paragraph: lowercase and split using regex to remove punctuation
            string[] words = Regex.Split(paragraph.ToLower(), @"\W+");

            Dictionary<string, int> freq = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (word.Length == 0 || bannedSet.Contains(word)) continue;

                if (!freq.ContainsKey(word))
                    freq[word] = 0;

                freq[word]++;
            }

            // Return the word with the highest frequency
            return freq.OrderByDescending(kv => kv.Value).First().Key;
        }
    }
}
