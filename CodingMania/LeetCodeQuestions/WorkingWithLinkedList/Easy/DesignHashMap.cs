using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Easy
{
    /*
     Design a HashMap without using any built-in hash table libraries.

Implement the MyHashMap class:

MyHashMap() initializes the object with an empty map.
void put(int key, int value) inserts a (key, value) pair into the HashMap. If the key already exists in the map, update the corresponding value.
int get(int key) returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key.
void remove(key) removes the key and its corresponding value if the map contains the mapping for the key.
 

Example 1:

Input
["MyHashMap", "put", "put", "get", "get", "put", "get", "remove", "get"]
[[], [1, 1], [2, 2], [1], [3], [2, 1], [2], [2], [2]]
Output
[null, null, null, 1, -1, null, 1, null, -1]

Explanation
MyHashMap myHashMap = new MyHashMap();
myHashMap.put(1, 1); // The map is now [[1,1]]
myHashMap.put(2, 2); // The map is now [[1,1], [2,2]]
myHashMap.get(1);    // return 1, The map is now [[1,1], [2,2]]
myHashMap.get(3);    // return -1 (i.e., not found), The map is now [[1,1], [2,2]]
myHashMap.put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
myHashMap.get(2);    // return 1, The map is now [[1,1], [2,1]]
myHashMap.remove(2); // remove the mapping for 2, The map is now [[1,1]]
myHashMap.get(2);    // return -1 (i.e., not found), The map is now [[1,1]]
 

Constraints:

0 <= key, value <= 106
At most 104 calls will be made to put, get, and remove.
     
     */
    public class DesignHashMap
    {
    }

    public class MyHashMap
    {
        //Define a linked List Node
        private class Node
        {
            public int Key;
            public int Value;
            public Node Next;
            public Node(int key, int value, Node next = null)
            {
                Key = key;
                Value = value;
                Next = next;
            }
        }

        private readonly int SIZE = 1009; // a prime Number for better distribution
        private Node[] buckets;

        public MyHashMap()
        {
            buckets = new Node[SIZE];
        }

        private int Hash(int Key)
        {
            return Key % SIZE;
        }

        public void Put(int key, int value)
        {
            int index = Hash(key);
            Node head = buckets[index];

            Node current = head;

            while (current != null)
            {
                if (current.Key == key)
                {
                    current.Value = value; // Update if key exists
                    return;
                }
                current = current.Next;
            }

            // Insert new node at the beginning of the list
            Node newNode = new Node(key, value, head);
            buckets[index] = newNode;
        }


        public int Get(int key)
        {
            int index = Hash(key);
            Node current = buckets[index];

            while (current != null)
            {
                if (current.Key == key)
                    return current.Value;
                current = current.Next;
            }

            return -1; // Not found
        }


        public void Remove(int key)
        {
            int index = Hash(key);
            Node current = buckets[index];
            Node prev = null;

            while (current != null)
            {
                if (current.Key == key)
                {
                    if (prev == null)
                        buckets[index] = current.Next;
                    else
                        prev.Next = current.Next;

                    return;
                }

                prev = current;
                current = current.Next;
            }
        }
    }


    ///SOLUTION 2
    ///

}
//Would you like a version that uses open addressing instead of separate chaining (linked list)?
