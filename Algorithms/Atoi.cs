using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    class Atoi
    {
        public static int MyAtoi(string s)
        {
            StringBuilder sb = new StringBuilder();
            int index = 0;
            while (index < s.Length)
            {
                //step1 leading white space
                if (s[index] == ' ') index++;                
                else
                {
                    s = s[index..];
                    break;
                }
            }

            if (string.IsNullOrEmpty(s)) return 0;
            char first = s[0];
            bool negative = false;
            if (first == '-' || first == '+')
            {
                if (first == '-')
                {
                    sb.Append(first);
                    negative = true;
                }
                s = s[1..];
            }
            if (string.IsNullOrEmpty(s)) return 0;
            first = s[0];
            if (first < 48 || first > 57) return 0;

            index = 0;
            while (index < s.Length)
            {
                if (s[index] == '0') index++;
                else
                {
                    break;
                }
            }
            s = s[index..];
            if (string.IsNullOrEmpty(s)) return 0;
            first = s[0];
            if (first < 48 || first > 57) return 0;
            index = 0;
            while (index < s.Length)
            {
                if (s[index] >= 48 && s[index] <= 57)
                {
                    sb.Append(s[index]);
                    index++;
                }
                else break;
            }
            string final = sb.ToString();
            if (string.IsNullOrEmpty(final)) return 0;
            if (negative && final.Length >= 11) return int.MinValue;
            else if (!negative && final.Length > 10) return int.MaxValue;

            if (long.TryParse(final, out long result) == false) return negative ? int.MinValue : int.MaxValue;
            else
            {
                if (result > int.MaxValue) return int.MaxValue;
                if (result < int.MinValue) return int.MinValue;

                return (int)result;
            }
        }
    }
}
