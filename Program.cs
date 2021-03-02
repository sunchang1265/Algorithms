using System;
using Leetcode.Algorithms;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            //test integerPalindrome
            //TestIntegerPalindrome();

            //test atoi
            //TestAtoi();

            //test ReverseInteger
            //TestReverseInteger();

            //test ZigZagConversion
            //TestZigZagConversion();

            //test Palindrome
            //TestPalindrome();

            //test TwoSum
            //TestTwoSums();         

            //test Add two numbers            
            //TestAddTwoNumbers();

            //test Longest Substring without repeat
            //TestLongestSubstringNoRepeat();
            
            Console.ReadLine();
        }

        private static void TestIntegerPalindrome()
        {
            int input = 121;
            Console.WriteLine($"input: {input}");
            Console.WriteLine($"output: {IntegerPalindrome.IsPalindromeNoString(input)}");
        }

        private static void TestAtoi()
        {
            string input = "      -000000214a7483648A";
            input = "2147483646";
            Console.WriteLine($"input: {input}");
            Console.WriteLine($"output: {Atoi.MyAtoi(input)}");
        }

        private static void TestReverseInteger()
        {
            int input = -2147483648;
            Console.WriteLine($"ReverseInteger input: {input}");
            Console.WriteLine($"ReverseInteger: {ReverseInteger.ReverseBest(input)}");
        }

        private static void TestZigZagConversion()
        {
            string input = "PAYPALISHIRING";
            Console.WriteLine($"TestZigZagConversion input: {input}");
            Console.WriteLine($"TestZigZagConversion: {ZigZagConversion.Convert(input, 5)}");
        }

        private static void TestPalindrome()
        {
            string input = "ababababa";
            Console.WriteLine($"Longest Palindromic Substring input: {input}");
            Console.WriteLine($"Longest Palindromic Substring: {Palindrome.LongestPalindrome(input)}");
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
