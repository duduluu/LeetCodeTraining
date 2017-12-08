using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTraining.CSharp._0._02 {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class Add_Two_Numbers {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            ListNode result = new ListNode(0);
            ListNode curNode = result;
            ListNode prevNode = curNode;
            int curSum = 0;

            do {
                curSum = curNode.val;
                if (l1 != null) {
                    curSum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null) {
                    curSum += l2.val;
                    l2 = l2.next;
                }
                curNode.val = curSum % 10;
                curNode.next = new ListNode(curSum / 10);
                prevNode = curNode;
                curNode = curNode.next;
            } while (l1 != null || l2 != null);

            if (curNode.val == 0) {
                prevNode.next = null;
            }

            return result;
        }
    }
}
