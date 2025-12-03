using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.BackTrackingQuestions.Medium
{
    /*
     Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.

The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the frequency of at least one of the chosen numbers is different.

The test cases are generated such that the number of unique combinations that sum up to target is less than 150 combinations for the given input.

 

Example 1:

Input: candidates = [2,3,6,7], target = 7
Output: [[2,2,3],[7]]
Explanation:
2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times.
7 is a candidate, and 7 = 7.
These are the only two combinations.
Example 2:

Input: candidates = [2,3,5], target = 8
Output: [[2,2,2,2],[2,3,3],[3,5]]
Example 3:

Input: candidates = [2], target = 1
Output: []
 

Constraints:

1 <= candidates.length <= 30
2 <= candidates[i] <= 40
All elements of candidates are distinct.
1 <= target <= 40

     
     */
    public class CombinationSum
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            BackTrack(candidates, target, 0, new List<int>(), result);
            return result;

        }

        private void BackTrack(int[] candidates, int remain, int start, List<int> current, IList<IList<int>> result)
        {
            //Base Cse: Found a valid Combination
            if (remain == 0)
            {
                result.Add(new List<int>(current));
                return;
            }

            // If remain < 0 → stop exploring
            if (remain < 0) return;

            // Explore candidates starting from "start" to avoid duplicates
            for (int i = start; i < candidates.Length; i++)
            {
                current.Add(candidates[i]); // choose

                // Explore further with reduced target (remain - candidates[i])
                BackTrack(candidates, remain - candidates[i], i, current, result);

                current.RemoveAt(current.Count - 1); // undo (backtrack)
            }
        }

    }
}
