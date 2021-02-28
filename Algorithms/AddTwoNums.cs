using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    public class AddTwoNums
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int temp = 0;
            
            while (l1.next != null)
            {
                int increment = 0;
                temp = l2.val + l1.val;
                if (temp >= 10) 
                {
                    increment = 1;
                    temp-=10;
                }

                if(l1.next == null)
                {
                    l2.val = temp;
                    if (l2.next != null) l2.next.val += increment;
                    else if (increment != 0)
                    {
                        l2.next = new ListNode(){val = increment};
                    }
                    return l2;
                }

                if(l2.next == null)
                {
                    l1.val = temp;
                    if (l1.next != null) l1.next.val += increment;
                    else if (increment != 0)
                    {
                        l1.next = new ListNode(){val = increment};
                    }
                    return l1;
                }
                
                l1 = l1.next;
                l2 = l2.next;
            }
            return null;
        }
    }

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
