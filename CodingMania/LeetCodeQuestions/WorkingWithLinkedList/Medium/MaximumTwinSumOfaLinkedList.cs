using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium
{
    class MaximumTwinSumOfaLinkedList
    {
        public int PairSum(ListNode head)
        {
            // Step 1: Find middle
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // Step 2: Reverse second half
            ListNode prev = null;
            while (slow != null)
            {
                ListNode next = slow.next;
                slow.next = prev;
                prev = slow;
                slow = next;
            }


            // Step 3: Traverse both halves to calculate max twin sum
            int maxSum = 0;
            ListNode first = head;
            ListNode second = prev;
            while (second != null)
            {
                maxSum = Math.Max(maxSum, first.val + second.val);
                first = first.next;
                second = second.next;
            }

            return maxSum;
        }

    }
}
