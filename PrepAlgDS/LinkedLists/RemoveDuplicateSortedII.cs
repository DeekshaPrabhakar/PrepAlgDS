using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.LinkedLists
{
    class RemoveDuplicateSortedII
    {
        public static void Run()
        {
            ListNode head = new ListNode(1);
            //head.next = new ListNode(1);
            //head.next.next = new ListNode(2);
            //head.next.next.next = new ListNode(3);
            //head.next.next.next.next = new ListNode(3);
            //head.next.next.next.next.next = new ListNode(3);
            Util.DisplayLinkedList(removeDuplicates(head));
        }

        public static ListNode removeDuplicates(ListNode A)
        {
            ListNode dummy = new ListNode(0);
            
            ListNode prev = dummy;
            ListNode curr = A;
            dummy.next = curr;
            int removedVal = -1;

            while (curr != null)
            {
                if ((curr.next != null && curr.val == curr.next.val))
                {
                    curr.next = curr.next.next;
                    removedVal = curr.val;
                }
                else if (curr.val == removedVal)
                {
                    prev.next = curr.next;
                    curr = prev.next;
                }
                else
                {
                    prev = curr;
                    curr = curr.next;
                }
            }


            return dummy.next;
        }
    }
}
