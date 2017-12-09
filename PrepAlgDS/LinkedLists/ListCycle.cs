using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.LinkedLists
{
    class ListCycle
    {
        public static void Run()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = head.next.next;
            
            ListNode output = listCycle(head);
            Console.WriteLine(output != null ? "Cycle started at node: " + output.val : "No Cycle");
        }

        public static ListNode listCycle(ListNode a)
        {
            ListNode slow = a;
            ListNode fast = a;

            while (fast != null && fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    slow = a;
                    while (slow != fast)
                    {
                        slow = slow.next;
                        fast = fast.next;
                    }
                    return slow;
                }
            }

            return new ListNode(-1);
        }
    }
}
