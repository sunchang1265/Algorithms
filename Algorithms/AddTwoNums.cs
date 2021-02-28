using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    class AddTwoNums
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode head = result;
            int increment = 0;
            while (l1 != null || l2 != null)
            {
                int x = l1 != null ? l1.val : 0;
                int y = l2 != null ? l2.val : 0;
                int sum = x + y + increment;
                increment = sum / 10;
                head.next = new ListNode() { val = sum % 10 };
                head = head.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }
            if (increment == 1) head.next = new ListNode() { val = increment };
            return result.next;
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
