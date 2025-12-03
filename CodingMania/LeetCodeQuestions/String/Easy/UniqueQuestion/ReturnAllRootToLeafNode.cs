using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.UniqueQuestion
{
    /*
     
     Given the root of a binary tree, return all root-to-leaf paths in any order.

A leaf is a node with no children.

 

Example 1:


Input: root = [1,2,3,null,5]
Output: ["1->2->5","1->3"]
Example 2:

Input: root = [1]
Output: ["1"]
 

Constraints:

The number of nodes in the tree is in the range [1, 100].
-100 <= Node.val <= 100

     
     */
    class ReturnAllRootToLeafNode
    {
        /*
         
           Given the Root of binary Tree, and you are asked to return 
        all root-to-leaf paths in any order

        Root -The Topmost node of the binary Tree (Starting Point)
        Leaf Node - a node that has no left or right Children

        Example 1

             1
            / \
           2   3
           \
             5


        So the root to leaf paths is

        1 → 2 → 5 → "1->2->5

        1 → 3 → "1->3"

        Final answer becomes
        ["1->2->5", "1->3"]


        Example 2
        Tree Structure
           1
        so we have only one path "1"

        output Final answer ["1"]

        How to Search it Depth-First Search(DFS) WE follow one path
        from root to a leaf before trying another 

        Recursiv Function carry the path as you traverse


         */
    }

    //So we using Depth-First Search(Recursive)
    
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val =0, TreeNode left= null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class BinaryTreePaths
    {
        //Starts the Traversal
        public IList<string> BinaryTreePathsMethod(TreeNode root)
        {
            //Intializes an empty List<strings> to hold the rsult
            List<string> result = new List<string>();

            //Check for null
            if (root == null)
            {
                return result;
            }

            //Call a Customethod to Explore the Tree,

            DFS(root, "", result);

            return result;
        }


        private void DFS(TreeNode node, string path, List<string> result)
        {
            //If node is null, return base Case
            if (node == null) return;

            //Build the path string

            //Add current Nodes, Value tothe path
            // if path is zero, so we just add the root node
            //first 
            if (path.Length == 0)
                path += node.val.ToString();

            //If path is not Zero, it means the root node as been added
            //so we just attach items here
            else
                path += "->" + node.val.ToString();

            // If it's a leaf node, add the path to the result
            //If the node is leaf (both left and right are null)
            if (node.left == null && node.right == null)
            {
                //add the path to result
                result.Add(path);
                return;
            }


            // Recursively traverse left and right child
            //else Recusrisevly Call DFS on the left child
            DFS(node.left, path, result);
            //Recursively call DFS ON THE rIGHT cHILD
            DFS(node.right, path, result);



            /*
             
                  1
                 / \
                2   3
                \
                 5

             
             
             The DFS would go like:

            Start at 1: path = "1"

            Go to left child 2: path = "1->2"

             Go to right child 5: path = "1->2->5" → Add to result

                 Backtrack

                 Go to right child 3: path = "1->3" → Add to result
             
             */
        }


    }
}
