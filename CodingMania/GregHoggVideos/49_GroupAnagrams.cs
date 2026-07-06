using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*
     49. Group Anagrams
Medium
Topics
premium lock icon
Companies
Given an array of strings strs, group the anagrams together. You can return the answer in any order.

 

Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]

Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

Explanation:

There is no string in strs that can be rearranged to form "bat".
The strings "nat" and "tan" are anagrams as they can be rearranged to form each other.
The strings "ate", "eat", and "tea" are anagrams as they can be rearranged to form each other.
Example 2:

Input: strs = [""]

Output: [[""]]

Example 3:

Input: strs = ["a"]

Output: [["a"]]

 

Constraints:

1 <= strs.length <= 104
0 <= strs[i].length <= 100
strs[i] consists of lowercase English letters.
     */
    class _49_GroupAnagrams
    {

        /*
         an anagram means Two strings have the same characters with the same frequency, but in a different order.
        How do we Know two strings are anagrams? We need a way to create a common identify for anagrams???
         
         Approach 1: Sorting Each String
         For every word:
         Convert to character array
         Sort characters
         Use sorted string as a key
         Add original word to that group

         
         */
        // I understand this Approach Wella Wella Wella
        public IList<IList<string>> GroupAnagramsSortingApproach(string[] strs)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            foreach (string word in strs)
            {
                //Convert to char Array
                char[] chars = word.ToCharArray();

                //Sort
                Array.Sort(chars);

                string key = new string(chars);

                //Check if the Sort has been added as the Key
                if (!map.ContainsKey(key))
                {
                    //If the Word has not been added, Add as Key to the World Here
                    map[key] = new List<string>();

                }
                //Then add to the List Of th World
                map[key].Add(word);
            }

            return map.Values.ToList<IList<string>>();
        }

        public IList<IList<string>> GroupAnagramsFrequencyApproach(string[] strs)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            foreach (string word in strs)
            {
                int[] count = new int[26];

                foreach (char  c  in word)
                {
                    count[c - 'a']++;

                }

                string key = string.Join("#", count);

                if (!map.ContainsKey(key))
                {
                    map[key] = new List<string>();
                }

                map[key].Add(word);
            }
            return map.Values.ToList<IList<string>>();
        }
    }
}
