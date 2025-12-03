using CodingMania.LeetCodeQuestions;
using CodingMania.LeetCodeQuestions.Array.Easy;
using CodingMania.LeetCodeQuestions.BinaryTreeQuestions.PlayingWithBinaryTree;
using CodingMania.LeetCodeQuestions.GraphQuestions.Easy;
using CodingMania.LeetCodeQuestions.InterviewQuestions;
using CodingMania.LeetCodeQuestions.WorkingWithRecursion;

namespace CodingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Playing with node 
            //Flow
            //HOW TO construct NODE

            /*

                              50
                            /     \
                          17        72
                          /  \       / \
                        12    23    54 76
                       /\      /     \
                      9 14    19      67




            
            BinaryTreeFirstPlayWith root = new BinaryTreeFirstPlayWith(50);

            var node2 = root.InsertLeft(17);
            var node3 = root.InsertRight(72);

            var node4 = node2.InsertLeft(12);
            var node5 = node2.InsertRight(23);

            var node6 = node3.InsertLeft(54);
            var node7 = node3.InsertRight(76);

            var node8 = node4.InsertLeft(9);
            var node9 = node4.InsertRight(14);

            var node10 = node5.InsertLeft(19);


            var node11 = node6.InsertRight(67);

             */

            //WorkingWithFibonanciFlow test = new WorkingWithFibonanciFlow();


            //Console.WriteLine(test.FibonacciMethod(0));
            //Console.WriteLine(test.FibonacciMethod(8));


            //WorkingWithFactorialFlow factorialFlow = new WorkingWithFactorialFlow();


            //int result = factorialFlow.Factorial(4);


            _997FindTheTownJudge fingJudge = new _997FindTheTownJudge();

            int[][] trust1 = { new int[] { 1, 2 } };
            int[][] trust2 = { new int[] { 1, 3 }, new int[] { 2, 3 } };
            int[][] trust3 = { new int[] { 1, 3 }, new int[] { 2, 3 }, new int[] { 3, 1 } };


            Console.WriteLine(fingJudge.FindJudge(2, trust1));  // 2
            Console.WriteLine(fingJudge.FindJudge(3, trust2)); // 3
            Console.WriteLine(fingJudge.FindJudge(3, trust3)); //-1


            Console.WriteLine("Using Graph");

            Console.WriteLine(fingJudge.FindJudgeUsingGrapgh(2, trust1));  // 2
            Console.WriteLine(fingJudge.FindJudgeUsingGrapgh(3, trust2)); // 3
            Console.WriteLine(fingJudge.FindJudgeUsingGrapgh(3, trust3)); //-1
        }

    }
}
