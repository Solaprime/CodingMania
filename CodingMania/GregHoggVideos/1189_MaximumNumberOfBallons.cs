using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*
     
     1189. Maximum Number of Balloons
Easy
Topics
premium lock icon
Companies
Hint
Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.

You can use each character in text at most once. Return the maximum number of instances that can be formed.

 

Example 1:



Input: text = "nlaebolko"
Output: 1
Example 2:



Input: text = "loonbalxballpoon"
Output: 2
Example 3:

Input: text = "leetcode"
Output: 0
 

Constraints:

1 <= text.length <= 104
text consists of lower case English letters only.
 

Note: This question is the same as 2287: Rearrange Characters to Make Target String.
     */
    public class _1189_MaximumNumberOfBallons
    {
        //tHIS cHATgPT sOLTUON IS A BIT lONG,
        //i AM THNKING CAN YOU NOT uSE hASHsET/dICTIONARY tHEN kEEP TH cOUNT AND CHECK
        //THE MIN
        public int MaxNumberOfBallons(string text)
        {
            int[] count = new int[26];

            foreach (char c in text)
            {
                count[c- 'a']++;
            }
            int b = count['b' - 'a'];
            int a = count['a' - 'a'];
            int l = count['l' - 'a'] / 2;
            int o = count['o' - 'a'] / 2;
            int n = count['n' - 'a'];

            //mATH.mIN ONLY COMAPRES TWO vALUE, THAT IS WHY WE ARE cHAINIG LIKE THIS
            //Math.Min();
            return Math.Min(b, Math.Min(a, Math.Min(l, Math.Min(o, n))));
        }
    }
}
