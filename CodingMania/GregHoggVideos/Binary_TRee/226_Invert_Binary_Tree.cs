using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.Binary_TRee
{
    /*
     226. Invert Binary Tree
Easy
Topics
premium lock icon
Companies
Given the root of a binary tree, invert the tree, and return its root.

 

Example 1:


Input: root = [4,2,7,1,3,6,9]
Output: [4,7,2,9,6,3,1]
Example 2:


Input: root = [2,1,3]
Output: [2,3,1]
Example 3:

Input: root = []
Output: []
 

Constraints:

The number of nodes in the tree is in the range [0, 100].
-100 <= Node.val <= 100
     
     */
    public class _226_Invert_Binary_Tree
    {
        /*
           Inberting a tree means producings its Miror Image: Everything that was on the left
          goes to the right, and everything on the right goes to the left , at every level 

        Example 1, [4,2,7,1,3,6,9]:


       Before                  After
        4                       4
      /   \                   /   \
     2     7                 7     2
    / \   / \               / \   / \
   1   3 6   9             9   6 3   1


        Cocept of Recurision is to introduce and Solve the base Case.
        After solving the base Case,Recursively call the method so all other Sections can be called


   2          2
  / \   →    / \
 1   3      3   1
       
        the key Insight is to swap at every node, at single node Inverting means swapping its Left and right
        children. To mirror the whole tree, You do that swap at every node
        At a single node, inverting means Swapping its left and right children .
        To mirror the whole tree, you do that Swap at every node..

        Note Swapping only at the root is not enough

        Note- Doing the Same thing at every node is what exactly recursion is for 

        Key Concpet of Recursion 

        The recursion recipe (same three steps as MaxDepth)
----Base case: an empty tree (null) needs nothing done, so return null.
-------Do this node's job: swap its left and right children.
----Trust the recursion: ask InvertTree to invert the left subtree and the right subtree.

         */

        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode temp = root.Left;
            root.Left = root.Right;
            root.Right = temp;

            InvertTree(root.Left);
            InvertTree(root.Right);

            return root;
        }
    }
}
