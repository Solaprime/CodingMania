using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.BackTrackingQuestions.Medium
{
    /*
     
     Given an array nums of distinct integers, return all the possible permutations. You can return the answer in any order.

 

Example 1:

Input: nums = [1,2,3]
Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
Example 2:

Input: nums = [0,1]
Output: [[0,1],[1,0]]
Example 3:

Input: nums = [1]
Output: [[1]]
 

Constraints:

1 <= nums.length <= 6
-10 <= nums[i] <= 10
All the integers of nums are unique
     
     */
    public class _46Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            BackTrack(nums, new List<int>(), new bool[nums.Length], result);
            return result;
        }

        private void BackTrack(int[] nums, List<int> current, bool[] used, IList<IList<int>> result)
        {

            //If permutation is Complete

            if (current.Count == nums.Length)
            {
                result.Add(new List<int>(current));
                return;

            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i])
                {
                    continue;
                }

                //Choose
                used[i] = true;
                current.Add(nums[i]);

                //Explore
                BackTrack(nums, current, used, result);

                //Undo choice (backtrack)
                used[i] = false;
                current.RemoveAt(current.Count - 1);
             }

        }
    }
}
