using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium.Part3
{
    /*
     
     Given the head of a linked list, we repeatedly delete consecutive sequences of nodes that sum to 0 until there are no such sequences.

After doing so, return the head of the final linked list.  You may return any such answer.

 

(Note that in the examples below, all sequences are serializations of ListNode objects.)

Example 1:

Input: head = [1,2,-3,3,1]
Output: [3,1]
Note: The answer [1,2,1] would also be accepted.
Example 2:

Input: head = [1,2,3,-3,4]
Output: [1,2,4]
Example 3:

Input: head = [1,2,3,-3,-2]
Output: [1]
 

Constraints:

The given linked list will contain between 1 and 1000 nodes.
Each node in the linked list has -1000 <= node.val <= 1000.
     */
    class RemoveZeroSumConsecutiveNodeFromLinkedList
    {
        public ListNode RemoveZeroSumSublists(ListNode head)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            Dictionary<int, ListNode> prefixMap = new Dictionary<int, ListNode>();
            int prefixSum = 0;
            ListNode current = dummy;

            // First pass: record the latest node with a given prefix sum
            while (current != null)
            {
                prefixSum += current.val;
                prefixMap[prefixSum] = current;
                current = current.next;
            }

            // Second pass: skip nodes between duplicate prefix sums
            prefixSum = 0;
            current = dummy;
            while (current != null)
            {
                prefixSum += current.val;
                current.next = prefixMap[prefixSum].next;
                current = current.next;
            }

            return dummy.next;
        }
    }
}
