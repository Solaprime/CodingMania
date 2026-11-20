using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.SlidingWindow
{
    /*
     [424. Longest Repeating Character Replacement](https://leetcode.com/problems/longest-repeating-character-replacement/)
Medium
Topics
Companies
You are given a string `s` and an integer `k`. You can choose any character of the string and change it to any other uppercase English character. You can perform this operation at most `k` times.
Return the length of the longest substring containing the same letter you can get after performing the above operations.
 
Example 1:

```
Input: s = "ABAB", k = 2
Output: 4
Explanation: Replace the two 'A's with two 'B's or vice versa.

```

Example 2:

```
Input: s = "AABABBA", k = 1
Output: 4
Explanation: Replace the one 'A' in the middle with 'B' and form "AABBBBA".
The substring "BBBB" has the longest repeating letters, which is 4.
There may exists other ways to achieve this answer too.
```

 
Constraints:

* `1 <= s.length <= 105`
* `s` consists of only uppercase English letters.
* `0 <= k <= s.length`
     */
    public class _424_Longest_Repeating_Chracters_Replacement
    {
        //You have a string of UpperCse Letters and May change at most k characters into any other letter. What is the Longest Substring you can make Every Letter is the Saamek
        // "ABAB", k =2 : Change both As to Bs to get"BBBB" O

        //"AABABBA", K=1: Change the A at index 3 to B to get "AABBBBA" the "BBBB" stretch has length 4.
        //This is close Relative of 1004

        /*
         replacements needed = window length − count of the mosfrequent letter
        so for the Window "AABA",the most frequent Letter is A(3 times) so it neeeds 4-3 = 1 replcament
        so the window is valid when that number is at most k;
        (right-left +1) - maxCount <K
         
         */


        public int CharacterReplacement(string s, int k)
        {
            //Since we are dealing with Letters Here 
            int[] count = new int[26];
            int left = 0;
            int maxCount = 0;  //Highest Single letter Count seen in a window
            int longest = 0;


            for (int right = 0; right < s.Length; right++)
            {
                //Add Incoming characer
                count[s[right] - 'A']++;
                maxCount = Math.Max(maxCount, count[s[right] - 'A']++);

                //Shrink While invalid
                while ((right-left +1)-maxCount >k)
                {
                    count[s[left] - 'A']--;
                    left++;
                }

                //record
                longest = Math.Max(longest, right - left + 1);
            }
            return longest;
        }
    }
}
