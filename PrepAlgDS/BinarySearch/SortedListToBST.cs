using PrepAlgDS.LinkedLists;
using PrepAlgDS.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.BinarySearch
{
    class SortedListToBST
    {
        public static void Run()
        {
            ListNode a = new ListNode(1);
            a.next = new ListNode(2);
            a.next.next = new ListNode(3);

            List<int> num = new List<int>();

            while (a != null)
            {
                num.Add(a.val);
                a = a.next;
            }


            TreeNode root = construct(num, 0, num.Count - 1);
        }

        public static TreeNode construct(List<int> num, int s, int e)
        {

            if (s > e)
                return null;
            int mid = s + (e - s) / 2;
            TreeNode node = new TreeNode(num[mid]);
            node.left = construct(num, s, mid - 1);
            node.right = construct(num, mid + 1, e);
            return node;

        }

    }
}
