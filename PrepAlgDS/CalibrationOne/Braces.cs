using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.CalibrationOne
{
    class Braces
    {
         public static void Run()
        {
            string[] res;
            int values_size = 0;
            values_size = Convert.ToInt32(Console.ReadLine());
            string[] values = new string[values_size];
            string values_item;
            for (int values_i = 0; values_i < values_size; values_i++)
            {
                values_item = Console.ReadLine();
                values[values_i] = values_item;
            }

            res = braces(values);
            for (int res_i = 0; res_i < res.Length; res_i++)
            {
                Console.WriteLine(res[res_i]);
            }
        }

         public static string[] braces(string[] values)
         {
             string[] result = new string[values.Length];

             for (int i = 0; i < values.Length; i++)
             {
                 if (isBalanced(values[i]))
                 {
                     result[i] = "YES";
                 }
                 else
                 {
                     result[i] = "NO";
                 }
             }
             return result;
         }

         private static bool isBalanced(string exp)
         {
             bool isBalanced = false;
             char[] input = exp.ToCharArray();
             Stack<char> bstack = new Stack<char>();

             foreach (char brace in input)
             {
                 if (isOpeningBrace(brace))
                 {
                     bstack.Push(brace);
                 }
                 else if (isClosingBrace(brace))
                 {
                     if (bstack.Count == 0)
                     {
                         isBalanced = false;
                         return isBalanced;
                     }

                     char openBrace = getOpenBrace(brace);
                     char stackBrace = bstack.Pop();
                     if (openBrace != stackBrace)
                     {
                         isBalanced = false;
                         return isBalanced;
                     }

                 }
             }

             isBalanced = bstack.Count == 0 ? true : false;
             return isBalanced;
         }

        private static char getOpenBrace(char ch)
        {
            char openBrace = '\0';
            switch (ch)
            {
                case '}':
                    openBrace = '{';
                    break;
                case ']':
                    openBrace = '[';
                    break;
                case ')':
                    openBrace = '(';
                    break;
                default:
                    break;

            }
            return openBrace;
        }

        private static bool isOpeningBrace(char ch)
        {
            bool isOpen = false;
            switch(ch)
            {
                case '{':
                    isOpen = true;
                    break;
                     case '[':
                    isOpen = true;
                    break;
                     case '(':
                    isOpen = true;
                    break;
                default:
                    break;

            }
            return isOpen;
        }

        private static bool isClosingBrace(char ch)
        {
            bool isClose = false;
            switch (ch)
            {
                case '}':
                    isClose = true;
                    break;
                case ']':
                    isClose = true;
                    break;
                case ')':
                    isClose = true;
                    break;
                default:
                    break;

            }
            return isClose;
        }
    }
}
