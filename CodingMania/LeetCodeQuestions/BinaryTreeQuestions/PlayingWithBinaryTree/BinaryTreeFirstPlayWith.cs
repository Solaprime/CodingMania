using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.BinaryTreeQuestions.PlayingWithBinaryTree
{
    /// <summary>
    /// Playing With Binary tREE fLOW...
    /// </summary>
    public class BinaryTreeFirstPlayWith
    {
        //key Components
        //Value stored in the Node, it has a public gETTER
        //meANING YOU CAN access the Value from Outside the Class
        //but it can only be set within the ClaSS cONSTRUCTOR
        public int Value { get; }

        //pUBLIC gET, yOU CAN READ THEM FROM oUTSIDE THE cLASS
        //bUT THE privateSet you can only set them Inside the Class 


        //rEPRESNNT THE lEFT CHILDREN OF THE cURRENT nODE IN THE bINARY TREE
        public BinaryTreeFirstPlayWith Left { get; private set; }

        //rEPRESNNT THE RIGHT CHILDREN OF THE cURRENT nODE IN THE bINARY TREE

        public BinaryTreeFirstPlayWith Right { get; private set; }

        //sET THE value foR ABINARY tREE
        public BinaryTreeFirstPlayWith(int value)
        {
            Value = value;
        }
         
        //iNSERT NEW LEFTcHILD WITH THE sPECIFIED vALUE
        public BinaryTreeFirstPlayWith InsertLeft(int leftValue)
        {
            Left = new BinaryTreeFirstPlayWith(leftValue);
            return Left;
        }

        //iNSERT NEW RIGHT cHILD
        public BinaryTreeFirstPlayWith InsertRight(int rightValue)
        {
            Right = new BinaryTreeFirstPlayWith(rightValue);
            return Right;
        }



        //Playing with node 
        //Flow
        //HOW TO construct NODE

        /*

                          50
                        /     \
                      17        72
                      /  \       / \
                    12    23    54 76
                   /\      /     \
                  9 14    19      67





        BinaryTreeFirstPlayWith root = new BinaryTreeFirstPlayWith(50);

        var node2 = root.InsertLeft(17);
        var node3 = root.InsertRight(72);

        var node4 = node2.InsertLeft(12);
        var node5 = node2.InsertRight(23);

        var node6 = node3.InsertLeft(54);
        var node7 = node3.InsertRight(76);

        var node8 = node4.InsertLeft(9);
        var node9 = node4.InsertRight(14);

        var node10 = node5.InsertLeft(19);


        var node11 = node6.InsertRight(67);


        *******************************
        (***************************)
        (***************************)
        (***************************)
        //tREE tRAVERsAL IS THE process of visiting all the  Children in a tree


        Sample Question
         

        
                          A
                        /     \
                        B        C
                      /  \       / \
                      D   E     f   g

        TreTraversal Method
          Inorder
        PostOrder 
        PreOrder


        ****For Inorder Traversal
        *
        Left > Root >Right
        //Visit the LeftMost root then go back to the Root then to the RightMost ROOT
        D -B-E-A-F-C-G



        ***fOR pOSToRDER
        Left -> Right -> root

        D -E-b-f-g-c-a
        tHAT weird shit we did in cpe

        *** For preOrder
          Use to create a copy of a tree
        root>left >right
        A B D E C F G

         */


    }
}

/*
 questions
Differnece between 


binary Tree - Each Node has maximum of 2 Children
Tree - TreeNode
Root- node at the top
Traversal - in Tress
leaf- a node with no Children
branch or path - if you take your root node an you Leaf node and all the nodes you  passed through to get to the Leaf Node we call that a branch


 Traversal Orders - Let SAY for a reason you wnat to travel a node or look up item in a node for whatever reason that is Called Traversal, the means by which you travel is called Traversal Order and to determine
a particular traversal order it depends
you can Iterative or Recursive apporach when Iteratinng the Tree
Branching Recursion

branching Recursion -Your call stack is the Same as your tree Order

Binary Search Tree - IF BAlanced gives us  O(lOG N)  similar to the way binary Dearch on a sorted array gives
O(lOG N)
binary Search Tree Follows the Binary Tree approach  but with one more additonal rule
(Every nodes value must be more than the Left Child value and Less than that the Right CHILD vALUE)

 e.g
     3
    /  \
 1       5

the greater than Left , less than Right rule needs to be true throughout the Tree

 e.g
     3
    /  \
 1       5
       /
     2
the above is not a binary SeARCH tree cause with respect t0 5 it IS balance, 
but 2 is on the Right HandSide of 3. So it is not balanced when we look at it Overall

We have concpets and aLGORITHMS FOR vALIDATING a Binary Searcg Tree

Finding a values in Bst is by traversing towrds it you are Loking fot 8 you knwow 8 is going to be on the
right handsIDE OF THE RROT

Binary Search Tree is really efficent for Storing Ordere Data

n/b  if a tree has Just one Node then it is stil a binary Tree
the only condiiton for a binary tree is that it musst not have more than  2 Children


Stric or Proper  binary Tree - In a strict binary tree each Node can have either 2 or 0 Children


Complete Biary Tree - All levels Except possible the last level  are Completely filled and all nodes are left as possible

Basically try to Fill up the left first

Perfrct Bnary Tree- Perfect Binar tree all levels are Comletely Filled


Tree traversal - Is the process of Visiting all the Node in a Tree

Given the Sample Node above
           A
          / \
         B   C
        /\   /\
      D   E  F G
Inorder-  left-root-right
 So we use Recursion to Visit as many left node as wee can, followed by the Root node then the Right Node
 So A - B-D SINCE WE GET TO d which is the Last go back to B
A-B-D-B-E.
so witht this we can not go left anymore so we Go back to the root wich is A
then we go right
A-C 
when we get to C we go to Left as priority We go to F 
THEN f IS LEAF GO BACK TO  c THEN To G



fINAL aLL STEPS

left -> root -> right
D->B ->E ->A ->F ->C->G


Post-ORDER- 
Goes from left->right -> root
go to the left children then the right children then the root
so go from a then get to D

nORAML cPE sHIT
D -> E ->B ->F ->g ->C ->A


pre-Order-
A-> b->D ->E -> C->f ->G

root->left ->right
 */

//so they are doing Secondary Check