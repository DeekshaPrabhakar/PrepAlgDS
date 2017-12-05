using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.LinkedLists
{
    class RemoveDuplicateSorted
    {
        public static void Run()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(1);
            head.next.next = new ListNode(1);
            head.next.next.next = new ListNode(3);
            head.next.next.next.next = new ListNode(3);
            Util.DisplayLinkedList(removeDuplicates(head));
        }

        public static ListNode removeDuplicates(ListNode A)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = A;

            ListNode curr = dummy.next;

            while(curr != null)
            {
                if (curr.next != null && curr.val == curr.next.val)
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    curr = curr.next;
                }
            }


            return dummy.next;
        }
    }
}
