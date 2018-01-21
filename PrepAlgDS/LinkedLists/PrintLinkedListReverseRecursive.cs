using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.LinkedLists
{
    class PrintLinkedListReverseRecursive
    {
        public static void Run()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);

            Reverse(head);
        }

        private static void Reverse(ListNode node)
        {
            if (node.next == null)
            {
                Console.WriteLine(node.val);
                return;
            }
            Reverse(node.next);
            Console.WriteLine(node.val);
        }
    }
}
