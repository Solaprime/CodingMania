using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.Binary_TRee
{
    /*
     104. Maximum Depth of Binary Tree
Easy
Topics
premium lock icon
Companies
Given the root of a binary tree, return its maximum depth.

A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

 

Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: 3
Example 2:

Input: root = [1,null,2]
Output: 2
 

Constraints:

The number of nodes in the tree is in the range [0, 104].
-100 <= Node.val <= 10
     
     
     */
    public class _104_Maximum_Depth_of_Binary_Tree
    {
        /*
         This is postOder, the code gets both childrn answers first and handles the node last
         */
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftDepth = MaxDepth(root.Left);
            int rightDepth = MaxDepth(root.Right);

           return 1+ Math.Max(leftDepth, rightDepth);
        }
    }
}
