using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Remove_Nth_Node_From_End_of_List
    {


        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public class Solution
        {
            public ListNode RemoveNthFromEnd(ListNode head, int n)
            {
                int headNum = 1;
                ListNode LN= head;
                while (LN.next != null)
                {
                    LN = LN.next;
                    headNum++;
                }

                LN = head;
                if (headNum - n == 0)
                {
                    return head.next;
                }

                for (int i = 1; i < headNum+1; i++)
                {
                    if (i == headNum - n)
                    {
                        if (LN.next == null)
                        {
                            return null;
                        }
                        LN.next = LN.next.next;
                        i = headNum;
                        break;
                    }
                    LN = LN.next;
                    if (i == headNum+1 - 1)
                    {
                        return LN;
                    }
                }
                return head;
            }
        }
    }
}
