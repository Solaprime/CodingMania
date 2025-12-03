using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium.Part2
{
    /*
     Given the head of a singly linked list where elements are sorted in ascending order, convert it to a height-balanced binary search tree.

 

Example 1:


Input: head = [-10,-3,0,5,9]
Output: [0,-3,9,-10,null,5]
Explanation: One possible answer is [0,-3,9,-10,null,5], which represents the shown height balanced BST.
Example 2:

Input: head = []
Output: []
 

Constraints:

The number of nodes in head is in the range [0, 2 * 104].
-105 <= Node.val <= 105
     */
    class ConvertedSortedListToBinaryTree
    {
        public TreeNodeFlow SortedListToBST(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return new TreeNodeFlow(head.val);

            // Find the middle node (and the node before it to break the list)
            ListNode prev = null, slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            // Disconnect the left half from the middle
            if (prev != null) prev.next = null;

            TreeNodeFlow root = new TreeNodeFlow(slow.val);

            // Left subtree
            root.left = (slow == head) ? null : SortedListToBST(head);

            // Right subtree
            root.right = SortedListToBST(slow.next);

            return root;
        }
    }

    public class TreeNodeFlow
    {
        public int val;
        public TreeNodeFlow left;
        public TreeNodeFlow right;
        public TreeNodeFlow(int val = 0, TreeNodeFlow left = null, TreeNodeFlow right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}
