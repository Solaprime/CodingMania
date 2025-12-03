using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium.Part2
{
    /*
     Given a linked list, swap every two adjacent nodes and return its head. You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)

 

Example 1:

Input: head = [1,2,3,4]

Output: [2,1,4,3]

Explanation:



Example 2:

Input: head = []

Output: []

Example 3:

Input: head = [1]

Output: [1]

Example 4:

Input: head = [1,2,3]

Output: [2,1,3]

 

Constraints:

The number of nodes in the list is in the range [0, 100].
0 <= Node.val <= 100
     */
    class SwapNodesInPair
    {
        public ListNode SwapPairs(ListNode head)
        {
            // Create a dummy node that points to the head
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            // prev is used to connect the previous part of the list with the swapped pair
            ListNode prev = dummy;

            while (prev.next != null && prev.next.next != null)
            {
                // Identify the two nodes to be swapped
                ListNode first = prev.next;
                ListNode second = first.next;

                // Swapping the two nodes
                first.next = second.next;
                second.next = first;
                prev.next = second;

                // Move prev forward to the next pair
                prev = first;
            }

            return dummy.next;
        }
    }
}
