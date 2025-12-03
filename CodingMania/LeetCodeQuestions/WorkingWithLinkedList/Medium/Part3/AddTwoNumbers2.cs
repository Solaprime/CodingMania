using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium.Part3
{
    /*
     
     You are given two non-empty linked lists representing two non-negative integers. The most significant digit comes first and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

 

Example 1:


Input: l1 = [7,2,4,3], l2 = [5,6,4]
Output: [7,8,0,7]
Example 2:

Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [8,0,7]
Example 3:

Input: l1 = [0], l2 = [0]
Output: [0]
 

Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.
 

Follow up: Could you solve it without reversing the input lists?
     */
    class AddTwoNumbers2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            Stack<int> s1 = new Stack<int>();
            Stack<int> s2 = new Stack<int>();

            // Push all values of l1 and l2 into their respective stacks
            while (l1 != null)
            {
                s1.Push(l1.val);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                s2.Push(l2.val);
                l2 = l2.next;
            }

            ListNode result = null;
            int carry = 0;

            // While we have digits or carry
            while (s1.Count > 0 || s2.Count > 0 || carry > 0)
            {
                int val1 = s1.Count > 0 ? s1.Pop() : 0;
                int val2 = s2.Count > 0 ? s2.Pop() : 0;

                int sum = val1 + val2 + carry;
                carry = sum / 10;

                ListNode newNode = new ListNode(sum % 10);
                newNode.next = result;
                result = newNode;
            }

            return result;
        }
    }
}
