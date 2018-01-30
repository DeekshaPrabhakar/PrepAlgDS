using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.DynamicProgramming
{
    class LongestParenthesesValid
    {
        public static void Run()
        {
            Console.WriteLine(longestValidParentheses("(()"));
            Console.WriteLine(longestValidParentheses(")()())"));
        }
        public static int longestValidParentheses(string A)
        {
            if (A == null || A.Length < 2)
            {
                return 0;
            }
            Stack<int> stack = new Stack<int>();
            stack.Push(-1);
            int max = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == '(')
                {
                    stack.Push(i);
                }
                else
                {
                    stack.Pop();
                    if (stack.Count > 0)
                    {
                        max = Math.Max(max, i - stack.Peek());
                    }
                    else
                    {
                        stack.Push(i);
                    }
                }
            }

            return max;
        }
    }
}
