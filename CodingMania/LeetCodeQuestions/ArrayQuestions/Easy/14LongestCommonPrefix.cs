using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.ArrayQuestions.Easy
{
    /*
     Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters if it is non-empty.
     */
    public class _14LongestCommonPrefix
    {
        //HorizontaL Scaning Method
        //Word Scanning
        public static string LongestCommonPrefix(string[] strs)
        {
            //Check For edges
            if(strs== null || strs.Length ==0)
            {
                return "";
            }

            //sET THE pREFIX
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(prefix))
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "")
                        return "";
                        
                }
            }
            return prefix;
        }

        //Vertical Scanning approach
        //Character Scanning
        public static string LongetCommonPrefix2(string[] strs)
        {
            //Check For edges
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            for (int i = 0; i < strs[0].Length; i++)
            {
                //Shortcut 
                //var current =strs[0]
                //var currentCharacter = curent[i];
                char c = strs[0][i];
                for (int j = 0; j< strs[i].Length; j++)
                {
                    if (i == strs[j].Length || strs[j][i] != c)
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }
            return strs[0];
        }
    }
}
