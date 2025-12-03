using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Easy
{
    /*
     
     Given head which is a reference node to a singly-linked list. The value of each node in the linked list is either 0 or 1. The linked list holds the binary representation of a number.

Return the decimal value of the number in the linked list.

The most significant bit is at the head of the linked list.

 

Example 1:


Input: head = [1,0,1]
Output: 5
Explanation: (101) in base 2 = (5) in base 10
Example 2:

Input: head = [0]
Output: 0
 

Constraints:

The Linked List is not empty.
Number of nodes will not exceed 30.
Each node's value is either 0 or 1.
     
     */
    public class ConvertBinaryNumberInaLinkedListToInteger
    {
        public int GetDecimalValue(ListNode head)
        {
            //Most Significant Bit is the Head of The List
            int result = 0;

            while (head != null)
            {
                //How this Shit translate to Maths
                //Funny Solution On how it is odne
                result = result * 2 + head.val;
                head = head.next;
            }

            return result;
        }
    }

    /*
     
     Why this works

Multiplying by 2 in decimal is equivalent to shifting bits left in binary.

Adding head.val places the new bit in the correct place.

Since we process from MSB → LSB, the result builds correctly without extra data structures. 


    The trick here is to simulate reading a binary number from left to right:

For example, for 1 → 0 → 1:

Start with result = 0

Read first 1 → result = (0 × 2) + 1 = 1

Read next 0 → result = (1 × 2) + 0 = 2

Read next 1 → result = (2 × 2) + 1 = 5

So, each step:


     */
}
