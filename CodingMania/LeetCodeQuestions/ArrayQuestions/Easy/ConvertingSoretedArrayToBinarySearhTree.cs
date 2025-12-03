using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.Array.Easy
{
    /*
     Convert Sorted Array to Binary Search Tree


       Given an integer array nums where the elements are sorted in ascending order, convert it to a 
height-balanced
 binary search tree.

 

Example 1:


Input: nums = [-10,-3,0,5,9]
Output: [0,-3,9,-10,null,5]
Explanation: [0,-10,5,null,-3,null,9] is also accepted:

Example 2:


Input: nums = [1,3]
Output: [3,1]
Explanation: [1,null,3] and [3,1] are both height-balanced BSTs.
 

Constraints:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums is sorted in a strictly increasing order.
     */
    internal class ConvertingSoretedArrayToBinarySearhTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return BuildBST(nums, 0, nums.Length - 1);
        }

        private TreeNode BuildBST(int[] nums, int left, int right)
        {
            // Base case: if the current subarray is empty, return null
            if (left > right)
            {
                return null;
            }

            // Find the middle index
            int mid = left + (right - left) / 2;

            // Create the root node with the middle element
            TreeNode node = new TreeNode(nums[mid]);

            // Recursively build the left subtree
            node.Left = BuildBST(nums, left, mid - 1);

            // Recursively build the right subtree
            node.Right = BuildBST(nums, mid + 1, right);

            return node;
        }
    }

    public class TreeNode
    {
        public int Val;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            Val = val;
            Left = left;
            Right = right;
        }
    }
}
