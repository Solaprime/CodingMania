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
                    //Or Create a new Key with an Empty List
                    map[key] = new List<string>();

                }
                //Then add to the List Of th World
                //Both new or Existing Key stiill enter Here
                map[key].Add(word);
            }

            return map.Values.ToList<IList<string>>();
        }


        /// <summary>
       /// ARRAY Sort is More Coplexity oh  So we Use 
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public IList<IList<string>> GroupAnagramsFrequencyApproach(string[] strs)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            foreach (string word in strs)
            {
                //The Restriant is Lower Case English  Letters
                int[] count = new int[26];

                //c - 'a' turns a letter into an index: 'a'→0, 'b'→1, …, 'z'→25.
                //For “eat”, the result is count[0]=1 (a), count[4]=1 (e), count[19]=1 (t),
                //and every other slot is 0.
                foreach (char  c  in word)
                {
                    count[c - 'a']++;

                }

                //So you need a key __Arrays can’t be used directly as dictionary keys, because C# compares arrays by reference,
                //not by contents. So you turn the array into a string, which gives “eat” the key 1#0#0#0#1#0#…#1#…#0.

                //The # separator matters. Without it, the counts [1, 11] and [11, 1] would both become "111",
                //and two non-anagrams could collide. The separator makes them "1#11" and "11#1".
                string key = string.Join("#", count);
               // var a = string.Join()

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
