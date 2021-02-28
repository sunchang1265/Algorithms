using System;

namespace Algorithms
{
    class Program
    {
        public string DefangIPaddr(string address)
        {
            string newAddr = string.Empty;
            foreach(char c in address)
            {
                if (c == '.') newAddr += $"[{c}]";
                else newAddr += c;
            }
            return newAddr;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.DefangIPaddr("1.1.1.1"));

            TwoSumSolution twoSum = new TwoSumSolution();
            int[] input = new int[] { 2, 7, 11, 15 };
            //int[] twoSumOutput = twoSum.TwoSum(input, 18);
            int[] twoSumOutput = twoSum.TwoSumBetter(input, 18);
            Console.WriteLine($"[{twoSumOutput[0]}], [{twoSumOutput[1]}]");
        }
    }
}
