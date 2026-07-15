using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*
     
     771. Jewels and Stones
Easy
Topics
premium lock icon
Companies
Hint
You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.

Letters are case sensitive, so "a" is considered a different type of stone from "A".

 

Example 1:

Input: jewels = "aA", stones = "aAAbbbb"
Output: 3
Example 2:

Input: jewels = "z", stones = "ZZ"
Output: 0
 

Constraints:

1 <= jewels.length, stones.length <= 50
jewels and stones consist of only English letters.
All the characters of jewels are unique.
     */
    public class _771JewelsandStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            /*
             Every character in jewels is a jewel type.
             Every character in stones is a stone you own.
             
             How many stones are jewels?
             */
           

            //get unique element in jewel
            HashSet<char> jewelSet = new HashSet<char>();


            foreach (char  jewel in jewels)
            {
                jewelSet.Add(jewel);
            }


            //iterate throgh the stone and  check if
            //the uniwue element is in the jewel
            //
            int count = 0;
            foreach (char stone in stones)
            {
                if (jewelSet.Contains(stone))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
