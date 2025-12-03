using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.BinaryTreeQuestions.Easy
{
    public class BinaryTreeInorderTraversal
    {
        /*
         
         
         Given the root of a binary tree, return the inorder traversal of its nodes' values.

 

Example 1:

Input: root = [1,null,2,3]

Output: [1,3,2]

Explanation:
    1
     \
      2
     /
    3



Example 2:

Input: root = [1,2,3,4,5,null,8,null,null,6,7,9]

Output: [4,2,6,5,7,1,3,9,8]

Explanation:


            1
         /   \
        2     3
       / \     \
      4   5     8
         / \     /
        6   7   9



Example 3:

Input: root = []

Output: []

Example 4:

Input: root = [1]

Output: [1]

 

Constraints:

The number of nodes in the tree is in the range [0, 100].
-100 <= Node.val <= 100
         */


        /////Left -. rOOT -> rIGHT
        ///

        /*
         
         
    1
     \
      2
     /
    3

         Step-by-step traversal:

Start at root 1, no left child

Visit 1

Move to right child 2, go to its left child 3

Visit 3, go back to 2

Visit 2

Output: [1, 3, 2]


        Example 2
        nput: root = [1,2,3,4,5,null,8,null,null,6,7,9]
          1
         /   \
        2     3
       / \     \
      4   5     8
         / \     /
        6   7   9

         Step-by-step traversal:

Traverse left subtree of 1:

Traverse left subtree of 2: visit 4

Visit 2

Traverse right subtree of 2 → visit 6, then 5, then 7

Visit 1

Traverse right subtree of 1:

Visit 3

Traverse right subtree of 3 → visit 9, then 8

Output: [4, 2, 6, 5, 7, 1, 3, 9, 8]
         */
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public class Solution
        {
            public IList<int> InorderTraversal(TreeNode root)
            {
                var result = new List<int>();
                Traverse(root, result);
                return result;
            }

            private void Traverse(TreeNode node, List<int> result)
            {
                if (node == null) return;

                Traverse(node.left, result);
                result.Add(node.val);
                Traverse(node.right, result);
            }

        }
    }
}
