using CodingMania.LeetCodeQuestions.String.Easy.Part5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*
        15. 3Sum
Medium
Topics
premium lock icon
Companies
Hint
Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets.

 

Example 1:

Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Explanation: 
nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
The distinct triplets are [-1,0,1] and [-1,-1,2].
Notice that the order of the output and the order of the triplets does not matter.
Example 2:

Input: nums = [0,1,1]
Output: []
Explanation: The only possible triplet does not sum up to 0.
Example 3:

Input: nums = [0,0,0]
Output: [[0,0,0]]
Explanation: The only possible triplet sums up to 0.
 

Constraints:

3 <= nums.length <= 3000
-105 <= nums[i] <= 105
     
     */
    public class _15_ThreeSum
    {

        public IList<IList<int>> ThreeSum(int[] nums)
        { 
            //You want to return a Multiple Tripples, So we create a list that will
           //Hold each valid combination here 
           List<IList<int>> result = new List<IList<int>>();

            //Sort the array, Sorting the array makes the Two pointer  Easy 
            Array.Sort(nums);

            //Step 2: Fix the First Number
            //The loop Select the First NUmber in our Tripplet
            //Why nums.Lenght -2, Necaause we need at least two more Elements after i

            //Index -- 0   1   2   3   4   5
            //let say you are at index 3 you need to have Index 4 and Index 5 availabel
            for (int i = 0; i < nums.Length-2; i++)
            {
                //Skip Duplicate
                //iF YOU ARE NOT ON THE first Number,checks if you have Duplicates
                // [-4, -1, -1, 0, 1, 2]
                // -1 + -1 + 0  =0
                // -1 is a duplicate . we process -1 twice we generatea duplicate
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                //Initialize the e Pointers
                //Note the i +1 in the Left 
                int left = i + 1;
                int right = nums.Length - 1;

                //Step fins the Other two nu,mber
                //Scan the iNDEX 

                while (left < right)
                {
                    //Ue three Positons fixedNumber =i, Then the Left and right that Slides
                    //We use and Ideas to convert the three Sum Problem to a 
                    //two Sum problem
                    //So we keep I fixed whule Moving Left and Right to find a pair
                    //that Completes the Sum
                    int sum = nums[i] + nums[left] + nums[right]; 

                    if (sum == 0)
                    {
                        result.Add(new List<int>
                        {
                            nums[i],
                            nums[left],
                            nums[right]
                        });

                        left++;
                        right--;

                        //Skip Duplicate left Value
                        while (left <  right  && nums[left]== nums[left-1])
                        {
                            left++;
                        }

                        //Skip Duplicate Right Valeu
                        while (left < right && nums[right] == nums[right +1])
                        {
                            right--;
                        }
                    }

                    else if(sum < 0)
                    {
                        left++;
                    }

                    else
                    {
                        right--;
                    }

                }
            }

            return result;
        }
    }
}
