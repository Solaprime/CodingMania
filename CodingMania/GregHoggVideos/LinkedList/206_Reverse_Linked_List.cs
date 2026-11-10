using CodingMania.LeetCodeQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.LinkedList
{
    /*
     Given the head of a singly linked list, reverse the list, and return the reversed list.

 

Example 1:


Input: head = [1,2,3,4,5]
Output: [5,4,3,2,1]
Example 2:


Input: head = [1,2]
Output: [2,1]
Example 3:

Input: head = []
Output: []
 

Constraints:

The number of nodes in the list is the range [0, 5000].
-5000 <= Node.val <= 5000
 

Follow up: A linked list can be reversed either iteratively or recursively. Could you implement both?



    //You can Use Iterative or Recursive apprach 
     
     */
    public class _206_Reverse_Linked_List
    {

        public ListNode ReverseIterative(ListNode head)
        {

            //Greg Hogg Cocenpt
            /*
             * Questions
                [1, -> 2, -> 3,->4, ->5]
            answer
                [5,4,3,2,1]

            --But      [1, -> 2, -> 3,->4, ->5] in Reverse Foramt is actualy   [1, <- 2, <-3,<-4, <-5] 
            So you just change the Direction of the arrow 
            or we will need to variable to track the (Current Varaible and The Previoud VARAIBLE)
             */

            ListNode prev = null;

            ListNode current = head;

            while(current != null)
            {
                ListNode nextNode = current.next;

                current.next = prev;

                //You are attaching to the  prev and Building it Up with Current 
                prev = current;

                current= nextNode;   
            }

            return prev;
        }
    }
}
