using System;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoSumSolution twoSum = new TwoSumSolution();
            int[] input = new int[] { 2, 7, 11, 15 };
            //int[] twoSumOutput = twoSum.TwoSum(input, 18);
            int[] twoSumOutput = twoSum.TwoSumBetter(input, 18);
            Console.WriteLine($"[{twoSumOutput[0]}], [{twoSumOutput[1]}]");
        }
    }
}
