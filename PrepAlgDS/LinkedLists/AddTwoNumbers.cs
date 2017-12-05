using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.LinkedLists
{
    class AddTwoNumbers
    {
        public static void Run()
        {
            //ListNode num1 = new ListNode(2);
            //num1.next = new ListNode(4);
            //num1.next.next = new ListNode(3);

            //ListNode num2 = new ListNode(5);
            //num2.next = new ListNode(6);
            //num2.next.next = new ListNode(6);
            ListNode num1 = new ListNode(9);
            num1.next = new ListNode(9);
            num1.next.next = new ListNode(1);

            ListNode num2 = new ListNode(1);
            Util.DisplayLinkedList(addTwoLists(num1, num2));
            
        }

        public static ListNode addTwoLists(ListNode A, ListNode B)
        {
            ListNode dummy = new ListNode(0);
            
            int sum = 0;
            int carry = 0;
            
            ListNode curr = dummy;

            while(A != null || B!= null)
            {
                sum =  carry;
                if (A != null)
                {
                    sum += A.val;
                }

                if(B != null)
                {
                    sum += B.val;
                }
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                A = A != null ? A.next : A;
                B = B != null ? B.next : B;
            }

            if(carry != 0)
            {
                curr.next = new ListNode(carry);
            }

            return dummy.next;
        }
    }
}
