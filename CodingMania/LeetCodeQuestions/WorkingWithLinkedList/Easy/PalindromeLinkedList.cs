using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Easy
{
    /*
       
    Solve thesee 

Given the head of a singly linked list, return true if it is a palindrome or false otherwise.

 

Example 1:


Input: head = [1,2,2,1]
Output: true
Example 2:


Input: head = [1,2]
Output: false
 

Constraints:

The number of nodes in the list is in the range [1, 105].
0 <= Node.val <= 9
 

Follow up: Could you do it in O(n) time and O(1) space?
     
     */
    public class PalindromeLinkedList
    {

        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return true;
            }

            // 1Find Middle of the List
            ListNode slow = head;
             ListNode  fast = head;


            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }


            //2 Revsese SeconD half

            ListNode secondHalf = Reverse(slow);


            //3. Compare both halves
            ListNode firstHalf = head;
            ListNode reversedHalf = secondHalf;

            while (reversedHalf != null)
            {
                if (firstHalf.val != reversedHalf.val)
                {
                    return false;
                }

                firstHalf = firstHalf.next;
                reversedHalf = reversedHalf.next;
            }


            return true;
        }

        private ListNode Reverse(ListNode head)
        {
            ListNode prev = null;
            ListNode currenet = head;

            while (currenet != null)
            {
                ListNode nextTemp = currenet.next;
                currenet.next = prev;
                prev = currenet;
                currenet = nextTemp;
            }

            return prev;
                
        }
    }
}
