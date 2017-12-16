using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Trees
{
    class BFSTraversal
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

            Console.WriteLine("Breadth First Traversal: ");
            BFSTraversalIterative(bt);
        }

        private static void BFSTraversalIterative(TreeNode root)
        {
            TreeNode curr = root;
            Queue<TreeNode> queue = new Queue<TreeNode>();

            while(curr != null || queue.Count >0)
            {
                if(curr != null)
                {
                    if (!curr.isVisited)
                    {
                        Console.WriteLine(curr.val);
                        curr.isVisited = true;
                    }
                    printChildren(curr);
                    if(curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }

                    curr = curr.left != null ? curr.left : curr.right;
                }
                else
                {
                    if (queue.Count > 0)
                    {
                        curr = queue.Dequeue();
                    }
                    else
                    {
                        curr = null;
                    }
                }
            }            
        }

        private static void printChildren(TreeNode node)
        {
            if(node.left != null && !node.left.isVisited)
            {
                Console.WriteLine(node.left.val);
                node.left.isVisited = true;
            }
            if (node.right != null && !node.right.isVisited)
            {
                Console.WriteLine(node.right.val);
                node.right.isVisited = true;
            }
        }
    }
}
