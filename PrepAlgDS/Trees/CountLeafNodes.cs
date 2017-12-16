using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Trees
{
    class CountLeafNodes
    {
        /*
        *       1
        *    2     3
        *  4    5
        */
        public static void Run()
        {
            TreeNode bt = new TreeNode(1);
            bt.left = new TreeNode(2);
            bt.left.left = new TreeNode(4);
            bt.left.right = new TreeNode(5);

            bt.right = new TreeNode(3);

            Console.WriteLine("Count Leaf Nodes: ");
            Console.WriteLine(countLeaves(bt));
        }

        private static int countLeaves(TreeNode node)
        {
            int count = 0;
            TreeNode curr = node;
            Stack<TreeNode> stack = new Stack<TreeNode>();

            while(curr != null || stack.Count > 0)
            {
                if(curr != null)
                {//keep going left
                    stack.Push(curr);
                    curr = curr.left;
                }
                else
                {
                    curr = stack.Pop();
                    if(curr.left == null && curr.right == null)
                    {
                        count += 1;
                    }
                    curr = curr.right;
                }
            }
            return count;
        }
    }
}
