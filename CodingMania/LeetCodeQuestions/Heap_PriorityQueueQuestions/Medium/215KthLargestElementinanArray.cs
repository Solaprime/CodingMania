using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.Heap_PriorityQueueQuestions.Medium
{
    /*
     Given an integer array nums and an integer k, return the kth largest element in the array.

Note that it is the kth largest element in the sorted order, not the kth distinct element.

Can you solve it without sorting?

 

Example 1:

Input: nums = [3,2,1,5,6,4], k = 2
Output: 5
Example 2:

Input: nums = [3,2,3,1,2,4,5,5,6], k = 4
Output: 4
 

Constraints:

1 <= k <= nums.length <= 105
-104 <= nums[i] <= 104
     */
    public class _215KthLargestElementinanArray
    {
        //UsING priority Queue Flow
        public int FindKthLargestUsingPriorityueue
            (int[] nums, int k)
        {

            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
            foreach  (int num in nums)
            {
                minHeap.Enqueue(num, num); //both Value and priority are num
                if (minHeap.Count > k)
                {
                    minHeap.Dequeue(); //remove Smallest
                }
            }
            return minHeap.Peek(); //kTH lARGEST element
        }


        //Using QuickSelect
        public int FindKthLargestUsingQuickSelect(int[] nums, int k)
        {
            int n = nums.Length;
            return QuickSelect(nums, 0, n - 1, n - k); // kth largest is (n-k)th smallest
        }
        private int QuickSelect(int[] nums, int left, int right, int kSmallest)
        {
            if (left == right)
                return nums[left];

            Random rand = new Random();
            int pivotIndex = rand.Next(left, right + 1);

            pivotIndex = Partition(nums, left, right, pivotIndex);

            if (kSmallest == pivotIndex)
                return nums[kSmallest];
            else if (kSmallest < pivotIndex)
                return QuickSelect(nums, left, pivotIndex - 1, kSmallest);
            else
                return QuickSelect(nums, pivotIndex + 1, right, kSmallest);
        }

        private int Partition(int[] nums, int left, int right, int pivotIndex)
        {
            int pivotValue = nums[pivotIndex];
            Swap(nums, pivotIndex, right);
            int storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (nums[i] < pivotValue)
                {
                    Swap(nums, storeIndex, i);
                    storeIndex++;
                }
            }

            Swap(nums, right, storeIndex);
            return storeIndex;
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
