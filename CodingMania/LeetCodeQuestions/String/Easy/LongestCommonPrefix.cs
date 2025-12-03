using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
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
strs[i] consists of only lowercase English letters if it is non-empty



        */
    public class LongestCommonPrefix
    {
        public string LongestCommonPrefixFlow(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            //What are youn Doing here
            //pass the 
            //weE ASSUME the First String in the array 
            //is the Common Prefix
            string prefix = strs[0];

            //Itearate over the Length of the array
            //Start Comparing 
            for (int i = 1; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(prefix))
                {
                    //Flower
                    //flowe
                    //flow
                    //fl0
                    //fl
                    //f

                    prefix = prefix.Substring(0, prefix.Length - 1);

                    if (string.IsNullOrEmpty(prefix))
                        return "";
                }
            }

            return prefix;
        }
    }
}
