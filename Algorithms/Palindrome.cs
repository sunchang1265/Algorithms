using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    class Palindrome
    {
        public static string LongestPalindrome(string s)
        {
            int max = 0;
            string result = string.Empty;
            char[] array = s.ToCharArray();
            if (array.Length == 1) return s;

            for (int i = 0; i < array.Length - 1; i++)
            {
                //cbbd, aaa, aaaa, abbba, abba 
                int cur = 1, l = i, r = i;
                while (l > 0 && r < array.Length - 1)
                {

                    if (array[l - 1] == array[r + 1])
                    {
                        l--;
                        r++;
                        cur += 2;
                    }
                    else break;
                }
                if (max < cur)
                {
                    max = r - l + 1;
                    result = s.Substring(l, max);
                }

                if (array[i] == array[i + 1])
                {
                    l = i;
                    r = i + 1;
                    cur = 2;
                    while (l > 0 && r < array.Length - 1)
                    {
                        if (array[l - 1] == array[r + 1])
                        {
                            l--;
                            r++;
                            cur += 2;
                        }
                        else break;
                    }

                    if (max < cur)
                    {
                        max = r - l + 1;
                        result = s.Substring(l, max);
                    }
                }
                if (max >= array.Length) break;
            }

            return result;
        }

    }
}
