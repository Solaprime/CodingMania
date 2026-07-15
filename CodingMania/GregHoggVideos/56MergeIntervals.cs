using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*
     Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.

 

Example 1:

Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].
Example 2:

Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.
Example 3:

Input: intervals = [[4,7],[1,4]]
Output: [[1,7]]
Explanation: Intervals [1,4] and [4,7] are considered overlapping.
 

Constraints:

1 <= intervals.length <= 104
intervals[i].length == 2
0 <= starti <= endi <= 104
     */
    public static class _56MergeIntervals
    {
        //Greg Hogg Explanation
        //If ypu have QUestion Like this [2,6] [1,3],[8,10],[7,9]
        //Obtaining solutiuo without Sorting is going to be Difficuylt Hence
        //the need for the Sorting
        //So overlap occurs when x[0] <=y[0] and x[1]>=y[0]


        public static  int[][] Merge(int[][] intervals)
        {
            //ChatGpt Condition for Overlap

            ////Two intervals overlap if:
            // current.start <= previous.end

            //Sort Intervals by start Time
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            List<int[]> result = new List<int[]>();

            
            //add First interval
            result.Add(intervals[0]);

            //The For Loop
            for (int i = 1; i < intervals.Length; i++)
            {
                //Pick the Last Interval In the result Array,
                //For the first iteration, the first Intervall added  in line 54
                //will be the Last Interval
                int[] lastInterval = result[result.Count - 1];
                //CurrentInterval
                int[] currenInterval = intervals[i];

                //Check Overlap
                if (currenInterval[0] <= lastInterval[1])
                {
                    //Merge Intervaks
                    /*
                     Merge:

                       [1, max(3,6)]
                         =
                       [1,6]
                     */
                    lastInterval[1] = Math.Max(lastInterval[1], currenInterval[1]);
                }
                else
                {
                    //no overLap
                    result.Add(currenInterval);
                }
            }
            return result.ToArray();
        }
        
    }
}
