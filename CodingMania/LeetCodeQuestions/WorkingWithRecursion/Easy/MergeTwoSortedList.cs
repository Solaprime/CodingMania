using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithRecursion.Easy
{
    /*
     qUESTION 21 


     You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

 

Example 1:


Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
Example 2:

Input: list1 = [], list2 = []
Output: []
Example 3:

Input: list1 = [], list2 = [0]
Output: [0]
 

Constraints:

The number of nodes in both lists is in the range [0, 50].
-100 <= Node.val <= 100
Both list1 and list2 are sorted in non-decreasing order.
     */
    public class MergeTwoSortedList
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            
            //Base cases: if one list is empty, return the other
            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }

            //Choose the smaller head node, splice it to the result
            //and recursively merge the rest
            if (list1.val  <= list2.val)
            {
                //so list1 is Comes First cal merge again on list.next
                list1.next = MergeTwoLists(list1.next, list2);
                //So list1 Comes First,
                return list1;
            }

            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }

        }



        //Iterative Apporach


        public ListNode MergeTwoListsIterative(ListNode list1, ListNode list2)
        {
            // Create a dummy node to simplify handling of head pointer.
            ListNode dummy = new ListNode(-1);
            ListNode current = dummy;

            // While neither list is empty, choose the smaller node.
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }

                // Move forward in the merged list
                current = current.next;
            }

            // At this point, one of the lists may still have nodes left.
            // Just connect the remainder directly.
            if (list1 != null)
                current.next = list1;
            else
                current.next = list2;

            // Return merged list, skipping the dummy node
            return dummy.next;
        }
    }

    /*
     We must return the head of a sorted list formed by stitching together the nodes of list1 and list2, both already sorted in non-decreasing order.


    Base cases

If list1 is null, all nodes must come from list2, so return list2.

If list2 is null, return list1.
These stop the recursion and correctly handle empty lists (e.g., [] + [] → [], [] + [0] → [0]).


    Inductive step (the recursive choice)
Compare the current head values:

If list1.val <= list2.val:

The next node in the merged list must be list1’s head (because it is the smaller/equal value).

We splice by setting list1.next to the merged result of the rest of list1 (list1.next) and all of list2.

Return list1 as the current head.

Otherwise, do the symmetric operation using list2.

This preserves sorted order because at each step we pick the smallest available node and then recursively solve the smaller problem.


    Call-stack trace (quick example)

For list1 = [1,2,4], list2 = [1,3,4]:

Compare 1 (list1) and 1 (list2) → take list1’s 1.

list1.next = MergeTwoLists([2,4], [1,3,4])

Now compare 2 and 1 → take list2’s 1.

list2.next = MergeTwoLists([2,4], [3,4])

Compare 2 and 3 → take list1’s 2.

list1.next = MergeTwoLists([4], [3,4])

Compare 4 and 3 → take list2’s 3.

list2.next = MergeTwoLists([4], [4])

Compare 4 and 4 → take list1’s 4 (either is fine on equality).

list1.next = MergeTwoLists([], [4])

Base case: list1 is empty → return [4]

Unwinding the stack stitches pointers in order, yielding [1,1,2,3,4,4].
     */


    /*
      Helper Function TO tEST

    public static class ListHelpers
{
    public static ListNode FromArray(int[] arr)
    {
        ListNode dummy = new ListNode();
        var tail = dummy;
        foreach (var x in arr)
        {
            tail.next = new ListNode(x);
            tail = tail.next;
        }
        return dummy.next;
    }

    public static int[] ToArray(ListNode head)
    {
        var list = new List<int>();
        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }
        return list.ToArray();
    }
}

// Example usage:
var l1 = ListHelpers.FromArray(new[] { 1, 2, 4 });
var l2 = ListHelpers.FromArray(new[] { 1, 3, 4 });
var merged = new Solution().MergeTwoLists(l1, l2);
// ListHelpers.ToArray(merged) -> [1, 1, 2, 3, 4, 4]

     
     
     */
}
