using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium.Part2
{
    /*
     Given the root of a binary tree, flatten the tree into a "linked list":

The "linked list" should use the same TreeNode class where the right child pointer points to the next node in the list and the left child pointer is always null.
The "linked list" should be in the same order as a pre-order traversal of the binary tree.
 

Example 1:


Input: root = [1,2,5,3,4,null,6]
Output: [1,null,2,null,3,null,4,null,5,null,6]
Example 2:

Input: root = []
Output: []
Example 3:

Input: root = [0]
Output: [0]
 

Constraints:

The number of nodes in the tree is in the range [0, 2000].
-100 <= Node.val <= 100
 

Follow up: Can you flatten the tree in-place (with O(1) extra space)?
     */
    class FlattenBinaryTreeToLinkedList
    {
        public void Flatten(TreeNode2 root)
        {
            TreeNode2 curr = root;

            while (curr != null)
            {
                if (curr.left != null)
                {
                    // Find the rightmost node of the left subtree
                    TreeNode2 predecessor = curr.left;
                    while (predecessor.right != null)
                    {
                        predecessor = predecessor.right;
                    }

                    // Rewire connections
                    predecessor.right = curr.right;
                    curr.right = curr.left;
                    curr.left = null;
                }

                // Move to the next node
                curr = curr.right;
            }
        }
    }

    public class TreeNode2
    {
        public int val;
        public TreeNode2 left;
        public TreeNode2 right;
        public TreeNode2(int val = 0, TreeNode2 left = null, TreeNode2 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
