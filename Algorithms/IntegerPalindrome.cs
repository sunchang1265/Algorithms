namespace Leetcode.Algorithms
{
    class IntegerPalindrome
    {
        public static bool IsPalindromeNoString(int x) 
        {
            if (x < 0) return false;
            else if (x < 10) return true;
            if (x%10 == 0) return false;
            int remain = x;
            int digit = x%10;
            int revert = 0;
            
            while (remain > revert)
            {
                digit = remain%10;
                remain = remain/10;
                revert = revert*10 + digit;

                if(remain == revert) return true;
            }
            if (remain == revert/10) return true;
            return false;

        }
        public static bool IsPalindrome(int x) 
        {
            //123321, 12321
            if (x < 0) return false;
            else if (x < 10) return true;
            string s = x.ToString();
            int length = s.Length;
            int l = length/2-1; 
            int r;
            if (length%2 == 0)
            {
                r = l+1;
            }
            else
            {
                r = l+2;
            }
            if(s[l] != s[r]) return false;
            while (l > 0 ) 
            {
                if (s[l] != s[r]) return false;
                l--;
                r++;
            }
            return true;
            
            


        }
    }
}