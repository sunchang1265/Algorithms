using System.Collections.Generic;
using System.Text;

namespace Leetcode.Algorithms
{
    class IntToRomanNum
    {
        public static string IntToRomanBetter(int num)
        {
            var c = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
            var n = new int[]    {1000,  900, 500,  400, 100,   90,  50,   40,  10,    9,   5,    4,   1};

            string result = string.Empty;
            int i=0;
            while (num > 0)
            {
                if (num >= n[i])
                {
                    num-= n[i];
                    result += c[i];
                }
                else i++;
            }
            return result;                           
        }
        public static string IntToRoman(int num)
        {
            //3999 MMM CM XC IX
            //1356 M CCC L VI
            int M = num / 1000;
            num = num % 1000;

            int CM=0, D=0, CD=0, C=0, XC=0, L=0, XL=0, X=0, IX=0, V=0, IV=0, I=0;
            // num<1000
            if (num >= 900)  
            {
                CM = 1;
                num = num - 900; // < 100
            }
            else
            {
                D = num / 500;
                num = num % 500;
                if (num >= 400)
                {
                    CD = 1;
                    num -= 400; // < 100
                }
                else
                {
                    C = num/100;
                    num = num%100; // <100
                }
            }

            // num<100
            if (num >= 90)
            {
                XC = 1;
                num -= 90; //<90
            }
            else
            {
                L = num / 50;
                num = num % 50; // < 50
                if(num >= 40)
                {
                    XL = 1;
                    num-=40; //<10
                }
                else
                {
                    X = num / 10;
                    num = num % 10; //<10
                }
            }

            // num < 10
            if (num == 9) IX = 1; 
            else if (num == 4) IV = 1;
            else
            {
                V = num / 5;
                I = num % 5;
            }
            
            StringBuilder sb = new StringBuilder();
            while (M > 0)
            {
                sb.Append("M");
                M--;
            }
            while (CM > 0)
            {
                sb.Append("CM");
                CM--;
            }
            while (D > 0)
            {
                sb.Append("D");
                D--;
            }
            while (CD > 0)
            {
                sb.Append("CD");
                CD--;
            }
            while (C > 0)
            {
                sb.Append("C");
                C--;
            }
            while (XC > 0)
            {
                sb.Append("XC");
                XC--;
            }
            while (L > 0)
            {
                sb.Append("L");
                L--;
            }
            while (XL > 0)
            {
                sb.Append("XL");
                XL--;
            }
            while (X > 0)
            {
                sb.Append("X");
                X--;
            }
            while (IX > 0)
            {
                sb.Append("IX");
                IX--;
            }
            while (IV > 0)
            {
                sb.Append("IV");
                IV--;
            }
            while (V > 0)
            {
                sb.Append("V");
                V--;
            }
            while (I > 0)
            {
                sb.Append("I");
                I--;
            }

            return sb.ToString();
        } 
    }
}