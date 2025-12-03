using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Easy
{
    /*
     Given an array nums, you can perform the following operation any number of times:

Select the adjacent pair with the minimum sum in nums. If multiple such pairs exist, choose the leftmost one.
Replace the pair with their sum.
Return the minimum number of operations needed to make the array non-decreasing.

An array is said to be non-decreasing if each element is greater than or equal to its previous element (if it exists).

 

Example 1:

Input: nums = [5,2,3,1]

Output: 2

Explanation:

The pair (3,1) has the minimum sum of 4. After replacement, nums = [5,2,4].
The pair (2,4) has the minimum sum of 6. After replacement, nums = [5,6].
The array nums became non-decreasing in two operations.

Example 2:

Input: nums = [1,2,2]

Output: 0

Explanation:

The array nums is already sorted.

 

Constraints:

1 <= nums.length <= 50
-1000 <= nums[i] <= 1000
     
     */
    public class MinimumPairRemovalToSortArray1
    {
        public int MinOperationsToMakeNonDecreasing(int[] nums)
        {
            List<int> list = new List<int>(nums);
            int operations = 0;

            while (!IsNonDecreasing(list))
            {
                int minSum = int.MaxValue;
                int minIndex = -1;

                for (int i = 0; i < list.Count - 1; i++)
                {
                    int sum = list[i] + list[i + 1];
                    if (sum < minSum)
                    {
                        minSum = sum;
                        minIndex = i;
                    }
                }

                // Merge the pair
                int merged = list[minIndex] + list[minIndex + 1];
                list.RemoveAt(minIndex);
                list[minIndex] = merged; // Replace the next one with the merged sum
                operations++;
            }

            return operations;
        }

        private bool IsNonDecreasing(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < list[i - 1]) return false;
            }
            return true;
        }
    }
}
