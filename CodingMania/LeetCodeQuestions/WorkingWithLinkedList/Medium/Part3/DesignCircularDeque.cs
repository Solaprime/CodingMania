using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium.Part3
{
    /*
     
     Design your implementation of the circular double-ended queue (deque).

Implement the MyCircularDeque class:

MyCircularDeque(int k) Initializes the deque with a maximum size of k.
boolean insertFront() Adds an item at the front of Deque. Returns true if the operation is successful, or false otherwise.
boolean insertLast() Adds an item at the rear of Deque. Returns true if the operation is successful, or false otherwise.
boolean deleteFront() Deletes an item from the front of Deque. Returns true if the operation is successful, or false otherwise.
boolean deleteLast() Deletes an item from the rear of Deque. Returns true if the operation is successful, or false otherwise.
int getFront() Returns the front item from the Deque. Returns -1 if the deque is empty.
int getRear() Returns the last item from Deque. Returns -1 if the deque is empty.
boolean isEmpty() Returns true if the deque is empty, or false otherwise.
boolean isFull() Returns true if the deque is full, or false otherwise.
 

Example 1:

Input
["MyCircularDeque", "insertLast", "insertLast", "insertFront", "insertFront", "getRear", "isFull", "deleteLast", "insertFront", "getFront"]
[[3], [1], [2], [3], [4], [], [], [], [4], []]
Output
[null, true, true, true, false, 2, true, true, true, 4]

Explanation
MyCircularDeque myCircularDeque = new MyCircularDeque(3);
myCircularDeque.insertLast(1);  // return True
myCircularDeque.insertLast(2);  // return True
myCircularDeque.insertFront(3); // return True
myCircularDeque.insertFront(4); // return False, the queue is full.
myCircularDeque.getRear();      // return 2
myCircularDeque.isFull();       // return True
myCircularDeque.deleteLast();   // return True
myCircularDeque.insertFront(4); // return True
myCircularDeque.getFront();     // return 4
 

Constraints:

1 <= k <= 1000
0 <= value <= 1000
At most 2000 calls will be made to insertFront, insertLast, deleteFront, deleteLast, getFront, getRear, isEmpty, isFull.
     */
    class DesignCircularDeque
    {
        private class Node
        {
            public int val;
            public Node prev, next;

            public Node(int val)
            {
                this.val = val;
            }
        }

        private Node head, tail;
        private int size;
        private readonly int capacity;

        public DesignCircularDeque(int k)
        {
            capacity = k;
            size = 0;
            head = new Node(-1); // Dummy head
            tail = new Node(-1); // Dummy tail
            head.next = tail;
            tail.prev = head;
        }

        public bool InsertFront(int value)
        {
            if (IsFull()) return false;

            Node newNode = new Node(value);
            Node first = head.next;

            head.next = newNode;
            newNode.prev = head;
            newNode.next = first;
            first.prev = newNode;

            size++;
            return true;
        }

        public bool InsertLast(int value)
        {
            if (IsFull()) return false;

            Node newNode = new Node(value);
            Node last = tail.prev;

            last.next = newNode;
            newNode.prev = last;
            newNode.next = tail;
            tail.prev = newNode;

            size++;
            return true;
        }

        public bool DeleteFront()
        {
            if (IsEmpty()) return false;

            Node toRemove = head.next;
            Node nextNode = toRemove.next;

            head.next = nextNode;
            nextNode.prev = head;

            size--;
            return true;
        }

        public bool DeleteLast()
        {
            if (IsEmpty()) return false;

            Node toRemove = tail.prev;
            Node prevNode = toRemove.prev;

            tail.prev = prevNode;
            prevNode.next = tail;

            size--;
            return true;
        }

        public int GetFront()
        {
            return IsEmpty() ? -1 : head.next.val;
        }

        public int GetRear()
        {
            return IsEmpty() ? -1 : tail.prev.val;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public bool IsFull()
        {
            return size == capacity;
        }
    }
}
