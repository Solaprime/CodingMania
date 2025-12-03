using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium.Part3
{
    /*
     You are given the head of a linked list with n nodes.

For each node in the list, find the value of the next greater node. That is, for each node, find the value of the first node that is next to it and has a strictly larger value than it.

Return an integer array answer where answer[i] is the value of the next greater node of the ith node (1-indexed). If the ith node does not have a next greater node, set answer[i] = 0.

 

Example 1:


Input: head = [2,1,5]
Output: [5,5,0]
Example 2:


Input: head = [2,7,4,3,5]
Output: [7,0,5,5,0]
 

Constraints:

The number of nodes in the list is n.
1 <= n <= 104
1 <= Node.val <= 109
     */
    class NextGreaterNodeInLinkedList
    {
        public int[] NextLargerNodes(ListNode head)
        {
            List<int> values = new List<int>();
            while (head != null)
            {
                values.Add(head.val);
                head = head.next;
            }

            int n = values.Count;
            int[] result = new int[n];
            Stack<int> stack = new Stack<int>(); // stores indices

            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && values[i] > values[stack.Peek()])
                {
                    int idx = stack.Pop();
                    result[idx] = values[i];
                }
                stack.Push(i);
            }

            return result;
        }
    }
}
