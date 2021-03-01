using System;
using System.Collections;
using System.Text;

namespace Leetcode.Algorithms
{
    class ReverseInteger
    {
        public static int ReverseBest(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                if (rev > Int32.MaxValue / 10 || (rev == Int32.MaxValue / 10 && pop > 7)) return 0;
                if (rev < Int32.MinValue / 10 || (rev == Int32.MinValue / 10 && pop < -8)) return 0;
                rev = rev * 10 + pop;
            }
            return rev;
        }
        public static int ReverseBetter(int x)
        {
            if (-10 < x && x < 10) return x;
            if (x <= Int32.MinValue || x > Int32.MaxValue) return 0;
            char[] array = Math.Abs(x).ToString().ToCharArray();
            Stack s = new Stack();
            foreach (char c in array)
            {
                s.Push(c);
            }
            StringBuilder sb = new StringBuilder();
            if (x < 0) sb.Append('-');
            while (s.Count > 0)
            {
                sb.Append(s.Pop());
            }
            return int.TryParse(sb.ToString(), out int output) ? output : 0;
        }
        public static int Reverse(int x)
        {
            if (-10 < x && x < 10) return x;
            bool negative = x < 0 ? true : false;
            string s = x.ToString();
            if (negative) s = s.Substring(1, s.Length - 1);
            char[] array = s.ToCharArray();
            char[] result = new char[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[array.Length - i - 1];
            }
            int index = 0;
            while (result[index] == '0' && index < result.Length)
            {
                index++;
            }
            string final = new string(result).Substring(index, result.Length - index);
            if (negative) final = '-' + final;
            if (int.TryParse(final, out int output)) return output;
            else return 0;
        }
    }
}