using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.GraphAlgorithm.BFS.Hard
{
    /*
     A transformation sequence from word beginWord to word endWord using a dictionary wordList is a sequence of words beginWord -> s1 -> s2 -> ... -> sk such that:

Every adjacent pair of words differs by a single letter.
Every si for 1 <= i <= k is in wordList. Note that beginWord does not need to be in wordList.
sk == endWord
Given two words, beginWord and endWord, and a dictionary wordList, return the number of words in the shortest transformation sequence from beginWord to endWord, or 0 if no such sequence exists.

 

Example 1:

Input: beginWord = "hit", endWord = "cog", wordList = ["hot","dot","dog","lot","log","cog"]
Output: 5
Explanation: One shortest transformation sequence is "hit" -> "hot" -> "dot" -> "dog" -> cog", which is 5 words long.
Example 2:

Input: beginWord = "hit", endWord = "cog", wordList = ["hot","dot","dog","lot","log"]
Output: 0
Explanation: The endWord "cog" is not in wordList, therefore there is no valid transformation sequence.
 

Constraints:

1 <= beginWord.length <= 10
endWord.length == beginWord.length
1 <= wordList.length <= 5000
wordList[i].length == beginWord.length
beginWord, endWord, and wordList[i] consist of lowercase English letters.
beginWord != endWord
All the words in wordList are unique.
     
     */
    public class _127WordLadder
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            HashSet<string> wordSet = new HashSet<string>(wordList);
            if (!wordSet.Contains(endWord)) return 0; // no possible path

            Queue<(string word, int length)> queue = new Queue<(string, int)>();
            queue.Enqueue((beginWord, 1)); // start with length 1 ("hit" itself)

            while (queue.Count > 0)
            {
                var (currentWord, length) = queue.Dequeue();

                if (currentWord == endWord)
                {
                    return length;
                }

                char[] wordChars = currentWord.ToCharArray();

                for (int i = 0; i < wordChars.Length; i++)
                {
                    char originalChar = wordChars[i];

                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        if (c == originalChar) continue;

                        wordChars[i] = c;
                        string newWord = new string(wordChars);

                        if (wordSet.Contains(newWord))
                        {
                            queue.Enqueue((newWord, length + 1));
                            wordSet.Remove(newWord); // avoid revisiting
                        }
                    }

                    wordChars[i] = originalChar; // restore for next iteration
                }
            }

            return 0; // no path found
        }
    }
}
