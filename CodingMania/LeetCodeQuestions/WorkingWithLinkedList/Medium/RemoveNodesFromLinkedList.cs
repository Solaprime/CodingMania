using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium
{
    /*
     You are given the head of a linked list.

Remove every node which has a node with a greater value anywhere to the right side of it.

Return the head of the modified linked list.

 

Example 1:


Input: head = [5,2,13,3,8]
Output: [13,8]
Explanation: The nodes that should be removed are 5, 2 and 3.
- Node 13 is to the right of node 5.
- Node 13 is to the right of node 2.
- Node 8 is to the right of node 3.
Example 2:

Input: head = [1,1,1,1]
Output: [1,1,1,1]
Explanation: Every node has value 1, so no nodes are removed.
 

Constraints:

The number of the nodes in the given list is in the range [1, 105].
1 <= Node.val <= 105

     */
    class RemoveNodesFromLinkedList
    {
        public ListNode RemoveNodes(ListNode head)
        {
            head = Reverse(head);

            ListNode dummy = new ListNode(0, head);
            ListNode curr = head;
            ListNode prev = dummy;

            int maxSoFar = int.MinValue;

            while (curr != null)
            {
                if (curr.val >= maxSoFar)
                {
                    maxSoFar = curr.val;
                    prev = curr;
                }
                else
                {
                    prev.next = curr.next; // Remove current node
                }
                curr = curr.next;
            }

            return Reverse(dummy.next);
        }

        private ListNode Reverse(ListNode head)
        {
            ListNode prev = null, curr = head;
            while (curr != null)
            {
                ListNode next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }
    }
}
