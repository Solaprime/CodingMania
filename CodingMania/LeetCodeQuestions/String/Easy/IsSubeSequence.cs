using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    /*
     * Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

 

Example 1:

Input: s = "abc", t = "ahbgdc"
Output: true
Example 2:

Input: s = "axc", t = "ahbgdc"
Output: false
 

Constraints:

0 <= s.length <= 100
0 <= t.length <= 104
s and t consist only of lowercase English letters.
 

Follow up: Suppose there are lots of incoming s, say s1, s2, ..., sk where k >= 109, and you want to check one by one to see if t has its subsequence. In this scenario, how would you change your code?
     */
    class IsSubeSequence
    {
        private Dictionary<char, List<int>> indexMap;

        // Constructor for optimized usage (preprocess t)
        //This solution preprocesses t once, then uses it to test many s strings efficiently.

        /*
         
         var checker = new IsSubeSequence("ahbgdc"); // Preprocess `t` once

bool r1 = checker.IsSubsequenceFast("abc");
bool r2 = checker.IsSubsequenceFast("axc");
bool r3 = checker.IsSubsequenceFast("hbd");
         
         
         
         */
        public IsSubeSequence(string t)
        {
            indexMap = new Dictionary<char, List<int>>();
            for (int i = 0; i < t.Length; i++)
            {
                if (!indexMap.ContainsKey(t[i]))
                    indexMap[t[i]] = new List<int>();
                indexMap[t[i]].Add(i);
            }
        }

        // Basic method for single check without preprocessing
        //Method to Check for Simple Case
        //If you iterating string with Billons How you do it is 
        //Differennt
        //We check if s is a SubSequent T
        // s is Shorter than T

        /*
         
         i: Index for s, j: Index for t

     If s[i] == t[j], move i forward (meaning this character is matched).

Always move j forward.
At the end, if all characters of s were matched (i == s.Length),
        return true.
         
         */
        public bool IsSubsequence(string s, string t)
        {
            int i = 0, j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                    i++;
                j++;
            }
            return i == s.Length;
        }

        // Optimized method using preprocessed t

        /*
         Uses the indexMap that was precomputed in the constructor.

Designed for situations where you're calling this method repeatedly for different s values but the same t.

Much faster than the simple method when checking many s strings.
         
         
         
         */
        public bool IsSubsequenceFast(string s)
        {
            int prevIndex = -1;

            foreach (char c in s)
            {
                if (!indexMap.ContainsKey(c))
                    return false;

                var positions = indexMap[c];
                int nextIndex = FindNextIndex(positions, prevIndex);

                if (nextIndex == -1)
                    return false;

                prevIndex = positions[nextIndex];
            }

            return true;
        }

        // Binary search to find the smallest number > prevIndex
        private int FindNextIndex(List<int> list, int prevIndex)
        {
            int left = 0, right = list.Count - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (list[mid] > prevIndex)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return (left < list.Count) ? left : -1;
        }
    }
}

/*
 
 A  SubSequence of  a string is a new String
Is formed by deleting zero or more characters from the original string,

Without changing the relative order of the remaining characters.

💡 Examples:

"abc" is a subsequence of "ahbgdc" → ✅ (Keep a, b, and c in order, delete h, g, d)

"axc" is not a subsequence of "ahbgdc" → ❌ (a and c exist in order, but x does not exist)


Problem Constraints
Length of s: Up to 100

Length of t: Up to 10,000

So, you need to process a smaller string (s) against a potentially long string (t).


 Follow-up Constraint
Imagine that you are given billions of different s strings (like s1, s2, ..., sk with k ≥ 10⁹), and you want to test each of them efficiently against a single string t.

The basic method works well if you're only checking a few s strings.

The optimized method is necessary if you're checking millions or billions of s strings against the same t.
 */
