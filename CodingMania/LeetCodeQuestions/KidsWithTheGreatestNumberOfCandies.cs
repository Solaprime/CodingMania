using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions
{
    internal class KidsWithTheGreatestNumberOfCandies
    {
        public List<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var maxCandies = candies.Max();
            List<bool> data = new List<bool>();
            foreach (int candy in candies)
            {
                bool result;
                if (candy + extraCandies >= maxCandies)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                data.Add(result);
            }

            return data;
        }

        //ChatGptSolution
        public IList<bool> KidsWithCandies2(int[] candies, int extraCandies)
        {
            // Step 1: Find the maximum candies any kid currently has
            int maxCandies = candies.Max();

            // Step 2: Create a list to store the results
            IList<bool> result = new List<bool>();

            // Step 3: Iterate through each kid's candies and calculate if they can have the most
            foreach (int candy in candies)
            {
                // Step 4: Check if the current kid's candies plus the extra candies
                // are greater than or equal to the maximum candies
                if (candy + extraCandies >= maxCandies)
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }
            }

            // Step 5: Return the result list
            return result;
        }
    }
}


//There are n kids with candies. You are given an integer array candies, where each candies[i] represents the number of candies the ith kid has, and an integer extraCandies, denoting the number of extra candies that you have.

//Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all the extraCandies, they will have the greatest number of candies among all the kids, or false otherwise.

//Note that multiple kids can have the greatest number of candies.

 

//Example 1:

//Input: candies = [2,3,5,1,3], extraCandies = 3
//Output: [true,true,true,false,true] 
//Explanation: If you give all extraCandies to:
//- Kid 1, they will have 2 + 3 = 5 candies, which is the greatest among the kids.
//- Kid 2, they will have 3 + 3 = 6 candies, which is the greatest among the kids.
//- Kid 3, they will have 5 + 3 = 8 candies, which is the greatest among the kids.
//- Kid 4, they will have 1 + 3 = 4 candies, which is not the greatest among the kids.
//- Kid 5, they will have 3 + 3 = 6 candies, which is the greatest among the kids.
//Example 2:

//Input: candies = [4,2,1,1,2], extraCandies = 1
//Output: [true,false,false,false,false] 
//Explanation: There is only 1 extra candy.
//Kid 1 will always have the greatest number of candies, even if a different kid is given the extra candy.
//Example 3:

//Input: candies = [12,1,12], extraCandies = 10
//Output: [true,false,true]
 

//Constraints:

//n == candies.length
//2 <= n <= 100
//1 <= candies[i] <= 100
//1 <= extraCandies <= 50There are n kids with candies. You are given an integer array candies, where each candies[i] represents the number of candies the ith kid has, and an integer extraCandies, denoting the number of extra candies that you have.

//Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all the extraCandies, they will have the greatest number of candies among all the kids, or false otherwise.

//Note that multiple kids can have the greatest number of candies.

 

//Example 1:

//Input: candies = [2,3,5,1,3], extraCandies = 3
//Output: [true,true,true,false,true] 
//Explanation: If you give all extraCandies to:
//- Kid 1, they will have 2 + 3 = 5 candies, which is the greatest among the kids.
//- Kid 2, they will have 3 + 3 = 6 candies, which is the greatest among the kids.
//- Kid 3, they will have 5 + 3 = 8 candies, which is the greatest among the kids.
//- Kid 4, they will have 1 + 3 = 4 candies, which is not the greatest among the kids.
//- Kid 5, they will have 3 + 3 = 6 candies, which is the greatest among the kids.
//Example 2:

//Input: candies = [4,2,1,1,2], extraCandies = 1
//Output: [true,false,false,false,false] 
//Explanation: There is only 1 extra candy.
//Kid 1 will always have the greatest number of candies, even if a different kid is given the extra candy.
//Example 3:

//Input: candies = [12,1,12], extraCandies = 10
//Output: [true,false,true]
 

//Constraints:

//n == candies.length
//2 <= n <= 100
//1 <= candies[i] <= 100
//1 <= extraCandies <= 50
