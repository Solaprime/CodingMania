using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithRecursion.Easy
{
    /*
     Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.

 

Example 1:


Input: head = [1,2,6,3,4,5,6], val = 6
Output: [1,2,3,4,5]
Example 2:

Input: head = [], val = 1
Output: []
Example 3:

Input: head = [7,7,7,7], val = 7
Output: []
 

Constraints:

The number of nodes in the list is in the range [0, 104].
1 <= Node.val <= 50
0 <= val <= 50
     */
    class _203_RemoveLinkedListElements
    {

        public ListNode RecurSiveApproach(ListNode head, int val)
        {
            //When using Recursive they use the same Approach or method
            if (head == null)
            {
                return null;
            }

            //this head.next is already callling the next elment
            //similar to While LOOP
            head.next = RecurSiveApproach(head.next, val);

            // Then, decide what to do with the current node

            //if (head.Value == val)
            //{
            //    // Remove this node by skipping it
            //    return head.Next;
            //}
            //else
            //{
            //    // Keep this node
            //    return head;
            //}
            return head.val == val ? head.next : head;
        }

        public static ListNode IterativeApproach(ListNode head, int val)
        {
            // Dummy node to handle edge cases (like removing head node(s))
            //Dummy will alwasy be at the Head
            //recall as you iterate the pointer is no loner at the head
            //Dummy Will always be at the Head
            ListNode dummy = new ListNode(0, head);
            //Current Vaible used to iterate
            //Since current is 0 SO YOU START FROM nEXT
            //to pick up items in the head and Start iteration from thir
            ListNode current = dummy;

            while (current.next != null)
            {
                if (current.next.val == val)
                {
                    // Skip the node
                    current.next = current.next.next;
                }
                else
                {
                    // Move forward
                    current = current.next;
                }
            }

            return dummy.next; // New head
        }


    }
}
