using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium.Part2
{
    /*
     You are given the head of a non-empty linked list representing a non-negative integer without leading zeroes.

Return the head of the linked list after doubling it.

 

Example 1:


Input: head = [1,8,9]
Output: [3,7,8]
Explanation: The figure above corresponds to the given linked list which represents the number 189. Hence, the returned linked list represents the number 189 * 2 = 378.
Example 2:


Input: head = [9,9,9]
Output: [1,9,9,8]
Explanation: The figure above corresponds to the given linked list which represents the number 999. Hence, the returned linked list reprersents the number 999 * 2 = 1998. 
 

Constraints:

The number of nodes in the list is in the range [1, 104]
0 <= Node.val <= 9
The input is generated such that the list represents a number that does not have leading zeros, except the number 0 itself.
     */
    class DoubleANumberRepresentedasaLinkedList
    {
        public ListNode DoubleIt(ListNode head)
        {
            head = ReverseList(head);

            ListNode curr = head;
            int carry = 0;

            while (curr != null)
            {
                int doubled = curr.val * 2 + carry;
                curr.val = doubled % 10;
                carry = doubled / 10;

                if (curr.next == null && carry > 0)
                {
                    curr.next = new ListNode(carry);
                    carry = 0;
                    break;
                }

                curr = curr.next;
            }

            return ReverseList(head);
        }

        private ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                ListNode nextTemp = head.next;
                head.next = prev;
                prev = head;
                head = nextTemp;
            }
            return prev;
        }
    }
}
