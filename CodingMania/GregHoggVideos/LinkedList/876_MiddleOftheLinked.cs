using CodingMania.LeetCodeQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.LinkedList
{
    /*
     876. Middle of the Linked List
Easy
Topics
premium lock icon
Companies
Given the head of a singly linked list, return the middle node of the linked list.

If there are two middle nodes, return the second middle node.

 

Example 1:


Input: head = [1,2,3,4,5]
Output: [3,4,5]
Explanation: The middle node of the list is node 3.
Example 2:


Input: head = [1,2,3,4,5,6]
Output: [4,5,6]
Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.
 

Constraints:

The number of nodes in the list is in the range [1, 100].
1 <= Node.val <= 100
     
     */
    public class _876_MiddleOftheLinked
    {
        /*
           ny Understanding
           6/2 = 3 - So the Fast pointer Moves Twice in 3 place before getting to the End of the Node
           Slow poimter Moves 1 *3 = 3 times - you can see the Comparison

         5/2 = 2
        1 *2 = 2

        but actual flow you are Starting from the First Node which is the head  so
        5/2  - For fast Node you will iterate to 5th element (lAST element) 1 + 4
         1 + 2*1 = 3 -(For Slow pointer you will iterate to the 3rd Element which will
        be the Middle)

         */
        public ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;  // Moves 1 Step
                fast = fast.next.next;  //Moves 2 Step
            }

            return slow;
        }
    }
}
