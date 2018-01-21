using PrepAlgDS.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS
{
    class Util
    {
        public static void Display(List<List<int>> list)
        {
            foreach (var sublist in list)
            {
                foreach (var value in sublist)
                {
                    Console.Write(value);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void DisplayListOfListOfStrings(List<List<string>> list)
        {
            foreach (var sublist in list)
            {
                foreach (var value in sublist)
                {
                    Console.Write(value);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void DisplayListOfStrings(List<string> list)
        {
            foreach (var value in list)
            {
                Console.Write(value);
                Console.WriteLine();
            }
        }


        public static void DisplayList(List<int> list)
        {
            foreach (var value in list)
            {
                Console.Write(value);
                Console.Write(' ');
            }
            Console.WriteLine();
        }

        public static void DisplayJSON(List<String> list)
        {
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }

        public static void DisplayLinkedList(ListNode list)
        {
            ListNode curr = list;
            while (curr != null)
            {
                if (curr.next != null)
                {
                    Console.Write(curr.val + "->");
                }
                else
                {
                    Console.Write(curr.val);
                }
                curr = curr.next;
            }
        }
    }
}
