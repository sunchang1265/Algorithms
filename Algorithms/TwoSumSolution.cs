using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class TwoSumSolution
    {

        public int[] TwoSum(int[] nums, int target)
        {
            int[] output = new int[2];
            for(int i=0; i<nums.Length; i++)
            {
                for(int j=i+1; j<nums.Length; j++)
                {
                    if((nums[i] + nums[j]) == target)
                    {
                        output[0] = i;
                        output[1] = j;
                    }
                }
            }
            return output;
        }

        public int[] TwoSumBetter(int[] nums, int target)
        {
            int[] output = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int res = target - nums[i];
                if (dict.ContainsKey(res))
                {
                    output[0] = i;
                    output[1] = dict[res];
                    break;
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }
            return output;
        }
    }
}
