using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
namespace CodingMania.LeetCodeQuestions.Array.Easy
{

//    You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
//    Merge nums1 and nums2 into a single array sorted in non-decreasing order.

//The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

//Example 1:

//Input: nums1 = [1, 2, 3, 0, 0, 0], m = 3, nums2 = [2, 5, 6], n = 3
//Output: [1, 2, 2, 3, 5, 6]
//    Explanation: The arrays we are merging are [1, 2, 3] and [2, 5, 6].
//The result of the merge is [1, 2, 2, 3, 5, 6] with the underlined elements coming from nums1.
//Example 2:

//Input: nums1 = [1], m = 1, nums2 = [], n = 0
//Output: [1]
//    Explanation: The arrays we are merging are [1] and [].
//The result of the merge is [1].
//Example 3:

//Input: nums1 = [0], m = 0, nums2 = [1], n = 1
//Output: [1]
//    Explanation: The arrays we are merging are [] and[1].
//The result of the merge is [1].
//Note that because m = 0, there are no elements in nums1.The 0 is only there to ensure the merge result can fit in nums1.
//    Constraints:

//nums1.length == m + n
//    nums2.length == n
//0 <= m, n <= 200
//1 <= m + n <= 200
//-109 <= nums1[i], nums2[j] <= 109


    internal class MergeTwoSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // Start merging from the end of both arrays
            int p1 = m - 1; // Pointer for the last element in nums1's valid section
            int p2 = n - 1; // Pointer for the last element in nums2
            int p = m + n - 1; // Pointer for the last position in nums1

            // Merge nums2 into nums1
            while (p1 >= 0 && p2 >= 0)
            {
                if (nums1[p1] > nums2[p2])
                {
                    nums1[p] = nums1[p1];
                    p1--;
                }
                else
                {
                    nums1[p] = nums2[p2];
                    p2--;
                }
                p--;
            }

            // If there are remaining elements in nums2, copy them to nums1
            while (p2 >= 0)
            {
                nums1[p] = nums2[p2];
                p2--;
                p--;
            }
        }
    }
}


//Two array integer Sorted in Increasing Order 

//public static void MergeTwoArray(int[] nums1, int[] nums2, int m, int n)
//{
//    //Hold the Pointeer for the Last Element in nums1
//    int p1 = m - 1;

//    //Pointer for the Last element in 2
//    int p2 = n - 1;

//    //Pointer for the lasr Position in nums1(total length m+n)
//    int p = m + n - 1;

//    //Start merge from the End of both array
//    //if we start Merge from the beginning, we would Overwrite values
//    //in nums1 that we have not processed Yet
//    //Start feeling from enf of Nums 1, Mkving backwards

//    //Merge From the back
//    //p Will sureley be greater than p1 and  p2 in these Case
//    //
//    while (p1 >= 0 && p2 >= 0)
//    {
//        //So it Does not become an infinite Loop
//        //you need to Decrease p1 and p2
//        //So you just start iterating from the back
//        if (nums1[p1] > nums2[p2])
//        {
//            //You pass in the Last Element Here
//            //compare the two last element to fight for
//            //Position of Last
//            nums1[p] = nums1[p1];
//            p1--;
//            //Why are we    decreasing p1 here 
//        }

//        else
//        {
//            nums1[p] = nums2[p2];
//            p2--;
//        }
//        //Always decrease 
//        //So next index to decrease is here
//        p--;
//    }

//    //If any elements remain in nums2, add them
//    //While Note it is Ascednigr order if you Loop throudh p1 to
//    //zero and there is still element in p2
//    //Recall it is in ascending order just add there
//    //p1 > p2

//    while (p2 >= 0)
//    {
//        nums1[p] = nums2[p2];
//        p2--;
//        p--;
//    }

//}
