using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Trees
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public bool isVisited = false;
        public TreeNode(int x) 
        { 
            this.val = x; 
            this.left = this.right = null;
            this.isVisited = false;
        }

        public void insert(int value)
        {
            if(value <= val)
            {
                if(left == null)
                {
                    left = new TreeNode(value);
                }
                else
                {
                   left.insert(value);
                }
            }
            else
            {
                if(right == null)
                {
                    right = new TreeNode(value);
                }
                else
                {
                    right.insert(value);
                }
            }
        }

        public bool contains(int value)
        {
            if(value == val)
            {
                return true;
            }
            else if(value < val)
            {
                if(left == null)
                {
                    return false;
                }
                else
                {
                    return left.contains(value);
                }
            }
            else
            {
                if (right == null)
                {
                    return false;
                }
                else
                {
                    return right.contains(value);
                }
            }
        }

        public void printInOrder()
        {
            if(left != null)
            {
                left.printInOrder();
            }
            Console.WriteLine(val);
            if(right != null)
            {
                right.printInOrder();
            }
        }

        public void printPreOrder()
        {
            Console.WriteLine(val);
            if (left != null)
            {
                left.printPreOrder();
            }            
            if (right != null)
            {
                right.printPreOrder();
            }
        }

        public void printPostOrder()
        {
            if (left != null)
            {
                left.printPostOrder();
            }
            
            if (right != null)
            {
                right.printPostOrder();
            }
            Console.WriteLine(val);
        }
    }
}
