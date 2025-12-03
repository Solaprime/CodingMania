using CodingMania.LeetCodeQuestions.BinaryTreeQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.BackTrackingQuestions.Easy
{
    /*
     
     Given the root of a binary tree, return all root-to-leaf paths in any order.

A leaf is a node with no children.

 

Example 1:

           1
      /           \
      2             3
        \
        5
Input: root = [1,2,3,null,5]
Output: ["1->2->5","1->3"]
Example 2:

Input: root = [1]
Output: ["1"]
 

Constraints:

The number of nodes in the tree is in the range [1, 100].
-100 <= Node.val <= 100
     */
    class BinaryTreePaths
    {
        public IList<string> BinaryTreePathsSolution(TreeNode root)
        {
            var result = new List<string>();
            if (root == null) return result;

            Backtrack(root, new List<int>(), result);
            return result;
        }

        private void Backtrack(TreeNode node, List<int> path, List<string> result)
        {
            if (node == null) return;

            // Step 1: Choose (add this node to path)
            path.Add(node.val);

            // Step 2: If it's a leaf, add to result
            if (node.left == null && node.right == null)
            {
                result.Add(string.Join("->", path));
            }
            else
            {
                // Step 3: Explore left & right
                Backtrack(node.left, path, result);
                Backtrack(node.right, path, result);
            }

            // Step 4: Undo choice (backtrack)
            path.RemoveAt(path.Count - 1);
        }
    }
}
