using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Trees
{
    class InorderTraversal
    {
        public static void Run()
        {
            TreeNode bt = new TreeNode(4);
            bt.left = new TreeNode(2);
            bt.left.left = new TreeNode(1);
            bt.left.right = new TreeNode(3);

            bt.right = new TreeNode(5);
            bt.right.right = new TreeNode(7);
            bt.right.right.left = new TreeNode(6);
            bt.right.right.right = new TreeNode(8);

            Console.WriteLine("Inorder: ");
            bt.printInOrder();
            Console.WriteLine("Inorder Iterative: ");
            inOrderIterative(bt);

            //Console.WriteLine("Preorder: ");
            //bt.printPreOrder();


            //Console.WriteLine("Postorder: ");
            //bt.printPostOrder();
        }

        public static void inOrderIterative(TreeNode bt)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();

            TreeNode curr = bt;
            while (curr != null || stack.Count > 0)
            {
                if(curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                else
                {
                    curr = stack.Pop();
                    Console.WriteLine(curr.val);
                    curr = curr.right;
                }
            }          
        }
    }
}
