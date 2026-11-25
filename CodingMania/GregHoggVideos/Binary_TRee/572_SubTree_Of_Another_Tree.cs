using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.Binary_TRee
{
    /*
     
     572. Subtree of Another Tree
Easy
Topics
premium lock icon
Companies
Hint
Given the roots of two binary trees root and subRoot, return true if there is a subtree of root with the same structure and node values of subRoot and false otherwise.

A subtree of a binary tree tree is a tree that consists of a node in tree and all of this node's descendants. The tree tree could also be considered as a subtree of itself.

 

Example 1:


Input: root = [3,4,5,1,2], subRoot = [4,1,2]
Output: true
Example 2:


Input: root = [3,4,5,1,2,null,null,null,null,0], subRoot = [4,1,2]
Output: false
 

Constraints:

The number of nodes in the root tree is in the range [1, 2000].
The number of nodes in the subRoot tree is in the range [1, 1000].
-104 <= root.val <= 104
-104 <= subRoot.val <= 104
     
     */
    public class _572_SubTree_Of_Another_Tree
    {
        public bool IsSubTree(TreeNode root, TreeNode subRoot)
        {
            if (root== null)
            {
                return false;
            }
            
            if (IsSameTree(root, subRoot))
            {
                return true;
            }

            //OtherWise look for a maths inside the left or Right subtree
            return IsSubTree(root.Left, subRoot) || IsSubTree(root.Right, subRoot);
        }

        //Solutuon for LeetCode 100

        public bool IsSameTree(TreeNode first , TreeNode second)
        {
            if (first == null && second == null)
            {
                return true;
            }

            if (first == null ||  second == null)
            {
                return false;
            }
            bool leftAnswer = IsSameTree(first.Left, second.Left);
            bool rightAnswer = IsSameTree(first.Right, second.Right);

            return leftAnswer && rightAnswer;
        }
    }
}
