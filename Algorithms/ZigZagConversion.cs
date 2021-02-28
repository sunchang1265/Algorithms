using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    class ZigZagConversion
    {
        public static string Convert(string s, int numRows)
        {            
            char[] array = s.ToCharArray();
            int len = array.Length;
            if (len <= numRows || numRows <=1 ) return s;
            
            List<List<char>> result = new List<List<char>>();
            for(int r=0; r<numRows; r++)
            {
                result.Add(new List<char>());
            }
            bool down = true; int index = 0;
            foreach(char c in array)
            {
                result[index].Add(c);               
                index = down ? index+1 : index-1;
                if (index == numRows)
                {
                    down = !down;
                    index = numRows - 2;
                }
                else if(index < 0)
                {
                    down = !down;
                    index = 1;
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach(List<char> row in result)
            {
                foreach(char c in row)
                    sb.Append(c);
            }
            return sb.ToString();            
        }
    }
}
