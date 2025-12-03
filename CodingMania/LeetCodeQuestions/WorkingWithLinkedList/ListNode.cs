using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList
{
      public     class ListNode
    {
      
            public int val;   // Valued stopred in the node
            public ListNode next;  // Pointer to the next node

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
    }
}
