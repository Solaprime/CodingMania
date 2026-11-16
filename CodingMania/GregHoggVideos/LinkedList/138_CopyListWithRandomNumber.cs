using CodingMania.LeetCodeQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.LinkedList
{
    /*
     138. Copy List with Random Pointer
Medium
Topics
premium lock icon
Companies
Hint
A linked list of length n is given such that each node contains an additional random pointer, which could point to any node in the list, or null.

Construct a deep copy of the list. The deep copy should consist of exactly n brand new nodes, where each new node has its value set to the value of its corresponding original node. Both the next and random pointer of the new nodes should point to new nodes in the copied list such that the pointers in the original list and copied list represent the same list state. None of the pointers in the new list should point to nodes in the original list.

For example, if there are two nodes X and Y in the original list, where X.random --> Y, then for the corresponding two nodes x and y in the copied list, x.random --> y.

Return the head of the copied linked list.

The linked list is represented in the input/output as a list of n nodes. Each node is represented as a pair of [val, random_index] where:

val: an integer representing Node.val
random_index: the index of the node (range from 0 to n-1) that the random pointer points to, or null if it does not point to any node.
Your code will only be given the head of the original linked list.

 

Example 1:


Input: head = [[7,null],[13,0],[11,4],[10,2],[1,0]]
Output: [[7,null],[13,0],[11,4],[10,2],[1,0]]
Example 2:


Input: head = [[1,1],[2,1]]
Output: [[1,1],[2,1]]
Example 3:



Input: head = [[3,null],[3,0],[3,null]]
Output: [[3,null],[3,0],[3,null]]
 

Constraints:

0 <= n <= 1000
-104 <= Node.val <= 104
Node.random is null or is pointing to some node in the linked list.
     
     */
    public class _138_CopyListWithRandomNumber
    {

        /*
         Question
         Each Node has 3 Fields ,- a value, a next pointer(to the Following Node and a 
        random ointer Which can point to any Node in the list)

        Solution - bulid a deep Copy: Brand New nodes
        Such that the Next of each Node is only pointing to the Random

      

        Question
        [[7,null],[13,0],[11,4],[10,2],[1,0]]

        take the First Node - Index 0, value 7, node.Next = 13, Node.Random = null
        take the Second Node - Index 1, value 13, node.Next = 11, Node.Random Is pointing to Index 0 which is the First Node with Value 7
        take the third Node - Index 2, value 11, node.Next = 10, Node.Random is pointing to the 4th Node with Value 1
        take the Fourth Node - Index 3, value 10, node.Next = 1, Node.Random = 11 which is the Third Node with value 11
        take the Fifth Node - Index 4, value 1, node.Next = 13, Node.Random = null

        Like Like that 

          In Example 1, the node with value 11 has random pointing to index 4 (the node with value 1). In the copy, the new 11 must point to the new 1, not the old one.

Why this is tricky: copying the next chain is easy, because you just walk forward.
        But when you copy a node, its random might point to a node you haven’t created yet, such as node 11 pointing ahead to node 1. You can’t link to something that doesn’t exist yet.


        Means To Solve this - PPPPPPPPPPPOPPP

        PASS 1 - Create a copy of Every Node (Value only) and Record each Pair in the Dictionary.
        Pass 2- Now that every Copy Exisit wire up next and Random by Looking Up the Copies in the dICTIONARY

         */

        public NodeWithRandom CopyRandomList(NodeWithRandom head)
        {
            if(head == null)
            {
                return null;
            }

            Dictionary<NodeWithRandom, NodeWithRandom> map = new Dictionary<NodeWithRandom, NodeWithRandom>();

            //Create every Copy, Values only
            NodeWithRandom current = head;

            while (current != null)
            {
                map[current] = new NodeWithRandom(current.val);
                current = current.next;
               
            }

            //Pass 2 Connec next AND random Pointers
            current = head;
            while (current != null)
            {
                NodeWithRandom copy = map[current];
                copy.next = current.next == null ? null : map[current.next];
                copy.random = current.random == null ? null : map[current.random];
                current = current.next;

            }

            return map[head];


        }
    }


    public class NodeWithRandom
    {
        public int val;
        public NodeWithRandom next;
        public NodeWithRandom random;

        public NodeWithRandom(int val)
        {
                
        }
    }
}
