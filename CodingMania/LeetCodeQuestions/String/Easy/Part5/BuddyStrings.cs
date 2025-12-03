using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part5
{
    /*
     Given two strings s and goal, return true if you can swap two letters in s so the result is equal to goal, otherwise, return false.

Swapping letters is defined as taking two indices i and j (0-indexed) such that i != j and swapping the characters at s[i] and s[j].

For example, swapping at indices 0 and 2 in "abcd" results in "cbad".
 

Example 1:

Input: s = "ab", goal = "ba"
Output: true
Explanation: You can swap s[0] = 'a' and s[1] = 'b' to get "ba", which is equal to goal.
Example 2:

Input: s = "ab", goal = "ab"
Output: false
Explanation: The only letters you can swap are s[0] = 'a' and s[1] = 'b', which results in "ba" != goal.
Example 3:

Input: s = "aa", goal = "aa"
Output: true
Explanation: You can swap s[0] = 'a' and s[1] = 'a' to get "aa", which is equal to goal.
 

Constraints:

1 <= s.length, goal.length <= 2 * 104
s and goal consist of lowercase letters.
     
     */
    class BuddyStrings
    {
        public bool BuddyStringsFlow(string s, string goal)
        {
            // If the lengths are different, return false
            if (s.Length != goal.Length) return false;

            // If the strings are the same, check if there are at least two identical characters
            if (s == goal)
            {
                var set = new HashSet<char>();
                foreach (char c in s)
                {
                    if (set.Contains(c))
                    {
                        return true; // We found at least two identical characters
                    }
                    set.Add(c);
                }
                return false;
            }

            // If the strings are not the same, find the differing positions
            var diff = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != goal[i])
                {
                    diff.Add(i);
                }
            }

            // If there are exactly two differing positions, check if swapping makes them equal
            if (diff.Count == 2)
            {
                int i = diff[0], j = diff[1];
                return s[i] == goal[j] && s[j] == goal[i]; // Check if swapping would result in equality
            }

            return false; // If there are not exactly two differing positions
        }
    }
}
