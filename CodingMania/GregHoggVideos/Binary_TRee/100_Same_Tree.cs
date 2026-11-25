using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.Binary_TRee
{
    /*
     
     
Code
Testcase
Test Result
Test Result
100. Same Tree
Easy
Topics
premium lock icon
Companies
Given the roots of two binary trees p and q, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

 

Example 1:


Input: p = [1,2,3], q = [1,2,3]
Output: true
Example 2:


Input: p = [1,2], q = [1,null,2]
Output: false
Example 3:


Input: p = [1,2,1], q = [1,1,2]
Output: false
 

Constraints:

The number of nodes in both trees is in the range [0, 100].
-104 <= Node.val <= 104
     */
    public class _100_Same_Tree
    {
        //Short answers Here

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            if (p.val != q.val) return false;

            return IsSameTree(p.Left, q.Left) && IsSameTree(p.Right, q.Right);
        }

        /*
         Why the order of the checks matters
-Both null first. If both are null, return true before anything else touches them.
-Then "either is null". At this point, if either one is null, it can't be both, because the previous line already handled that. So exactly one is null, which means the shapes differ.
-Only now read .val. Both are guaranteed non-null, so there's no crash.
         
         
         
         */


        public bool CompareTwoNode(TreeNode first, TreeNode second)
        {
            //Check the ordering of the And Conditon and the Or Codntion

            //Both are null here, So they match here both Empty
            if (first == null && second==null)
            {
                return true;
            }

            // Exactly one is Empty -> Shapes Differ
            if (first == null || second == null)
            {
                return false;
            }

            //Both Exist (Both values exist, so we check if the Values Match)
            if (first.val != second.val)
            {
                return false;
            }

            //USE the Children answers instead of ignoring them
           bool leftAnswer = CompareTwoNode(first.Left, second.Left);  //Keep the leftAnswer so you can resuse 
           bool rightAnswer = CompareTwoNode(first.Right, second.Right); //keep the rightAnswer

            return leftAnswer && rightAnswer;  //Comapre the both

        }



        /// <summary>
        /// My First attempt which is wrong, Kindly revuiew for me 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>

        public bool CompareTwoNodeSolaSolutuon(TreeNode first, TreeNode second)
        {


            if (first.val != second.val)
            {
                return false;
            }
            CompareTwoNodeSolaSolutuon(first.Left, second.Left); // you are throwing the Recusive Result away 
            CompareTwoNodeSolaSolutuon(first.Right, second.Right); //
            return true;

        }
    }
}
