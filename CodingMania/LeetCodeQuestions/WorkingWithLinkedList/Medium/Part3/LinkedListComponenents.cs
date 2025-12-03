using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium.Part3
{
    class LinkedListComponenents
    {
        public int NumComponents(ListNode head, int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>(nums);
            int count = 0;
            ListNode current = head;

            while (current != null)
            {
                if (numSet.Contains(current.val) &&
                    (current.next == null || !numSet.Contains(current.next.val)))
                {
                    count++;
                }
                current = current.next;
            }

            return count;
        }
    }
}
