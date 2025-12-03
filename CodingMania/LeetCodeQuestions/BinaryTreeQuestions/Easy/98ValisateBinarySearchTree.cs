using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.BinaryTreeQuestions.Easy
{
    /*
     Given the root of a binary tree, determine if it is a valid binary search tree (BST).

A valid BST is defined as follows:

The left subtree of a node contains only nodes with keys strictly less than the node's key.
The right subtree of a node contains only nodes with keys strictly greater than the node's key.
Both the left and right subtrees must also be binary search trees.
 

Example 1:


      2
    /   \
    1    3
Input: root = [2,1,3]
Output: true
Example 2:

        5
    /       \
    1        4
            / \
            3 6
Input: root = [5,1,4,null,null,3,6]
Output: false
Explanation: The root node's value is 5 but its right child's value is 4.
 

Constraints:

The number of nodes in the tree is in the range [1, 104].
-231 <= Node.val <= 231 - 1
     */
    public class _98ValisateBinarySearchTree
    {
        //Rwcursive Range Check Solution
        public bool IsValidBST(TreeNode root)
        {
            return Validate(root, long.MinValue, long.MaxValue);
        }

        // Helper: returns true if subtree rooted at node respects (min, max)
        private bool Validate(TreeNode node, long min, long max)
        {
            if (node == null) return true;

            // Node value must be strictly between min and max
            if (node.val <= min || node.val >= max) return false;

            // Left must be in (min, node.val), right in (node.val, max)
            return Validate(node.left, min, node.val) && Validate(node.right, node.val, max);
        }

        //iterative Inorder Stack 
        public bool IsValidBST_Inorder(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            TreeNode curr = root;
            long prev = long.MinValue; // prev holds last visited value; long to avoid overflow

            while (curr != null || stack.Count > 0)
            {
                // go to leftmost
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }

                curr = stack.Pop();

                // current value must be strictly greater than previous visited
                if (curr.val <= prev) return false;

                prev = curr.val;
                curr = curr.right;
            }

            return true;
        }
    }
}
