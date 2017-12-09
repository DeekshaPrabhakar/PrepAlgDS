using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.LinkedLists
{
    class MergeSortedLists
    {
        public static void Run()
        {
            ListNode A = new ListNode(5);
            A.next = new ListNode(8);
            A.next.next = new ListNode(20);
            ListNode head = new ListNode(4);
            head.next = new ListNode(11);
            head.next.next = new ListNode(15);
            Util.DisplayLinkedList(mergeSortedLists(A, head));
        }

        public static ListNode mergeSortedLists(ListNode A, ListNode B)
        {
            ListNode dummy = new ListNode(0);

            ListNode curr = dummy;

            while (A != null || B != null)
            {
                if(A!= null && B!= null)
                {
                    if(A.val < B.val)
                    {
                        curr.next = new ListNode(A.val);
                        A = A.next;
                        curr = curr.next;
                    }
                    else
                    {
                        curr.next = new ListNode(B.val);
                        B = B.next;
                        curr = curr.next;
                    }
                }
                else if(A!= null)
                {
                    curr.next = new ListNode(A.val);
                    A = A.next;
                    curr = curr.next;
                }
                else if (B != null)
                {
                    curr.next = new ListNode(B.val);
                    B = B.next;
                    curr = curr.next;
                }
                else
                {
                    break;
                }
            }


            return dummy.next;
        }
    }
}
