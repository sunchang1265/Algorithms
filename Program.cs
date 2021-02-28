using System;
using Leetcode.Algorithms;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            //test TwoSum
            //TestTwoSums();         

            //test Add two numbers            
            //TestAddTwoNumbers();

            //test Longest Substring without repeat
            TestLongestSubstringNoRepeat();
            
            Console.ReadLine();
        }

        private static void TestLongestSubstringNoRepeat()
        {
            string input = "pwwkew";
            Console.WriteLine($"Longest Substring without repeat input: {input}");
            Console.WriteLine($"Longest Substring without repeat: {LongestSubstringNoRepeat.LengthOfLongestSubstringBetter(input)}");
        }

        private static void TestAddTwoNumbers()
        {
            ListNode l1 = new ListNode() { val = 9 };
            ListNode l2 = new ListNode() { val = 9 };
            ListNode l3 = new ListNode() { val = 9 };
            l1.next = l2;
            l2.next = l3;

            ListNode r1 = new ListNode() { val = 9 };
            ListNode r2 = new ListNode() { val = 9 };
            //ListNode r3 = new ListNode() { val = 4 };
            r1.next = r2;
            //r2.next = r3;

            ListNode result = AddTwoNums.AddTwoNumbers(l1, r1);
            while (result != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
        }
        private static void TestTwoSums()
        {
            TwoSumSolution twoSum = new TwoSumSolution();
            int[] input = new int[] { 2, 7, 11, 15 };
            //int[] twoSumOutput = twoSum.TwoSum(input, 18);
            int[] twoSumOutput = twoSum.TwoSumBetter(input, 18);
            Console.WriteLine($"[{twoSumOutput[0]}], [{twoSumOutput[1]}]");
        }

    }
}
