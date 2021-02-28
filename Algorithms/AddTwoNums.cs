using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class AddTwoNums
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode resultNext = new ListNode();
            int temp = 0;
            if (l1.next == null)
            {
                temp = l2.val + l1.val;
                if (temp >= 10)
                {
                    l2.val = temp - 10;
                    l2.next.val++;
                }
                else l2.val = temp;
                return l2;
            }
            if (l2.next == null)
            {
                temp = l2.val + l1.val;
                if (temp >= 10)
                {
                    l2.val = temp - 10;
                    l2.next.val++;
                }
                else l2.val = temp;
                return l2;
            }
            while (l1.next != null)
            {
                int increment = 0;
                int valResult = l1.val + l2.val;
                if (valResult >= 10)
                {
                    result.val = valResult - 10;
                    increment = 1;
                }
                l1Next = l1.next;
                l2Next = l2.next;
                if (l1.next == null || l2.next == null)

                if (l2.next == null)

            }
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
