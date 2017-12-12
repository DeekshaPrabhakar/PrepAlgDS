using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Trees
{
    class SymmetricBinaryTree
    {
        public static void Run()
        {
            Console.WriteLine("Trees: Symmetric Binary Tree");
            TreeNode symmetric = new TreeNode(1);
            symmetric.left = new TreeNode(2);
            symmetric.left.left = new TreeNode(3);
            symmetric.left.right = new TreeNode(4);


            symmetric.right = new TreeNode(2);
            symmetric.right.left = new TreeNode(4);
            symmetric.right.right = new TreeNode(3);
            Console.WriteLine(isSymmetric(symmetric).ToString());
            Console.WriteLine("");

            TreeNode notSymmetric = new TreeNode(1);
            notSymmetric.left = new TreeNode(2);
            notSymmetric.left.right = new TreeNode(3);


            notSymmetric.right = new TreeNode(2);
            notSymmetric.right.right = new TreeNode(3);
            Console.WriteLine(isSymmetric(notSymmetric).ToString());
            Console.WriteLine("");
            Console.WriteLine("");
        }
        private static bool isSymmetric(TreeNode A)
        {
            return (A == null || checkSymmetric(A.left, A.right));
        }

        private static bool checkSymmetric(TreeNode subtreeLeft, TreeNode subtreeRight)
        {
            if (subtreeLeft == null && subtreeRight == null)
            {
                return true;
            }
            else if (subtreeLeft != null && subtreeRight != null)
            {
                return (subtreeLeft.val == subtreeRight.val && checkSymmetric(subtreeLeft.left, subtreeRight.right) && checkSymmetric(subtreeLeft.right, subtreeRight.left));
            }
            return false;
        }
    }
}
