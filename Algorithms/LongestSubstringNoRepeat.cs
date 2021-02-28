using System;
using System.Collections.Generic;

namespace Leetcode.Algorithms
{
    class LongestSubstringNoRepeat
    {
        public static int LengthOfLongestSubstringBetter(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int longest = 0, i = 0, j = 0, n = s.Length;
            char[] array = s.ToCharArray(); 
            if (array.Length == 1) return 1;
            while (i < n && j < n)
            {
                if (set.Contains(array[j]))
                {
                    set.Remove(array[i++]);                    
                    //PrintHashSet(set);
                }
                else
                {
                    set.Add(array[j++]);
                    //PrintHashSet(set);
                    longest = Math.Max(longest, j - i);
                }
            }

            return longest;
        }
        public static int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            HashSet<char> r = new HashSet<char>();
            char[] array = s.ToCharArray();
            if (array.Length == 1) return 1;
            for (int i = 0; i<array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    char c = array[j];
                    if (!r.Contains(c))
                    {
                        r.Add(c);
                    }
                    else
                    {
                        max = r.Count > max ? r.Count : max;
                        r = new HashSet<char>();
                        break;
                    }
                }
                if (max >= array.Length - i) break;
            }
            return max;

        }

        private static void PrintHashSet<T>(HashSet<T> s)
        {
            Console.WriteLine($"Current Set: ");
            foreach (T d in s)
            {
                Console.Write($"{d} ");
            }
            Console.WriteLine();
        }
    }
}
