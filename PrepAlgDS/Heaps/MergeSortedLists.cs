using PrepAlgDS.LinkedLists;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Heaps
{
    class MergeSortedLists
    {
        public static void Run()
        {
            ListNode num1 = new ListNode(1);
            num1.next = new ListNode(10);
            num1.next.next = new ListNode(20);

            ListNode num2 = new ListNode(4);
            num2.next = new ListNode(11);
            num2.next.next = new ListNode(13);

            ListNode num3 = new ListNode(3);
            num3.next = new ListNode(8);
            num3.next.next = new ListNode(9);

            Util.DisplayLinkedList(mergeSortedLists(num1, num2, num3));
        }

        private static ListNode mergeSortedLists(ListNode A, ListNode B, ListNode C)
        {
            Heap<int> heap = new Heap<int>();
            ListNode num1 = A;
            ListNode num2 = B;
            ListNode num3 = C;

            while(num1 != null || num2!= null || num3 != null)
            {
                if(num1 != null)
                {
                    heap.Add(num1.val);
                    num1 = num1.next;
                }

                if (num2 != null)
                {
                    heap.Add(num2.val);
                    num2 = num2.next;
                }

                if (num3 != null)
                {
                    heap.Add(num3.val);
                    num3 = num3.next;
                }
            }

            ListNode dummy = new ListNode(0);
            ListNode curr = dummy;
            while (heap.GetSize() > 0)
            {
                int min = heap.PopMin();
                curr.next = new ListNode(min);
                curr = curr.next;
            }

            return dummy.next;
        }
    }
}
