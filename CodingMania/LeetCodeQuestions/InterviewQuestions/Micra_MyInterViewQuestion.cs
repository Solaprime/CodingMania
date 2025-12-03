using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.InterviewQuestions
{
    /*
     Coding exercise
Task Queue Optimizer You are developing a task scheduling system for a cloud service provider. Each task has a processing time and a priority level. The system needs to process tasks in a way that balances efficiency and priority. You are given an array of tasks, where each task is represented as [processing_time, priority]. The processing_time is the number of time units needed to complete the task, and priority is a value from 1 to 10 (where 10 is highest priority). Implement a function that rearranges the task queue to optimize processing according to these rules: 1. Higher priority tasks should generally be processed earlier 2. However, if a high-priority task has an extremely long processing time compared to lower priority tasks, the system may choose to process multiple shorter tasks first The
optimization formula is: task_score = priority * 10 -
processing_time Tasks should be processed in descending order of their task_score. If two tasks have the same score, process the one with higher priority first.

    EXAMPLE 1
Input: [[5, 3], [2, 5], [8, 10], [1, 2]]
Output: [2, 1, 0, 3]
Explanation: Task 2 ([8, 10]) has score

    Requirements
Implement a function that takes an array of [processing_time, priority] pairs and returns the optimized processing order
Calculate each task's score using the formula:
task_score = priority * 10 - processing_time
Sort tasks by their score in descending order
Break ties by prioritizing tasks with higher priority values
Return the optimized order as indices of the original tasks array (0-indexed)
Handle edge cases like empty arrays or invalid inputs appropriately
Aim for an efficient solution with appropriate time complexity
     
     */
    class Micra_MyInterViewQuestion
    {
        /*
         Higher priority tasks should be processed earlier.

BUT if a high-priority task takes too long, the system may choose to run shorter, lower-priority tasks first.

To balance this, we compute a task score:,
        Higher priority tasks should be processed earlier.

BUT if a high-priority task takes too long, the system may choose to run shorter, lower-priority tasks first.

To balance this, we compute a task score:

ini
Copy
Edit
task_score = priority * 10 - processing_time
Higher priority = better score.

Lower processing_time = better score.

Sort tasks in descending order of task_score.

If two tasks have the same score, pick the one with higher priority first.

Return the indices of tasks in the optimized order (not the tasks themselves).
       
        Task Index	Task	Score (priority * 10 - time)	Priority
0	[5, 3]	3×10 - 5 = 25	3
1	[2, 5]	5×10 - 2 = 48	5
2	[8, 10]	10×10 - 8 = 92	10
3	[1, 2]	2×10 - 1 = 19	2

        Sorted by score (descending):
92, 48, 25, 19 → indices: [2, 1, 0, 3]
         */
        public List<int> OptimizeTaskOrder(List<int[]> tasks)
        {
            if (tasks == null || tasks.Count == 0)
                return new List<int>();

            // 1. Create a list of tasks with index, score, and priority
            var scoredTasks = tasks
                .Select((task, index) => new
                {
                    Index = index,
                    Score = task[1] * 10 - task[0], // score = priority * 10 - time
                    Priority = task[1]
                })
                .ToList();

            // 2. Sort by descending score, then by descending priority
            var sorted = scoredTasks
                .OrderByDescending(t => t.Score)
                .ThenByDescending(t => t.Priority)
                .Select(t => t.Index) // return only the original index
                .ToList();

            return sorted;
        }
    }
}
