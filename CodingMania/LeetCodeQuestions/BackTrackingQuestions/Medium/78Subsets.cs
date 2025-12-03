using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.BackTrackingQuestions.Medium
{

    /*
     
     Given an integer array nums of unique elements, return all possible subsets (the power set).

The solution set must not contain duplicate subsets. Return the solution in any order.

 

Example 1:

Input: nums = [1,2,3]
Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
Example 2:

Input: nums = [0]
Output: [[],[0]]
 

Constraints:

1 <= nums.length <= 10
-10 <= nums[i] <= 10
All the numbers of nums are unique.
     */
    public class _78Subsets
    {

        public IList<IList<int>> SubSets(int[] nums)
        {

            var result = new List<IList<int>>();
            //THE fIRST iTERATION YOU PASS IN AN eMPTY ARRAY TO SGINIFY []
            BackTrack(nums, 0, new List<int>(), result);
            return result;
        }

        private void BackTrack(int[] nums, int start, List<int> current, IList<IList<int>> result)
        {
            //Add a copy of the Current Subset
            //aDD cURRENT to resulr, recall from first Iteration it is Empty
            result.Add(new List<int>(current));

            //Explore further elements
            //iTERATE USEING [1, 2, 3] Using The Question array passed
            for (int i = start; i < nums.Length; i++)
            {
                //choose
                //Include the current number.
                current.Add(nums[i]);

                //Pass in the Current Array into here
                //Explore
                BackTrack(nums, i + 1, current, result);

                // Exclude the current number.
                //Undo Bacltrack

                current.RemoveAt(current.Count - 1);
            }
        }

        /*
         
         We use backtracking to explore subsets:

At each index, we decide:

Include the current number.

Exclude the current number.

When we reach the end of the array, we add the current subset to the result.

We then backtrack (undo the last choice) to explore other possibilities.


        Process:

Start with []

Add 1 → [1]

Add 2 → [1,2]

Add 3 → [1,2,3]

Backtrack → [1,2]

Backtrack → [1]

Add 3 → [1,3]

Backtrack → []

Add 2 → [2]

Add 3 → [2,3]

Backtrack → []

Add 3 → [3]

        the process og bactracking  i understand from line 95, but from line 96 I no Understand againg, the Undoing part ,the backTracking Part

        You need to Comprohend  Recursion
         */
    }
}
