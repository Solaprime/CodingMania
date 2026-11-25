using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.Binary_TRee
{
    public class Core_Binary_Tree_Explanation
    {
        //Build a sample Treenode
        /*
         
        1          ← root (level 0)
       / \
      2   3        ← level 1
     / \   \
    4   5   6      ← level 2 (4, 5, 6 are leaves)


        //root - the top node, with no parent -- 1
        //parent/Child - a node and thenodes directly below it --2 is the parent of 4 and 5
        //leaf - a node with no children-- 4, 5, and 6
        //subtree - a node plus everything below it - the subtreet rooted at 2 is {2,4,5}
        //edge - the link between a parent and a child 1-2 is a an Edge
        //Depth of a node - edges from the root down to it depth of 5 == 2
        //Height of a tree - edges(or nodes ) on the longest root-to-leaf-pATH 2 EDGES OR 3 NODES

        this is how leetCode writes a tree as an array 
        root = [1,2,3,4,5,null,6]
        the arrat list nodes level by level, left to right with null marking a missing child
        Level 0:  1
Level 1:  2, 3
Level 2:  4, 5, (null = 3 has no left child), 6


        another Example
        [3,9,20,null,null,15,7]:
      3
     / \
    9   20
       /  \
      15   7


  types of binary tree you will hear about
  full - Every node has 0 or 2 children never exactly 1
  complete - Every level is full except the possibly the last, which fills from the left used by heaps
  perfect - Every level is completely full 
  balanced- for every node, the left and right subtree heights differ by at most 1
  BST(Binary Search Tree) - For every node, evertyhing in the left subtree is smaller, everything in the right subtree is larger      

         */
         public TreeNode CreateTree()
         {
            TreeNode root1 = new TreeNode(1);
            root1.Left = new TreeNode(2);
            root1.Right = new TreeNode(3);
            root1.Left.Left = new TreeNode(4);
            root1.Left.Right = new TreeNode(5);
            root1.Right.Right =new TreeNode(6);
            return root1;

         }

        /*Traversalssssssssss
           Most tree problem come down to visting every node in a partivular order. ther are two familes

        DFS - Depth-First Search (DFS): go deep before going wide ,

        DFS follows one branch all the way down before backing up, There are three Version, which differ only in when 
        you process the Current Node comparred with its Children

        PreOrder -Node, left, right   (how to memorize node comes pre(before))
        InOrder -left, node, right   (how to memorize node comes in the Middle))
        PostOrder -left, right, node   (how to memorize node comes post(after))


         */

        /*
         
            //the three Function are identical except for where the Console.WriteLine Sits
        1
       / \
      2   3
     / \   \
    4   5   6
         
         Traversal               	Output
        Preorder	               1 2 4 5 3 6
        Inorder	                   4 2 5 1 3 6
        Postorder	               4 5 2 6 3 1
         */

        //PreOrder Flow
        /*
          When to use preOrder -Parent must be handles before its Children, Such as Copying a tree ot passing information down
        for example("The path so far")


         */
        public void PreOrder(TreeNode node)
        {
            //Console is simulating the Processing Flow
            //Base:Case: Empty tree, nothing to do
            if (node == null)
            {
                return;
            }
            Console.WriteLine("This is the Pre_Order Receursive Flow Here");
            //Process the Current Val of Node___
            Console.WriteLine(node.val + "  "); //Process Node First
            PreOrder(node.Left);  
            PreOrder(node.Right);
        }

        //in_Order 
        /*
           
         InOrder: On  aBST, inorder visit values in sorted order
         */
        public void InOrder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine("This is the In_Order Flow Recursive Here");
            InOrder(node.Left);
            //Process the Current Val the Current Node val in the middle of left and Right
            Console.WriteLine(node.val + "  "); // Process node in the Middle
            InOrder(node.Right);

        }

        /*
          PostOrder : When a node need needs answerd from it children first, Such as height, size or
        "is this subbTree balances" information flows up. this is the Most Common one in interview problems
         */

        public void PostOrder(TreeNode node)
        {
            if(node == null)
            {
                return;
            }
            Console.WriteLine("This is the Post_Order Recursive Flow Here");
            PostOrder(node.Left);
            PostOrder(node.Right);
            //Process the Current Node Last after Calling the left and right
            Console.WriteLine(node.val + "  "); //Process Node last
        }


        /*
         Breadt-First Search (BFS): Lvel by level
        BFS visits the tree one level at a time. top to bottom,Left to right , it uses a queue(First in, First out)

        Use BFS when the problem mentions levels, “closest”, “shortest path”, or “what you see from the right/left side”.
         */

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;       // nodes on THIS level
                var level = new List<int>();

                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode node = queue.Dequeue();
                    level.Add(node.val);

                    if (node.Left != null) queue.Enqueue(node.Left);
                    if (node.Right != null) queue.Enqueue(node.Right);
                }

                result.Add(level);
            }

            return result;

        }
        // For the example tree, this returns [[1], [2, 3], [4, 5, 6]].


        /*
          Recursion Flow


        6. How to think recursively about trees

This is the most important skill for tree problems. The pattern is:

Base case: what’s the answer for an empty tree (null)?
Trust the recursion: assume your function already works on node.left and node.right.
Combine: use those two answers plus the current node to build this node’s answer.
         
         */

        /*
         
         8. Recognizing what a problem needs
The problem asks about…	Reach for
height, depth, size, balance, diameter	postorder DFS (children first, combine upward)
something that depends on the path from the root	preorder DFS (pass information down as a parameter)
a BST in sorted order, kth smallest, validating a BST	inorder DFS
levels, a right/left side view, the nearest node	BFS with a queue
comparing two trees	DFS on both trees at the same time
         
         */

    }

    public class TreeNode
    {
        public int val;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int val =0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            Left = left;
            Right = right;
        }
    }
}
